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
            ExiststingIssue = new Button();
            SuspendLayout();
            // 
            // NewLeaseButton
            // 
            NewLeaseButton.Location = new Point(148, 139);
            NewLeaseButton.Name = "NewLeaseButton";
            NewLeaseButton.Size = new Size(224, 95);
            NewLeaseButton.TabIndex = 4;
            NewLeaseButton.Text = "New Issue";
            NewLeaseButton.UseVisualStyleBackColor = true;
            NewLeaseButton.Click += NewLeaseButton_Click;
            // 
            // ExiststingIssue
            // 
            ExiststingIssue.Location = new Point(417, 139);
            ExiststingIssue.Name = "ExiststingIssue";
            ExiststingIssue.Size = new Size(223, 95);
            ExiststingIssue.TabIndex = 5;
            ExiststingIssue.Text = "Existsting Issue";
            ExiststingIssue.UseVisualStyleBackColor = true;
            ExiststingIssue.Click += ExiststingIssue_Click;
            // 
            // TenantIssuesAndTickets
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExiststingIssue);
            Controls.Add(NewLeaseButton);
            Name = "TenantIssuesAndTickets";
            Text = "TenantIssuesAndTickets";
            Load += TenantIssuesAndTickets_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button NewLeaseButton;
        private Button ExiststingIssue;
    }
}