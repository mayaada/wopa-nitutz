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
            label1 = new Label();
            openTicket_Tab.SuspendLayout();
            openTickets_Lable.SuspendLayout();
            pendingTickets_Lable.SuspendLayout();
            resolvedTickets_Lable.SuspendLayout();
            SuspendLayout();
            // 
            // openTicketListBox
            // 
            openTicketListBox.BackColor = SystemColors.Control;
            openTicketListBox.FormattingEnabled = true;
            openTicketListBox.ItemHeight = 40;
            openTicketListBox.Location = new Point(0, 16);
            openTicketListBox.Name = "openTicketListBox";
            openTicketListBox.Size = new Size(1465, 684);
            openTicketListBox.TabIndex = 0;
            openTicketListBox.SelectedIndexChanged += openTicketListBox_SelectedIndexChanged;
            // 
            // openTicket_Tab
            // 
            openTicket_Tab.Controls.Add(openTickets_Lable);
            openTicket_Tab.Controls.Add(pendingTickets_Lable);
            openTicket_Tab.Controls.Add(resolvedTickets_Lable);
            openTicket_Tab.Font = new Font("Segoe UI Variable Small Semibol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openTicket_Tab.Location = new Point(24, 127);
            openTicket_Tab.Name = "openTicket_Tab";
            openTicket_Tab.SelectedIndex = 0;
            openTicket_Tab.Size = new Size(1482, 751);
            openTicket_Tab.TabIndex = 1;
            // 
            // openTickets_Lable
            // 
            openTickets_Lable.Controls.Add(openTicketListBox);
            openTickets_Lable.Location = new Point(10, 57);
            openTickets_Lable.Name = "openTickets_Lable";
            openTickets_Lable.Padding = new Padding(3);
            openTickets_Lable.Size = new Size(1462, 684);
            openTickets_Lable.TabIndex = 0;
            openTickets_Lable.Text = "Open Tickets";
            openTickets_Lable.UseVisualStyleBackColor = true;
            // 
            // pendingTickets_Lable
            // 
            pendingTickets_Lable.Controls.Add(pendingTicketListBox);
            pendingTickets_Lable.Location = new Point(10, 57);
            pendingTickets_Lable.Name = "pendingTickets_Lable";
            pendingTickets_Lable.Padding = new Padding(3);
            pendingTickets_Lable.Size = new Size(1462, 684);
            pendingTickets_Lable.TabIndex = 1;
            pendingTickets_Lable.Text = "Pending Tickets";
            pendingTickets_Lable.UseVisualStyleBackColor = true;
            // 
            // pendingTicketListBox
            // 
            pendingTicketListBox.BackColor = SystemColors.Control;
            pendingTicketListBox.FormattingEnabled = true;
            pendingTicketListBox.ItemHeight = 40;
            pendingTicketListBox.Location = new Point(0, 0);
            pendingTicketListBox.Name = "pendingTicketListBox";
            pendingTicketListBox.Size = new Size(1472, 684);
            pendingTicketListBox.TabIndex = 0;
            pendingTicketListBox.SelectedIndexChanged += pendingTicketListBox_SelectedIndexChanged;
            // 
            // resolvedTickets_Lable
            // 
            resolvedTickets_Lable.Controls.Add(resolvedTicketListBox);
            resolvedTickets_Lable.Location = new Point(10, 57);
            resolvedTickets_Lable.Name = "resolvedTickets_Lable";
            resolvedTickets_Lable.Padding = new Padding(3);
            resolvedTickets_Lable.Size = new Size(1462, 684);
            resolvedTickets_Lable.TabIndex = 2;
            resolvedTickets_Lable.Text = "Resolved Tickets ";
            resolvedTickets_Lable.UseVisualStyleBackColor = true;
            resolvedTickets_Lable.Click += resolvedTickets_Lable_Click;
            // 
            // resolvedTicketListBox
            // 
            resolvedTicketListBox.BackColor = SystemColors.Control;
            resolvedTicketListBox.FormattingEnabled = true;
            resolvedTicketListBox.ItemHeight = 40;
            resolvedTicketListBox.Location = new Point(0, 0);
            resolvedTicketListBox.Name = "resolvedTicketListBox";
            resolvedTicketListBox.Size = new Size(1472, 684);
            resolvedTicketListBox.TabIndex = 0;
            resolvedTicketListBox.SelectedIndexChanged += resolvedTicketListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 21.9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(606, 25);
            label1.Name = "label1";
            label1.Size = new Size(261, 80);
            label1.TabIndex = 2;
            label1.Text = "Tickets";
            // 
            // MaintenanceTicketManagementForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1526, 889);
            Controls.Add(label1);
            Controls.Add(openTicket_Tab);
            ForeColor = SystemColors.ControlDarkDark;
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
        private Label label1;
    }
}