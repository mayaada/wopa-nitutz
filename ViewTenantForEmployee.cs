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

            bool toSearch = true;
            if (CompanytextBox1.Text == "")
            {
                toSearch = false;
                MessageBox.Show("Please enter a valid Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Program.seekTenant(CompanytextBox1.Text) == null)
            {
                toSearch = false;
                MessageBox.Show("Tenant does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (toSearch == true)
            {
                tenantExists = Program.seekTenant(CompanytextBox1.Text);
                CompanyNameTEXTBOX.Text = tenantExists.getCompanyName();
                EmailtextBox4.Text = tenantExists.getContactEmail();
                NOEtextBox4.Text = tenantExists.getNumberOfEmployees().ToString();
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



        private void EmailtextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void NOEtextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameTEXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
