
// create class Ticket like employee
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;

// create class Ticket

namespace nitutz
{
    public class Ticket
    {
        // create properties
        public int TicketID;
        public DateTime TimeTime;
        public DateTime DateOpened;
        public TicketStatus TicketStatus;
        public Employee OpenedByEmployee;
        public Tenant OpenedByTenant;
        public Issue RefferenceIssue;

        // create constructor
        public Ticket(int ticketID, DateTime timeTime, DateTime dateOpened, TicketStatus ticketStatus, Employee openedByEmployee, Tenant openedByTenant, Issue refferenceIssue)
        {
            this.TicketID = ticketID;
            this.TimeTime = timeTime;
            this.DateOpened = dateOpened;
            this.TicketStatus = ticketStatus;
            this.OpenedByEmployee = openedByEmployee;
            this.OpenedByTenant = openedByTenant;
            this.RefferenceIssue = refferenceIssue;
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

        public DateTime getTimeTime()
        {
            return TimeTime;
        }

        public void setTimeTime(DateTime timeTime)
        {
            this.TimeTime = timeTime;
        }

        public DateTime getDateOpened()
        {
            return DateOpened;
        }

        public void setDateOpened(DateTime dateOpened)
        {
            this.DateOpened = dateOpened;
        }

        public TicketStatus getTicketStatus()
        {
            return TicketStatus;
        }

        public void setTicketStatus(TicketStatus ticketStatus)
        {
            this.TicketStatus = ticketStatus;
        }

        public Employee getOpenedByEmployee()
        {
            return OpenedByEmployee;
        }

        public void setOpenedByEmployee(Employee openedByEmployee)
        {
            this.OpenedByEmployee = openedByEmployee;
        }

        public Tenant getOpenedByTenant()
        {
            return OpenedByTenant;
        }

        public void setOpenedByTenant(Tenant openedByTenant)
        {
            this.OpenedByTenant = openedByTenant;
        }

        public Issue getRefferenceIssue()
        {
            return RefferenceIssue;
        }

        public void setRefferenceIssue(Issue refferenceIssue)
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

