using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nitutz
{
    public partial class newEmployeeBooking : Form

    {
        private Employee currentUser;
        private List<MeetingLocation> meetingLocations;


        public newEmployeeBooking(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.meetingLocations = Program.MeetingLocations.ToList();
            locationDropDownBox.Items.Clear();
            foreach (var meetingLocation in meetingLocations)
            {
                locationDropDownBox.Items.Add(meetingLocation.getRoomName());
            }
        }

        private Booking newBooking;


        private void newEmployeeBooking_Load(object sender, EventArgs e)
        {

        }

        private void userEmailLable_Click(object sender, EventArgs e)
        {

        }

        private void BookMeetingRoomButton_Click(object sender, EventArgs e)
        {
            //DateTime selectedDate = datePicker.Value;
            DateTime selectedStartTime = startTimePicker.Value;
            DateTime selectedEndTime = endTimePicker1.Value;
            MeetingLocation meetingLocation = Program.seekMeetingLocation(locationDropDownBox.Text);


            // newBooking = new Booking(selectedDate, selectedStartTime, selectedEndTime, employeeEmail, meetingLocation);


        }

        private void bookAndCreateEvent_Button(object sender, EventArgs e)
        {
            
            // save booking fields
            DateTime bookingDate = date_Button.Value;
            DateTime startTime = startTimePicker.Value;
            DateTime endTime = endTimePicker1.Value;
            MeetingLocation meetingLocation = Program.seekMeetingLocation(locationDropDownBox.Text);

            //check availability in calendar
            bool isAvailable = GoogleCalendar.checkMeetingLocationCalendarAvailability(bookingDate, startTime, endTime, meetingLocation);

            //save availability from calendar
            BookingStatus bookingStatus;
            if (isAvailable)
            {
                bookingStatus = BookingStatus.Approved;
            }
            else
            {
                bookingStatus = BookingStatus.Declined;

            }

            // create booking with updated fields
            Booking newBooking = new Booking(bookingDate, startTime, endTime, currentUser, meetingLocation, BookingStatus.Declined); Booking newBooking = new Booking(bookingDate, startTime, endTime, currentUser, meetingLocation, BookingStatus.Approved);

            // new event form window
            FormCreateEvent eventForm = new FormCreateEvent(currentUser);
            this.Hide();
            eventForm.Show();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void locationDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
