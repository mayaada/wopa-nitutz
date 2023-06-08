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
    public partial class UpdateTenant : Form
    {
        private Tenant tenant;
        public UpdateTenant()
        {
            InitializeComponent();
            UpdateButton.Hide();
            
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
            if (CompanyNametextBox != null)
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
    }
}
