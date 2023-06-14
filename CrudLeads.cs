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
        private Employee currentUser;
        public CrudLeads(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateLead updateLead = new UpdateLead(currentUser);
            updateLead.Show();
        }

        private void CrudLeads_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatLead CreatLeadForm = new CreatLead(currentUser);
            CreatLeadForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteLead DeleteLead = new DeleteLead(currentUser);
            DeleteLead.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePageEmployee homepageemployee = new HomePageEmployee(currentUser);
            this.Hide();
            homepageemployee.Show();
        }
    }
}
