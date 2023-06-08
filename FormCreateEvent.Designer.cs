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
            EventNameTextBox = new TextBox();
            EventNameLabel = new Label();
            MaxInviteesLabel = new Label();
            label5 = new Label();
            EventDatesCalendar = new MonthCalendar();
            ChooseNumber = new NumericUpDown();
            EventDatesLabel = new Label();
            saveAndCreateBookingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ChooseNumber).BeginInit();
            SuspendLayout();
            // 
            // EventNameTextBox
            // 
            EventNameTextBox.Location = new Point(175, 152);
            EventNameTextBox.Name = "EventNameTextBox";
            EventNameTextBox.Size = new Size(150, 31);
            EventNameTextBox.TabIndex = 1;
            EventNameTextBox.TextChanged += Event_TextChanged_1;
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Location = new Point(52, 152);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(107, 25);
            EventNameLabel.TabIndex = 2;
            EventNameLabel.Text = "Event Name";
            EventNameLabel.Click += label1_Click;
            // 
            // MaxInviteesLabel
            // 
            MaxInviteesLabel.AutoSize = true;
            MaxInviteesLabel.Location = new Point(52, 218);
            MaxInviteesLabel.Name = "MaxInviteesLabel";
            MaxInviteesLabel.Size = new Size(110, 25);
            MaxInviteesLabel.TabIndex = 6;
            MaxInviteesLabel.Text = "Max Invitees";
            MaxInviteesLabel.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(253, 28);
            label5.Name = "label5";
            label5.Size = new Size(288, 53);
            label5.TabIndex = 7;
            label5.Text = "Create Event";
            // 
            // EventDatesCalendar
            // 
            EventDatesCalendar.Location = new Point(440, 152);
            EventDatesCalendar.Name = "EventDatesCalendar";
            EventDatesCalendar.SelectionRange = new SelectionRange(new DateTime(2029, 12, 26, 0, 0, 0, 0), new DateTime(2030, 1, 1, 0, 0, 0, 0));
            EventDatesCalendar.ShowToday = false;
            EventDatesCalendar.TabIndex = 10;
            EventDatesCalendar.TrailingForeColor = SystemColors.Highlight;
            EventDatesCalendar.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // ChooseNumber
            // 
            ChooseNumber.Location = new Point(175, 218);
            ChooseNumber.Name = "ChooseNumber";
            ChooseNumber.Size = new Size(150, 31);
            ChooseNumber.TabIndex = 11;
            ChooseNumber.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // EventDatesLabel
            // 
            EventDatesLabel.AutoSize = true;
            EventDatesLabel.Location = new Point(541, 118);
            EventDatesLabel.Name = "EventDatesLabel";
            EventDatesLabel.Size = new Size(105, 25);
            EventDatesLabel.TabIndex = 12;
            EventDatesLabel.Text = "Event Dates";
            EventDatesLabel.Click += label2_Click_1;
            // 
            // saveAndCreateBookingButton
            // 
            saveAndCreateBookingButton.Location = new Point(52, 347);
            saveAndCreateBookingButton.Name = "saveAndCreateBookingButton";
            saveAndCreateBookingButton.Size = new Size(134, 60);
            saveAndCreateBookingButton.TabIndex = 13;
            saveAndCreateBookingButton.Text = "create";
            saveAndCreateBookingButton.UseVisualStyleBackColor = true;
            saveAndCreateBookingButton.Click += SaveEventAndCreateBooking_Button;
            // 
            // FormCreateEvent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveAndCreateBookingButton);
            Controls.Add(EventDatesLabel);
            Controls.Add(ChooseNumber);
            Controls.Add(EventDatesCalendar);
            Controls.Add(label5);
            Controls.Add(MaxInviteesLabel);
            Controls.Add(EventNameLabel);
            Controls.Add(EventNameTextBox);
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

        private TextBox EventNameTextBox;
        private Label EventNameLabel;
        private Label MaxInviteesLabel;
        private Label label5;
        private MonthCalendar EventDatesCalendar;
        private NumericUpDown ChooseNumber;
        private Label EventDatesLabel;
        private Button saveAndCreateBookingButton;
    }
}