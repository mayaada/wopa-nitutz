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
        private Employee currentUser;
        private DateTime StartD;
        private DateTime EndD;


        public FormCreateEvent(Employee currentUser, DateTime SD, DateTime ED)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.StartD = SD;
            this.EndD = ED;

        }

        private void FormCreateEvent_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveEventAndCreateBooking_Button(object sender, EventArgs e)
        {
            int maxInvite = (int)ChooseNumber.Value;
            DateTime startDate = StartD;
            DateTime endDate = EndD;
            newEvent = new Event(EventName.Text, startDate, endDate, maxInvite, true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            NewBookingForEmployee neb = new NewBookingForEmployee(currentUser);
            neb.Show();
            this.Hide();
        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


