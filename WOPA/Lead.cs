namespace WOPA
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
        
        public string GetCompanyName()
        {
            return companyName;
        }

        public string GetContact()
        {
            return contact;
        }
        
        public string getNumber()
        {
            return this.number;
        }

        public string GetEmail()
        {
            return email;
        }

        public DateTime GetDateOpened()
        {
            return dateOpened;
        }

        public LeadStatus GetStatus()
        {
            return this.leadStatus;
        }

        public int GetWorkStationNumber()
        {
            return this.NumOfworkStation;
        }

        public LeadSource GetSource()
        {
            return this.leadSource;
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
        public void updateStatus(LeadStatus status)
        {
            this.leadStatus = status;
        }
        
        public void updateWorkStationNumber(int workStation)
        {
            this.NumOfworkStation = workStation;
        }

        public void convertToNewTenant(string contactEmail, string website, DateTime dateJoined, int numberOfEmployees, bool isActive)
        {
            Tenant convertedTenant = new Tenant(this.companyName, contactEmail, website, dateJoined, numberOfEmployees, isActive, isNew: true);
        }

        public void createLead()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText =
                "EXECUTE SP_addLead @companyName, @contact, @number, @email, @dateOpened, @leadStatus, @workStation, @leadSource";
            c.Parameters.AddWithValue("@companyName", this.companyName);
            c.Parameters.AddWithValue("@contact", this.contact);
            c.Parameters.AddWithValue("@number", this.number);
            c.Parameters.AddWithValue("@email", this.email);
            c.Parameters.AddWithValue("@dateOpened", this.dateOpened);
            c.Parameters.AddWithValue("@leadStatus", this.leadStatus);
            c.Parameters.AddWithValue("@workStation", this.NumOfworkStation);
            c.Parameters.AddWithValue("@leadSource", this.leadSource);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        
        


    }
}