using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace nitutz
{
    public partial class MaintenanceTicketManagementForm : Form
    {
        private List<Ticket> allTickets;
        private List<Ticket> openTickets;
        private Employee currentUser;
        private List<Ticket> pendingTickets;
        private List<Ticket> resolvedTickets;
        private List<Issue> issues;
        private Ticket currentTicket;
        private Issue currentIssue;
        private bool isUserInteraction = false;



        public MaintenanceTicketManagementForm(Employee currentUser)
        {
            InitializeComponent();


            allTickets = Program.Tickets.ToList();

            openTicketListBox.SelectedIndexChanged -= openTicketListBox_SelectedIndexChanged;

            initOpenTicketsList();

            openTicketListBox.SelectedIndexChanged += openTicketListBox_SelectedIndexChanged;

            pendingTicketListBox.SelectedIndexChanged -= pendingTicketListBox_SelectedIndexChanged;

            initPendingTicketsList();
            pendingTicketListBox.SelectedIndexChanged += pendingTicketListBox_SelectedIndexChanged;

            resolvedTicketListBox.SelectedIndexChanged -= resolvedTicketListBox_SelectedIndexChanged;

            initResolvedTicketsList();
            resolvedTicketListBox.SelectedIndexChanged += resolvedTicketListBox_SelectedIndexChanged;

            this.currentUser = currentUser;
        }

        private void initResolvedTicketsList()
        {
            resolvedTickets = new List<Ticket>();

            foreach (Ticket ticket in allTickets)
            {
                if (ticket.getTicketStatus() == TicketStatus.Resolved)
                {
                    resolvedTickets.Add(ticket);
                }
            }

            resolvedTicketListBox.DataSource = resolvedTickets;
        }

        private void initPendingTicketsList()
        {
            pendingTickets = new List<Ticket>();
            foreach (Ticket ticket in allTickets)
            {
                if (ticket.getTicketStatus() == TicketStatus.Pending)
                {
                    pendingTickets.Add(ticket);
                }
            }

            pendingTicketListBox.DataSource = pendingTickets;

        }

        private void initOpenTicketsList()
        {
            openTickets = new List<Ticket>();
            foreach (Ticket ticket in allTickets)
            {
                if (ticket.getTicketStatus() == TicketStatus.Open)
                {
                    openTickets.Add(ticket);
                }
            }
            openTicketListBox.DataSource = openTickets;
        }

        public void MaintenanceTicketManagementForm_Load(object sender, EventArgs e) { }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openTicketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTicket = (Ticket)openTicketListBox.SelectedItem;

            if (currentTicket == null)
            {
                // add message box
            }
            else
            {
                currentIssue = currentTicket.getRefferenceIssue();
                TicketEditForm form = new TicketEditForm(currentIssue, currentTicket);
                form.Show();
                this.Hide();

            }
        }

        private void pendingTicketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTicket = (Ticket)pendingTicketListBox.SelectedItem;

            if (currentTicket == null)
            {
                // add message box
            }
            else
            {
                currentIssue = currentTicket.getRefferenceIssue();
                TicketEditForm form = new TicketEditForm(currentIssue, currentTicket);
                form.Show();
                this.Hide();
            }
        }

        private void resolvedTicketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTicket = (Ticket)resolvedTicketListBox.SelectedItem;

            if (currentTicket == null)
            {
                // add message box
            }
            else
            {
                currentIssue = currentTicket.getRefferenceIssue();
                TicketEditForm form = new TicketEditForm(currentIssue, currentTicket);
                form.Show();
                this.Hide();
            }
        }

        private void resolvedTickets_Lable_Click(object sender, EventArgs e)
        {

        }
    }

}
