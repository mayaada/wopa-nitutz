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
    public partial class TenantIssuesAndTickets : Form
    {

        private Tenant currentTenant;
        public TenantIssuesAndTickets(Tenant Tenant)
        {
            InitializeComponent();
            this.currentTenant =  Tenant;
        }

        private void TenantIssuesAndTickets_Load(object sender, EventArgs e)
        {

        }

        private void NewLeaseButton_Click(object sender, EventArgs e)
        {
            NewIssueByTenant NewIssueByTenant = new NewIssueByTenant(currentTenant);
            NewIssueByTenant.Show();
            this.Hide();
        }

        private void ExiststingIssue_Click(object sender, EventArgs e)
        {

        }
    }
}
