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
    public partial class NewBookingForTenantForm : Form
    {
        private Tenant currentUser;
        private List<MeetingLocation> meetingLocations;
        private List<TimeSpan> bookingHours;
        public NewBookingForTenantForm(Tenant currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            initMeetingLocationsList();
            initBookingHoursList();
        }

        private void NewBookingForTenantForm_Load(object sender, EventArgs e)
        {

        }
        private void initMeetingLocationsList()
        {
            this.meetingLocations = Program.MeetingLocations.ToList();
            LocationcomboBox1.Items.Clear();
            foreach (var meetingLocation in meetingLocations)
            {
                LocationcomboBox1.Items.Add(meetingLocation.getRoomName());
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

            StarDatecomboBox1.Items.Clear();
            EndDatecomboBox1.Items.Clear();

            foreach (TimeSpan time in bookingHours)
            {
                StarDatecomboBox1.Items.Add(time.ToString());
                EndDatecomboBox1.Items.Add(time.ToString());
            }

        }
        private Booking newBooking;

        private void NewTenantBooking_Load() { }

        private void StarDatecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EndDatecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LocationcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookMeetingRoomButton_Click(object sender, EventArgs e)
        {
            // save booking fields
            DateTime bookingDate = dateTimePicker1.Value;
            TimeSpan selectedStartTime = TimeSpan.Parse(StarDatecomboBox1.Text);
            TimeSpan selectedEndTime = TimeSpan.Parse(EndDatecomboBox1.Text);

            MeetingLocation meetingLocation = Program.seekMeetingLocation(LocationcomboBox1.Text);

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

                // TenantHomePage eventForm = new TenantHomePage(currentUser);
                //this.Hide();
                //eventForm.Show();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            // TenantHomePage homepage = new TenantHomePage(currentUser);
            //homepage.Show();
        }

        private void DatePiker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}






