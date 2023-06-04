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
       public void createLead()
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@email", email);
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Lead @companyName, @contact, @number, @email,"
                + " @dateOpened, @workStation, @status, @source, @Added_By";
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", NumOfworkStation);
            c.Parameters.AddWithValue("@source", source);
            SQL_CON SC = new SQL_CON();
            c.Parameters.AddWithValue("@status", status);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SC.execute_non_query(c);
            c.CommandText = "EXECUTE dbo.Update_Lead @companyName, @contact, @number, @email,"
        {
        public void updateLead()

        }
            SqlCommand c = new SqlCommand();
            c.Parameters.AddWithValue("@companyName", companyName);
                + " @dateOpened, @workStation, @status, @source, @Added_By";
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", NumOfworkStation);
            c.Parameters.AddWithValue("@status", status);
            c.Parameters.AddWithValue("@source", source);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SQL_CON SC = new SQL_CON();
        }
            SC.execute_non_query(c);

        public void deleteLead()
            SqlCommand c = new SqlCommand();
        {
            c.Parameters.AddWithValue("@companyName", companyName);
            c.CommandText = "EXECUTE dbo.Delete_Lead @companyName, @contact, @number, @dateOpened, @Added_By";
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            c.Parameters.AddWithValue("@number", number);
            SQL_CON SC = new SQL_CON();
        }
            SC.execute_non_query(c);

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

        public void updateStatus(LeadStatus value)
        {
            return this.leadSource;
        }
        
        public void updateContact(string contact)
        {
            return NumOfworkStation;
        }
        
        public void updateNumber(string number)
        {
            NumOfworkStation = value;
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
            return Added_By;
        }

        public void createLead()
        {
            Added_By = Program.seekEemploye(value.getEmail());
        }
        
        

        //function that turn the lead to a Tenant 
        public Tenant convertToTenant()
        {
            Tenant tenant = new Tenant(companyName, contact, number, email, 
            dateOpened, NumOfworkStation, status, source, Added_By, true);
            updateStatus(LeadStatus Move_To_Tenant);
            return tenant;
        } 


    }
}