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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//אילוץ שם משתמש מרשימת עובדים
        {
                 string input = textBox2.Text; // Get the user input from textBox2

                // Check if the input exists in the List<Employee>
                bool exists = Program.Employees.Any(employee => employee.getEmail() == input);

                if (exists)
                {
                    // Input exists in the list, perform the desired action
                }
                else
                {
                    // Input does not exist in the list, display an error message
                    MessageBox.Show("Invalid input. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

    }
    

