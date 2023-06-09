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
    public partial class CrudLeads : Form
    {
        public CrudLeads()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateLead updateLead = new UpdateLead();
            updateLead.Show();
        }

        private void CrudLeads_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatLead CreatLeadForm = new CreatLead();
            CreatLeadForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteLead DeleteLead = new DeleteLead();
            DeleteLead.Show();
        }
    }
}
