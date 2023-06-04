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
using System.Data;
using System.Data.SqlClient;

namespace WOPA;
public class Issue
{
    // create properties
    public string IssueName { get; set; }
    public string IssueLocation { get; set; }
    public string IssueType { get; set; }
    public string IssuePriority { get; set; }
    public string Photo { get; set; }

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

    // create method to add issue
    public static void AddIssue(Issue issue)
    {
        // create connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WOPA"].ConnectionString);

        // create query
        string query = "INSERT INTO ISSUES VALUES (@Issue, @Issue_Location, @Issue_Type, @Issue_Priority, @Photo)";

        // create command
        SqlCommand command = new SqlCommand(query, connection);

        // add parameters
        command.Parameters.AddWithValue("@Issue", issue.IssueName);
        command.Parameters.AddWithValue("@Issue_Location", issue.IssueLocation);
        command.Parameters.AddWithValue("@Issue_Type", issue.IssueType);
        command.Parameters.AddWithValue("@Issue_Priority", issue.IssuePriority);
        command.Parameters.AddWithValue("@Photo", issue.Photo);

        // open connection
        connection.Open();

        // execute command
        command.ExecuteNonQuery();

        // close connection
        connection.Close();
    }

    // create method to get all issues
    public static List<Issue> GetAllIssues()
    {
        // create connection
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WOPA"].ConnectionString);

        // create query
        string query = "SELECT * FROM ISSUES";

        // create command
        SqlCommand command = new SqlCommand(query, connection);

        // create list to store issues
        List<Issue> issues = new List<Issue>();

        // open connection
        connection.Open();

        // execute command
        SqlDataReader reader = command.ExecuteReader();

        // read data
        while (reader.Read())
        {
            // create issue object
            Issue issue = new Issue();

            // set properties
            issue.IssueName = reader["Issue"].ToString();
            issue.IssueLocation = reader["Issue_Location"].ToString();
            issue.IssueType = reader["Issue_Type"].ToString();
            issue.IssuePriority = reader["Issue_Priority"].ToString();
            issue.Photo = reader["Photo"].ToString();
        }
    
    }
}
