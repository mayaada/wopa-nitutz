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
        public CrudTenants()
        {
            InitializeComponent();
        }

        private void CrudTenants_Load(object sender, EventArgs e)
        {

        }

        private void AddTenantButton_Click(object sender, EventArgs e)
        {
            CreateTenant tenantForm = new CreateTenant();
            tenantForm.Show();
            this.Hide();
        }

        private void UpdateTenantButton_Click(object sender, EventArgs e)
        {
            UpdateTenant tenantForm = new UpdateTenant();
            tenantForm.Show();
            this.Hide();
        }

        private void ManageTenantsLable_Click(object sender, EventArgs e)
        {

        }
    }
}
