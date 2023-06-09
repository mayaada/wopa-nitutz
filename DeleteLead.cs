using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nitutz
{
    public partial class DeleteLead : Form
    {
        public DeleteLead()
        {
            InitializeComponent();
        }

        private void DeleteLead_Load(object sender, EventArgs e)
        {

        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {
            string companyName = CompanyNametextBox1.Text;

            // Connect to the database and execute the delete query
            string connectionString = "your_connection_string";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM YourTableName WHERE companyName = @companyName";
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@companyName", companyName);
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected (deleted)
                    if (rowsAffected > 0)
                    {
                        // Display a message box indicating deletion success
                        MessageBox.Show("The record was deleted successfully.");
                    }
                    else
                    {
                        // Display a message box indicating that no matching record was found
                        MessageBox.Show("No record found with the specified company name.");
                    }
                }
            }

            // Close the current form and open the CrudLeads form
            this.Close();
            CrudLeads crudLeadsForm = new CrudLeads();
            crudLeadsForm.Show();
        }

        private void CompanyNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
