/*
CREATE TABLE ISSUES (
Issue	           VARCHAR (60)		NOT NULL,
Issue_Location     VARCHAR (60)		NOT NULL,
Issue_Type         Issue_Type       NOT NULL , 
Issue_Priority     Priority         NOT NULL ,
Photo              VARCHAR(256)     NULL,
CONSTRAINT PK_ISSUE PRIMARY KEY (Issue,Issue_Location)
)
*/

// crate class Issue
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;

namespace nitutz;
public class Issue
{
    // create properties
    public string IssueName;
    public string IssueLocation;
    public IssueType IssueType;
    public string IssuePriority;
    public string Photo;

    // create constructor
    public Issue(string issueName, string issueLocation, string issueType, string issuePriority, string photo)
    {
        IssueName = issueName;
        IssueLocation = issueLocation;
        IssueType = issueType;
        IssuePriority = issuePriority;
        Photo = photo;
    }

    // create default constructor
    public Issue()
    {
    }

    // CRATE GET AND SET FOR ALL PROPERTIES
    public string getIssueName()
    {
        return IssueName;
    }

    public void setIssueName(string issueName)
    {
        IssueName = issueName;
    }

    public string getIssueLocation()
    {
        return IssueLocation;
    }

    public void setIssueLocation(string issueLocation)
    {
        IssueLocation = issueLocation;
    }

    public string getIssueType()
    {
        return IssueType;
    }

    public void setIssueType(string issueType)
    {
        IssueType = issueType;
    }

    public string getIssuePriority()
    {
        return IssuePriority;
    }

    public void setIssuePriority(string issuePriority)
    {
        IssuePriority = issuePriority;
    }

    public string getPhoto()
    {
        return Photo;
    }

    public void setPhoto(string photo)
    {
        Photo = photo;
    }

    // create method to add issue to database LIKE IN EMPLOYEE
    public void addIssue()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.Add_Issue @Issue,@Issue_Location,@Issue_Type,@Issue_Priority,@Photo";
        c.Parameters.AddWithValue("@Issue", IssueName);
        c.Parameters.AddWithValue("@Issue_Location", IssueLocation);
        c.Parameters.AddWithValue("@Issue_Type", IssueType);
        c.Parameters.AddWithValue("@Issue_Priority", IssuePriority);
        c.Parameters.AddWithValue("@Photo", Photo);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    // create method to update issue in database LIKE IN EMPLOYEE

    public void updateIssue(string oldIssueName, string oldIssueLocation)
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.Update_Issue @Issue,@Issue_Location,@Issue_Type,@Issue_Priority,@Photo,@oldIssueName,@oldIssueLocation";
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




}
