
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;
//c create class Event like employee
namespace nitutz
{
    public class Event
    {
        //c create attributes like employee
        private string EventName;
        private DateTime StartDate;
        private DateTime EndDate;
        private int MaxInvitees;

        //c create constructor like employee
        public Event(string eventName, DateTime startDate, DateTime endDate, int maxInvitees)
        {
            this.EventName = eventName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this. MaxInvitees = maxInvitees;
        }

        //c create getters and setters like employee
        public string getEventName()
        {
            return EventName;
        }

        public void setEventName(string eventName)
        {
            EventName = eventName;
        }

        public DateTime getStartDate()
        {
            return StartDate;
        }

        public void setStartDate(DateTime startDate)
        {
            StartDate = startDate;
        }

        public DateTime getEndDate()
        {
            return EndDate;
        }

        public void setEndDate(DateTime endDate)
        {
            EndDate = endDate;
        }

        public int getMaxInvitees()
        {
            return MaxInvitees;
        }

        public void setMaxInvitees(int maxInvitees)
        {
            MaxInvitees = maxInvitees;
        }

        //c create method to add event to database like employee
        public void addEvent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Event @Event_Name, @Start_Date, @End_Date, @Max_Invitees";
            c.Parameters.AddWithValue("@Event_Name", EventName);
            c.Parameters.AddWithValue("@Start_Date", StartDate);
            c.Parameters.AddWithValue("@End_Date", EndDate);
            c.Parameters.AddWithValue("@Max_Invitees", MaxInvitees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //c create method to update event to database like employee
        public void updateEvent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Event @Event_Name, @Start_Date, @End_Date, @Max_Invitees";
            c.Parameters.AddWithValue("@Event_Name", EventName);
            c.Parameters.AddWithValue("@Start_Date", StartDate);
            c.Parameters.AddWithValue("@End_Date", EndDate);
            c.Parameters.AddWithValue("@Max_Invitees", MaxInvitees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //c create method to
    }
}

