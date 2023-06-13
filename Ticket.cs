
// create class Ticket like employee
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;
using System.Globalization;

// create class Ticket

namespace nitutz
{
    public class Ticket
    {
        // create properties
        public int ticketID;
        public DateTime time;
        public DateTime dateOpened;
        public TicketStatus ticketStatus;
        public Employee openedByEmployee;
        public Tenant openedByTenant;
        public Issue refferenceIssue;

        // create constructor
        public Ticket(int ticketID, DateTime timeTime, DateTime dateOpened, TicketStatus ticketStatus, Employee openedByEmployee, Tenant openedByTenant, Issue refferenceIssue)
        {
            this.ticketID = ticketID;
            this.time = timeTime;
            this.dateOpened = dateOpened;
            this.ticketStatus = ticketStatus;
            this.openedByEmployee = openedByEmployee;
            this.openedByTenant = openedByTenant;
            this.refferenceIssue = refferenceIssue;
        }

        // create default constructor
   

        // CRATE GET AND SET FOR ALL PROPERTIES
        public int getTicketID()
        {
            return this.ticketID;
        }

        public void setTicketID(int ticketID)
        {
            this.ticketID = ticketID;
        }


        public DateTime getTime()
        {
            return this.time;
        }

        public DateTime getDateOpened()
        {
            return this.dateOpened;
        }

        public void setDateOpened(DateTime dateOpened)
        {
            this.dateOpened = dateOpened;
        }

        public TicketStatus getTicketStatus()
        {
            return this.ticketStatus;
        }

        public void setTicketStatus(TicketStatus ticketStatus)
        {
            this.ticketStatus = ticketStatus;
        }

        public Employee getOpenedByEmployee()
        {
            return this.openedByEmployee;
        }

        public void setOpenedByEmployee(Employee openedByEmployee)
        {
            this.openedByEmployee = openedByEmployee;
        }

        public Tenant getOpenedByTenant()
        {
            return this.openedByTenant;
        }

        public void setOpenedByTenant(Tenant openedByTenant)
        {
            this.openedByTenant = openedByTenant;
        }

        public Issue getRefferenceIssue()
        {
            return this.refferenceIssue;
        }

        public void setRefferenceIssue(Issue refferenceIssue)
        {
            this.refferenceIssue = refferenceIssue;
        }

        // Return a string representation of the ticket
        public override string ToString()
        {   
            if(openedByEmployee != null)
            {
                return $"Ticket ID: {ticketID} ,Date Opened: {dateOpened.Date}, Opened By: {openedByEmployee.getName()}, Issue: {refferenceIssue.getIssueName()} ";

            } else if(openedByTenant != null) {

                return $"Ticket ID: {ticketID} ,Date Opened: {dateOpened.ToString("dd/M/yyyy", CultureInfo.InvariantCulture)}, Opened By: {openedByTenant.getCompanyName()}, Issue: {refferenceIssue.getIssueName()}";

            }
            return "No Ticket Found";
        }   

        // create method to add ticket to database like employee
        public void addTicketToDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Ticket @Ticket_ID, @Time_Time, @Date_Opened, @Ticket_Status, @Opened_By_Employee, @Opened_By_Tenant, @Refference_Issue";
            c.Parameters.AddWithValue("@Ticket_ID", ticketID);
            c.Parameters.AddWithValue("@Time_Time", time);
            c.Parameters.AddWithValue("@Date_Opened", dateOpened);
            c.Parameters.AddWithValue("@Ticket_Status", ticketStatus);
            c.Parameters.AddWithValue("@Opened_By_Employee", openedByEmployee);
            c.Parameters.AddWithValue("@Opened_By_Tenant", openedByTenant);
            c.Parameters.AddWithValue("@Refference_Issue", refferenceIssue);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // create method to update ticket in database like employee
        public void updateTicketInDB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Ticket @Ticket_ID, @Time_Time, @Date_Opened, @Ticket_Status, @Opened_By_Employee, @Opened_By_Tenant, @Refference_Issue, @Refference_Location";
            c.Parameters.AddWithValue("@Ticket_ID", ticketID);
            c.Parameters.AddWithValue("@Time_Time", time);
            c.Parameters.AddWithValue("@Date_Opened", dateOpened);
            c.Parameters.AddWithValue("@Ticket_Status", ticketStatus.ToString());
            if(openedByEmployee != null)
            {
                c.Parameters.AddWithValue("@Opened_By_Employee", openedByEmployee.getEmail());
            } else
            {
                c.Parameters.AddWithValue("@Opened_By_Employee", DBNull.Value);
            }
            if(openedByTenant != null)
            {
                c.Parameters.AddWithValue("@Opened_By_Tenant", openedByTenant.getCompanyName());
            } else
            {
                c.Parameters.AddWithValue("@Opened_By_Tenant", DBNull.Value);

            }
            c.Parameters.AddWithValue("@Refference_Issue", refferenceIssue.getIssueName());

            c.Parameters.AddWithValue("@Refference_Location", refferenceIssue.getIssueLocation());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}

