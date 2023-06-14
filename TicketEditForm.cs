using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nitutz
{
    public partial class TicketEditForm : Form
    {
        private Issue currentIssue;
        private Ticket currentTicket;
        private Employee currentUser;

        public TicketEditForm(Issue curentIssue, Ticket currentTicket)
        {
            InitializeComponent();
            this.currentIssue = curentIssue;
            this.currentTicket = currentTicket;
            typeComboBox.DataSource = Enum.GetValues(typeof(IssueType));
            priorityComboBox.DataSource = Enum.GetValues(typeof(Priority));
            statusComboBox.DataSource = Enum.GetValues(typeof(TicketStatus));


        }

        private void TicketEditForm_Load(object sender, EventArgs e)
        {
            issueTextBox.Text = currentIssue.getIssueName();
            locationTextBox.Text = currentIssue.getIssueLocation();
            typeComboBox.Text = currentIssue.getIssueType().ToString();
            priorityComboBox.Text = currentIssue.getIssuePriority().ToString();
            dateOpenedTextBox.Text = currentTicket.getDateOpened().ToString("dd-MM-yyyy");
            timeOpenedTextBox.Text = DateTime.Today.Add(currentTicket.getTime()).ToString("HH:mm:ss");
            openedByTextBox.Text = checkOpenedByClass();
            statusComboBox.Text = currentTicket.getTicketStatus().ToString();
        }

        private string checkOpenedByClass()
        {
            if (currentTicket.openedByEmployee != null)
            {
                return currentTicket.openedByEmployee.getName();
            }
            else { return currentTicket.openedByTenant.getCompanyName(); }
        }

        private void issue_Lable_Click(object sender, EventArgs e)
        {

        }

        private void location_Lable_Click(object sender, EventArgs e)
        {
        }

        private void type_Lable_Click(object sender, EventArgs e)
        {
        }

        private void priority_Lable_Click(object sender, EventArgs e)
        {
        }

        private void dateOpened_Lable_Click(object sender, EventArgs e)
        {
        }

        private void timeOpened_Lable_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void openedBy_Lable_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            IssueType selectedIssueType = Program.seekIssueType(typeComboBox.SelectedItem.ToString());
            currentIssue.setIssueType(selectedIssueType);

            Priority selectedPriority = Program.seekPriority(priorityComboBox.SelectedItem.ToString());
            currentIssue.setIssuePriority(selectedPriority);

            TicketStatus selectedTicketStatus = Program.seekTicketStatus(statusComboBox.SelectedItem.ToString());
            currentTicket.setTicketStatus(selectedTicketStatus);


            // update in DB
            currentIssue.updateIssue();
            currentTicket.updateTicketInDB();

            SendMail("Somr fileds in your Ticket have been changed, please notice to view changes.");

        }
        private void SendMail(string email)
        {

            string from = "ta4126463@gmail.com";
            string to = "ta4126463@gmail.com";
            string fromPassword = "iwaoyfhfccyrnmsy";


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            mail.Subject = "Confirmation email";
            mail.Body = "<html><body>" + email + "</body></html>";
            mail.IsBodyHtml = true;

            var SmtpServer = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new System.Net.NetworkCredential(from, fromPassword),
                EnableSsl = true,
            };
            try
            {
                SmtpServer.Send(mail);
                MessageBox.Show("Your email has been sent.");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("An error occurred while sending the email: " + ex.Message);
            }
        }

            private void backButton_Click(object sender, EventArgs e)
        {
            MaintenanceTicketManagementForm form = new MaintenanceTicketManagementForm(currentUser);
            form.Show();
            this.Hide();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}