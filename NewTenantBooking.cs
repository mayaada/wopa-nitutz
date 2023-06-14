using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nitutz
{
    public partial class NewTenantBooking : Form
    {
        private Tenant currentUser;
        private List<MeetingLocation> meetingLocations;
        private List<TimeSpan> bookingHours;

        public NewTenantBooking(Tenant currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            initMeetingLocationsList();
            initBookingHoursList();
        }

        private void initMeetingLocationsList()
        {
            this.meetingLocations = Program.MeetingLocations.ToList();
            locationComboBox.Items.Clear();
            foreach (var meetingLocation in meetingLocations)
            {
                locationComboBox.Items.Add(meetingLocation.getRoomName());
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

        private Booking newBooking;

        private void NewTenantBooking_Load() { }



        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save booking fields
            DateTime bookingDate = DatePicker.Value;
            TimeSpan selectedStartTime = TimeSpan.Parse(startTimeComboBox.Text);
            TimeSpan selectedEndTime = TimeSpan.Parse(endTimeComboBox.Text);

            MeetingLocation meetingLocation = Program.seekMeetingLocation(locationComboBox.Text);

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

            if(readyToAdd)
            {   
                // create booking with updated fields
                Booking newBooking = new Booking(bookingDate, selectedStartTime, selectedEndTime, currentUser, meetingLocation, true, bookingStatus);

                // TenantHomePage eventForm = new TenantHomePage(currentUser);
                //this.Hide();
                //eventForm.Show();

            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePageTenant homepage = new HomePageTenant(currentUser);
            this.Hide();
            homepage.Show();           


        }
    }
}