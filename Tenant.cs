using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace nitutz
{
    public class Tenant
    {
       private string companyName;
        private string contactEmail;
        private string website;
        private DateTime dateJoined;
        private int numberOfEmployees;
        private bool isActive;
        private List<Lease> leases;
        private List<Ticket> tickets;
        private List<Booking> bookings;


        public Tenant(string companyName, string contactEmail, string website, DateTime dateJoined,
            int numberOfEmployees, bool isActive, bool isNew)
        {
            this.companyName = companyName;
            this.contactEmail = contactEmail;
            this.website = website;
            this.dateJoined = dateJoined;
            this.numberOfEmployees = numberOfEmployees;
            this.isActive = isActive;
            this.leases = new List<Lease>(); // each tenant can have  a few leases
            this.tickets = new List<Ticket>(); // each tenant can have a few tickets 
            this.bookings = new List<Booking>(); // each tenant can have a few bookings
            
     
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

        public String getNumOfEmployees()
        {
            String Num = this.numberOfEmployees.ToString();
            return Num; 
        }

        public bool getIsActive()
        {
            return this.isActive;
        }

        public String getIsActivity()
        {
            String Activity = isActive.ToString();
            Console.WriteLine(Activity);
            return Activity;
        }


        public void updateCompanyName(string Name)
        {
            this.companyName = Name;
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
        public void UpdateActivateTenant (bool Activity)
        {
            this.isActive = Activity;
        }


        public void createTenant()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText =
                "EXECUTE SP_Create_Tenant @Company_Name, @Contact_Email, @Website, @Date_Joined, @Number_Of_Employees , @Is_Active ";
            c.Parameters.AddWithValue("@Company_Name", this.companyName.ToString());
            c.Parameters.AddWithValue("@Contact_Email", this.contactEmail.ToString());
            c.Parameters.AddWithValue("@Website", this.website.ToString());
            c.Parameters.AddWithValue("@Date_Joined", this.dateJoined);
            c.Parameters.AddWithValue("@Number_Of_Employees", (int)this.numberOfEmployees);
            c.Parameters.AddWithValue("@Is_Active", this.isActive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateTenant()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText =
                "EXECUTE SP_Update_Tenant @Company_Name, @Contact_Email, @Website, @Number_Of_Employees , @Is_Active";
            c.Parameters.AddWithValue("@COMPANY_NAME", this.companyName);
            c.Parameters.AddWithValue("@CONTACT_EMAIL", this.contactEmail);
            c.Parameters.AddWithValue("@WEBSITE", this.website);
            c.Parameters.AddWithValue("@NUMBER_OF_EMPLOYEES", this.numberOfEmployees);
            c.Parameters.AddWithValue("@Is_Active", this.isActive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void deleteTenant()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText =
                "EXECUTE SP_Delete_Tenant @Company_Name, @Is_Active";
            c.Parameters.AddWithValue("@Is_Active", this.isActive);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        // create methos that return the lease of the tenant from program.leases
        public Lease getLease()
        {
            String Email = this.contactEmail;
            Lease L = Program.Leases.Find(x => x.getSignedByTenant().getContactEmail() == Email);
            return L;
        }



    }

}