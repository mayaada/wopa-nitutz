using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using System.Text.RegularExpressions;

namespace nitutz
{
    public partial class UpdateLead : Form
    {
        private Lead lead;
        public UpdateLead()
        {
            InitializeComponent();
            Updatebutton.Hide();
            LeadStatuscomboBox1.DataSource = Enum.GetValues(typeof(LeadStatus));
        }

        private void UpdateLead_Load(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputCompanyName = CompanyTextBox.Text;
            bool readyToUpdate = true;

            if (inputCompanyName == "" || Program.seekLead(inputCompanyName) == null)
            {
                readyToUpdate = false;
                MessageBox.Show("Please enter vail company.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }

            if (readyToUpdate == true)

            {
                //הצגת הכפתורים
                Updatebutton.Show();
                //איתור המופע המתאים והצגת הפרטים
                lead = Program.seekLead(CompanyTextBox.Text);
                contactTextBox.Text = lead.getContact();
                PhoneTextBox.Text = lead.getNumber();
                EmailTextBox.Text = lead.getEmail();
                WorkStationBox5.Text = lead.getWorkStationNumber().ToString();
                LeadStatuscomboBox1.SelectedItem = lead.getStatus();
                Console.WriteLine(lead.getStatus());


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool readyToUpdate = true;
            if (Regex.IsMatch(contactTextBox.Text, @"\d"))
            {
                readyToUpdate = false;
                MessageBox.Show("Please enter a valid contact name");
            }
            if (PhoneTextBox.Text.Length != 10 || !PhoneTextBox.Text.All(char.IsDigit))
            {
                readyToUpdate = false;
                MessageBox.Show("Please fill in the 'Phone' field with a valid 10-digit phone number", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!EmailTextBox.Text.Contains("@") || !EmailTextBox.Text.Contains(".com"))
            {
                readyToUpdate = false;
                MessageBox.Show("Please fill in the 'Email' field correctly", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            int workstationValue;
            if (!int.TryParse(WorkStationBox5.Text, out workstationValue))
            {
                readyToUpdate = false;
                MessageBox.Show("Please fill in the 'Workstation' field with a valid number", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (contactTextBox.Text == "" || PhoneTextBox.Text == "" || EmailTextBox.Text == "" || WorkStationBox5.Text == "")
            {
                readyToUpdate = false;
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (!EmailTextBox.Text.Contains("@") && !EmailTextBox.Text.Contains(".com"))
            {
                readyToUpdate = false;
                MessageBox.Show("Please fill in the email field correctly", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (readyToUpdate == true)
            {
                lead.updateContact(contactTextBox.Text);
                lead.updateNumber(PhoneTextBox.Text);
                lead.updateEmail(EmailTextBox.Text);
                int num = int.Parse(WorkStationBox5.Text);
                Console.WriteLine(num);
                lead.updateWorkStationNumber(num);
                lead.updateLeadStatus((LeadStatus)LeadStatuscomboBox1.SelectedItem);
                lead.updateLead();
                MessageBox.Show("Lead updated successfully");
            }
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

        private void BACKbutton1_Click(object sender, EventArgs e)
        {
            CrudLeads CrudLeads = new CrudLeads();
            CrudLeads.Show();
            this.Hide();

        }
    }
}