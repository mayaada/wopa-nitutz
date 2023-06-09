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
    public partial class UpdateLead : Form
    {
        private Lead lead;
        public UpdateLead()
        {
            InitializeComponent();
        }

        private void UpdateLead_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CompanyTextBox != null)
            {
                //הצגת הכפתורים
                Updatebutton.Show();
                //איתור המופע המתאים והצגת הפרטים
                lead = Program.seeklead(CompanyTextBox.Text);
                contactTextBox.Text = lead.getContact();
                PhoneTextBox.Text = lead.getNumber();
                EmailTextBox.Text = lead.getEmail();
                WorkStationBox5.Text = lead.getWorkStationNumber();
                //CreatedNewTextBox.Text = lead.getCreatedNew();
                LeadStatuscomboBox1.DataSource = Enum.GetValues(typeof(LeadStatus)); // Populate ComboBox with enum values
                // Set the selected value of the ComboBox based on the lead's status
                LeadStatuscomboBox1.SelectedItem = lead.getStatus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lead.updateContact(contactTextBox.Text);
            lead.updateNumber(PhoneTextBox.Text);
            lead.updateEmail(EmailTextBox.Text);
            lead.updateWorkStationNumber(WorkStationBox5.Text);
            lead.updateLeadStatus(LeadStatuscomboBox1.Text);

           // int num = int.Parse(NumOfEmptextBox1.Text);
           // Console.WriteLine(num);
           // tenant.updateNumberOfEmployees(num);
            //bool Activity = bool.Parse(IsActiveTextBox.Text);
            //Console.WriteLine(Activity);
            //tenant.UpdateActivateTenant(Activity);
           // tenant.updateTenant();
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkStationBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatedNewTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeadStatuscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

