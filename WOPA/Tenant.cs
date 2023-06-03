/*
CREATE TABLE TENANTS(
Company_Name    varchar (60)		PRIMARY KEY     NOT NULL,
Contact_Email   varchar (60)        NOT NULL, 
Website         varchar  (60)       NULL, 
Date_Joined     DATE                NOT NULL,
Number_Of_Employees INT             NOT NULL
)
*/

namespace WOPA
{

    public class Tenant
    {
        private string companyName;
        private string contactEmail;
        private string website;
        private DateTime dateJoined;
        private int numberOfEmployees;
        private bool isActive;
        

        public Tenant(string companyName, string contactEmail, string website, DateTime dateJoined,
            int numberOfEmployees, bool isActive, bool isNew)
        {
            this.companyName = companyName;
            this.contactEmail = contactEmail;
            this.website = website;
            this.dateJoined = dateJoined;
            this.numberOfEmployees = numberOfEmployees;
            this.isActive = isActive;
            if (isNew)
            {
                createTenant();
                Program.Tenants.Add(this);
            }
            

        }
        
        public string getCompanyName()
        {
            return this.companyName;
        }
        
        public string getContactEmail()
        {
            return this.contactEmail;
        }
        
        public string getWebsite()
        {
            return this.website;
        }
        
        public DateTime getDateJoined()
        {
            return this.dateJoined;
        }
        
        public int getNumberOfEmployees()
        {
            return this.numberOfEmployees;
        }
        
        public void updateContactEmail(string contactEmail)
        {
            this.contactEmail = contactEmail;
        }
        
        public void updateWebsite(string website)
        {
            this.website = website;
        }

        public void updateNumberOfEmployees(int numberOfEmployees)
        {
            this.numberOfEmployees = numberOfEmployees;
        }
        
        
        public void createTenant()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText =
                "EXECUTE SP_CREATE_TENANT @Company_Name, @Contact_Email, @Website, @Date_Joined, @Number_Of_Employees";
            c.Parameters.AddWithValue("@COMPANY_NAME", this.companyName);
            c.Parameters.AddWithValue("@CONTACT_EMAIL", this.contactEmail);
            c.Parameters.AddWithValue("@WEBSITE", this.website);
            c.Parameters.AddWithValue("@DATE_JOINED", this.dateJoined);
            c.Parameters.AddWithValue("@NUMBER_OF_EMPLOYEES", this.numberOfEmployees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}