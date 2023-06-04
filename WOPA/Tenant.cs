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

        public Tenant(string companyName, string contactEmail, string website, DateTime dateJoined,
            int numberOfEmployees, bool is_new)
        {
            this.companyName = companyName;
            this.contactEmail = contactEmail;
            this.website = website;
            this.dateJoined = dateJoined;
            this.numberOfEmployees = numberOfEmployees;

        }
        
        public string getCompanyName()
        {
            return this.companyName;
        }

    }
}