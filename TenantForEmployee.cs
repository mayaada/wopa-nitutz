using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nitutz
{
    public partial class TenantForEmployee : Form
    {
        public TenantForEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TenantForEmployee_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text; // Get the user input from textBox2

            // Check if the input exists in the List<Employee>
            bool exists = Program.Tenants.Any(tenant => tenant.getCompanyName() == input);

            if (exists)
            {
                // Input exists in the list, perform the desired action

                // Create an instance of HomePageEmployee form
                TenantDetailsForEmployee TenantDetailsForEmployeeForm = new TenantDetailsForEmployee();
                TenantDetailsForEmployeeForm.Show(); // Show the HomePageEmployee form
                this.Hide(); // Hide the current form (Form2)
            }
            else
            {
                // Input does not exist in the list, display an error message
                MessageBox.Show("Invalid input. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


