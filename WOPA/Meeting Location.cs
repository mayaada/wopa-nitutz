
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;


namespace WOPA
{
    public class MeetingLocation
    {
        public string RoomName ;
        public MeetingLocationType MeetingLocationType ;
        public int Capacity ;
        public int Floor;

        public MeetingLocation(string roomName, MeetingLocationType meetingLocationType, int capacity, int floor)
        {
            RoomName = roomName;
            MeetingLocationType = meetingLocationType;
            Capacity = capacity;
            Floor = floor;
        }

        public string getRoomName()
        {
            return this.RoomName;
        }

        public MeetingLocationType getMeetingLocationType()
        {
            return this.MeetingLocationType;
        }

        public int getCapacity()
        {
            return this.Capacity;
        }

        public int getFloor()
        {
            return this.Floor;
        }

        public void setRoomName(string roomName)
        {
            this.RoomName = roomName;
        }

        public void setMeetingLocationType(MeetingLocationType meetingLocationType)
        {
            this.MeetingLocationType = meetingLocationType;
        }

        public void setCapacity(int capacity)
        {
            this.Capacity = capacity;
        }

        public void setFloor(int floor)
        {
            this.Floor = floor;
        }

        public void createMeetingLocation()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Meeting_Location @Room_Name, @Meeting_Location_Type, @Capacity, @Floor";
            c.Parameters.AddWithValue("@Room_Name", this.RoomName);
            c.Parameters.AddWithValue("@Meeting_Location_Type", this.MeetingLocationType);
            c.Parameters.AddWithValue("@Capacity", this.Capacity);
            c.Parameters.AddWithValue("@Floor", this.Floor);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void addMeetingLocation()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Meeting_Location @Room_Name, @Meeting_Location_Type, @Capacity, @Floor";
            c.Parameters.AddWithValue("@Room_Name", this.RoomName);
            c.Parameters.AddWithValue("@Meeting_Location_Type", this.MeetingLocationType);
            c.Parameters.AddWithValue("@Capacity", this.Capacity);
            c.Parameters.AddWithValue("@Floor", this.Floor);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}