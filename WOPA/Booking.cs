

// create class Booking like employee
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms; // winform
using Microsoft.Data;
using Microsoft.Data.SqlClient;

// create class Booking

namespace WOPA
{
    public class Booking
    {
        // create properties
        public int BookingID;
        public string BookingDate;
        public string StartTime;
        public string EndTime;
        public string BookingStatus;
        public string CreatedByEmployee;
        public string CreatedByTenant;
        public string EventRelatedTo;
        public string BookingLocation;

        // create constructor
        public Booking(int bookingID, string bookingDate, string startTime, string endTime, string bookingStatus, string createdByEmployee, string createdByTenant, string eventRelatedTo, string bookingLocation)
        {
            BookingID = bookingID;
            BookingDate = bookingDate;
            StartTime = startTime;
            EndTime = endTime;
            BookingStatus = bookingStatus;
            CreatedByEmployee = createdByEmployee;
            CreatedByTenant = createdByTenant;
            EventRelatedTo = eventRelatedTo;
            BookingLocation = bookingLocation;
        }

        // create default constructor
        public Booking()
        {
        }

        // CRATE GET AND SET FOR ALL PROPERTIES
        public int getBookingID()
        {
            return BookingID;
        }

        public string getBookingDate()
        {
            return BookingDate;
        }

        public string getStartTime()
        {
            return StartTime;
        }

        public string getEndTime()
        {
            return EndTime;
        }

        public string getBookingStatus()
        {
            return BookingStatus;
        }

        public string getCreatedByEmployee()
        {
            return CreatedByEmployee;
        }

        public string getCreatedByTenant()
        {
            return CreatedByTenant;
        }

        public string getEventRelatedTo()
        {
            return EventRelatedTo;
        }

        public string getBookingLocation()
        {
            return BookingLocation;
        }

        public void setBookingID(int bookingID)
        {
            BookingID = bookingID;
        }

        public void setBookingDate(string bookingDate)
        {
            BookingDate = bookingDate;
        }

        public void setStartTime(string startTime)
        {
            StartTime = startTime;
        }

        public void setEndTime(string endTime)
        {
            EndTime = endTime;
        }

        public void setBookingStatus(string bookingStatus)
        {
            BookingStatus = bookingStatus;
        }

        public void setCreatedByEmployee(string createdByEmployee)
        {
            CreatedByEmployee = createdByEmployee;
        }

        public void setCreatedByTenant(string createdByTenant)
        {
            CreatedByTenant = createdByTenant;
        }

        // create update method like employee
        public void update()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Update_Booking @Booking_ID, @Booking_Date, @Start_Time, @End_Time, @Booking_Status, @Created_By_Employee, @Created_By_Tenant, @Event_Related_To, @Booking_Location";
            c.Parameters.AddWithValue("@Booking_ID", BookingID);
            c.Parameters.AddWithValue("@Booking_Date", BookingDate);
            c.Parameters.AddWithValue("@Start_Time", StartTime);
            c.Parameters.AddWithValue("@End_Time", EndTime);
            c.Parameters.AddWithValue("@Booking_Status", BookingStatus);
            c.Parameters.AddWithValue("@Created_By_Employee", CreatedByEmployee);
            c.Parameters.AddWithValue("@Created_By_Tenant", CreatedByTenant);
            c.Parameters.AddWithValue("@Event_Related_To", EventRelatedTo);
            c.Parameters.AddWithValue("@Booking_Location", BookingLocation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // create add method like employee
        public void add()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Add_Booking @Booking_Date, @Start_Time, @End_Time, @Booking_Status, @Created_By_Employee, @Created_By_Tenant, @Event_Related_To, @Booking_Location";
            c.Parameters.AddWithValue("@Booking_Date", BookingDate);
            c.Parameters.AddWithValue("@Start_Time", StartTime);
            c.Parameters.AddWithValue("@End_Time", EndTime);
            c.Parameters.AddWithValue("@Booking_Status", BookingStatus);
            c.Parameters.AddWithValue("@Created_By_Employee", CreatedByEmployee);
            c.Parameters.AddWithValue("@Created_By_Tenant", CreatedByTenant);
            c.Parameters.AddWithValue("@Event_Related_To", EventRelatedTo);
            c.Parameters.AddWithValue("@Booking_Location", BookingLocation);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
