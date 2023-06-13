namespace nitutz
{
    partial class NewBookingForEmployee
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
            createBookingLable = new Label();
            dateLable = new Label();
            startTimeLable = new Label();
            endTimePicker = new Label();
            LocationLable = new Label();
            BookMeetingRoomButton = new Button();
            CreateEvent_Button = new Button();
            date_Button = new DateTimePicker();
            locationDropDownBox = new ComboBox();
            endTimeComboBox = new ComboBox();
            startTimeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // createBookingLable
            // 
            createBookingLable.AutoSize = true;
            createBookingLable.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            createBookingLable.Location = new Point(396, 15);
            createBookingLable.Margin = new Padding(5, 0, 5, 0);
            createBookingLable.Name = "createBookingLable";
            createBookingLable.Size = new Size(580, 89);
            createBookingLable.TabIndex = 0;
            createBookingLable.Text = "Create Booking";
            // 
            // dateLable
            // 
            dateLable.AutoSize = true;
            dateLable.Location = new Point(425, 171);
            dateLable.Margin = new Padding(5, 0, 5, 0);
            dateLable.Name = "dateLable";
            dateLable.Size = new Size(87, 41);
            dateLable.TabIndex = 1;
            dateLable.Text = "Date:";
            // 
            // startTimeLable
            // 
            startTimeLable.AutoSize = true;
            startTimeLable.Location = new Point(425, 276);
            startTimeLable.Margin = new Padding(5, 0, 5, 0);
            startTimeLable.Name = "startTimeLable";
            startTimeLable.Size = new Size(158, 41);
            startTimeLable.TabIndex = 3;
            startTimeLable.Text = "Start Time:";
            // 
            // endTimePicker
            // 
            endTimePicker.AutoSize = true;
            endTimePicker.Location = new Point(425, 370);
            endTimePicker.Margin = new Padding(5, 0, 5, 0);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(148, 41);
            endTimePicker.TabIndex = 3;
            endTimePicker.Text = "End Time:";
            // 
            // LocationLable
            // 
            LocationLable.AutoSize = true;
            LocationLable.Location = new Point(425, 463);
            LocationLable.Margin = new Padding(5, 0, 5, 0);
            LocationLable.Name = "LocationLable";
            LocationLable.Size = new Size(138, 41);
            LocationLable.TabIndex = 6;
            LocationLable.Text = "Location:";
            // 
            // BookMeetingRoomButton
            // 
            BookMeetingRoomButton.Location = new Point(1003, 597);
            BookMeetingRoomButton.Margin = new Padding(5);
            BookMeetingRoomButton.Name = "BookMeetingRoomButton";
            BookMeetingRoomButton.Size = new Size(252, 97);
            BookMeetingRoomButton.TabIndex = 7;
            BookMeetingRoomButton.Text = "Book Meeting Room";
            BookMeetingRoomButton.UseVisualStyleBackColor = true;
            BookMeetingRoomButton.Click += BookMeetingRoomButton_Click;
            // 
            // CreateEvent_Button
            // 
            CreateEvent_Button.Location = new Point(139, 597);
            CreateEvent_Button.Margin = new Padding(5);
            CreateEvent_Button.Name = "CreateEvent_Button";
            CreateEvent_Button.Size = new Size(252, 97);
            CreateEvent_Button.TabIndex = 7;
            CreateEvent_Button.Text = "Book and Create Event";
            CreateEvent_Button.UseVisualStyleBackColor = true;
            CreateEvent_Button.Click += bookAndCreateEvent_Button;
            // 
            // date_Button
            // 
            date_Button.Location = new Point(617, 171);
            date_Button.Name = "date_Button";
            date_Button.Size = new Size(406, 47);
            date_Button.TabIndex = 8;
            date_Button.ValueChanged += date_Button_ValueChanged;
            // 
            // locationDropDownBox
            // 
            locationDropDownBox.FormattingEnabled = true;
            locationDropDownBox.Location = new Point(619, 459);
            locationDropDownBox.Name = "locationDropDownBox";
            locationDropDownBox.Size = new Size(302, 49);
            locationDropDownBox.TabIndex = 9;
            locationDropDownBox.SelectedIndexChanged += locationDropDownBox_SelectedIndexChanged;
            // 
            // endTimeComboBox
            // 
            endTimeComboBox.FormattingEnabled = true;
            endTimeComboBox.Location = new Point(617, 366);
            endTimeComboBox.Name = "endTimeComboBox";
            endTimeComboBox.Size = new Size(302, 49);
            endTimeComboBox.TabIndex = 10;
            // 
            // startTimeComboBox
            // 
            startTimeComboBox.FormattingEnabled = true;
            startTimeComboBox.Location = new Point(617, 272);
            startTimeComboBox.Name = "startTimeComboBox";
            startTimeComboBox.Size = new Size(302, 49);
            startTimeComboBox.TabIndex = 11;
            // 
            // NewBookingForEmployee
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 738);
            Controls.Add(startTimeComboBox);
            Controls.Add(endTimeComboBox);
            Controls.Add(locationDropDownBox);
            Controls.Add(date_Button);
            Controls.Add(CreateEvent_Button);
            Controls.Add(BookMeetingRoomButton);
            Controls.Add(LocationLable);
            Controls.Add(endTimePicker);
            Controls.Add(startTimeLable);
            Controls.Add(dateLable);
            Controls.Add(createBookingLable);
            Margin = new Padding(5);
            Name = "NewBookingForEmployee";
            Text = "NewBookingForEmployee";
            Load += newEmployeeBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createBookingLable;
        private Label dateLable;
        private Label startTimeLable;
        private Label endTimePicker;
        private Label LocationLable;
        private Button BookMeetingRoomButton;
        private Button CreateEvent_Button;
        private DateTimePicker date_Button;
        private ComboBox locationDropDownBox;
        private ComboBox endTimeComboBox;
        private ComboBox startTimeComboBox;
    }
}