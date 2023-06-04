using WOPA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using System.Data;
using System.Data.SqlClient;

namespace WOPA
{
    public class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
            //רשימות
        public static System.Collections.Generic.List<Employee> Employees ;
        public static System.Collections.Generic.List<Lead> Leads ;
        public static System.Collections.Generic.List<Tenant> Tenants ;
        public static System.Collections.Generic.List<Lease> Leases ;

        [STAThread]


        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Employee seekEemploye(string email)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.getEmail() == email)
                    return employee;
            }
            return null;
        }


        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_employees();//אתחול הרשימה של העובדים
            init_leads();//אתחול הרשימה של לקוחות פוטנצייאלים
            init_tenants();// אתחול הרשימה של הדיירים
            init_leases();//אתחול הרשימה של החוזים
        }

        // init leases
        public static void init_leases()//מילוי הרשימה של החוזים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Leases";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Leases = new List<Lease>();
            while (rdr.Read())
            {
                Lease lease = new Lease((int)rdr.GetValue(0), rdr.GetValue(1).ToString(), DateTime.Parse((rdr.GetValue(2).ToString())),
                    DateTime.Parse((rdr.GetValue(3).ToString())), (int)rdr.GetValue(4), rdr.GetValue(5).ToString(), seekEemploye(rdr.GetValue(6).ToString()),
                    seekTenant(rdr.GetValue(7).ToString()), false);
                Leases.Add(lease);
            }
        }

        //שיטה שמחפשת דייר ברשימה לפי תעודת זהות
        public static Tenant seekTenant(string companyName)
        {
            foreach (Tenant tenant in Tenants)
            {
                if (tenant.getCompanyName() == companyName)
                    return tenant;
            }
            return null;
        }


        // init tenants
        public static void init_tenants()//מילוי הרשימה של הדיירים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Tenants";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Tenants = new List<Tenant>();
            while (rdr.Read())
            {
                Tenant tenant = new Tenant(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    DateTime.Parse((rdr.GetValue(3).ToString())), (int)rdr.GetValue(4), true, false);
                Tenants.Add(tenant);
            }
        }


        public static void init_employees()//מילוי מערך עובדים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Emplpoyees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), rdr.GetValue(4).ToString());
                Employee employee = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), 
                    rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), employeeType , true , false);
                Employees.Add(employee);
            }
        }

        public static void init_leads()//מילוי מערך לקוחות פוטנציאלים מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Leads = new List<Lead>();
            while (rdr.Read())
            {

                LeadStatus leadStatus = (LeadStatus)Enum.Parse(typeof(LeadStatus), rdr.GetValue(6).ToString());
                LeadSource leadSource = (LeadSource)Enum.Parse(typeof(LeadSource), rdr.GetValue(7).ToString());

                Lead lead = new Lead(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),rdr.GetValue(2).ToString(),
                rdr.GetValue(3).ToString(), DateTime.Parse((rdr.GetValue(4).ToString())), (int)rdr.GetValue(5) , leadStatus
                , leadSource, seekEemploye(rdr.GetValue(8).ToString()) , false) ;
                Leads.Add (lead); 
                   
            }
        }



        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
            Application.Run(new mainForm());
        }
    }
}

