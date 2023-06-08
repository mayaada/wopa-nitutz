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
        public newEmployeeBooking()
        {
            InitializeComponent();
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
            DateTime selectedDate = datePicker.Value;
            DateTime selectedStartTime = startTimePicker.Value;
            DateTime selectedEndTime = endTimePicker1.Value;
            Employee employeeEmail = Program.seekEemploye(UserEmailTextBok.Text);
            MeetingLocation meetingLocation = Program.seekMeetingLocation(meetingLocationTextBox.Text);


            newBooking = new Booking(selectedDate, selectedStartTime, selectedEndTime, employeeEmail, meetingLocation);


        }

        private void BookEventButton_Click(object sender, EventArgs e)
        {

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
    }
}
