using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nitutz
{
    public partial class employeeSignIn : Form
    {
        private Employee currentUser;

        public employeeSignIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputEmail = textBox2.Text.Trim(); // Get the user input from textBox2 and trim any leading/trailing whitespace
            string inputPassword = textBox3.Text.Trim(); // Get the user input from textBox3 and trim any leading/trailing whitespace

            if (string.IsNullOrWhiteSpace(inputEmail) || string.IsNullOrWhiteSpace(inputPassword))
            {
                // One or both of the textboxes are empty or contain only whitespace
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            // Check if the input exists in the List<Employee>
            bool exists = Program.Employees.Any(employee => employee.getEmail() == inputEmail);

            if (exists)
            {
                // Input exists in the list, perform the desired action

                // Create an instance of HomePageEmployee form
                currentUser = Program.seekEemploye(inputEmail);
                HomePageEmployee homePageEmployeeForm = new HomePageEmployee(currentUser);
                homePageEmployeeForm.Show(); // Show the HomePageEmployee form
                this.Hide(); // 
            }
            else
            {
                // Input does not exist in the list, display an error message
                MessageBox.Show("Invalid email. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EmployeeSignIn_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
