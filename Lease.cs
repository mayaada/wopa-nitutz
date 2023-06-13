using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;

namespace nitutz
{
    public class Lease
    {
        private int leaseID;
        private string signerName;
        private DateTime startDate;
        private DateTime endDate;
        private int terminationNotice;
        private string termsAndConditions;
        private Employee signedByEmployee;
        private Tenant signedByTenant;
        private List<LeasedItem> itemsLeased; // list of items leased by tenant on this lease
        

        // constructor for new lease
        public Lease(int leaseID, string signerName, DateTime startDate, DateTime endDate, int terminationNotice,
            string termsAndConditions, Employee signedByEmployee, Tenant signedByTenant, bool isNew)
        {
            this.leaseID = leaseID;
            this.signerName = signerName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.terminationNotice = terminationNotice;
            this.termsAndConditions = termsAndConditions;
            this.signedByEmployee = signedByEmployee;
            this.signedByTenant = signedByTenant;
            if (isNew)
            {
                createLease();
                Program.Leases.Add(this);
            }
            this.itemsLeased = new List<LeasedItem>();
        }

        //create getters for all attributes
        public int getLeaseID()
        {
            return this.leaseID;
        }

        public string getSignerName()
        {
            return this.signerName;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }

        public DateTime getEndDate()
        {
            return this.endDate;
        }


        public int getTerminationNotice()
        {
            return this.terminationNotice;
        }

        public string getTermsAndConditions()
        {
            return this.termsAndConditions;
        }

        public Employee getSignedByEmployee()
        {
            return this.signedByEmployee;
        }

        public Tenant getSignedByTenant()
        {
            return this.signedByTenant;
        }

        public List<LeasedItem> getItemsLeased()
        {
            return this.itemsLeased;
        }

        public void AddLeasedItem(LeasedItem leasedItem)
        {
            itemsLeased.Add(leasedItem);
        }

        public void DeleteLeasedItem(LeasedItem leasedItem)
        {
            itemsLeased.Remove(leasedItem);
        }

        // create update for all attributes

        public void updateStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public void updateEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public void updateTerminationNotice(int terminationNotice)
        {
            this.terminationNotice = terminationNotice;
        }

        public void updateTermsAndConditions(string termsAndConditions)
        {
            this.termsAndConditions = termsAndConditions;
        }

        public void initItemsLeased ()

        {
            List<LeasedItem> LI = Program.GetLeasedItemDataList();

            foreach (LeasedItem LeasedItem in LI)
            {
                Lease L = (LeasedItem.getRelatesToLease());

                if (L.getLeaseID() == this.leaseID)

                {
                    itemsLeased.Add(LeasedItem);
                }
               
            }
        }



        public void createLease()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Lease @leaseID, @signerName, @startDate, @endDate, @terminationNotice, @termsAndConditions, @signedByEmployee, @signedByTenant";
            c.Parameters.AddWithValue("@leaseID", leaseID);
            c.Parameters.AddWithValue("@signerName", signerName);
            c.Parameters.AddWithValue("@startDate", startDate);
            c.Parameters.AddWithValue("@endDate", endDate);
            c.Parameters.AddWithValue("@terminationNotice", terminationNotice);
            c.Parameters.AddWithValue("@termsAndConditions", termsAndConditions);
            c.Parameters.AddWithValue("@signedByEmployee", signedByEmployee);
            c.Parameters.AddWithValue("@signedByTenant", signedByTenant);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateLease()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Lease @leaseID, @signerName, @startDate, @endDate, @terminationNotice, @termsAndConditions, @signedByEmployee, @signedByTenant";
            c.Parameters.AddWithValue("@leaseID", leaseID);
            c.Parameters.AddWithValue("@signerName", signerName);
            c.Parameters.AddWithValue("@startDate", startDate);
            c.Parameters.AddWithValue("@endDate", endDate);
            c.Parameters.AddWithValue("@terminationNotice", terminationNotice);
            c.Parameters.AddWithValue("@termsAndConditions", termsAndConditions);
            c.Parameters.AddWithValue("@signedByEmployee", signedByEmployee.getEmail());
            c.Parameters.AddWithValue("@signedByTenant", signedByTenant.getCompanyName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}