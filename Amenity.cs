
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform 
using Microsoft.Data;
using Microsoft.Data.SqlClient;


namespace nitutz
{
    public class Amenity
    {

        private AmenityType amenityType;

        public Amenity(AmenityType amenityType)
        {
            this.amenityType = amenityType;
        }

        public AmenityType getAmenityType()
        {
            return amenityType;
        }

        public void setAmenityType(AmenityType amenityType)
        {
            this.amenityType = amenityType;
        }

        public void createAmenity()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Create_Amenity @amenityType";
            c.Parameters.AddWithValue("@amenityType", this.amenityType);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // create add amenity to db like employee
        public void addAmenity()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Amenity @amenityType";
            c.Parameters.AddWithValue("@amenityType", this.amenityType);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
