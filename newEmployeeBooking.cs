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
    public partial class NewBookingForEmployee : Form

    {
        private Employee currentUser;
        private List<MeetingLocation> meetingLocations;
        private List<TimeSpan> bookingHours;
        private Booking booking;


        public NewBookingForEmployee(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            initMeetingLocationsList();
            initBookingHoursList();
        }

        private void initMeetingLocationsList()
        {
            this.meetingLocations = Program.MeetingLocations.ToList();
            locationDropDownBox.Items.Clear();
            foreach (var meetingLocation in meetingLocations)
            {
                locationDropDownBox.Items.Add(meetingLocation.getRoomName());
            }
        }



        private void initBookingHoursList()
        {
            bookingHours = new List<TimeSpan>();

            TimeSpan currentTime = TimeSpan.Zero;

            while (currentTime < TimeSpan.FromDays(1))
            {
                bookingHours.Add(currentTime);
                currentTime = currentTime.Add(TimeSpan.FromMinutes(15));
            }

            startTimeComboBox.Items.Clear();
            endTimeComboBox.Items.Clear();

            foreach (TimeSpan time in bookingHours)
            {
                startTimeComboBox.Items.Add(time.ToString());
                endTimeComboBox.Items.Add(time.ToString());
            }

        }

        private void newEmployeeBooking_Load(object sender, EventArgs e)
        {

        }

        private void userEmailLable_Click(object sender, EventArgs e)
        {

        }

        private void BookMeetingRoomButton_Click(object sender, EventArgs e)
        {
            // save booking fields
            DateTime bookingDate = date_Button.Value;
            TimeSpan selectedStartTime = TimeSpan.Parse(startTimeComboBox.Text);
            TimeSpan selectedEndTime = TimeSpan.Parse(endTimeComboBox.Text);

            MeetingLocation meetingLocation = Program.seekMeetingLocation(locationDropDownBox.Text);

            //check availability in calendar
            bool isAvailable = GoogleCalendar.checkMeetingLocationCalendarAvailability(bookingDate, selectedStartTime, selectedEndTime, meetingLocation);

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

            //check constraints

            bool readyToAdd = true;

            if (bookingDate < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readyToAdd = false;
            }

            if (selectedEndTime < selectedStartTime)
            {
                MessageBox.Show("End Time cannot precede Start Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readyToAdd = false;
            }

            if (readyToAdd)
            {


                // create booking with updated fields
                Booking newBooking = new Booking(bookingDate, selectedStartTime, selectedEndTime, currentUser, meetingLocation, true, bookingStatus);

                HomePageEmployee eventForm = new HomePageEmployee(currentUser);
                //this.Hide();
                //eventForm.Show();
            }
        }

        private void bookAndCreateEvent_Button(object sender, EventArgs e)
        {
            // save booking fields
            DateTime bookingDate = date_Button.Value;
            TimeSpan selectedStartTime = TimeSpan.Parse(startTimeComboBox.Text);
            TimeSpan selectedEndTime = TimeSpan.Parse(endTimeComboBox.Text);

            MeetingLocation meetingLocation = Program.seekMeetingLocation(locationDropDownBox.Text);

            //check availability in calendar
            bool isAvailable = GoogleCalendar.checkMeetingLocationCalendarAvailability(bookingDate, selectedStartTime, selectedEndTime, meetingLocation);

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

            //check constraints

            bool readyToAdd = true;

            if (bookingDate < DateTime.Now.Date)
            {
                MessageBox.Show("Please select a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readyToAdd = false;
            }

            if (selectedEndTime < selectedStartTime)
            {
                MessageBox.Show("End Time cannot precede Start Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readyToAdd = false;
            }

            if (readyToAdd)
            {


                // create booking with updated fields
                Booking newBooking = new Booking(bookingDate, selectedStartTime, selectedEndTime, currentUser, meetingLocation, true, bookingStatus);


                FormCreateEvent FormCreateEvent = new FormCreateEvent(currentUser, bookingDate, bookingDate);
                FormCreateEvent.Show();
                this.Hide();
            }

        }

        private void locationDropDownBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void date_Button_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePageEmployee homepageemployee = new HomePageEmployee(currentUser);
            this.Hide();
            homepageemployee.Show();
        }
    }
}
