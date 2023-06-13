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
    public partial class CrudLeasedItems : Form
    {
        public CrudLeasedItems()
        {
            InitializeComponent();
            InitializeListView();
            PopulateListView();

        }

        private void InitializeListView()
        {
            // Set the ListView to "Details" view mode
            listView1.View = View.Details;
            listView1.LabelEdit = true;


            // Add columns with headers
            listView1.Columns.Add("ID", 60);
            listView1.Columns.Add("Floor", 60);
            listView1.Columns.Add("Type", 100);
            listView1.Columns.Add("EC", 60);
            listView1.Columns.Add("Availability", 100);
            listView1.Columns.Add("Lease", 100);
            listView1.Columns.Add("Price", 100);
            listView1.Columns.Add("Credit", 100);
            listView1.Columns.Add("Deposit", 100);
        }
        private void PopulateListView()
        {
            List<LeasedItem> leasedItems = Program.GetLeasedItemDataList();

            listView1.Items.Clear();

            foreach (LeasedItem leasedItem in leasedItems)
            {
                ListViewItem item = new ListViewItem(leasedItem.getNumber().ToString());
                item.SubItems.Add(leasedItem.getFloor().ToString());
                item.SubItems.Add(leasedItem.getLeasedItemTypeName().ToString());
                item.SubItems.Add(leasedItem.getElectricCharging() ? "Yes" : "No");
                item.SubItems.Add(leasedItem.getIsAvailable() ? "Yes" : "No");
                item.SubItems.Add(leasedItem.getLeaseNumber().ToString());
                item.SubItems.Add(leasedItem.getPrice().ToString());
                item.SubItems.Add(leasedItem.getCreditAmount().ToString());
                item.SubItems.Add(leasedItem.getDeposit().ToString());

                listView1.Items.Add(item);
            }
        }



        private void CrudLeasedItems_Load(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {

            bool ReadyToUpdate = true;

            if (listView1.SelectedItems.Count == 0)
            {
                ReadyToUpdate = false;
                MessageBox.Show("Please select a leased item to update");
            }

            if (ECtextBox1.Text == null || AvailtextBox1.Text == null || leasetextBox1.Text == null)
            {

                ECtextBox1.Text = Program.seekLeasedItem(int.Parse(listView1.SelectedItems[0].SubItems[0].Text)).getElectricCharging() ? "Yes" : "No";
                AvailtextBox1.Text = Program.seekLeasedItem(int.Parse(listView1.SelectedItems[0].SubItems[0].Text)).getIsAvailable() ? "Yes" : "No";
                leasetextBox1.Text = Program.seekLeasedItem(int.Parse(listView1.SelectedItems[0].SubItems[0].Text)).getLeaseNumber().ToString();
            }


            if (ReadyToUpdate == true && listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Access the subitems by column index and modify their values
                string updatedID = selectedItem.SubItems[0].Text;

                // set all changes in leasedItem object 
                LeasedItem leasedItem = Program.seekLeasedItem(int.Parse(updatedID));
                leasedItem.updateElectricCharging(getEC(selectedItem));
                leasedItem.updateIsAvailable(getAvail(selectedItem));
                leasedItem.updateLease(getLease(selectedItem));
                leasedItem.updateLeasedItem();

            }


        }

        public int getLease(ListViewItem selectedItem)
        {
            int num = 0;

            if (leasetextBox1.Text.Length < 1)
            { num = int.Parse(selectedItem.SubItems[5].Text); }
            else
            { num = int.Parse(leasetextBox1.Text); }
            return num;
        }

        public bool getEC(ListViewItem selectedItem)
        {
            bool boll = new bool();
            if (ECtextBox1.Text.Length < 1)
            { boll = selectedItem.SubItems[3].Text == "Yes" ? true : false; }
            else
            { boll = ECtextBox1.Text == "Yes" ? true : false; }
            return boll;
        }

        public bool getAvail(ListViewItem selectedItem)
        {
            bool boll = new bool();
            if (AvailtextBox1.Text.Length < 1)
            { boll = selectedItem.SubItems[4].Text == "Yes" ? true : false; }
            else
            { boll = AvailtextBox1.Text == "Yes" ? true : false; }
            return boll;
        }

        private void AvailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ECtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void leasetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BACKbutton_Click(object sender, EventArgs e)
        {
            CRUD_LI f = new CRUD_LI();
            f.Show();
            this.Hide();


        }
    }
}
