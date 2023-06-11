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
        private int numOfworkStation;
        private LeadSource leadSource;
        private Employee addedBy;
        private Tenant tenant;

        public Lead(string companyName, string contact, string number, string email, DateTime dateOpened, int workStation,
         LeadStatus status, LeadSource source, Employee Added_By, Boolean isNew)
        {
            this.companyName = companyName;
            this.contact = contact;
            this.number = number;
            this.email = email;
            this.dateOpened = dateOpened;
            this.leadStatus = status;
            this.numOfworkStation = workStation;
            this.leadSource = source;
            this.addedBy = Added_By;
            if (isNew)
            {

                createLead();
                Program.Leads.Add(this);
            }
        }

        public Lead(string companyName, string contact, string number, string email, DateTime dateOpened, int workStation,
         LeadStatus status, LeadSource source, Employee Added_By, Tenant CreatedNew, bool isNew)
        {
            this.companyName = companyName;
            this.contact = contact;
            this.number = number;
            this.email = email;
            this.dateOpened = dateOpened;
            this.leadStatus = status;
            this.numOfworkStation = workStation;
            this.leadSource = source;
            this.addedBy = Added_By;
            this.tenant = CreatedNew;
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
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", numOfworkStation);
            c.Parameters.AddWithValue("@source", leadSource.ToString());
            c.Parameters.AddWithValue("@status", leadStatus.ToString());
            c.Parameters.AddWithValue("@Added_By", addedBy.getEmail());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        // public void updateLead()

        // {
        //     SqlCommand c = new SqlCommand();
        //     c.CommandText = "EXECUTE dbo.SP_Update_Lead   @contact, @number, @email, @workStation, @status";
        //     c.Parameters.AddWithValue("@email", email);
        //     c.Parameters.AddWithValue("@contact", contact);
        //     c.Parameters.AddWithValue("@number", number);
        //     c.Parameters.AddWithValue("@workStation", numOfworkStation);
        //     c.Parameters.AddWithValue("@status", leadStatus);
        //     SQL_CON SC = new SQL_CON();
        //     SC.execute_non_query(c);

        // }

        public void updateLead()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Lead @copmany_name, @contact, @number, @email,"
                + " @dateOpened, @workStation, @status, @source, @Added_By";
            c.Parameters.AddWithValue("@copmany_name", companyName);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", numOfworkStation);
            c.Parameters.AddWithValue("@status", leadStatus.ToString());
            c.Parameters.AddWithValue("@source", leadSource.ToString());
            c.Parameters.AddWithValue("@Added_By", addedBy.getEmail());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void deleteLead()

        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Delete_Lead @companyName";
            c.Parameters.AddWithValue("@companyName", companyName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);

        }


        public string getCompanyName()
        {
            return this.companyName;
        }

        public string getContact()
        {
            return this.contact;
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
            leadStatus = Enum.Parse<LeadStatus>(leadStatus.ToString());
            return this.leadStatus;
        }

        public int getWorkStationNumber()
        {
            return this.numOfworkStation;
        }

        public Tenant getTenant()
        {
            return this.tenant;
        }

        public LeadSource getSource()
        {
            return this.leadSource;
        }

        public Employee getAddedBy()
        {
            return this.addedBy;
        }


        public Tenant getCreatedNew()
        {
            return this.tenant;
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
            this.leadStatus = Enum.Parse<LeadStatus>(status.ToString());
        }

        public void updateWorkStationNumber(int workStation)
        {
            this.numOfworkStation = workStation;
        }




        //function that turn the lead to a Tenant 
        public void convertToTenant(string email, string website, DateTime dateJoined, int numberOfEmployees)
        {
            Tenant tenant = new Tenant(this.companyName, email, website, dateJoined, numberOfEmployees, true, true);
            Program.Tenants.Add(tenant);
            updateLeadStatus(LeadStatus.MovetoTenant);
        }



    }
}

