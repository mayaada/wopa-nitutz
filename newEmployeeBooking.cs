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
    public partial class newEmployeeBooking : Form

    {
        private Employee currentUser;

        public newEmployeeBooking(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
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

        private void createEvent_Button(object sender, EventArgs e)
        {
            FormCreateEvent eventForm = new FormCreateEvent();
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
