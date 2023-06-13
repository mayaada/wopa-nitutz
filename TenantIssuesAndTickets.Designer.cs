namespace nitutz
{
    partial class TenantIssuesAndTickets
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
            NewLeaseButton = new Button();
            listView1 = new ListView();
            BackButton = new Button();
            CreateTicketBueeon = new Button();
            SuspendLayout();
            // 
            // NewLeaseButton
            // 
            NewLeaseButton.BackColor = SystemColors.ControlDarkDark;
            NewLeaseButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewLeaseButton.ForeColor = SystemColors.ButtonHighlight;
            NewLeaseButton.Location = new Point(640, 389);
            NewLeaseButton.Name = "NewLeaseButton";
            NewLeaseButton.Size = new Size(148, 58);
            NewLeaseButton.TabIndex = 4;
            NewLeaseButton.Text = "New Issue";
            NewLeaseButton.UseVisualStyleBackColor = false;
            NewLeaseButton.Click += NewLeaseButton_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 56);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 318);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDarkDark;
            BackButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ButtonHighlight;
            BackButton.Location = new Point(12, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(127, 35);
            BackButton.TabIndex = 6;
            BackButton.Text = "BACK";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // CreateTicketBueeon
            // 
            CreateTicketBueeon.BackColor = SystemColors.ControlDarkDark;
            CreateTicketBueeon.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTicketBueeon.ForeColor = SystemColors.ButtonHighlight;
            CreateTicketBueeon.Location = new Point(461, 389);
            CreateTicketBueeon.Name = "CreateTicketBueeon";
            CreateTicketBueeon.Size = new Size(163, 58);
            CreateTicketBueeon.TabIndex = 7;
            CreateTicketBueeon.Text = "Create Ticket";
            CreateTicketBueeon.UseVisualStyleBackColor = false;
            CreateTicketBueeon.Click += CreateTicketBueeon_Click;
            // 
            // TenantIssuesAndTickets
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateTicketBueeon);
            Controls.Add(BackButton);
            Controls.Add(listView1);
            Controls.Add(NewLeaseButton);
            Name = "TenantIssuesAndTickets";
            Text = "TenantIssuesAndTickets";
            Load += TenantIssuesAndTickets_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button NewLeaseButton;
        private ListView listView1;
        private Button BackButton;
        private Button CreateTicketBueeon;
    }
}