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
    public partial class MyMaintenancerequests : Form
    {
        public MyMaintenancerequests()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MyMaintenancerequests_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenNewMaintenanceRequest OpenNewMaintenanceRequest = new OpenNewMaintenanceRequest();
            OpenNewMaintenanceRequest.Show();
            this.Hide();
        }
    }
}
