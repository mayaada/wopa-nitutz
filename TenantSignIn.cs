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
    public partial class TenantSignIn : Form
    {
        public Tenant currentUser;
        public static string Tenant;

        public TenantSignIn()
        {
            InitializeComponent();
            this.currentUser = Program.seekTenant(textBox2.ToString());
        }

        public static string GetTenant()
        {
            return Tenant;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            string inputCompanyName = textBox2.Text.Trim(); // Get the user input from textBox2 and trim any leading/trailing whitespace
            string inputPassword = textBox3.Text.Trim(); // Get the user input from textBox3 and trim any leading/trailing whitespace

            if (string.IsNullOrWhiteSpace(inputCompanyName) || string.IsNullOrWhiteSpace(inputPassword))
            {
                // One or both of the textboxes are empty or contain only whitespace
                MessageBox.Show("Please enter both Username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            if (Program.seekTenant(inputCompanyName) == null)
            {
                // The company name does not exist in the database
                MessageBox.Show("Company name does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }
            currentUser = Program.seekTenant(textBox2.Text);
            HomePageTenant HomePageTenant = new HomePageTenant(this.currentUser);
            HomePageTenant.Show();
            this.Hide();



        }
    }
}