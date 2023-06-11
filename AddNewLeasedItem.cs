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
    public partial class AddNewLeasedItem : Form
    {
        public AddNewLeasedItem()
        {
            InitializeComponent();
        }

        private void AddNewLeasedItem_Load(object sender, EventArgs e)
        {

        }

        private void Leases_Click(object sender, EventArgs e)
        {

        }

        private void TypetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ECtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AvailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeasetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {

            int number = Program.GetLeasedItemDataList().Count + 1;
            LeasedItem L = new LeasedItem(number, (int)numericUpDown1.Value, GetType(TypetextBox1.Text), bool.Parse(ECtextBox1.Text), bool.Parse(AvailtextBox1.Text), Program.seekLease(int.Parse(LeasetextBox1.Text)), true);
        }

        private LeasedItemType GetType(string type)
        {
            if (type == "Parking Spot")
            {
                return Program.seekLeasedItemType("Parking Spot");
            }
            if (type == "CoWorking Workstation")
            {
                return Program.seekLeasedItemType("CoWorking Workstation");
            }
            if (type == "Office Workstation")
            {
                return Program.seekLeasedItemType("Office Workstation");
            }
            if (type == "Suite Workstation")
            {
                return Program.seekLeasedItemType("Suite Workstation");
            }
            return null;
        }





        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BACKbutton1_Click(object sender, EventArgs e)
        {
            CRUD_LI F = new CRUD_LI();
            F.Show();
            this.Hide();
        }

        // generate randome number for leased item number


    }
}