namespace nitutz
{
    partial class newEmployeeBooking
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
            startTimePicker = new DateTimePicker();
            endTimePicker = new Label();
            LocationLable = new Label();
            BookMeetingRoomButton = new Button();
            CreateEvent_Button = new Button();
            endTimePicker1 = new DateTimePicker();
            date_Button = new DateTimePicker();
            locationDropDownBox = new ComboBox();
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
            // startTimePicker
            // 
            startTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.Location = new Point(619, 276);
            startTimePicker.Margin = new Padding(5);
            startTimePicker.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            startTimePicker.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(252, 47);
            startTimePicker.TabIndex = 2;
            startTimePicker.ValueChanged += startTimePicker_ValueChanged;
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
            // endTimePicker1
            // 
            endTimePicker1.Format = DateTimePickerFormat.Time;
            endTimePicker1.Location = new Point(619, 370);
            endTimePicker1.Margin = new Padding(5);
            endTimePicker1.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            endTimePicker1.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            endTimePicker1.Name = "endTimePicker1";
            endTimePicker1.Size = new Size(252, 47);
            endTimePicker1.TabIndex = 2;
            // 
            // date_Button
            // 
            date_Button.Location = new Point(617, 171);
            date_Button.Name = "date_Button";
            date_Button.Size = new Size(406, 47);
            date_Button.TabIndex = 8;
            // 
            // locationDropDownBox
            // 
            locationDropDownBox.FormattingEnabled = true;
            locationDropDownBox.Location = new Point(619, 461);
            locationDropDownBox.Name = "locationDropDownBox";
            locationDropDownBox.Size = new Size(302, 49);
            locationDropDownBox.TabIndex = 9;
            locationDropDownBox.SelectedIndexChanged += locationDropDownBox_SelectedIndexChanged;
            // 
            // newEmployeeBooking
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 738);
            Controls.Add(locationDropDownBox);
            Controls.Add(date_Button);
            Controls.Add(CreateEvent_Button);
            Controls.Add(BookMeetingRoomButton);
            Controls.Add(LocationLable);
            Controls.Add(endTimePicker);
            Controls.Add(startTimeLable);
            Controls.Add(endTimePicker1);
            Controls.Add(startTimePicker);
            Controls.Add(dateLable);
            Controls.Add(createBookingLable);
            Margin = new Padding(5);
            Name = "newEmployeeBooking";
            Text = "newEmployeeBooking";
            Load += newEmployeeBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createBookingLable;
        private Label dateLable;
        private Label startTimeLable;
        private DateTimePicker startTimePicker;
        private Label endTimePicker;
        private Label LocationLable;
        private Button BookMeetingRoomButton;
        private Button CreateEvent_Button;
        private DateTimePicker endTimePicker1;
        private DateTimePicker date_Button;
        private ComboBox locationDropDownBox;
    }
}