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
            button1 = new Button();
            SuspendLayout();
            // 
            // createBookingLable
            // 
            createBookingLable.AutoSize = true;
            createBookingLable.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            createBookingLable.Location = new Point(231, 9);
            createBookingLable.Name = "createBookingLable";
            createBookingLable.Size = new Size(348, 53);
            createBookingLable.TabIndex = 0;
            createBookingLable.Text = "Create Booking";
            // 
            // dateLable
            // 
            dateLable.AutoSize = true;
            dateLable.Location = new Point(250, 104);
            dateLable.Name = "dateLable";
            dateLable.Size = new Size(53, 25);
            dateLable.TabIndex = 1;
            dateLable.Text = "Date:";
            // 
            // startTimeLable
            // 
            startTimeLable.AutoSize = true;
            startTimeLable.Location = new Point(250, 168);
            startTimeLable.Name = "startTimeLable";
            startTimeLable.Size = new Size(95, 25);
            startTimeLable.TabIndex = 3;
            startTimeLable.Text = "Start Time:";
            // 
            // endTimePicker
            // 
            endTimePicker.AutoSize = true;
            endTimePicker.Location = new Point(250, 226);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(89, 25);
            endTimePicker.TabIndex = 3;
            endTimePicker.Text = "End Time:";
            // 
            // LocationLable
            // 
            LocationLable.AutoSize = true;
            LocationLable.Location = new Point(250, 282);
            LocationLable.Name = "LocationLable";
            LocationLable.Size = new Size(83, 25);
            LocationLable.TabIndex = 6;
            LocationLable.Text = "Location:";
            // 
            // BookMeetingRoomButton
            // 
            BookMeetingRoomButton.BackColor = SystemColors.ControlDarkDark;
            BookMeetingRoomButton.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BookMeetingRoomButton.ForeColor = SystemColors.Window;
            BookMeetingRoomButton.Location = new Point(590, 364);
            BookMeetingRoomButton.Name = "BookMeetingRoomButton";
            BookMeetingRoomButton.Size = new Size(148, 59);
            BookMeetingRoomButton.TabIndex = 7;
            BookMeetingRoomButton.Text = "Book Meeting Room";
            BookMeetingRoomButton.UseVisualStyleBackColor = false;
            BookMeetingRoomButton.Click += BookMeetingRoomButton_Click;
            // 
            // CreateEvent_Button
            // 
            CreateEvent_Button.BackColor = SystemColors.ControlDarkDark;
            CreateEvent_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CreateEvent_Button.ForeColor = SystemColors.Window;
            CreateEvent_Button.Location = new Point(82, 364);
            CreateEvent_Button.Name = "CreateEvent_Button";
            CreateEvent_Button.Size = new Size(148, 59);
            CreateEvent_Button.TabIndex = 7;
            CreateEvent_Button.Text = "Book and Create Event";
            CreateEvent_Button.UseVisualStyleBackColor = false;
            CreateEvent_Button.Click += bookAndCreateEvent_Button;
            // 
            // date_Button
            // 
            date_Button.Location = new Point(363, 104);
            date_Button.Margin = new Padding(2);
            date_Button.Name = "date_Button";
            date_Button.Size = new Size(240, 31);
            date_Button.TabIndex = 8;
            date_Button.ValueChanged += date_Button_ValueChanged;
            // 
            // locationDropDownBox
            // 
            locationDropDownBox.FormattingEnabled = true;
            locationDropDownBox.Location = new Point(364, 280);
            locationDropDownBox.Margin = new Padding(2);
            locationDropDownBox.Name = "locationDropDownBox";
            locationDropDownBox.Size = new Size(179, 33);
            locationDropDownBox.TabIndex = 9;
            locationDropDownBox.SelectedIndexChanged += locationDropDownBox_SelectedIndexChanged;
            // 
            // endTimeComboBox
            // 
            endTimeComboBox.FormattingEnabled = true;
            endTimeComboBox.Location = new Point(363, 223);
            endTimeComboBox.Margin = new Padding(2);
            endTimeComboBox.Name = "endTimeComboBox";
            endTimeComboBox.Size = new Size(179, 33);
            endTimeComboBox.TabIndex = 10;
            // 
            // startTimeComboBox
            // 
            startTimeComboBox.FormattingEnabled = true;
            startTimeComboBox.Location = new Point(363, 166);
            startTimeComboBox.Margin = new Padding(2);
            startTimeComboBox.Name = "startTimeComboBox";
            startTimeComboBox.Size = new Size(179, 33);
            startTimeComboBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(21, 27);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NewBookingForEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}