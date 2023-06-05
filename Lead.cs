using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nitutz
{

    public class Lead
    {
        private string companyName;
        private string contact;
        private string number;
        private string email;
        private DateTime dateOpened;
        private LeadStatus leadStatus;
        private int NumOfworkStation;
        private LeadSource leadSource;
        private Employee Added_By;

        public Lead(string companyName, string contact, string number, string email, DateTime dateOpened, int workStation,
         LeadStatus status, LeadSource source, Employee Added_By, Boolean isNew)
        {
            this.companyName = companyName;
            this.contact = contact;
            this.number = number;
            this.email = email;
            this.dateOpened = dateOpened;
            this.leadStatus = status;
            this.NumOfworkStation = workStation;
            this.leadSource = source;
            this.Added_By = Added_By;
            if (isNew)
            {
                createLead();
                Program.Leads.Add(this);
            }
        }
        public void createLead()

        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Lead @companyName, @contact, @number, @email,"
                + " @dateOpened, @workStation, @status, @source, @Added_By";
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", NumOfworkStation);
            c.Parameters.AddWithValue("@source", leadSource);
            SQL_CON SC = new SQL_CON();
            c.Parameters.AddWithValue("@status", leadStatus);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SC.execute_non_query(c);
        }
        public void updateLead()

        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Lead @companyName, @contact, @number, @email,"
                + " @dateOpened, @workStation, @status, @source, @Added_By";
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", NumOfworkStation);
            c.Parameters.AddWithValue("@status", leadStatus);
            c.Parameters.AddWithValue("@source", leadSource);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }


        public string getCompanyName()
        {
            return companyName;
        }

        public string getContact()
        {
            return contact;
        }

        public string getNumber()
        {
            return this.number;
        }

        public string getEmail()
        {
            return email;
        }

        public DateTime getDateOpened()
        {
            return dateOpened;
        }

        public LeadStatus getStatus()
        {
            return this.leadStatus;
        }

        public int getWorkStationNumber()
        {
            return this.NumOfworkStation;
        }


        public void updateContact(string contact)
        {
            this.contact = contact;
        }

        public void updateNumber(string number)
        {
            this.number = number;
        }

        public void updateEmail(string email)
        {
            this.email = email;
        }
        public void updateLeadStatus(LeadStatus status)
        {
            this.leadStatus = status;
        }

        public void updateWorkStationNumber(int workStation)
        {
            this.NumOfworkStation = workStation;
        }



        //function that turn the lead to a Tenant 
        public void convertToTenant(string email, string website, DateTime dateJoined, int numberOfEmployees)
        {
            Tenant tenant = new Tenant(this.companyName, email, website, dateJoined, numberOfEmployees, true, true);
            Program.Tenants.Add(tenant);
            updateLeadStatus(LeadStatus.MoveToTenant);
        }



    }
}

