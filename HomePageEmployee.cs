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
        public HomePageEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            TenantDetailsForEmployee tenantForm = new TenantDetailsForEmployee(); // Create an instance of the TenantForEmployee form
            tenantForm.Show(); // Show the TenantForEmployee form
            this.Hide(); // Hide the current form (HomePageEmployee)
        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
