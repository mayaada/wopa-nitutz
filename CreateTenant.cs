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
    public partial class CreateTenant : Form
    {
        public CreateTenant()
        {
            InitializeComponent();
        }

        private void CreateTenant_Load(object sender, EventArgs e)
        {

        }

        private void AddNewTenantLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumEmpLabel_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void WebsiteTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTenantButton_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;

            Tenant T = new Tenant(CompanyNameTB.Text, EmailTB.Text, WebsiteTB.Text, currentDate,
                (int)numericUpDown1.Value, true, true);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            CrudTenants mf = new CrudTenants();
            mf.Show();
            this.Close();
        }
    }
}
