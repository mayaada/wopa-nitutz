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
        public string IssueName;
        public string IssueLocation;
        public IssueType IssueType;
        public Priority IssuePriority;
        public string Photo;

        public Issue(string issueName, string issueLocation, IssueType issueType, Priority issuePriority, string photo)
        {
            this.IssueName = issueName;
            this.IssueLocation = issueLocation;
            this.IssueType = issueType;
            this.IssuePriority = issuePriority;
            this.Photo = photo;
        }

        public Issue()
        {
        }

        public string GetIssueName()
        {
            return IssueName;
        }

        public void SetIssueName(string issueName)
        {
            IssueName = issueName;
        }

        public string GetIssueLocation()
        {
            return IssueLocation;
        }

        public void SetIssueLocation(string issueLocation)
        {
            IssueLocation = issueLocation;
        }

        public IssueType GetIssueType()
        {
            return IssueType;
        }

        public void SetIssueType(IssueType issueType)
        {
            IssueType = issueType;
        }

        public Priority GetIssuePriority()
        {
            return IssuePriority;
        }

        public void SetIssuePriority(Priority issuePriority)
        {
            IssuePriority = issuePriority;
        }

        public string GetPhoto()
        {
            return Photo;
        }

        public void SetPhoto(string photo)
        {
            Photo = photo;
        }

        public void AddIssue()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Issue @Issue, @Issue_Location, @Issue_Type, @Issue_Priority, @Photo";
            c.Parameters.AddWithValue("@Issue", IssueName);
            c.Parameters.AddWithValue("@Issue_Location", IssueLocation);
            c.Parameters.AddWithValue("@Issue_Type", IssueType);
            c.Parameters.AddWithValue("@Issue_Priority", IssuePriority);
            c.Parameters.AddWithValue("@Photo", Photo);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void UpdateIssue(string oldIssueName, string oldIssueLocation)
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Issue @Issue, @Issue_Location, @Issue_Type, @Issue_Priority, @Photo, @oldIssueName, @oldIssueLocation";
            c.Parameters.AddWithValue("@Issue", IssueName);
            c.Parameters.AddWithValue("@Issue_Location", IssueLocation);
            c.Parameters.AddWithValue("@Issue_Type", IssueType);
            c.Parameters.AddWithValue("@Issue_Priority", IssuePriority);
            c.Parameters.AddWithValue("@Photo", Photo);
            c.Parameters.AddWithValue("@oldIssueName", oldIssueName);
            c.Parameters.AddWithValue("@oldIssueLocation", oldIssueLocation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void DeleteIssue()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Delete_Issue @Issue, @Issue_Location";
            c.Parameters.AddWithValue("@Issue", IssueName);
            c.Parameters.AddWithValue("@Issue_Location", IssueLocation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
