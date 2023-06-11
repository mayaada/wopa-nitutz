using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nitutz
{
    public partial class LeaseEditForEmployee : Form
    {
        public Tenant tenantExists;
        private LeasedItem leasedItem;
        private Lease currentLease;
        private List<LeasedItem> itemsLeased;
        public LeaseEditForEmployee(Tenant tenantExists)
        {
            InitializeComponent();
            this.tenantExists = tenantExists;
            this.currentLease = tenantExists.getCurrentLease();
            this.itemsLeased = currentLease.getItemsLeased();

            InitializeListView();
            PopulateListView();
        }


        private void InitializeListView()
        {

            // Set the ListView to "Details" view mode
            listView1.View = View.Details;
            listView1.LabelEdit = true;

            // Set up the listView1 control
            
            listView1.Columns.Add("Item Number" , 60);
            listView1.Columns.Add("Item Floor" , 60);
            listView1.Columns.Add("Type", 60);

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

        private void PopulateListView()
        {
            itemsLeased = currentLease.getItemsLeased();

            listView1.Items.Clear();


            foreach (LeasedItem itemLeased in itemsLeased)
            {
                ListViewItem item = new ListViewItem(itemLeased.getNumber().ToString());
                item.SubItems.Add(itemLeased.getNumber().ToString());
                item.SubItems.Add(itemLeased.getFloor().ToString());
                item.SubItems.Add(itemLeased.getType().getType());
                listView1.Items.Add(item);

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
