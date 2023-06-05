using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using nitutz;

namespace nitutz
{
    public class Include
    {
        private Amenity amenity;
        private MeetingLocation meetingLocation;

        public Include(Amenity amenity, MeetingLocation meetingLocation)
        {
            this.amenity = amenity;
            this.meetingLocation = meetingLocation;
        }

        public Amenity getAmenity()
        {
            return this.amenity;
        }

        public MeetingLocation getMeetingLocation()
        {
            return this.meetingLocation;
        }

        public void setAmenity(Amenity amenity)
        {
            this.amenity = amenity;
        }

        public void setMeetingLocation(MeetingLocation meetingLocation)
        {
            this.meetingLocation = meetingLocation;
        }

        public void createInclude()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Include @amenityType, @roomName";
            c.Parameters.AddWithValue("@amenityType", this.amenity.getAmenityType());
            c.Parameters.AddWithValue("@roomName", this.meetingLocation.getRoomName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void addInclude()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Include @amenityType, @roomName";
            c.Parameters.AddWithValue("@amenityType", this.amenity.getAmenityType());
            c.Parameters.AddWithValue("@roomName", this.meetingLocation.getRoomName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }




    }
}