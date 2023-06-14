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
    public partial class UpdateTenant : Form
    {
        private Tenant tenant;
        private Employee currentUser;
        public UpdateTenant(Employee currentUser)
        {
            InitializeComponent();
            UpdateButton.Hide();
            this.currentUser = currentUser;

        }

        private void UpdateTenantLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchCNbutton_Click(object sender, EventArgs e)
        {
            bool ReadyToSearch = true;

            if (CompanyNametextBox == null)
            {
                ReadyToSearch = false;
                MessageBox.Show("Please enter a company name");
            }
            if (Program.seekTenant(CompanyNametextBox.Text) == null)
            {
                ReadyToSearch = false;
                MessageBox.Show("Tenant not found");
            }

            if (ReadyToSearch == true)
            {
                //הצגת הכפתורים
                UpdateButton.Show();
                //איתור המופע המתאים והצגת הפרטים
                tenant = Program.seekTenant(CompanyNametextBox.Text);
                EmailtextBox1.Text = tenant.getContactEmail();
                NumOfEmptextBox1.Text = tenant.getNumOfEmployees();
                WebsitetextBox.Text = tenant.getWebsite();
                IsActiveTextBox.Text = tenant.getIsActivity();

            }
        }

        private void WebsiteLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumOfEmptextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool ReadyToUpdate = true;

            if (CompanyNametextBox.Text == "" || EmailtextBox1.Text == "" || WebsitetextBox.Text == "")
            {
                ReadyToUpdate = false;
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!EmailtextBox1.Text.Contains("@") && !EmailtextBox1.Text.Contains(".com"))
            {
                ReadyToUpdate = false;
                MessageBox.Show("Please fill in the email field correctly", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!WebsitetextBox.Text.Contains("www.") && !WebsitetextBox.Text.Contains(".com"))
            {
                ReadyToUpdate = false;
                MessageBox.Show("Please fill in the 'website' field correctly", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ReadyToUpdate == true)
            {
                tenant.updateCompanyName(CompanyNametextBox.Text);
                tenant.updateContactEmail(EmailtextBox1.Text);
                tenant.updateWebsite(WebsitetextBox.Text);
                int num = int.Parse(NumOfEmptextBox1.Text);
                Console.WriteLine(num);
                tenant.updateNumberOfEmployees(num);
                bool Activity = bool.Parse(IsActiveTextBox.Text);
                Console.WriteLine(Activity);
                tenant.UpdateActivateTenant(Activity);
                tenant.updateTenant();
                MessageBox.Show("Tenant updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void WebsitetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsActivelabel1_Click(object sender, EventArgs e)
        {

        }

        private void IsActiveTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Backbutton_Click(object sender, EventArgs e)
        {
            CrudTenants mf = new CrudTenants(currentUser);
            mf.Show();
            this.Close();

        }


        private void UpdateTenant_Load(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click_1(object sender, EventArgs e)
        {
            CrudTenants CrudTenants = new CrudTenants(currentUser);
            CrudTenants.Show();
            this.Hide();
        }
    }
}
