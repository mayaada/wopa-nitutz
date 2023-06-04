namespace WOPA
{

    public class Lead
    {
        private string companyName;
        private string contact;
        private string number;
        private string email;
        private DateTime dateOpened;
        private LeadStatus status;
        private int NumOfworkStation;
        private LeadSource source;
        private Employee Added_By;

        public Lead(string companyName, string contact, string number, string email, DateTime dateOpened, int workStation,
         LeadStatus status, LeadSource source, Employee Added_By, Boolean isNew)
        {
            this.companyName = companyName;
            this.contact = contact;
            this.number = number;
            this.email = email;
            this.dateOpened = dateOpened;
            this.status = status;
            this.NumOfworkStation = workStation;
            this.source = source;
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
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", NumOfworkStation);
            c.Parameters.AddWithValue("@status", status);
            c.Parameters.AddWithValue("@source", source);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateLead()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Lead @companyName, @contact, @number, @email,"
                + " @dateOpened, @workStation, @status, @source, @Added_By";
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@email", email);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@workStation", NumOfworkStation);
            c.Parameters.AddWithValue("@status", status);
            c.Parameters.AddWithValue("@source", source);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void deleteLead()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Delete_Lead @companyName, @contact, @number, @dateOpened, @Added_By";
            c.Parameters.AddWithValue("@companyName", companyName);
            c.Parameters.AddWithValue("@contact", contact);
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@dateOpened", dateOpened);
            c.Parameters.AddWithValue("@Added_By", Added_By.getEmail());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public string GetCompanyName()
        {
            return companyName;
        }

        public void SetCompanyName(string value)
        {
            companyName = value;
        }

        public string GetContact()
        {
            return contact;
        }

        public void SetContact(string value)
        {
            contact = value;
        }

        public string GetNumber()
        {
            return number;
        }

        public void SetNumber(string value)
        {
            number = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

        public DateTime GetDateOpened()
        {
            return dateOpened;
        }

        public void SetDateOpened(DateTime value)
        {
            dateOpened = value;
        }

        public LeadStatus GetStatus()
        {
            return status;
        }

        public void updateStatus(LeadStatus value)
        {
            status = value;
        }

        public int GetWorkStation()
        {
            return NumOfworkStation;
        }

        public void SetWorkStation(int value)
        {
            NumOfworkStation = value;
        }

        public LeadSource GetSource()
        {
            return source;
        }

        public void SetSource(LeadSource value)
        {
            source = value;
        }

        public Employee GetAddedBy()
        {
            return Added_By;
        }

        public void SetAddedBy(Employee value)
        {
            Added_By = Program.seekEemploye(value.getEmail());
        }

        //function that turn the lead to a Tenant 
        public Tenant convertToTenant()
        {
            Tenant tenant = new Tenant(companyName, contact, number, email, 
            dateOpened, NumOfworkStation, status, source, Added_By, true);
            updateStatus(LeadStatus MoveToTenant);
            return tenant;
        } 


    }
}