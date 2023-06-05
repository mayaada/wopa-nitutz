
// create class Ticket like employee
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;

// create class Ticket

namespace WOPA
{
    public class Ticket
    {
        // create properties
        public int TicketID;
        public string TimeTime;
        public string DateOpened;
        public string TicketStatus;
        public string OpenedByEmployee;
        public string OpenedByTenant;
        public string RefferenceIssue;

        // create constructor
        public Ticket(int ticketID, string timeTime, string dateOpened, string ticketStatus, string openedByEmployee, string openedByTenant, string refferenceIssue)
        {
            TicketID = ticketID;
            TimeTime = timeTime;
            DateOpened = dateOpened;
            TicketStatus = ticketStatus;
            OpenedByEmployee = openedByEmployee;
            OpenedByTenant = openedByTenant;
            RefferenceIssue = refferenceIssue;
        }

        // create default constructor
        public Ticket()
        {
        }

        // CRATE GET AND SET FOR ALL PROPERTIES
        public int getTicketID()
        {
            return TicketID;
        }

        public void setTicketID(int ticketID)
        {
            TicketID = ticketID;
        }

        public string getTimeTime()
        {
            return TimeTime;
        }

        public void setTimeTime(string timeTime)
        {
            TimeTime = timeTime;
        }

        public string getDateOpened()
        {
            return DateOpened;
        }

        public void setDateOpened(string dateOpened)
        {
            DateOpened = dateOpened;
        }

        public string getTicketStatus()
        {
            return TicketStatus;
        }

        public void setTicketStatus(string ticketStatus)
        {
            TicketStatus = ticketStatus;
        }

        public string getOpenedByEmployee()
        {
            return OpenedByEmployee;
        }

        public void setOpenedByEmployee(string openedByEmployee)
        {
            OpenedByEmployee = openedByEmployee;
        }

        public string getOpenedByTenant()
        {
            return OpenedByTenant;
        }

        public void setOpenedByTenant(string openedByTenant)
        {
            OpenedByTenant = openedByTenant;
        }

        public string getRefferenceIssue()
        {
            return RefferenceIssue;
        }

        public void setRefferenceIssue(string refferenceIssue)
        {
            RefferenceIssue = refferenceIssue;
        }

        // create method to add ticket to database like employee
        public void addTicketToDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Ticket @Ticket_ID, @Time_Time, @Date_Opened, @Ticket_Status, @Opened_By_Employee, @Opened_By_Tenant, @Refference_Issue";
            c.Parameters.AddWithValue("@Ticket_ID", TicketID);
            c.Parameters.AddWithValue("@Time_Time", TimeTime);
            c.Parameters.AddWithValue("@Date_Opened", DateOpened);
            c.Parameters.AddWithValue("@Ticket_Status", TicketStatus);
            c.Parameters.AddWithValue("@Opened_By_Employee", OpenedByEmployee);
            c.Parameters.AddWithValue("@Opened_By_Tenant", OpenedByTenant);
            c.Parameters.AddWithValue("@Refference_Issue", RefferenceIssue);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // create method to update ticket in database like employee
        public void updateTicketInDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Ticket @Ticket_ID, @Time_Time, @Date_Opened, @Ticket_Status, @Opened_By_Employee, @Opened_By_Tenant, @Refference_Issue";
            c.Parameters.AddWithValue("@Ticket_ID", TicketID);
            c.Parameters.AddWithValue("@Time_Time", TimeTime);
            c.Parameters.AddWithValue("@Date_Opened", DateOpened);
            c.Parameters.AddWithValue("@Ticket_Status", TicketStatus);
            c.Parameters.AddWithValue("@Opened_By_Employee", OpenedByEmployee);
            c.Parameters.AddWithValue("@Opened_By_Tenant", OpenedByTenant);
            c.Parameters.AddWithValue("@Refference_Issue", RefferenceIssue);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}

        