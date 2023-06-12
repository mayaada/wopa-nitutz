using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dateOpenedTextBox.Text = currentTicket.getDateOpened().ToString();
            timeOpenedTextBox.Text = currentTicket.getTime().ToString();
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
            private void updateButton_Click(object sender, EventArgs e)
            {
                String oldIssueName = currentIssue.getIssueName();
                String oldIssueLocation = currentIssue.getIssueLocation();

                IssueType selectedIssueType = Program.seekIssueType(typeComboBox.SelectedIndex.ToString());
                currentIssue.setIssueType(selectedIssueType);
               
                Priority selectedPriority = Program.seekPriority(priorityComboBox.SelectedItem.ToString());
                currentIssue.setIssuePriority(selectedPriority);

                TicketStatus selectedTicketStatus = Program.seekTicketStatus(statusComboBox.SelectedItem.ToString());
                currentTicket.setTicketStatus(selectedTicketStatus);

            currentIssue.updateIssue(oldIssueName, oldIssueLocation);
            currentTicket.updateTicketInDB();
            }
        }
    } 