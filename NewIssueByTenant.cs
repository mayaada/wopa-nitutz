using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace nitutz
{
    public partial class NewIssueByTenant : Form
    {

        private Tenant currentUser;
        // private string currentTenantName;
        public NewIssueByTenant(Tenant tenant)
        {
            InitializeComponent();
            this.currentUser = tenant;
            PrioritycomboBox1.DataSource = Enum.GetValues(typeof(Priority));
            TypecomboBox1.DataSource = Enum.GetValues(typeof(IssueType));

        }

        private void IssuetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrioritycomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DescriptiontextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {

            bool readyTocreate = true;

            if (IssuetextBox1.Text == null || LocationtextBox1.Text == null)
            {
                readyTocreate = false;
                MessageBox.Show("Please enter an issue");
            }

            if (readyTocreate == true)
            {

                DateTime currentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                IssueType issueType = (IssueType)TypecomboBox1.SelectedItem;
                Priority issuePriority = (Priority)PrioritycomboBox1.SelectedItem;
                String issue = IssuetextBox1.Text;
                String location = LocationtextBox1.Text;
                int ticketID = new Random().Next(100000, 999999);

                Issue I = new Issue(issue, location, issueType, issuePriority, "Null", true);
                Ticket T = new Ticket(ticketID, currentTime, currentDate, currentUser, I, true);
                SendMail("Your Ticket has been successfully updateded, we will process your request soon.");
            }



        }

        private void NewIssueByTenant_Load(object sender, EventArgs e)
        {

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePageTenant HomePageTenant = new HomePageTenant(currentUser);
            HomePageTenant.Show();
            this.Hide();
        }
    }
}
