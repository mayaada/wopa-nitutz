using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;

namespace nitutz
{
    public class LeasedItem
    {
        private int number;
        private int floor;
        private LeasedItemType type;
        private bool electricCharging;
        private bool isAvailable;
        private Lease relatesTo;

        public LeasedItem(int number, int floor, LeasedItemType type, bool electricCharging, bool isAvailable, Lease relatesTo, bool isNew)
        {
            this.number = number;
            this.floor = floor;
            this.type = type;
            this.electricCharging = electricCharging;
            this.isAvailable = isAvailable;
            this.relatesTo = relatesTo;
            if (isNew)
            {
                createLeasedItem();
                Program.LeasedItems.Add(this);
            }

        }

        public int getNumber()
        {
            return this.number;
        }

        public int getFloor()
        {
            return this.floor;
        }

        public LeasedItemType getType()
        {
            return this.type;
        }

        public bool getElectricCharging()
        {
            return this.electricCharging;
        }

        public bool getIsAvailable()
        {
            return this.isAvailable;
        }
        
        public Lease getRelatesToLease()
        {
            return this.relatesTo;
        }

        public void updateType(LeasedItemType type)
        {
            this.type = type;
        }

        public void updateElectricCharging(bool electricCharging)
        {
            this.electricCharging = electricCharging;
        }

        public void updateIsAvailable(bool isAvailable)
        {
            this.isAvailable = isAvailable;
        }

        public void updateLease (int leaseID)
        {
            this.relatesTo = Program.seekLease(leaseID);
        }

        


        public int getLeaseNumber() {
            int num = this.relatesTo.getLeaseID();
            return num;

        }

        public string getLeasedItemTypeName()
        {
            string name = this.type.getType();
            return name;
        }

        public double getPrice()
        {
            double price = this.type.getPrice();
            return price;
        }

        public int getCreditAmount()
        {
            int credit = this.type.getCreditAmount();
            return credit;
        }

        public double getDeposit()
        {
            double deposit = this.type.getDeposit();
            return deposit;
        }
        
        public void createLeasedItem()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Leased_Item @number, @floor, @type, @electricCharging, @isAvailable, @LeaseID";
            c.Parameters.AddWithValue("@number", number);
            c.Parameters.AddWithValue("@floor", floor);
            c.Parameters.AddWithValue("@type", type.getType());
            c.Parameters.AddWithValue("@electricCharging", electricCharging);
            c.Parameters.AddWithValue("@isAvailable", isAvailable);
            c.Parameters.AddWithValue("@LeaseID", relatesTo.getLeaseID());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateLeasedItem()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Leased_Item @number, @electricCharging, @isAvailable, @LeaseID";
            c.Parameters.AddWithValue("@number", number);
            if(electricCharging != null)
            {
                c.Parameters.AddWithValue("@electricCharging", electricCharging);
            } else
            {   
                c.Parameters.AddWithValue("@electricCharging", DBNull.Value);
            }
            
            c.Parameters.AddWithValue("@isAvailable", isAvailable);

            if (relatesTo != null)
            {
                c.Parameters.AddWithValue("@LeaseID", relatesTo.getLeaseID());
            } else
            {
                c.Parameters.AddWithValue("@LeaseID", DBNull.Value);
            }
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        internal void updatateRelatesTo(int leaseID)
        {
            this.relatesTo = Program.seekLease(leaseID);
        }
    }
}