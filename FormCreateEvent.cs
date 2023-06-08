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

    public partial class FormCreateEvent : Form
    {
        private Event newEvent;

        public FormCreateEvent()
        {
            InitializeComponent();
        }

        private void FormCreateEvent_Load(object sender, EventArgs e)
        {
            EventDatesCalendar.DateSelected += monthCalendar1_DateSelected;

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = EventDatesCalendar.SelectionStart;
            DateTime endDate = EventDatesCalendar.SelectionEnd;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void eventName_textBox(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveEventAndCreateBooking_Button(object sender, EventArgs e)
        {
            int maxInvite = (int)ChooseNumber.Value;
            DateTime startDate = EventDatesCalendar.SelectionStart;
            DateTime endDate = EventDatesCalendar.SelectionEnd;
            newEvent = new Event(EventNameTextBox.Text, startDate, endDate, maxInvite);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }
    }


