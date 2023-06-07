using nitutz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace nitutz
{
    public class Program
    {
        
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Lead> Leads;
        public static System.Collections.Generic.List<Tenant> Tenants;
        public static System.Collections.Generic.List<Lease> Leases;
        public static System.Collections.Generic.List<LeasedItemType> LeasedItemTypes;
        public static System.Collections.Generic.List<LeasedItem> LeasedItems;
        public static System.Collections.Generic.List<Amenity> Amenities;
       


        [STAThread]

        public static void initLists() //����� ������� ���� ���� �������
        {
        init_employees();//����� ������ �� �������
        init_leads();//����� ������ �� ������ �����������
        init_tenants();// ����� ������ �� �������
        init_leases();//����� ������ �� ������
        init_LeasedItemTypes();
        init_LeasedItems();//����� ������ �� ������ ��������
        init_Amenities();
        
        }

        public static void init_employees() //����� ���� ������ ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Emplpoyees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), rdr.GetValue(4).ToString().Replace(" ", string.Empty));
                Employee employee = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), employeeType, true, false);
                Employees.Add(employee);
            }
        }
        public static void init_leads() //����� ���� ������ ���������� ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_leads";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Leads = new List<Lead>();
            while (rdr.Read())
            {
                LeadStatus leadStatus = (LeadStatus)Enum.Parse(typeof(LeadStatus), rdr.GetValue(6).ToString().Replace(" ", string.Empty));

                LeadSource leadSource = (LeadSource)Enum.Parse(typeof(LeadSource), rdr.GetValue(7).ToString().Replace(" ", string.Empty));

                Lead lead = new Lead(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    rdr.GetValue(3).ToString(), DateTime.Parse((rdr.GetValue(4).ToString())), (int)rdr.GetValue(5),
                    leadStatus
                    , leadSource, seekEemploye(rdr.GetValue(8).ToString()), false);
                Leads.Add(lead);
            }
        }
        public static void init_tenants() //����� ������ �� ������� ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Tenants";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Tenants = new List<Tenant>();
            while (rdr.Read())
            {
                Tenant tenant = new Tenant(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    rdr.GetValue(2).ToString(),
                    DateTime.Parse((rdr.GetValue(3).ToString())), (int)rdr.GetValue(4), true, false);
                Tenants.Add(tenant);
            }
        }

        public static void init_leases() //����� ������ �� ������ ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Leases";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Leases = new List<Lease>();
            while (rdr.Read())
            {
                Lease lease = new Lease((int)rdr.GetValue(0), rdr.GetValue(1).ToString(),
                    DateTime.Parse((rdr.GetValue(2).ToString())),
                    DateTime.Parse((rdr.GetValue(3).ToString())), (int)rdr.GetValue(4), rdr.GetValue(5).ToString(),
                    seekEemploye(rdr.GetValue(6).ToString()),
                    seekTenant(rdr.GetValue(7).ToString()), false);
                Leases.Add(lease);
            }
        }

        public static void init_LeasedItemTypes() {
             SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_LeasedItemTypes";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            LeasedItemTypes = new List<LeasedItemType>();
            while (rdr.Read())
            {
                LeasedItemType LeasedItemType = new LeasedItemType (
                    rdr.GetValue(0).ToString(), (Double)rdr.GetValue(1),
                    (int)rdr.GetValue(2),(Double)rdr.GetValue(3)
                );
            }
        }


        public static void init_LeasedItems()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_LeasedItems";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            LeasedItems = new List<LeasedItem>();
            while (rdr.Read())
            {
                LeasedItem LeasedItem = new LeasedItem(
                    (int)rdr.GetValue(0), (int)rdr.GetValue(1),
                    seekLeasedItemType(rdr.GetValue(2).ToString()), (bool)rdr.GetValue(3),
                    (bool)rdr.GetValue(4), seekLease((int)rdr.GetValue(5)), false
                );
            }
        }

        public static void init_Amenities()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Amenities";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Amenities = new List<Amenity>();
            while (rdr.Read())
            {
                AmenityType AmenityType = (AmenityType)Enum.Parse(typeof(AmenityType), rdr.GetValue(1).ToString().Replace(" ", string.Empty));
                Amenity Amenity = new Amenity(
                AmenityType
                );
            }
        }

        

        //���� ������ ���� ������ ��� ����� ����
        public static Tenant seekTenant(string companyName)
        {
            foreach (Tenant tenant in Tenants)
            {
                if (tenant.getCompanyName() == companyName)
                    return tenant;
            }

            return null;
        }
        //���� ������ ���� ������ ��� ����� ����
        public static Employee seekEemploye(string email)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.getEmail() == email)
                    return employee;
            }

            return null;
        }

        public static LeasedItemType seekLeasedItemType(string type)
        {
            foreach (LeasedItemType LeasedItemType in LeasedItemTypes)
            {
                if (LeasedItemType.getType() == type)
                    return LeasedItemType;
            }

            return null;
        }
        
        public static Lease seekLease(int number)
        {
            foreach (Lease lease in Leases)
            {
                if (lease.getLeaseID() == number)
                    return lease;
            }

            return null;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists(); //����� �� �������
            Application.Run(new MainForm());
        }


    }
}