using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace nitutz
{
    public partial class ViewTenantForEmployee : Form
    {

        private Tenant tenantExists;
        private Employee currentUser;
        public ViewTenantForEmployee()
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {
            string input = CompanytextBox1.Text; // Get the user input from textBox2
            tenantExists = Program.seekTenant(input);
            if (string.IsNullOrWhiteSpace(input))
            {
                // One or both of the textboxes are empty or contain only whitespace
                MessageBox.Show("Please enter a valid Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }
            // Check if the input exists in the List<Employee>

            bool exists = Program.Tenants.Any(tenant => tenant.getCompanyName() == input);

            if (exists)
            {
                textBox1.Text = tenantExists.getCompanyName();
                textBox2.Text = tenantExists.getContactEmail();
                textBox3.Text = tenantExists.getNumberOfEmployees().ToString();

            }
            else
            {
                // Input does not exist in the list, display an error message
                MessageBox.Show("Invalid input. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CompanytextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewLeasebutton1_Click(object sender, EventArgs e)
        {
            LeaseEditForEmployee LeaseEditForEmployee = new LeaseEditForEmployee(tenantExists);
            LeaseEditForEmployee.Show();
            this.Hide();
        }

        private void ViewTenantForEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePageEmployee HomePageEmployee = new HomePageEmployee();
            HomePageEmployee.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
