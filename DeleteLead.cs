using Microsoft.Data.SqlClient;
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
    public partial class DeleteLead : Form
    {
        public DeleteLead()
        {
            InitializeComponent();
        }

        private void DeleteLead_Load(object sender, EventArgs e)
        {
            Lead l = Program.seekLead(CompanyNametextBox1.Text);

        }



        private void CompanyNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            string inputCompanyName = CompanyNametextBox1.Text.Trim(); // Get the user input from 

            bool readyToDelete = true;

            if (inputCompanyName == "" || Program.seekLead(CompanyNametextBox1.Text) == null)
            {
                readyToDelete = false;
                MessageBox.Show("Please enter vail company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }
            if (readyToDelete == true)
            {
                Lead lead = Program.seekLead(CompanyNametextBox1.Text);
                lead.deleteLead();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrudLeads CrudLeads = new CrudLeads();
            CrudLeads.Show();
            this.Hide();

        }
    }
}
