using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nitutz
{
    internal class GoogleCalendar
    {

        public GoogleCalendar() { }

        public static Boolean checkMeetingLocationCalendarAvailability(DateTime date, TimeSpan startTime, TimeSpan endTime, MeetingLocation meetingLocation)
        {
            //TODO: Connect to google calendar API 
            // check if booking slot for the current Meeting location is free
            // change booking status 
            bool isAvailable = true; // will change once connected
            return isAvailable;
        }
    }
}
