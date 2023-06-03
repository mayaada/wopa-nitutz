namespace WOPA;

public class Employee
{
    private string email;
    private string name;
    private string number;
    private EmployeeType employeeType;
    private string password;
    private Boolean isActive;

    public Employee(string email, string name, string number, EmployeeType employeeType, string password,
        Boolean isActive, Boolean isNew)
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

    public void createEmployee()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE SP_add_employee @employeeId, @firstName, @lastName, @role, @password";
        c.Parameters.AddWithValue("@employeeId", this.employeeId);
        c.Parameters.AddWithValue("@firstName", this.firstName);
        c.Parameters.AddWithValue("@lastName", this.lastName);
        c.Parameters.AddWithValue("@role", this.role.ToString());
        c.Parameters.AddWithValue("@password", this.password);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    public int getId()
    {
        return this.employeeId;
    }

    public string getFirstName()
    {
        return this.firstName;
    }

    public string getLastName()
    {
        return this.lastName;
    }

    public Role getRole()
    {
        return this.role;
    }

    public string getPassword()
    {
        return this.password;
    }

    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public void setRole(Role role)
    {
        this.role = role;
    }

    public void setPassword(string password)
    {
        this.password = password;
    }


    public void updateEmployee()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE SP_update_employee @employeeId, @firstName, @lastName, @role, @password";
        c.Parameters.AddWithValue("@employeeId", this.employeeId);
        c.Parameters.AddWithValue("@firstName", this.firstName);
        c.Parameters.AddWithValue("@lastName", this.lastName);
        c.Parameters.AddWithValue("@role", this.role.ToString());
        c.Parameters.AddWithValue("@password", this.password);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    public void deleteEmployee()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE SP_delete_employee @employeeId";
        c.Parameters.AddWithValue("@employeeId", this.employeeId);
        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    public static void loadEmployees()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE SP_get_employees";
        SQL_CON SC = new SQL_CON();
        DataTable dt = SC.execute_query(c);
        foreach (DataRow row in dt.Rows)
        {
            int employeeId = Convert.ToInt32(row["employeeId"]);
            string firstName = row["firstName"].ToString();
            string lastName = row["lastName"].ToString();
            Role role = (Role)Enum.Parse(typeof(Role), row["role"].ToString());
            string password = row["password"].ToString();
            Employee employee = new Employee(employeeId, firstName, lastName, role, password, false);
            Program.Employees.Add(employee);
        }
    }

    public static Employee getEmployee(int employeeId)
    {
        foreach (Employee employee in Program.Employees)
        {
            if (employee.getId() == employeeId)
            {
                return employee;
            }
        }

        return null;
    }

    public static Employee getEmployee(string firstName, string lastName)
    {
        foreach (Employee employee in Program.Employees)
        {
            if (employee.getFirstName() == firstName && employee.getLastName() == lastName)
            {
                return employee;
            }
        }

        return null;
    }
}