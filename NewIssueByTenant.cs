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
    public partial class NewIssueByTenant : Form
    {

        private Tenant currentTenant;
        public NewIssueByTenant(Tenant tenant)
        {
            InitializeComponent();
            this.currentTenant = tenant;
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
            DateTime currentDate = DateTime.Now;
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            IssueType issueType = (IssueType)TypecomboBox1.SelectedItem;
            Priority issuePriority = (Priority)PrioritycomboBox1.SelectedItem;
            String issue = IssuetextBox1.Text;
            String location = LocationtextBox1.Text;



            Issue I = new Issue(issue,location, issueType , issuePriority ,"Null", true);
            Ticket T = new Ticket(currentTime, currentDate, "Pending" ,currentTenant, issue ,location,true );




        }

        private void NewIssueByTenant_Load(object sender, EventArgs e)
        {

        }
    }
}
