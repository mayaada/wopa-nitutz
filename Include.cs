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
        private String amenity;
        private MeetingLocation meetingLocation;
        

        public Include(String amenity, MeetingLocation meetingLocation)
        {
            this.amenity = amenity;
            this.meetingLocation = meetingLocation;
        }



        public String getAmenity()
        {
            return this.amenity;
        }

        public MeetingLocation getMeetingLocation()
        {
            return this.meetingLocation;
        }

        public void setAmenity(String amenity)
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
            c.CommandText = "EXECUTE dbo.Create_Include @amenity, @meetingLocation";
            c.Parameters.AddWithValue("@amenity", this.amenity);
            c.Parameters.AddWithValue("@meetingLocation", this.meetingLocation.getRoomName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // create update include to db like employee

        public void updateInclude()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Include @amenity, @meetingLocation";
            c.Parameters.AddWithValue("@amenity", this.amenity);
            c.Parameters.AddWithValue("@meetingLocation", this.meetingLocation.getRoomName());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

       




    }
}