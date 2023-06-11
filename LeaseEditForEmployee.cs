using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nitutz
{
    public partial class LeaseEditForEmployee : Form
    {
        public Tenant tenantExists;
        private LeasedItem leasedItem;
        private Lease currentLease;
        public LeaseEditForEmployee(Tenant tenantExists)
        {
            InitializeComponent();
            this.tenantExists = tenantExists;
        }

        private void label2_Click(object sender, EventArgs e)
        {



        }

        private void LeaseIdtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeasedItemtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaseEditForEmployee_Load(object sender, EventArgs e)
        {
            Lease currentLease = tenantExists.GetCurrentLease();

            if (currentLease != null)
            {
                int leaseId = currentLease.getLeaseID();
                LeaseIdtextBox1.Text = leaseId.ToString();
            }
            else
            {
                LeaseIdtextBox1.Text = "No Current Lease Found";
            }
            if (currentLease != null)
            {
                int leaseId = currentLease.getLeaseID();
                textBox1.Text = leaseId.ToString();
                DateTime startDate = currentLease.getStartDate();
                StartDatetextBox1.Text = startDate.ToShortDateString();
                DateTime endDate = currentLease.getEndDate();
                EndDatetextBox1.Text = endDate.ToShortDateString();
                int terminationNotice = currentLease.getTerminationNotice();
                textBox1.Text = terminationNotice.ToString();
                string termsAndConditions = currentLease.getTermsAndConditions();
                textBox2.Text = termsAndConditions;

            }
            else
            {

                EndDatetextBox1.Text = "No Current Lease Found";
                textBox1.Text = "No Current Lease Found";
                textBox2.Text = "No Current Lease Found";
                LeaseIdtextBox1.Text = "No Current Lease Found";
                StartDatetextBox1.Text = "No Current Lease Found";
            }

        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void StartDatetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndDatetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TermianationNoticelabel5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BACKbutton1_Click(object sender, EventArgs e)
        {
            CrudLeads CrudLeads = new CrudLeads();
            CrudLeads.Show();
            this.Hide();

        }
    }
}
