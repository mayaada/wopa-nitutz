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
    public partial class TenantHomePage : Form
    {
        public TenantHomePage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyMaintenancerequests MyMaintenancerequestsForm = new MyMaintenancerequests();
            MyMaintenancerequestsForm.Show(); // Show the MyMaintenancerequests form
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreateEvent createEventForm = new FormCreateEvent();
            createEventForm.Show(); // Show the FormCreateEvent form
            this.Hide();
        }

        private void TenantHomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
