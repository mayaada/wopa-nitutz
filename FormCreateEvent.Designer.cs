namespace nitutz
{
    partial class FormCreateEvent
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
            EventNameLabel = new Label();
            MaxInviteesLabel = new Label();
            label5 = new Label();
            ChooseNumber = new NumericUpDown();
            saveAndCreateBookingButton = new Button();
            backButton = new Button();
            EventName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ChooseNumber).BeginInit();
            SuspendLayout();
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Location = new Point(312, 249);
            EventNameLabel.Margin = new Padding(5, 0, 5, 0);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(177, 41);
            EventNameLabel.TabIndex = 2;
            EventNameLabel.Text = "Event Name";
            EventNameLabel.Click += label1_Click;
            // 
            // MaxInviteesLabel
            // 
            MaxInviteesLabel.AutoSize = true;
            MaxInviteesLabel.Location = new Point(312, 352);
            MaxInviteesLabel.Margin = new Padding(5, 0, 5, 0);
            MaxInviteesLabel.Name = "MaxInviteesLabel";
            MaxInviteesLabel.Size = new Size(183, 41);
            MaxInviteesLabel.TabIndex = 6;
            MaxInviteesLabel.Text = "Max Invitees";
            MaxInviteesLabel.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(389, 71);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(481, 89);
            label5.TabIndex = 7;
            label5.Text = "Create Event";
            label5.Click += label5_Click;
            // 
            // ChooseNumber
            // 
            ChooseNumber.Location = new Point(554, 352);
            ChooseNumber.Margin = new Padding(5);
            ChooseNumber.Name = "ChooseNumber";
            ChooseNumber.Size = new Size(255, 47);
            ChooseNumber.TabIndex = 11;
            ChooseNumber.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // saveAndCreateBookingButton
            // 
            saveAndCreateBookingButton.Location = new Point(698, 535);
            saveAndCreateBookingButton.Margin = new Padding(5);
            saveAndCreateBookingButton.Name = "saveAndCreateBookingButton";
            saveAndCreateBookingButton.Size = new Size(228, 98);
            saveAndCreateBookingButton.TabIndex = 13;
            saveAndCreateBookingButton.Text = "Create";
            saveAndCreateBookingButton.UseVisualStyleBackColor = true;
            saveAndCreateBookingButton.Click += SaveEventAndCreateBooking_Button;
            // 
            // backButton
            // 
            backButton.Location = new Point(399, 535);
            backButton.Name = "backButton";
            backButton.Size = new Size(230, 98);
            backButton.TabIndex = 14;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // EventName
            // 
            EventName.Location = new Point(553, 243);
            EventName.Name = "EventName";
            EventName.Size = new Size(256, 47);
            EventName.TabIndex = 15;
            EventName.TextChanged += EventName_TextChanged;
            // 
            // FormCreateEvent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 738);
            Controls.Add(EventName);
            Controls.Add(backButton);
            Controls.Add(saveAndCreateBookingButton);
            Controls.Add(ChooseNumber);
            Controls.Add(label5);
            Controls.Add(MaxInviteesLabel);
            Controls.Add(EventNameLabel);
            Margin = new Padding(5);
            Name = "FormCreateEvent";
            Text = "FormCreateEvent";
            Load += FormCreateEvent_Load;
            ((System.ComponentModel.ISupportInitialize)ChooseNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Event_TextChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label EventNameLabel;
        private Label MaxInviteesLabel;
        private Label label5;
        private NumericUpDown ChooseNumber;
        private Button saveAndCreateBookingButton;
        private Button backButton;
        private TextBox EventName;
    }
}