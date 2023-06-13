namespace nitutz
{
    partial class HomePageTenant
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
            WelcomrLabel = new Label();
            NewTicketButton = new Button();
            OpenNewTicket = new Label();
            button1 = new Button();
            newBookingButton = new Button();
            SuspendLayout();
            // 
            // WelcomrLabel
            // 
            WelcomrLabel.AutoSize = true;
            WelcomrLabel.Font = new Font("Britannic Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomrLabel.Location = new Point(488, 112);
            WelcomrLabel.Margin = new Padding(5, 0, 5, 0);
            WelcomrLabel.Name = "WelcomrLabel";
            WelcomrLabel.Size = new Size(292, 74);
            WelcomrLabel.TabIndex = 0;
            WelcomrLabel.Text = "Welcome";
            // 
            // NewTicketButton
            // 
            NewTicketButton.BackColor = SystemColors.ControlDarkDark;
            NewTicketButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewTicketButton.ForeColor = SystemColors.ButtonHighlight;
            NewTicketButton.Location = new Point(960, 443);
            NewTicketButton.Margin = new Padding(5, 5, 5, 5);
            NewTicketButton.Name = "NewTicketButton";
            NewTicketButton.Size = new Size(196, 79);
            NewTicketButton.TabIndex = 2;
            NewTicketButton.Text = "Open";
            NewTicketButton.UseVisualStyleBackColor = false;
            NewTicketButton.Click += NewTicketButton_Click;
            // 
            // OpenNewTicket
            // 
            OpenNewTicket.AutoSize = true;
            OpenNewTicket.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OpenNewTicket.Location = new Point(874, 379);
            OpenNewTicket.Margin = new Padding(5, 0, 5, 0);
            OpenNewTicket.Name = "OpenNewTicket";
            OpenNewTicket.Size = new Size(389, 46);
            OpenNewTicket.TabIndex = 3;
            OpenNewTicket.Text = "New Maintenance Ticket";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(20, 57);
            button1.Margin = new Padding(5, 5, 5, 5);
            button1.Name = "button1";
            button1.Size = new Size(160, 74);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // newBookingButton
            // 
            newBookingButton.Location = new Point(221, 354);
            newBookingButton.Name = "newBookingButton";
            newBookingButton.Size = new Size(297, 155);
            newBookingButton.TabIndex = 5;
            newBookingButton.Text = "New Booking";
            newBookingButton.UseVisualStyleBackColor = true;
            newBookingButton.Click += newBookingButton_Click;
            // 
            // HomePageTenant
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1360, 738);
            Controls.Add(newBookingButton);
            Controls.Add(button1);
            Controls.Add(OpenNewTicket);
            Controls.Add(NewTicketButton);
            Controls.Add(WelcomrLabel);
            Margin = new Padding(5, 5, 5, 5);
            Name = "HomePageTenant";
            Text = "HomePageTenant";
            Load += HomePageTenant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomrLabel;
        private Button NewTicketButton;
        private Label OpenNewTicket;
        private Button button1;
        private Button newBookingButton;
    }
}