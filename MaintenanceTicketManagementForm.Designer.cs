namespace nitutz
{
    partial class MaintenanceTicketManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openTicketListBox = new ListBox();
            openTicket_Tab = new TabControl();
            openTickets_Lable = new TabPage();
            pendingTickets_Lable = new TabPage();
            pendingTicketListBox = new ListBox();
            resolvedTickets_Lable = new TabPage();
            resolvedTicketListBox = new ListBox();
            ticketsLable = new Label();
            openTicket_Tab.SuspendLayout();
            openTickets_Lable.SuspendLayout();
            pendingTickets_Lable.SuspendLayout();
            resolvedTickets_Lable.SuspendLayout();
            SuspendLayout();
            // 
            // openTicketListBox
            // 
            openTicketListBox.FormattingEnabled = true;
            openTicketListBox.ItemHeight = 41;
            openTicketListBox.Location = new Point(0, 0);
            openTicketListBox.Name = "openTicketListBox";
            openTicketListBox.Size = new Size(1878, 865);
            openTicketListBox.TabIndex = 0;
            openTicketListBox.SelectedIndexChanged += openTicketListBox_SelectedIndexChanged;
            // 
            // openTicket_Tab
            // 
            openTicket_Tab.Controls.Add(openTickets_Lable);
            openTicket_Tab.Controls.Add(pendingTickets_Lable);
            openTicket_Tab.Controls.Add(resolvedTickets_Lable);
            openTicket_Tab.Location = new Point(24, 111);
            openTicket_Tab.Name = "openTicket_Tab";
            openTicket_Tab.SelectedIndex = 0;
            openTicket_Tab.Size = new Size(1898, 932);
            openTicket_Tab.TabIndex = 1;
            // 
            // openTickets_Lable
            // 
            openTickets_Lable.Controls.Add(openTicketListBox);
            openTickets_Lable.Location = new Point(10, 58);
            openTickets_Lable.Name = "openTickets_Lable";
            openTickets_Lable.Padding = new Padding(3);
            openTickets_Lable.Size = new Size(1878, 864);
            openTickets_Lable.TabIndex = 0;
            openTickets_Lable.Text = "Open Tickets";
            openTickets_Lable.UseVisualStyleBackColor = true;
            // 
            // pendingTickets_Lable
            // 
            pendingTickets_Lable.Controls.Add(pendingTicketListBox);
            pendingTickets_Lable.Location = new Point(10, 58);
            pendingTickets_Lable.Name = "pendingTickets_Lable";
            pendingTickets_Lable.Padding = new Padding(3);
            pendingTickets_Lable.Size = new Size(1878, 864);
            pendingTickets_Lable.TabIndex = 1;
            pendingTickets_Lable.Text = "Pending Tickets";
            pendingTickets_Lable.UseVisualStyleBackColor = true;
            // 
            // pendingTicketListBox
            // 
            pendingTicketListBox.FormattingEnabled = true;
            pendingTicketListBox.ItemHeight = 41;
            pendingTicketListBox.Location = new Point(0, 0);
            pendingTicketListBox.Name = "pendingTicketListBox";
            pendingTicketListBox.Size = new Size(1872, 865);
            pendingTicketListBox.TabIndex = 0;
            pendingTicketListBox.SelectedIndexChanged += pendingTicketListBox_SelectedIndexChanged;
            // 
            // resolvedTickets_Lable
            // 
            resolvedTickets_Lable.Controls.Add(resolvedTicketListBox);
            resolvedTickets_Lable.Location = new Point(10, 58);
            resolvedTickets_Lable.Name = "resolvedTickets_Lable";
            resolvedTickets_Lable.Padding = new Padding(3);
            resolvedTickets_Lable.Size = new Size(1878, 864);
            resolvedTickets_Lable.TabIndex = 2;
            resolvedTickets_Lable.Text = "Resolved Tickets ";
            resolvedTickets_Lable.UseVisualStyleBackColor = true;
            // 
            // resolvedTicketListBox
            // 
            resolvedTicketListBox.FormattingEnabled = true;
            resolvedTicketListBox.ItemHeight = 41;
            resolvedTicketListBox.Location = new Point(0, 0);
            resolvedTicketListBox.Name = "resolvedTicketListBox";
            resolvedTicketListBox.Size = new Size(1878, 865);
            resolvedTicketListBox.TabIndex = 0;
            resolvedTicketListBox.SelectedIndexChanged += resolvedTicketListBox_SelectedIndexChanged;
            // 
            // ticketsLable
            // 
            ticketsLable.AutoSize = true;
            ticketsLable.Location = new Point(550, 57);
            ticketsLable.Name = "ticketsLable";
            ticketsLable.Size = new Size(109, 41);
            ticketsLable.TabIndex = 2;
            ticketsLable.Text = "Tickets";
            // 
            // MaintenanceTicketManagementForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1934, 1055);
            Controls.Add(ticketsLable);
            Controls.Add(openTicket_Tab);
            Name = "MaintenanceTicketManagementForm";
            Text = "MaintenanceTicketManagementForm";
            Load += MaintenanceTicketManagementForm_Load;
            openTicket_Tab.ResumeLayout(false);
            openTickets_Lable.ResumeLayout(false);
            pendingTickets_Lable.ResumeLayout(false);
            resolvedTickets_Lable.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox openTicketListBox;
        private TabControl openTicket_Tab;
        private TabPage openTickets_Lable;
        private TabPage pendingTickets_Lable;
        private ListBox pendingTicketListBox;
        private TabPage resolvedTickets_Lable;
        private ListBox resolvedTicketListBox;
        private Label ticketsLable;
    }
}