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
    public partial class HomePageTenant : Form
    {
        private Tenant currentUser;
        public HomePageTenant(Tenant currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;


        }

        private void HomePageTenant_Load(object sender, EventArgs e)
        {

        }

        private void NewTicketButton_Click(object sender, EventArgs e)
        {
            TenantIssuesAndTickets TenantIssuesAndTickets = new TenantIssuesAndTickets(currentUser);
            TenantIssuesAndTickets.Show();  
            this.Hide();
        }
    }
}
