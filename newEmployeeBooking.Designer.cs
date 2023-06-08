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
            datePicker = new DateTimePicker();
            startTimeLable = new Label();
            startTimePicker = new DateTimePicker();
            endTimePicker = new Label();
            userEmailLable = new Label();
            UserEmailTextBok = new TextBox();
            LocationLable = new Label();
            BookMeetingRoomButton = new Button();
            BookEventButton = new Button();
            endTimePicker1 = new DateTimePicker();
            meetingLocationTextBox = new TextBox();
            SuspendLayout();
            // 
            // createBookingLable
            // 
            createBookingLable.AutoSize = true;
            createBookingLable.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            createBookingLable.Location = new Point(233, 9);
            createBookingLable.Name = "createBookingLable";
            createBookingLable.Size = new Size(348, 53);
            createBookingLable.TabIndex = 0;
            createBookingLable.Text = "Create Booking";
            // 
            // dateLable
            // 
            dateLable.AutoSize = true;
            dateLable.Location = new Point(250, 96);
            dateLable.Name = "dateLable";
            dateLable.Size = new Size(53, 25);
            dateLable.TabIndex = 1;
            dateLable.Text = "Date:";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(364, 96);
            datePicker.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            datePicker.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(300, 31);
            datePicker.TabIndex = 2;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // startTimeLable
            // 
            startTimeLable.AutoSize = true;
            startTimeLable.Location = new Point(250, 154);
            startTimeLable.Name = "startTimeLable";
            startTimeLable.Size = new Size(95, 25);
            startTimeLable.TabIndex = 3;
            startTimeLable.Text = "Start Time:";
            // 
            // startTimePicker
            // 
            startTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.Location = new Point(364, 154);
            startTimePicker.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            startTimePicker.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.Size = new Size(124, 31);
            startTimePicker.TabIndex = 2;
            startTimePicker.ValueChanged += startTimePicker_ValueChanged;
            // 
            // endTimePicker
            // 
            endTimePicker.AutoSize = true;
            endTimePicker.Location = new Point(250, 209);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(89, 25);
            endTimePicker.TabIndex = 3;
            endTimePicker.Text = "End Time:";
            // 
            // userEmailLable
            // 
            userEmailLable.AutoSize = true;
            userEmailLable.Location = new Point(250, 267);
            userEmailLable.Name = "userEmailLable";
            userEmailLable.Size = new Size(98, 25);
            userEmailLable.TabIndex = 3;
            userEmailLable.Text = "User Email:";
            userEmailLable.Click += userEmailLable_Click;
            // 
            // UserEmailTextBok
            // 
            UserEmailTextBok.Location = new Point(364, 261);
            UserEmailTextBok.Name = "UserEmailTextBok";
            UserEmailTextBok.Size = new Size(150, 31);
            UserEmailTextBok.TabIndex = 4;
            // 
            // LocationLable
            // 
            LocationLable.AutoSize = true;
            LocationLable.Location = new Point(250, 322);
            LocationLable.Name = "LocationLable";
            LocationLable.Size = new Size(79, 25);
            LocationLable.TabIndex = 6;
            LocationLable.Text = "Location";
            // 
            // BookMeetingRoomButton
            // 
            BookMeetingRoomButton.Location = new Point(590, 364);
            BookMeetingRoomButton.Name = "BookMeetingRoomButton";
            BookMeetingRoomButton.Size = new Size(148, 59);
            BookMeetingRoomButton.TabIndex = 7;
            BookMeetingRoomButton.Text = "Book Meeting Room";
            BookMeetingRoomButton.UseVisualStyleBackColor = true;
            BookMeetingRoomButton.Click += BookMeetingRoomButton_Click;
            // 
            // BookEventButton
            // 
            BookEventButton.Location = new Point(82, 364);
            BookEventButton.Name = "BookEventButton";
            BookEventButton.Size = new Size(148, 59);
            BookEventButton.TabIndex = 7;
            BookEventButton.Text = "Book Event";
            BookEventButton.UseVisualStyleBackColor = true;
            BookEventButton.Click += BookEventButton_Click;
            // 
            // endTimePicker1
            // 
            endTimePicker1.Format = DateTimePickerFormat.Time;
            endTimePicker1.Location = new Point(364, 209);
            endTimePicker1.MaxDate = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            endTimePicker1.MinDate = new DateTime(2023, 6, 1, 0, 0, 0, 0);
            endTimePicker1.Name = "endTimePicker1";
            endTimePicker1.Size = new Size(124, 31);
            endTimePicker1.TabIndex = 2;
            // 
            // meetingLocationTextBox
            // 
            meetingLocationTextBox.Location = new Point(364, 319);
            meetingLocationTextBox.Name = "meetingLocationTextBox";
            meetingLocationTextBox.Size = new Size(150, 31);
            meetingLocationTextBox.TabIndex = 4;
            meetingLocationTextBox.TextChanged += textBox1_TextChanged;
            // 
            // newEmployeeBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookEventButton);
            Controls.Add(BookMeetingRoomButton);
            Controls.Add(LocationLable);
            Controls.Add(meetingLocationTextBox);
            Controls.Add(UserEmailTextBok);
            Controls.Add(userEmailLable);
            Controls.Add(endTimePicker);
            Controls.Add(startTimeLable);
            Controls.Add(endTimePicker1);
            Controls.Add(startTimePicker);
            Controls.Add(datePicker);
            Controls.Add(dateLable);
            Controls.Add(createBookingLable);
            Name = "newEmployeeBooking";
            Text = "newEmployeeBooking";
            Load += newEmployeeBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createBookingLable;
        private Label dateLable;
        private DateTimePicker datePicker;
        private Label startTimeLable;
        private DateTimePicker startTimePicker;
        private Label endTimePicker;
        private Label userEmailLable;
        private TextBox UserEmailTextBok;
        private Label LocationLable;
        private Button BookMeetingRoomButton;
        private Button BookEventButton;
        private DateTimePicker endTimePicker1;
        private TextBox meetingLocationTextBox;
    }
}