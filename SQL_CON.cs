using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; //חשוב!
using System.Windows.Forms; //עבור ההודעות!
using Microsoft.Data;
using System.IO;

namespace nitutz
{
    internal class SQL_CON
    {
        private const string DB_NAME = "SADM_9";
        private const string USERNAME = "tamaryos@bgufbm.onmicrosoft.com";
        private const string PASSWORD = "fqv86251";

        SqlConnection conn;

        public SQL_CON()
        {
            // For better string concatenation, we prefer to use String Interpolation ($"..{}"),
            // So we can have dynamic variables inside our string
            // without the risk of making a typo in rest of the connection string
            conn = new SqlConnection(
            $"Data Source = dbcourse.database.windows.net;Initial Catalog={DB_NAME};Persist Security Info=True;Encrypt=True;User ID={USERNAME};Password={PASSWORD};Authentication=ActiveDirectoryPassword");
            // "Data Source=dbcourse.database.windows.net;Initial Catalog=SADM_9;Persist Security Info=True");
            //"Data Source=dbcourse.database.windows.net;Initial Catalog=SADM_9;Persist Security Info=True;User ID=tamaryos@bgufbm.onmicrosoft.com;Authentication=ActiveDirectoryPassword");
        }

        public void execute_non_query(SqlCommand cmd)
        {
            try
            {
                // open a connection object
                this.conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show(" השאילתה בוצעה בהצלחה", "המשך", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public SqlDataReader execute_query(SqlCommand cmd)
        {
            try
            {
                // open a connection object
                conn.Open();
                cmd.Connection = conn;
                SqlDataReader READER = cmd.ExecuteReader();
                return READER;
            }
            catch (Exception ex)
            {
                var bla = $"Data Source = dbcourse.database.windows.net;Initial Catalog={DB_NAME};Persist Security Info=True;Encrypt=True;User ID={USERNAME};Password={PASSWORD};Authentication=ActiveDirectoryPassword";
                MessageBox.Show("שגיאה בביצוע השאילתה" + ex.Message, "המשך", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}