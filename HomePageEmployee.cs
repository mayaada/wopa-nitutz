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
    public partial class HomePageEmployee : Form
    {
        private Employee currentUser;

        public HomePageEmployee(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        public HomePageEmployee()
        {
        }

        private void button1_Click(object sender, EventArgs e)

        {
            //  TenantDetailsForEmployee TenantDetailsForEmployee = new TenantDetailsForEmployee();
            // TenantDetailsForEmployee.Show();
            // this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            CrudLeads CrudLeads = new CrudLeads(currentUser);
            CrudLeads.Show();
            this.Hide();
        }

        private void maintenanceTickets_Button_Click(object sender, EventArgs e)
        {
            MaintenanceTicketManagementForm form = new MaintenanceTicketManagementForm(currentUser);
            this.Hide();
            form.Show();

        }


        private void HomePageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrudTenants CrudTenants = new CrudTenants(currentUser);
            CrudTenants.Show();
            this.Hide();
        }

        private void existingEventsButton_Click(object sender, EventArgs e)
        {
            NewBookingForEmployee form = new NewBookingForEmployee(currentUser);
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewTenantForEmployee ViewTenantForEmployee = new ViewTenantForEmployee();
            ViewTenantForEmployee.Show();
            this.Hide();
        }

        private void newTicket_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void leasesButton_Click(object sender, EventArgs e)
        {
            ViewTenantForEmployee form = new ViewTenantForEmployee();
            this.Hide();
            form.Show();
        }

        private void leasedItemsButton_Click(object sender, EventArgs e)
        {
            CRUD_LI form = new CRUD_LI();
            this.Hide();
            this.Show();
        }
    }
}
