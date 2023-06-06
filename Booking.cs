using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nitutz
{
     public class Booking
    {
        // create properties
        public int BookingID;
        public DateTime BookingDate;
        public DateTime StartTime;
        public DateTime EndTime;
        public BookingStatus BookingStatus;
        public Employee CreatedByEmployee;
        public Tenant CreatedByTenant;
        public Event EventRelatedTo;
        public MeetingLocation BookingLocation;

        // create constructor
        public Booking(int bookingID, DateTime bookingDate, DateTime startTime, DateTime endTime, BookingStatus bookingStatus,
         Employee createdByEmployee, Tenant createdByTenant, Event eventRelatedTo, MeetingLocation bookingLocation)
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

        public DateTime getBookingDate()
        {
            return BookingDate;
        }

        public DateTime getStartTime()
        {
            return StartTime;
        }

        public DateTime getEndTime()
        {
            return EndTime;
        }

        public BookingStatus getBookingStatus()
        {
            return BookingStatus;
        }

        public Employee getCreatedByEmployee()
        {
            return CreatedByEmployee;
        }

        public Tenant getCreatedByTenant()
        {
            return CreatedByTenant;
        }

        public Event getEventRelatedTo()
        {
            return EventRelatedTo;
        }

        public MeetingLocation getBookingLocation()
        {
            return BookingLocation;
        }

        public void setBookingID(int bookingID)
        {
            BookingID = bookingID;
        }

        public void setBookingDate(DateTime bookingDate)
        {
            BookingDate = bookingDate;
        }

        public void setStartTime(DateTime startTime)
        {
            StartTime = startTime;
        }

        public void setEndTime(DateTime endTime)
        {
            EndTime = endTime;
        }

        public void setBookingStatus(BookingStatus bookingStatus)
        {
            BookingStatus = bookingStatus;
        }

        public void setCreatedByEmployee(Employee createdByEmployee)
        {
            CreatedByEmployee = createdByEmployee;
        }

        public void setCreatedByTenant(Tenant createdByTenant)
        {
            CreatedByTenant = createdByTenant;
        }

        public void setEventRelatedTo(Event eventRelatedTo)
        {
            EventRelatedTo = eventRelatedTo;
        }

        public void setBookingLocation(MeetingLocation bookingLocation)
        {
            BookingLocation = bookingLocation;
        }


        // create update method like employee
        public void updateBooking()
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
        public void addBooking()
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

        public void deleteBooking()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Delete_Booking @Booking_ID";
            c.Parameters.AddWithValue("@Booking_ID", BookingID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
