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
            SuspendLayout();
            // 
            // WelcomrLabel
            // 
            WelcomrLabel.AutoSize = true;
            WelcomrLabel.Font = new Font("Britannic Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomrLabel.Location = new Point(287, 68);
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
            NewTicketButton.Location = new Point(565, 270);
            NewTicketButton.Name = "NewTicketButton";
            NewTicketButton.Size = new Size(115, 48);
            NewTicketButton.TabIndex = 2;
            NewTicketButton.Text = "Open";
            NewTicketButton.UseVisualStyleBackColor = false;
            NewTicketButton.Click += NewTicketButton_Click;
            // 
            // OpenNewTicket
            // 
            OpenNewTicket.AutoSize = true;
            OpenNewTicket.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OpenNewTicket.Location = new Point(514, 231);
            OpenNewTicket.Name = "OpenNewTicket";
            OpenNewTicket.Size = new Size(224, 28);
            OpenNewTicket.TabIndex = 3;
            OpenNewTicket.Text = "New Maintenance Ticket";
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
            // HomePageTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(OpenNewTicket);
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
        private Label OpenNewTicket;
        private Button button1;
    }
}