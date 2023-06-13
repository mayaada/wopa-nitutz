using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace nitutz
{
    public class Issue
    {
        private string issueName;
        private string issueLocation;
        private IssueType issueType;
        private Priority issuePriority;
        private string photo;
        private List<Ticket> ticketsOpened; //different tickets open for this specific issue

        public Issue(string issueName, string issueLocation,
         IssueType issueType, Priority issuePriority, string photo , bool isNew)
        {
            this.issueName = issueName;
            this.issueLocation = issueLocation;
            this.issueType = issueType;
            this.issuePriority = issuePriority;
            this.photo = photo;
            this.ticketsOpened = new List<Ticket>();
            if (isNew)
            {
                Program.Issues.Add(this);
                addIssue();
            }
        }

        public string getIssueName()
        {
            return this.issueName;
        }

        public void setIssueName(string issueName)
        {
            this.issueName = issueName;
        }

        public string getIssueLocation()
        {
            return this.issueLocation;
        }

        public void setIssueLocation(string issueLocation)
        {
            this.issueLocation = issueLocation;
        }

        public IssueType getIssueType()
        {
            return this.issueType;
        }

        public void setIssueType(IssueType issueType)
        {
            this.issueType = issueType;
        }

        public Priority getIssuePriority()
        {
            return this.issuePriority;
        }

        public void setIssuePriority(Priority issuePriority)
        {
            this.issuePriority = issuePriority;
        }

        public string getPhoto()
        {
            return this.photo;
        }

        public void setPhoto(string photo)
        {
            this.photo = photo;
        }

        public List<Ticket> getTicketsOpened()
        {
            return this.ticketsOpened;
        }

        public void addIssue()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Issue @Issue, @Issue_Location, @Issue_Type, @Issue_Priority, @Photo";
            c.Parameters.AddWithValue("@Issue", issueName);
            c.Parameters.AddWithValue("@Issue_Location", issueLocation.ToString());
            c.Parameters.AddWithValue("@Issue_Type", issueType.ToString());
            c.Parameters.AddWithValue("@Issue_Priority", (issuePriority.ToString()));
            c.Parameters.AddWithValue("@Photo", photo);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateIssue()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Issue @Issue, @Issue_Location, @Issue_Type, @Issue_Priority, @Photo";
            c.Parameters.AddWithValue("@Issue", issueName);
            c.Parameters.AddWithValue("@Issue_Location", issueLocation);
            c.Parameters.AddWithValue("@Issue_Type", issueType.ToString());
            c.Parameters.AddWithValue("@Issue_Priority", issuePriority.ToString());
            c.Parameters.AddWithValue("@Photo", DBNull.Value);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void deleteIssue()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Delete_Issue @Issue, @Issue_Location";
            c.Parameters.AddWithValue("@Issue", issueName);
            c.Parameters.AddWithValue("@Issue_Location", issueLocation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
