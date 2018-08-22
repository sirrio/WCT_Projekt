using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

using Act.Framework;
using Act.Framework.MetaData;
using Act.UI;

namespace WCTACTTicket {
    public static class Connection {
        public static SqlConnection sql;

        public static bool localMode = true;

        private static string saPw = ""; 

        public static void connect(ConnectionEventArgs e) {
            initializeSqlConnection(e);

            try {
                sql.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden! Grund: " + ex.Message);
            }

            createTableTickets();

            createTableEntries();

            createTableAssigns();

            createTablePrefs();

        }

        public static void disconnect() {
            try {
                sql.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Verbindung konnte nicht geschlossen werden! Grund: " + ex.Message);
            }
        }

        private static void initializeSqlConnection(ConnectionEventArgs e) {
            try {

                if (localMode) {
                    try {
                        sql = new SqlConnection("Data Source=" + Init.fw.ActDatabase.Machine +
                       ";Trusted_Connection=yes" +
                       ";database=" + e.DatabaseName +
                       ";connection timeout=10");
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
                else {
                    try {

                        sql = new SqlConnection("Data Source=" + e.HostName + "\\ACT7" +
                            ";Initial Catalog=" + e.DatabaseName +
                            ";User ID=actTicket;Password=" + saPw +
                            ";Connect Timeout=15");
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden. /n Bitte wenden sie sich an einen Administrator! /n SERVER: " + e.HostName + " /n DB: " + e.DatabaseName);
                    }
                }
            }
            catch (IOException ex) {
            }

        }

        private static void createTableAssigns() {
            try {
                SqlCommand cmd = new SqlCommand("create table tbl_custom_ticket_assigns (ID int PRIMARY KEY IDENTITY, " +
                                                                "ticketID int, " +
                                                                "userID uniqueidentifier)", sql);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { }
        }

        private static void createTableEntries() {
            try {
                SqlCommand cmd = new SqlCommand("create table tbl_custom_ticket_entries (ID int PRIMARY KEY IDENTITY, " +
                                                                "ticketID int, " +
                                                                "subject nvarchar(100), " +
                                                                "timeStart datetime, " +
                                                                "timeEnd datetime, " +
                                                                "special bit, " +
                                                                "creator nvarchar(50), " +
                                                                "text text)", sql);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        private static void createTableTickets() {
            try {
                SqlCommand cmd = new SqlCommand("create table tbl_custom_tickets (ID int PRIMARY KEY IDENTITY, " +
                                                                                "subject nvarchar(50), " +
                                                                                "date datetime, " +
                                                                                "priority smallint, " +
                                                                                "creator uniqueidentifier, " +
                                                                                "finished bit, " +
                                                                                "billWritten bit, " +
                                                                                "assignNote text, " +
                                                                                "ownerName nvarchar(100) Not Null default '', " +
                                                                                "owner uniqueidentifier Not Null default '" + Guid.Empty + "', " +
                                                                                "contactName nvarchar(100), " +
                                                                                "contact uniqueidentifier, " +
                                                                                "companyName nvarchar(100), " +
                                                                                "company uniqueidentifier)", sql);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        private static void createTablePrefs() {
            try {
                SqlCommand cmd = new SqlCommand("create table tbl_custom_prefs (ID int PRIMARY KEY IDENTITY, " +

                                                                "name nvarchar(100), " +
                                                                "value int)", sql);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

            try {
                bool b = true;
                SqlCommand cmd = new SqlCommand("select name from tbl_custom_prefs", Connection.sql);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    if ("TicketTime" == dr.GetString(0)) {
                        b = false;
                    }
                }
                dr.Close();

                if (b) {
                    cmd = new SqlCommand(null, Connection.sql);
                    cmd.CommandText = "insert into tbl_custom_prefs (name, value) values (@name, @val)";
                    cmd.Parameters.AddWithValue("@name", "TicketTime");
                    cmd.Parameters.AddWithValue("@val", 10);

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex) { }
        }

        public static List<int> getMyTicketIDs() {
            SqlCommand cmd = new SqlCommand("select userid, ticketid from tbl_custom_ticket_assigns", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            List<int> tickets = new List<int>();

            while (dr.Read()) {
                if (Init.fw.CurrentUser.ID == dr.GetGuid(0)) {
                    tickets.Add(dr.GetInt32(1));
                }
            }
            dr.Close();

            return tickets;
        }

        public static int getTicketTimePref() {
            SqlCommand cmd = new SqlCommand("select name, value from tbl_custom_prefs", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                if ("TicketTime" == dr.GetString(0)) {
                    int value = dr.GetInt32(1);
                    dr.Close();
                    return value;
                }
            }
            dr.Close();
            return 10;
        }

        public static bool hasAssignedTickets() {
            SqlCommand cmd = new SqlCommand("select userid from tbl_custom_ticket_assigns", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                if (Init.fw.CurrentUser.ID == dr.GetGuid(0)) {
                    dr.Close();
                    return true;
                }
            }
            dr.Close();
            return false;
        }

        public static void sqlLoadAssign(DTicket ticket) {
            SqlCommand cmd = new SqlCommand("select userID, ticketID, fullname from tbl_custom_ticket_assigns, tbl_contact where tbl_custom_ticket_assigns.userid = tbl_contact.contactid and tbl_custom_ticket_assigns.ticketID='" + ticket.ID + "'", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                DAssign assign = new DAssign();
                assign.userID = dr.GetGuid(0);
                assign.ticket = ticket;
                assign.name = dr.GetString(2);

                ticket.addAssign(assign);
            }
            dr.Close();
        }

        public static void sqlLoadEntrie(DTicket ticket) {
            SqlCommand cmd = new SqlCommand("select id, ticketid, subject, timestart, timeend, special, creator, text, fullname from tbl_custom_ticket_entries, tbl_contact where tbl_custom_ticket_entries.creator=tbl_contact.contactid and ticketID='" + ticket.ID + "'", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                DEntry entry = new DEntry();
                entry.ID = dr.GetInt32(0);
                entry.ticket = ticket;
                entry.subject = dr.GetString(2);
                entry.dateStart = dr.GetDateTime(3);
                entry.dateEnd = dr.GetDateTime(4);
                entry.special = dr.GetBoolean(5);
                entry.creator = dr.GetString(6);
                entry.text = dr.GetString(7);
                entry.creatorFullname = dr.GetString(8);
                ticket.addEntrie(entry);
            }
            dr.Close();
        }


        public static void sqlLoadTicket(DTicket ticket) {
            SqlCommand cmd = new SqlCommand("select id, subject, date, priority, creator, finished, billwritten, contactName, contact, companyName, company, assignNote, owner, ownerName from tbl_custom_tickets where ID='" + ticket.ID + "'", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            ticket.ID = dr.GetInt32(0);
            ticket.subject = dr.GetString(1);
            ticket.date = dr.GetDateTime(2);
            ticket.priority = dr.GetInt16(3);
            ticket.creator = dr.GetGuid(4);
            ticket.finished = dr.GetBoolean(5);
            ticket.billWritten = dr.GetBoolean(6);
            ticket.contactName = dr.GetString(7);
            ticket.contact = dr.GetGuid(8);
            ticket.companyName = dr.GetString(9);
            ticket.company = dr.GetGuid(10);
            ticket.assignNote = dr.GetString(11);
            ticket.owner = dr.GetGuid(12);
            ticket.ownerName = dr.GetString(13);
            dr.Close();
        }

        public static void sqlUpdateEntries(DTicket ticket) {
            foreach (DEntry entry in ticket.listEntry) {
                if (entry.ID == -1) {
                    SqlCommand cmd = new SqlCommand(null, Connection.sql);
                    cmd.CommandText = "insert into tbl_custom_ticket_entries (ticketID, subject, timeStart, timeEnd, special, creator, text) values (@tID, @subj, @tstart, @tend, @spec, @creat, @txt) SELECT SCOPE_IDENTITY() AS id";
                    cmd.Parameters.AddWithValue("@tID", ticket.ID);
                    cmd.Parameters.AddWithValue("@subj", entry.subject);
                    cmd.Parameters.AddWithValue("@tstart", entry.dateStart);
                    cmd.Parameters.AddWithValue("@tend", entry.dateEnd);
                    cmd.Parameters.AddWithValue("@spec", entry.special);
                    cmd.Parameters.AddWithValue("@creat", entry.creator);
                    cmd.Parameters.AddWithValue("@txt", entry.text);

                    entry.ID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                if (entry.toBeChanged) {
                    SqlCommand cmd = new SqlCommand(null, Connection.sql);
                    cmd.CommandText = "update tbl_custom_ticket_entries set subject=@subj, special=@special, text=@text, timeStart=@dateStart, timeEnd=@dateEnd where ID=@id";
                    cmd.Parameters.AddWithValue("@subj", entry.subject);
                    cmd.Parameters.AddWithValue("@special", entry.special);
                    cmd.Parameters.AddWithValue("@text", entry.text);
                    cmd.Parameters.AddWithValue("@dateStart", entry.dateStart);
                    cmd.Parameters.AddWithValue("@dateEnd", entry.dateEnd);
                    cmd.Parameters.AddWithValue("@id", entry.ID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void sqlUpdatePrefMinTime(int value) {
            SqlCommand cmd = new SqlCommand(null, Connection.sql);
            cmd.CommandText = "update tbl_custom_prefs set value=@val where name='TicketTime'";
            cmd.Parameters.AddWithValue("@val", value);

            cmd.ExecuteNonQuery();
        }

        public static void sqlUpdateTicket(DTicket ticket) {
            SqlCommand cmd = new SqlCommand(null, Connection.sql);
            cmd.CommandText = "update tbl_custom_tickets set subject=@subj, creator=@crea, contact=@cont, contactName=@contName, priority=@prio, finished=@fin, billWritten=@bill, company=@comp, companyName=@compName, assignNote=@note, owner=@owner, ownerName=@ownerName where ID=@id";
            cmd.Parameters.AddWithValue("@id", ticket.ID);
            cmd.Parameters.AddWithValue("@prio", ticket.priority);
            cmd.Parameters.AddWithValue("@subj", ticket.subject);
            cmd.Parameters.AddWithValue("@crea", ticket.creator);
            cmd.Parameters.AddWithValue("@cont", ticket.contact);
            cmd.Parameters.AddWithValue("@contName", ticket.contactName);
            cmd.Parameters.AddWithValue("@fin", ticket.finished);
            cmd.Parameters.AddWithValue("@bill", ticket.billWritten);
            cmd.Parameters.AddWithValue("@comp", ticket.company);
            cmd.Parameters.AddWithValue("@compName", ticket.companyName);
            cmd.Parameters.AddWithValue("@note", ticket.assignNote);
            cmd.Parameters.AddWithValue("@owner", ticket.owner);
            cmd.Parameters.AddWithValue("@ownerName", ticket.ownerName);
            cmd.ExecuteNonQuery();
        }

        public static void sqlInsertAssign(DTicket ticket) {
            foreach (DAssign assign in ticket.getListAssign) {
                SqlCommand cmd = new SqlCommand(null, Connection.sql);
                cmd.CommandText = "INSERT INTO tbl_custom_ticket_assigns (ticketID, userID) VALUES (@ticketid, @userid)";
                cmd.Parameters.AddWithValue("@ticketid", ticket.ID);
                cmd.Parameters.AddWithValue("@userid", assign.userID);

                cmd.ExecuteNonQuery();
            }
        }

        public static void sqlInsertEntry(DTicket ticket) {
            foreach (DEntry entry in ticket.listEntry) {
                SqlCommand cmd = new SqlCommand(null, Connection.sql);
                cmd.CommandText = "insert into tbl_custom_ticket_entries (ticketID, subject, timeStart, timeEnd, special, creator, text) values (@tID, @subj, @tstart, @tend, @spec, @creat, @txt)";
                cmd.Parameters.AddWithValue("@tID", ticket.ID);
                cmd.Parameters.AddWithValue("@subj", entry.subject);
                cmd.Parameters.AddWithValue("@tstart", entry.dateStart);
                cmd.Parameters.AddWithValue("@tend", entry.dateEnd);
                cmd.Parameters.AddWithValue("@spec", entry.special);
                cmd.Parameters.AddWithValue("@creat", entry.creator);
                cmd.Parameters.AddWithValue("@txt", entry.text);

                cmd.ExecuteNonQuery();
            }
        }

        public static void sqlInstertTicket(DTicket ticket) {
            SqlCommand cmd = new SqlCommand(null, Connection.sql);
            cmd.CommandText = "INSERT INTO tbl_custom_tickets (subject, date, priority, creator, contact, contactName, finished, billWritten, company, companyName, assignNote, owner, ownerName) VALUES (@subj, @date, @prio, @creat, @cont, @contName, @fin, @bill, @comp, @compName, @assignNote, @owner, @ownerName) SELECT SCOPE_IDENTITY() AS ticket_id";
            cmd.Parameters.AddWithValue("@prio", ticket.priority);
            cmd.Parameters.AddWithValue("@subj", ticket.subject);
            cmd.Parameters.AddWithValue("@fin", ticket.finished);
            cmd.Parameters.AddWithValue("@bill", ticket.billWritten);
            cmd.Parameters.AddWithValue("@date", ticket.date);
            cmd.Parameters.AddWithValue("@creat", ticket.creator);
            cmd.Parameters.AddWithValue("@cont", ticket.contact);
            cmd.Parameters.AddWithValue("@comp", ticket.company);
            cmd.Parameters.AddWithValue("@contName", ticket.contactName);
            cmd.Parameters.AddWithValue("@compName", ticket.companyName);
            cmd.Parameters.AddWithValue("@assignNote", ticket.assignNote);
            cmd.Parameters.AddWithValue("@owner", ticket.owner);
            cmd.Parameters.AddWithValue("@ownerName", ticket.ownerName);

            ticket.ID = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public static void sqlDeleteTicket(DTicket ticket) {
            SqlCommand cmd = new SqlCommand("delete from tbl_custom_tickets where ID=" + ticket.ID, Connection.sql);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from tbl_custom_ticket_entries where ticketID=" + ticket.ID, Connection.sql);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from tbl_custom_ticket_assigns where ticketID=" + ticket.ID, Connection.sql);
            cmd.ExecuteNonQuery();
        }

        public static void sqlLoadAllTickets(List<DTicket> ticketList) {
            SqlCommand cmd = new SqlCommand("select id, subject, date, priority, creator, finished, billwritten, company, companyName, contact, contactName, owner, ownerName from tbl_custom_tickets", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                DTicket ticket = new DTicket();

                ticket.ID = dr.GetInt32(0);
                ticket.subject = dr.GetString(1);
                ticket.date = dr.GetDateTime(2);
                ticket.priority = dr.GetInt16(3);
                ticket.creator = dr.GetGuid(4);
                ticket.finished = dr.GetBoolean(5);
                ticket.billWritten = dr.GetBoolean(6);
                ticket.company = dr.GetGuid(7);
                ticket.companyName = dr.GetString(8);
                ticket.contact = dr.GetGuid(9);
                ticket.contactName = dr.GetString(10);
                ticket.owner = dr.GetGuid(11);
                ticket.ownerName = dr.GetString(12);

                ticketList.Add(ticket);
            }
            dr.Close();
        }

        public static void sqlLoadAllAssigns(List<DTicket> ticketList) {
            SqlCommand cmd = new SqlCommand("select userID, ticketID, Lastname from tbl_custom_ticket_assigns, tbl_contact where tbl_custom_ticket_assigns.userid = tbl_contact.contactid", Connection.sql);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                foreach (DTicket t in ticketList) {
                    if (t.ID == dr.GetInt32(1)) {
                        DAssign assign = new DAssign();
                        assign.userID = dr.GetGuid(0);
                        assign.ticket = t;
                        assign.name = dr.GetString(2);

                        t.addAssign(assign);
                    }
                }
            }
            dr.Close();
        }

        public static void sqlDeleteAssigns(DTicket ticket) {
            SqlCommand cmd = new SqlCommand("delete from tbl_custom_ticket_assigns where ticketID = @ticketid", Connection.sql);
            cmd.Parameters.AddWithValue("@ticketid", ticket.ID);

            cmd.ExecuteNonQuery();
        }

        public static void sqlDeleteEntry(DTicket ticket) {
            foreach (DEntry entry in ticket.listEntry) {
                if (entry.toBeDeleted) {
                    SqlCommand cmd = new SqlCommand("delete from tbl_custom_ticket_entries where ID=" + entry.ID, Connection.sql);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
