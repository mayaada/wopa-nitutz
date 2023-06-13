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
    public partial class TenantIssuesAndTickets : Form
    {

        private Tenant currentUser;
        //private string currentTenant;
        public TenantIssuesAndTickets(Tenant Tenant)
        {
            this.currentUser = Tenant;
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
            listView1.Columns.Add("Issue", 110);
            listView1.Columns.Add("Location", 110);
            listView1.Columns.Add("Type", 110);
            listView1.Columns.Add("Priority", 110);
            listView1.Columns.Add("Photo", 110);

        }

        private void PopulateListView()
        {
            List<Issue> issues = Program.GetIssueDataList();

            listView1.Items.Clear();

            foreach (Issue issue in issues)
            {

                ListViewItem item = new ListViewItem(issue.getIssueName());
                item.SubItems.Add(issue.getIssueLocation().ToString());
                item.SubItems.Add(issue.getIssueType().ToString());
                item.SubItems.Add(issue.getIssuePriority().ToString());
                item.SubItems.Add(issue.getPhoto().ToString());
                listView1.Items.Add(item);
            }
        }

        private void TenantIssuesAndTickets_Load(object sender, EventArgs e)
        {

        }

        private void NewLeaseButton_Click(object sender, EventArgs e)
        {
            NewIssueByTenant NewIssueByTenant = new NewIssueByTenant(currentUser);
            NewIssueByTenant.Show();
            this.Hide();
        }

        private void ExiststingIssue_Click(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateTicketBueeon_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string issueName = item.SubItems[0].Text;
                string issueLocation = item.SubItems[1].Text;
                IssueType issueType = (IssueType)Enum.Parse(typeof(IssueType), item.SubItems[2].Text);
                Priority issuePriority = (Priority)Enum.Parse(typeof(Priority), item.SubItems[3].Text);
                string photo = item.SubItems[4].Text;
                DateTime currentDate = DateTime.Now;
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                int ticketID = new Random().Next(100000, 999999);

                Issue issue = new Issue(issueName, issueLocation, issueType, issuePriority, photo, false);
                Ticket ticket = new Ticket(ticketID, currentTime, currentDate, currentUser, issue, true);
                EmailSender emailSender = new EmailSender();
                emailSender.SendEmail("info@wopa.space",currentUser.getContactEmail(),"Confirmation email", "Your Ticket has been successfully updateded, we will process your request soon.");
                
                

            }

        }
    }
}
