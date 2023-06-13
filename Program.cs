using nitutz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace nitutz
{
    public class Program
    {

        public static System.Collections.Generic.List<Employee> Employees;
        public static System.Collections.Generic.List<Lead> Leads;
        public static System.Collections.Generic.List<Tenant> Tenants;
        public static System.Collections.Generic.List<Lease> Leases;
        public static System.Collections.Generic.List<LeasedItemType> LeasedItemTypes;
        public static System.Collections.Generic.List<LeasedItem> LeasedItems;
        public static System.Collections.Generic.List<Amenity> Amenities;
        public static System.Collections.Generic.List<Issue> Issues;
        public static System.Collections.Generic.List<Ticket> Tickets;
        public static System.Collections.Generic.List<Event> Events;
        public static System.Collections.Generic.List<MeetingLocation> MeetingLocations;
        public static System.Collections.Generic.List<Booking> Bookings;
        public static System.Collections.Generic.List<Include> Includes;
        public static System.Collections.Generic.List<Invite> Invites;



        [STAThread]

        public static void initLists() //����� ������� ���� ���� �������
        {
            init_employees();//����� ������ �� �������
            init_leads();//����� ������ �� ������ �����������
            init_tenants();// ����� ������ �� �������
            init_leases();//����� ������ �� ������
            init_LeasedItemTypes();
            init_LeasedItems();//����� ������ �� ������ ��������
            init_leasesLeasedItems();
            init_Amenities();
            init_Issues();
            init_Tickets();
            init_TicketsPerIssue();
            init_Events();
            init_MeetingLocations();
            init_Bookings();
            init_Includes();
            init_Invites();

        }

        public static void init_employees() //����� ���� ������ ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Emplpoyees";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Employees = new List<Employee>();

            while (rdr.Read())
            {
                EmployeeType employeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), rdr.GetValue(4).ToString().Replace(" ", string.Empty));
                Employee employee = new Employee(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), employeeType, true, false);
                Employees.Add(employee);
            }
        }
        public static void init_leads() //����� ���� ������ ���������� ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_leads";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Leads = new List<Lead>();
            while (rdr.Read())
            {
                LeadStatus leadStatus = (LeadStatus)Enum.Parse(typeof(LeadStatus), rdr.GetValue(6).ToString().Replace(" ", string.Empty));

                LeadSource leadSource = (LeadSource)Enum.Parse(typeof(LeadSource), rdr.GetValue(7).ToString().Replace(" ", string.Empty));

                Lead lead = new Lead(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(),
                    rdr.GetValue(3).ToString(), DateTime.Parse((rdr.GetValue(4).ToString())), (int)rdr.GetValue(5),
                    leadStatus, leadSource, seekEmployee(rdr.GetValue(8).ToString()), false);
                Leads.Add(lead);
            }
        }
        public static void init_tenants() //����� ������ �� ������� ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Tenants";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Tenants = new List<Tenant>();
            while (rdr.Read())
            {
                Tenant tenant = new Tenant(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(),
                    rdr.GetValue(2).ToString(),
                    DateTime.Parse((rdr.GetValue(3).ToString())), (int)rdr.GetValue(4), true, false);
                Tenants.Add(tenant);
            }
        }
        public static void init_leases() //����� ������ �� ������ ���� ���� �������
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Leases";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Leases = new List<Lease>();
            while (rdr.Read())
            {
                Lease lease = new Lease((int)rdr.GetValue(0), rdr.GetValue(1).ToString(),
                    DateTime.Parse((rdr.GetValue(2).ToString())),
                    DateTime.Parse((rdr.GetValue(3).ToString())), (int)rdr.GetValue(4), rdr.GetValue(5).ToString(),
                    seekEmployee(rdr.GetValue(6).ToString()),
                    seekTenant(rdr.GetValue(7).ToString()), false);
                Leases.Add(lease);
            }
        }

        public static void init_LeasedItemTypes()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_LeasedItemTypes";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            LeasedItemTypes = new List<LeasedItemType>();
            while (rdr.Read())
            {
                LeasedItemType LeasedItemType = new LeasedItemType(
                    rdr.GetValue(0).ToString(), Convert.ToDouble(rdr.GetValue(1)),
                    (int)rdr.GetValue(2), Convert.ToDouble(rdr.GetValue(3))
                );
                LeasedItemTypes.Add(LeasedItemType);
            }
        }

        public static void init_leasesLeasedItems()
        {
            Leases.ForEach(lease => { lease.initItemsLeased(); });
        }

        public static void init_LeasedItems()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_LeasedItems";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            LeasedItems = new List<LeasedItem>();
            while (rdr.Read())
            {
                LeasedItem LeasedItem = new LeasedItem(
                    (int)rdr.GetValue(0), (int)rdr.GetValue(1),
                    seekLeasedItemType(rdr.GetValue(2).ToString()), (bool)rdr.GetValue(3),
                    (bool)rdr.GetValue(4), seekLease((int)rdr.GetValue(5)), false
                );
                LeasedItems.Add(LeasedItem);
            }
        }

        public static void init_Amenities()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Amenities";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Amenities = new List<Amenity>();
            while (rdr.Read())
            {
                Amenity Amenity = new Amenity(
                rdr.GetValue(0).ToString()
                );
                Amenities.Add(Amenity);
            }
        }

        public static void init_Issues()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Issues";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Issues = new List<Issue>();
            while (rdr.Read())
            {
                IssueType IssueType = (IssueType)Enum.Parse(typeof(IssueType), rdr.GetValue(2).ToString().Replace(" ", string.Empty));
                Priority issuePriority = (Priority)Enum.Parse(typeof(Priority), rdr.GetValue(3).ToString().Replace(" ", string.Empty));
                Issue Issue = new Issue(
                rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), IssueType, issuePriority, rdr.GetValue(4).ToString(), false
                );
                Issues.Add(Issue);
            }
        }

        public static void init_Tickets()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Tickets";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Tickets = new List<Ticket>();
            while (rdr.Read())
            {
                TicketStatus TicketStatus = (TicketStatus)Enum.Parse(typeof(TicketStatus), rdr.GetValue(3).ToString().Replace(" ", string.Empty));
                Ticket Ticket = new Ticket(
                (int)rdr.GetValue(0), TimeSpan.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()),
                TicketStatus, seekEmployee(rdr.GetValue(4).ToString()), seekTenant(rdr.GetValue(5).ToString()), seekIssue(rdr.GetValue(6).ToString(), rdr.GetValue(7).ToString()), false
                );
                Tickets.Add(Ticket);
            }
        }


        private static void init_TicketsPerIssue()
        {
            
        }

        public static void init_Events()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Events";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Events = new List<Event>();
            while (rdr.Read())
            {
                Event Event = new Event(
                rdr.GetValue(0).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()),
                (int)rdr.GetValue(3), false
                );
                Events.Add(Event);
            }
        }

        public static void init_MeetingLocations()

        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_MeetingLocations";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            MeetingLocations = new List<MeetingLocation>();
            while (rdr.Read())
            {
                MeetingLocationType MeetingLocationType = (MeetingLocationType)Enum.Parse(typeof(MeetingLocationType), rdr.GetValue(1).ToString().Replace(" ", string.Empty));
                MeetingLocation MeetingLocation = new MeetingLocation(
                rdr.GetValue(0).ToString(), MeetingLocationType, (int)rdr.GetValue(2), (int)rdr.GetValue(3)
                );
                MeetingLocations.Add(MeetingLocation);
            }
        }

        public static void init_Bookings()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Bookings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Bookings = new List<Booking>();
            while (rdr.Read())
            {
                BookingStatus BookingStatus = (BookingStatus)Enum.Parse(typeof(BookingStatus), rdr.GetValue(4).ToString().Replace(" ", string.Empty));
                Booking Booking = new Booking(
                (int)rdr.GetValue(0), DateTime.Parse(rdr.GetValue(1).ToString()), TimeSpan.Parse(rdr.GetValue(2).ToString()), TimeSpan.Parse(rdr.GetValue(3).ToString()),
                BookingStatus, seekEmployee(rdr.GetValue(5).ToString()), seekTenant(rdr.GetValue(6).ToString()), seekEvent(rdr.GetValue(7).ToString()), seekMeetingLocation(rdr.GetValue(8).ToString()), false
                );
                Bookings.Add(Booking);
            }
        }

        public static void init_Includes()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Includes";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Includes = new List<Include>();
            while (rdr.Read())
            {
                MeetingLocation meetingLocationType = seekMeetingLocation(rdr.GetValue(1).ToString());

                Include Include = new Include(
                    rdr.GetValue(0).ToString(), meetingLocationType
                );

                Includes.Add(Include);
            }
        }

        public static void init_Invites()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Invites";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Invites = new List<Invite>();
            while (rdr.Read())
            {
                Tenant tenant = seekTenant(rdr.GetValue(0).ToString());
                Event eventName = seekEvent(rdr.GetValue(1).ToString());

                Invite Invite = new Invite(
                    tenant, eventName
                );

                Invites.Add(Invite);
            }
        }



        //���� ������ ���� ������ ��� ����� ����
        public static Tenant seekTenant(string companyName)
        {
            foreach (Tenant tenant in Tenants)
            {
                if (tenant.getCompanyName() == companyName)
                    return tenant;
            }

            return null;
        }
        //���� ������ ���� ������ ��� ����� ����
        public static Employee seekEmployee(string email)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.getEmail() == email)
                    return employee;
            }

            return null;
        }

        public static LeasedItemType seekLeasedItemType(string type)
        {
            foreach (LeasedItemType LeasedItemType in LeasedItemTypes)
            {
                if (LeasedItemType.getType() == type)
                    return LeasedItemType;
            }

            return null;
        }


        public static Lease seekLease(int number)
        {
            foreach (Lease lease in Leases)
            {
                if (lease.getLeaseID() == number)
                    return lease;
            }

            return null;
        }

        public static Issue seekIssue(string issueID, string issueLocation)
        {
            foreach (Issue issue in Issues)
            {
                if (issue.getIssueName() == issueID && issue.getIssueLocation() == issueLocation)
                    return issue;
            }

            return null;
        }
        public static IssueType seekIssueType(string issueTypeName)
        {
            foreach (IssueType issueType in Enum.GetValues(typeof(IssueType)))
            {
                if (issueType.ToString() == issueTypeName)
                    return issueType;
            }

            return default(IssueType);
        }

        public static Priority seekPriority(string priorityName)
        {
            foreach (Priority priority in Enum.GetValues(typeof(Priority)))
            {
                if (priority.ToString() == priorityName)
                    return priority;
            }

            return default(Priority);
        }

        public static TicketStatus seekTicketStatus(string ticketStatusName)
        {
            foreach (TicketStatus ticketStatus in Enum.GetValues(typeof(TicketStatus)))
            {
                if (ticketStatus.ToString() == ticketStatusName)
                    return ticketStatus;
            }

            return default(TicketStatus);
        }




        public static Event seekEvent(string eventName)
        {
            foreach (Event Event in Events)
            {
                if (Event.getEventName() == eventName)
                    return Event;
            }

            return null;
        }

        public static MeetingLocation seekMeetingLocation(string roomName)
        {
            foreach (MeetingLocation MeetingLocation in MeetingLocations)
            {
                if (MeetingLocation.getRoomName() == roomName)
                    return MeetingLocation;
            }

            return null;
        }

        public static Amenity seekAmenity(string amenityType)
        {
            foreach (Amenity Amenity in Amenities)
            {
                if (Amenity.getAmenityType() == amenityType)
                    return Amenity;
            }

            return null;
        }

        public static Lead seekLead(string CompantName)
        {
            foreach (Lead Lead in Leads)
            {
                if (Lead.getCompanyName() == CompantName)
                    return Lead;
            }

            return null;
        }

        public static LeasedItem seekLeasedItem(int number)
        {
            foreach (LeasedItem LeasedItem in LeasedItems)
            {
                if (LeasedItem.getNumber() == number)
                    return LeasedItem;
            }

            return null;
        }

        public static List<LeasedItem> GetLeasedItemDataList()
        {
            return LeasedItems;


        }

        public static List<Issue> GetIssueDataList()
        {
            return Issues;
        }



        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists(); //����� �� �������
             Application.Run(new MainForm());


        }





    }
}