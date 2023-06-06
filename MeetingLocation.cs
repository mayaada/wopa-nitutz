
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;


namespace nitutz
{
    public class MeetingLocation
    {
        private string roomName;
        private MeetingLocationType meetingLocationType;
        private int capacity;
        private int floor;
        private List<Booking> bookings;

        public MeetingLocation(string roomName, MeetingLocationType meetingLocationType, int capacity, int floor)
        {
            this.roomName = roomName;
            this.meetingLocationType = meetingLocationType;
            this.capacity = capacity;
            this.floor = floor;
            this.bookings = new List<Booking>();
        }

        public string getRoomName()
        {
            return this.roomName;
        }

        public MeetingLocationType getMeetingLocationType()
        {
            return this.meetingLocationType;
        }

        public int getCapacity()
        {
            return this.capacity;
        }

        public int getFloor()
        {
            return this.floor;
        }
        
        public List<Booking> getBookings()
        {
            return this.bookings;
        }

        public void setRoomName(string roomName)
        {
            this.roomName = roomName;
        }

        public void setMeetingLocationType(MeetingLocationType meetingLocationType)
        {
            this.meetingLocationType = meetingLocationType;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public void setFloor(int floor)
        {
            this.floor = floor;
        }

        public void createMeetingLocation()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Meeting_Location @Room_Name, @Meeting_Location_Type, @Capacity, @Floor";
            c.Parameters.AddWithValue("@Room_Name", this.roomName);
            c.Parameters.AddWithValue("@Meeting_Location_Type", this.meetingLocationType);
            c.Parameters.AddWithValue("@Capacity", this.capacity);
            c.Parameters.AddWithValue("@Floor", this.floor);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void addMeetingLocation()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Meeting_Location @Room_Name, @Meeting_Location_Type, @Capacity, @Floor";
            c.Parameters.AddWithValue("@Room_Name", this.roomName);
            c.Parameters.AddWithValue("@Meeting_Location_Type", this.meetingLocationType);
            c.Parameters.AddWithValue("@Capacity", this.capacity);
            c.Parameters.AddWithValue("@Floor", this.floor);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}