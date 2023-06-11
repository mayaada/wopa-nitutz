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
        public TenantSignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputCompanyName = textBox2.Text.Trim(); // Get the user input from textBox2 and trim any leading/trailing whitespace
            string inputPassword = textBox3.Text.Trim(); // Get the user input from textBox3 and trim any leading/trailing whitespace

            if (string.IsNullOrWhiteSpace(inputCompanyName) || string.IsNullOrWhiteSpace(inputPassword))
            {
                // One or both of the textboxes are empty or contain only whitespace
                MessageBox.Show("Please enter both Username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Check if the input exists in the List<Employee>
            bool exists = Program.Tenants.Any(tenants => tenants.getCompanyName() == inputCompanyName);

            if (exists)
            {
                // Input exists in the list, perform the desired action

                // Create an instance of HomePageEmployee form
               
            }
            else
            {
                // Input does not exist in the list, display an error message
                MessageBox.Show("Invalid Username. Please enter a valid Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
