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
    public partial class CrudTenants : Form
    {
        private Employee currentUser;
        public CrudTenants(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void CrudTenants_Load(object sender, EventArgs e)
        {

        }

        private void AddTenantButton_Click(object sender, EventArgs e)
        {
            CreateTenant tenantForm = new CreateTenant(currentUser);
            tenantForm.Show();
            this.Hide();
        }

        private void UpdateTenantButton_Click(object sender, EventArgs e)
        {
            UpdateTenant tenantForm = new UpdateTenant(currentUser);
            tenantForm.Show();
            this.Hide();
        }

        private void ManageTenantsLable_Click(object sender, EventArgs e)
        {

        }

        private void BACKbutton_Click(object sender, EventArgs e)
        {
            HomePageEmployee homepageemployee = new HomePageEmployee(currentUser);
            this.Hide();
            homepageemployee.Show();
        }
    }
}
