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
        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Lead> Leads;

        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Employee seeEemploye(string email)
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
            init_leads();//אתחול הרשימה של ההזמנות
        }


        public static void init_employee()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Emplpoyees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                Employee_Type employee_type = (Employee_Type)Enum.Parse(typeof(Employee_Type), rdr.GetValue(4).ToString());
                Employee employee = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), employee_type , true , false);
                Employee.Add(employee);
            }
        }

        public static void init_orders()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Orders = new List<Order>();
            while (rdr.Read())
            {
                Order o = new Order(seekWorker(rdr.GetValue(0).ToString()), int.Parse(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), int.Parse(rdr.GetValue(3).ToString()), false);
                Orders.Add(o);
                seekWorker(rdr.GetValue(0).ToString()).AddOrders(o);
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

