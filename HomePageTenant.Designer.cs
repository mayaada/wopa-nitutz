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
            SuspendLayout();
            // 
            // WelcomrLabel
            // 
            WelcomrLabel.AutoSize = true;
            WelcomrLabel.Location = new Point(331, 75);
            WelcomrLabel.Name = "WelcomrLabel";
            WelcomrLabel.Size = new Size(85, 25);
            WelcomrLabel.TabIndex = 0;
            WelcomrLabel.Text = "Welcome";
            // 
            // NewTicketButton
            // 
            NewTicketButton.Location = new Point(565, 270);
            NewTicketButton.Name = "NewTicketButton";
            NewTicketButton.Size = new Size(115, 48);
            NewTicketButton.TabIndex = 2;
            NewTicketButton.Text = "Open";
            NewTicketButton.UseVisualStyleBackColor = true;
            NewTicketButton.Click += NewTicketButton_Click;
            // 
            // OpenNewTicket
            // 
            OpenNewTicket.AutoSize = true;
            OpenNewTicket.Location = new Point(514, 231);
            OpenNewTicket.Name = "OpenNewTicket";
            OpenNewTicket.Size = new Size(202, 25);
            OpenNewTicket.TabIndex = 3;
            OpenNewTicket.Text = "New Maintenance Ticket";
            // 
            // HomePageTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}