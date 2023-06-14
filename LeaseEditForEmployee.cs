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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace nitutz
{
    public partial class LeaseEditForEmployee : Form
    {
        public Tenant tenantExists;
        private LeasedItem leasedItem;
        private Lease currentLease;
        private List<LeasedItem> itemsLeased;
        private List<LeasedItemType> itemsLeasedType;
        public LeaseEditForEmployee(Tenant tenantExists)
        {
            InitializeComponent();
            this.tenantExists = tenantExists;
            this.currentLease = tenantExists.getCurrentLease();
            this.itemsLeased = currentLease.getItemsLeased();
            init_leasedItemType_combobox();
            InitializeListView();
            PopulateListView();
        }

        private void init_leasedItemType_combobox()
        {
            this.itemsLeasedType = Program.LeasedItemTypes.ToList();
            addLeasedItem_combobox.Items.Clear();
            foreach (LeasedItemType type in itemsLeasedType)
            {
                addLeasedItem_combobox.Items.Add(type.getType());
            }
        }

        private void InitializeListView()
        {

            // Set the ListView to "Details" view mode
            listView1.View = View.Details;
            listView1.LabelEdit = true;

            // Set up the listView1 control

            listView1.Columns.Add("Item Number", 60);
            listView1.Columns.Add("Item Floor", 60);
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
            List<LeasedItem> itemsLeased = currentLease.getItemsLeased();

            listView1.Items.Clear();


            foreach (LeasedItem itemLeased in itemsLeased)
            {
                ListViewItem item = new ListViewItem(itemLeased.getNumber().ToString());
                //item.SubItems.Add(itemLeased.getNumber().ToString());
                item.SubItems.Add(itemLeased.getFloor().ToString());
                item.SubItems.Add(itemLeased.getType().getType());
                listView1.Items.Add(item);

            }

        }


        private void Savebutton1_Click(object sender, EventArgs e)
        {
            // Check if the end date is earlier than the start date
            DateTime startDate = DateTime.Parse(StartDatetextBox1.Text);
            DateTime endDate;
            if (EndDatetextBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!DateTime.TryParse(EndDatetextBox1.Text, out endDate))
            {
                // Invalid date format
                MessageBox.Show("Invalid end date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (endDate < startDate)
            {
                // Invalid end date
                MessageBox.Show("Invalid end date. Please enter a date later than the start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the termination notice is a valid integer
            int terminationNotice;
            if (!int.TryParse(textBox1.Text, out terminationNotice))
            {
                // Invalid termination notice format
                MessageBox.Show("Invalid termination notice format. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (terminationNotice < 2)
            {
                // Invalid termination notice
                MessageBox.Show("Invalid termination notice. Please enter a value of 2 or more.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string termsAndConditions = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(termsAndConditions))
            {
                // Invalid terms and conditions
                MessageBox.Show("Invalid terms and conditions. Please enter a non-empty string.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Continue with saving the lease information
            currentLease.updateEndDate(endDate);
            currentLease.updateTerminationNotice(int.Parse(textBox1.Text));
            currentLease.updateTermsAndConditions(textBox2.Text);

            currentLease.updateLease();
            MessageBox.Show("Lease information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ViewTenantForEmployee ViewTenantForEmployee = new ViewTenantForEmployee();
            ViewTenantForEmployee.Show();
            this.Hide();
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


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string str = listView1.SelectedItems[0].ToString().Substring(listView1.SelectedItems[0].ToString().IndexOf("{") + 1, listView1.SelectedItems[0].ToString().IndexOf("}") - listView1.SelectedItems[0].ToString().IndexOf("{") - 1);
                int itemType = int.Parse(str.ToString());
                int leaseId = currentLease.getLeaseID();
                SqlCommand c = new SqlCommand();
                c.CommandText = "EXECUTE dbo.pd_remove_item_lease @numbert , @lease";
                c.Parameters.AddWithValue("@numbert", itemType);
                c.Parameters.AddWithValue("@lease", leaseId);
                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(c);
                currentLease.DeleteLeasedItem(Program.seekLeasedItem(itemType));
                PopulateListView();
            }
        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {

        }

        private void addLeasedItem_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void AddItem_Button_Click(object sender, EventArgs e)
        {
            LeasedItem addedItem = null; // Initialize addedItem as null
            LeasedItemType type = Program.seekLeasedItemType(addLeasedItem_combobox.SelectedItem.ToString());
            List<LeasedItem> programLeasedItems = Program.GetLeasedItemDataList();

            foreach (LeasedItem leasedItem in programLeasedItems)
            {
                if (leasedItem.getType() == type && leasedItem.getIsAvailable())
                {
                    addedItem = leasedItem;
                    currentLease.AddLeasedItem(addedItem);
                    addedItem.updateIsAvailable(false);
                    addedItem.updatateRelatesTo(currentLease.getLeaseID());
                    leasedItem.updateLeasedItem();
                    PopulateListView();
                    break; // Exit the loop once a suitable leased item is found

                }
            }

            if (addedItem == null)
            {
                MessageBox.Show("No Type Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}







