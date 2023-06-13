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
            button1 = new Button();
            newBookingButton = new Button();
            SuspendLayout();
            // 
            // WelcomrLabel
            // 
            WelcomrLabel.AutoSize = true;
            WelcomrLabel.Font = new Font("Britannic Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomrLabel.Location = new Point(299, 67);
            WelcomrLabel.Name = "WelcomrLabel";
            WelcomrLabel.Size = new Size(176, 44);
            WelcomrLabel.TabIndex = 0;
            WelcomrLabel.Text = "Welcome";
            // 
            // NewTicketButton
            // 
            NewTicketButton.BackColor = SystemColors.ControlDarkDark;
            NewTicketButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewTicketButton.ForeColor = SystemColors.ButtonHighlight;
            NewTicketButton.Location = new Point(521, 240);
            NewTicketButton.Name = "NewTicketButton";
            NewTicketButton.Size = new Size(166, 100);
            NewTicketButton.TabIndex = 2;
            NewTicketButton.Text = "Open New Maintenance Ticket";
            NewTicketButton.UseVisualStyleBackColor = false;
            NewTicketButton.Click += NewTicketButton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 35);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 4;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // newBookingButton
            // 
            newBookingButton.BackColor = SystemColors.ControlDarkDark;
            newBookingButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newBookingButton.ForeColor = SystemColors.Window;
            newBookingButton.Location = new Point(130, 240);
            newBookingButton.Margin = new Padding(2, 2, 2, 2);
            newBookingButton.Name = "newBookingButton";
            newBookingButton.Size = new Size(173, 95);
            newBookingButton.TabIndex = 5;
            newBookingButton.Text = "New Booking";
            newBookingButton.UseVisualStyleBackColor = false;
            newBookingButton.Click += newBookingButton_Click;
            // 
            // HomePageTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(newBookingButton);
            Controls.Add(button1);
            Controls.Add(NewTicketButton);
            Controls.Add(WelcomrLabel);
            Name = "HomePageTenant";
            Text = "HomePageTenant";
            Load += HomePageTenant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomrLabel;
        private Button NewTicketButton;
        private Button button1;
        private Button newBookingButton;
    }
}