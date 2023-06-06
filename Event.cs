
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
        private string eventName;
        private DateTime startDate;
        private DateTime endDate;
        private int maxInvitees;
        private List<Booking> bookings;

        //c create constructor like employee
        public Event(string eventName, DateTime startDate, DateTime endDate, int maxInvitees)
        {
            this.eventName = eventName;
            this.startDate = startDate;
            this.endDate = endDate;
            this. maxInvitees = maxInvitees;
            this.bookings = new List<Booking>(); // each event can have a few bookings
        }

        //c create getters and setters like employee
        public string getEventName()
        {
            return eventName;
        }

        public void setEventName(string eventName)
        {
            this.eventName = eventName;
        }

        public DateTime getStartDate()
        {
            return this.startDate;
        }

        public void setStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public DateTime getEndDate()
        {
            return this.endDate;
        }

        public void setEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public int getMaxInvitees()
        {
            return this.maxInvitees;
        }

        public void setMaxInvitees(int maxInvitees)
        {
            this.maxInvitees = maxInvitees;
        }

        public List<Booking> getBookings()
        {
            return this.bookings;
        }

        //c create method to add event to database like employee
        public void addEvent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Event @Event_Name, @Start_Date, @End_Date, @Max_Invitees";
            c.Parameters.AddWithValue("@Event_Name", eventName);
            c.Parameters.AddWithValue("@Start_Date", startDate);
            c.Parameters.AddWithValue("@End_Date", endDate);
            c.Parameters.AddWithValue("@Max_Invitees", maxInvitees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //c create method to update event to database like employee
        public void updateEvent()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Event @Event_Name, @Start_Date, @End_Date, @Max_Invitees";
            c.Parameters.AddWithValue("@Event_Name", eventName);
            c.Parameters.AddWithValue("@Start_Date", startDate);
            c.Parameters.AddWithValue("@End_Date", endDate);
            c.Parameters.AddWithValue("@Max_Invitees", maxInvitees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        //c create method to
    }
}

