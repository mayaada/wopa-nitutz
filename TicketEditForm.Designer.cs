namespace nitutz
{
    partial class TicketEditForm
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
            ticketsAndIssueDetails_Lable = new Label();
            issue_Lable = new Label();
            location_Lable = new Label();
            type_Lable = new Label();
            priority_Lable = new Label();
            dateOpened_Lable = new Label();
            timeOpened_Lable = new Label();
            openedBy_Lable = new Label();
            status_Lable = new Label();
            issueTextBox = new TextBox();
            locationTextBox = new TextBox();
            dateOpenedTextBox = new TextBox();
            timeOpenedTextBox = new TextBox();
            openedByTextBox = new TextBox();
            updateButton = new Button();
            backButton = new Button();
            typeComboBox = new ComboBox();
            priorityComboBox = new ComboBox();
            statusComboBox = new ComboBox();
            SuspendLayout();
            // 
            // ticketsAndIssueDetails_Lable
            // 
            ticketsAndIssueDetails_Lable.AutoSize = true;
            ticketsAndIssueDetails_Lable.Font = new Font("Britannic Bold", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            ticketsAndIssueDetails_Lable.ForeColor = SystemColors.ActiveCaptionText;
            ticketsAndIssueDetails_Lable.Location = new Point(261, 50);
            ticketsAndIssueDetails_Lable.Name = "ticketsAndIssueDetails_Lable";
            ticketsAndIssueDetails_Lable.Size = new Size(515, 52);
            ticketsAndIssueDetails_Lable.TabIndex = 1;
            ticketsAndIssueDetails_Lable.Text = "Ticket And Issue Details";
            // 
            // issue_Lable
            // 
            issue_Lable.AutoSize = true;
            issue_Lable.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            issue_Lable.Location = new Point(106, 153);
            issue_Lable.Name = "issue_Lable";
            issue_Lable.Size = new Size(92, 40);
            issue_Lable.TabIndex = 2;
            issue_Lable.Text = "Issue:";
            issue_Lable.Click += issue_Lable_Click;
            // 
            // location_Lable
            // 
            location_Lable.AutoSize = true;
            location_Lable.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            location_Lable.Location = new Point(106, 250);
            location_Lable.Name = "location_Lable";
            location_Lable.Size = new Size(138, 40);
            location_Lable.TabIndex = 3;
            location_Lable.Text = "Location:";
            location_Lable.Click += location_Lable_Click;
            // 
            // type_Lable
            // 
            type_Lable.AutoSize = true;
            type_Lable.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            type_Lable.Location = new Point(106, 347);
            type_Lable.Name = "type_Lable";
            type_Lable.Size = new Size(85, 40);
            type_Lable.TabIndex = 4;
            type_Lable.Text = "Type:";
            type_Lable.Click += type_Lable_Click;
            // 
            // priority_Lable
            // 
            priority_Lable.AutoSize = true;
            priority_Lable.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priority_Lable.Location = new Point(106, 444);
            priority_Lable.Name = "priority_Lable";
            priority_Lable.Size = new Size(120, 40);
            priority_Lable.TabIndex = 5;
            priority_Lable.Text = "Priority:";
            priority_Lable.Click += priority_Lable_Click;
            // 
            // dateOpened_Lable
            // 
            dateOpened_Lable.AutoSize = true;
            dateOpened_Lable.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateOpened_Lable.Location = new Point(106, 541);
            dateOpened_Lable.Name = "dateOpened_Lable";
            dateOpened_Lable.Size = new Size(200, 40);
            dateOpened_Lable.TabIndex = 6;
            dateOpened_Lable.Text = "Date Opened:";
            dateOpened_Lable.Click += dateOpened_Lable_Click;
            // 
            // timeOpened_Lable
            // 
            timeOpened_Lable.AutoSize = true;
            timeOpened_Lable.Location = new Point(106, 638);
            timeOpened_Lable.Name = "timeOpened_Lable";
            timeOpened_Lable.Size = new Size(206, 41);
            timeOpened_Lable.TabIndex = 7;
            timeOpened_Lable.Text = "Time Opened:";
            timeOpened_Lable.Click += timeOpened_Lable_Click;
            // 
            // openedBy_Lable
            // 
            openedBy_Lable.AutoSize = true;
            openedBy_Lable.Location = new Point(106, 735);
            openedBy_Lable.Name = "openedBy_Lable";
            openedBy_Lable.Size = new Size(173, 41);
            openedBy_Lable.TabIndex = 8;
            openedBy_Lable.Text = "Opened By:";
            openedBy_Lable.Click += openedBy_Lable_Click;
            // 
            // status_Lable
            // 
            status_Lable.AutoSize = true;
            status_Lable.Location = new Point(106, 832);
            status_Lable.Name = "status_Lable";
            status_Lable.Size = new Size(105, 41);
            status_Lable.TabIndex = 9;
            status_Lable.Text = "Status:";
            // 
            // issueTextBox
            // 
            issueTextBox.Enabled = false;
            issueTextBox.Location = new Point(349, 150);
            issueTextBox.Name = "issueTextBox";
            issueTextBox.Size = new Size(471, 47);
            issueTextBox.TabIndex = 10;
            // 
            // locationTextBox
            // 
            locationTextBox.Enabled = false;
            locationTextBox.Location = new Point(349, 247);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(471, 47);
            locationTextBox.TabIndex = 11;
            locationTextBox.TextChanged += textBox2_TextChanged;
            // 
            // dateOpenedTextBox
            // 
            dateOpenedTextBox.Enabled = false;
            dateOpenedTextBox.Location = new Point(349, 538);
            dateOpenedTextBox.Name = "dateOpenedTextBox";
            dateOpenedTextBox.Size = new Size(471, 47);
            dateOpenedTextBox.TabIndex = 14;
            // 
            // timeOpenedTextBox
            // 
            timeOpenedTextBox.Enabled = false;
            timeOpenedTextBox.Location = new Point(349, 635);
            timeOpenedTextBox.Name = "timeOpenedTextBox";
            timeOpenedTextBox.Size = new Size(471, 47);
            timeOpenedTextBox.TabIndex = 15;
            // 
            // openedByTextBox
            // 
            openedByTextBox.Enabled = false;
            openedByTextBox.Location = new Point(349, 732);
            openedByTextBox.Name = "openedByTextBox";
            openedByTextBox.Size = new Size(471, 47);
            openedByTextBox.TabIndex = 16;
            openedByTextBox.TextChanged += textBox7_TextChanged;
            // 
            // updateButton
            // 
            updateButton.BackColor = SystemColors.ControlDarkDark;
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.Window;
            updateButton.Location = new Point(793, 918);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(218, 63);
            updateButton.TabIndex = 18;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click_1;
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.ControlDarkDark;
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.ForeColor = SystemColors.Window;
            backButton.Location = new Point(536, 918);
            backButton.Name = "backButton";
            backButton.Size = new Size(218, 63);
            backButton.TabIndex = 19;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // typeComboBox
            // 
            typeComboBox.FormattingEnabled = true;
            typeComboBox.Location = new Point(349, 347);
            typeComboBox.Name = "typeComboBox";
            typeComboBox.Size = new Size(471, 49);
            typeComboBox.TabIndex = 20;
            typeComboBox.SelectedIndexChanged += typeComboBox_SelectedIndexChanged;
            // 
            // priorityComboBox
            // 
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(349, 441);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(471, 49);
            priorityComboBox.TabIndex = 21;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(349, 829);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(471, 49);
            statusComboBox.TabIndex = 22;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // TicketEditForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1048, 1014);
            Controls.Add(statusComboBox);
            Controls.Add(priorityComboBox);
            Controls.Add(typeComboBox);
            Controls.Add(backButton);
            Controls.Add(updateButton);
            Controls.Add(openedByTextBox);
            Controls.Add(timeOpenedTextBox);
            Controls.Add(dateOpenedTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(issueTextBox);
            Controls.Add(status_Lable);
            Controls.Add(openedBy_Lable);
            Controls.Add(timeOpened_Lable);
            Controls.Add(dateOpened_Lable);
            Controls.Add(priority_Lable);
            Controls.Add(type_Lable);
            Controls.Add(location_Lable);
            Controls.Add(issue_Lable);
            Controls.Add(ticketsAndIssueDetails_Lable);
            Name = "TicketEditForm";
            Text = "TicketEditForm";
            Load += TicketEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ticketsAndIssueDetails_Lable;
        private Label issue_Lable;
        private Label location_Lable;
        private Label type_Lable;
        private Label priority_Lable;
        private Label dateOpened_Lable;
        private Label timeOpened_Lable;
        private Label openedBy_Lable;
        private Label status_Lable;
        private TextBox issueTextBox;
        private TextBox locationTextBox;
        private TextBox dateOpenedTextBox;
        private TextBox timeOpenedTextBox;
        private TextBox openedByTextBox;
        private Button updateButton;
        private Button backButton;
        private ComboBox typeComboBox;
        private ComboBox priorityComboBox;
        private ComboBox statusComboBox;
    }
}