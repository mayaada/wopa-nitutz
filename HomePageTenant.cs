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
        //private string currentTenant;
        public HomePageTenant(Tenant currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();



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

        private void button1_Click(object sender, EventArgs e)
        {
            TenantSignIn TenantSignIn = new TenantSignIn();
            TenantSignIn.Show();
            this.Hide();
        }

        private void newBookingButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenNewTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
