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

        private void button1_Click(object sender, EventArgs e)

        {
            TenantDetailsForEmployee TenantDetailsForEmployee = new TenantDetailsForEmployee();
            TenantDetailsForEmployee.Show();
            this.Hide();
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void HomePageEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrudTenants CrudTenants = new CrudTenants();
            CrudTenants.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
