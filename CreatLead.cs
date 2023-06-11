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
    public partial class CreatLead : Form
    {
        public CreatLead()
        {
            InitializeComponent();
        }

        private void CreatLead_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;

           // Lead L = new Lead(CompanyNameTextBox.Text, ContacttextBox1.Text, PhontextBox1.Text, EmailtextBox1.Text, currentDate, 
              //  (int)NumOfWorkstationumericUpDown1.Value, 'Open',true)//   ושדות עד הסוףlead source open לבדוק איך מכניס אוטומטי
            {

            };
        }



        private void NumOfWorkstationumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContacttextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhontextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailtextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
