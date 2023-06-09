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
    public partial class EditLease : Form
    {
        private Tenant tenant;
        private Lease lease;
        public EditLease(Tenant tenant)
        {
            this.tenant = tenant;
            InitializeComponent();
        }

        private void EditLease_Load(object sender, EventArgs e)
        {
            this.lease = tenant.getLease(); // Assuming there's a method GetLease in the Tenant class

            // Display the lease details in textBox1
            textBox1.Text = $"Lease ID: {lease.getLeaseID()}\r\n";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
