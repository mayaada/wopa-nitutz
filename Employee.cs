using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace nitutz;

public class Employee
{
    private string email;
    private string name;
    private string number;
    private EmployeeType employeeType;
    private string password;
    private bool isActive;
    public System.Collections.Generic.List<Tenant> workStationRequests; // 

    public Employee(string email, string number, string name, string password, EmployeeType employeeType,
        Boolean isActive, bool isNew)
    {
        this.email = email;
        this.name = name;
        this.number = number;
        this.employeeType = employeeType;
        this.password = password;
        this.isActive = isActive;
        if (isNew)
        {
            createEmployee();
            Program.Employees.Add(this);
        }
    }
    public string getEmail()
    {
        return this.email;
    }

    public string getName()
    {
        return this.name;
    }

    public EmployeeType getEmployeeType()
    {
        return this.employeeType;
    }

    public string getPassword()
    {
        return this.password;
    }

    public void changeType(EmployeeType type)
    {
        this.employeeType = type;
    }

    public void changeEmail(string newEmail)
    {
        this.email = newEmail;
    }

    public void changeNumber(string newNumber)
    {
        this.number = newNumber;
    }

    public void resetPassword(string newPassword)
    {
        this.password = newPassword;
    }

    public void inactivate()
    {
        this.isActive = false;
    }

    public void createEmployee()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE SP_add_employee @email, @name, @number, @employeeType, @password";
        c.Parameters.AddWithValue("@email", this.email);
        c.Parameters.AddWithValue("@name", this.name);
        c.Parameters.AddWithValue("@employeeType", this.employeeType);
        c.Parameters.AddWithValue("@password", this.password);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    public void updateEmployee()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE SP_Update_employees @email, @name, @number, @employeeType, @password";
        c.Parameters.AddWithValue("@email", this.email);
        c.Parameters.AddWithValue("@name", this.name);
        c.Parameters.AddWithValue("@employeeType", this.employeeType);
        c.Parameters.AddWithValue("@password", this.password);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

}
