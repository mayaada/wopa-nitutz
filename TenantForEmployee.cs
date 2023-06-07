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
        
                string selectedTenant = textBox1.Text; // Get the value entered in textBox1

                // Check if the entered value exists in the Tenants list
                Tenant tenant = Program.Tenants.FirstOrDefault(t => t.getCompanyName() == selectedTenant);
                if (tenant != null)
                {
                    TenantDetailsForEmployee tenantDetailsForm = new TenantDetailsForEmployee(); // Create an instance of TenantDetailsForEmployee form
                    tenantDetailsForm.Show(); // Show the TenantDetailsForEmployee form
                    this.Hide(); // Hide the current form (TenantForEmployee)
                }
                else
                {
                    MessageBox.Show("Invalid tenant selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }

