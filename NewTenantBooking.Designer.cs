namespace nitutz
{
    partial class NewTenantBooking
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
            DatePicker = new DateTimePicker();
            startTimeLable = new Label();
            endTimeLable = new Label();
            label1 = new Label();
            BookMeetingButton = new Button();
            startTimeComboBox = new ComboBox();
            endTimeComboBox = new ComboBox();
            BackButton = new Button();
            locationComboBox = new ComboBox();
            SuspendLayout();
            // 
            // createBookingLable
            // 
            createBookingLable.AutoSize = true;
            createBookingLable.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            createBookingLable.Location = new Point(400, 38);
            createBookingLable.Margin = new Padding(5, 0, 5, 0);
            createBookingLable.Name = "createBookingLable";
            createBookingLable.Size = new Size(580, 89);
            createBookingLable.TabIndex = 0;
            createBookingLable.Text = "Create Booking";
            // 
            // dateLable
            // 
            dateLable.AutoSize = true;
            dateLable.Location = new Point(199, 176);
            dateLable.Margin = new Padding(5, 0, 5, 0);
            dateLable.Name = "dateLable";
            dateLable.Size = new Size(86, 40);
            dateLable.TabIndex = 1;
            dateLable.Text = "Date:";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(400, 175);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(598, 47);
            DatePicker.TabIndex = 14;
            DatePicker.ValueChanged += DatePicker_ValueChanged;
            // 
            // startTimeLable
            // 
            startTimeLable.AutoSize = true;
            startTimeLable.Location = new Point(199, 280);
            startTimeLable.Margin = new Padding(5, 0, 5, 0);
            startTimeLable.Name = "startTimeLable";
            startTimeLable.Size = new Size(158, 40);
            startTimeLable.TabIndex = 3;
            startTimeLable.Text = "Start Time:";
            // 
            // endTimeLable
            // 
            endTimeLable.AutoSize = true;
            endTimeLable.Location = new Point(199, 380);
            endTimeLable.Margin = new Padding(5, 0, 5, 0);
            endTimeLable.Name = "endTimeLable";
            endTimeLable.Size = new Size(144, 40);
            endTimeLable.TabIndex = 5;
            endTimeLable.Text = "End Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 480);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 40);
            label1.TabIndex = 7;
            label1.Text = "Location:";
            // 
            // BookMeetingButton
            // 
            BookMeetingButton.BackColor = SystemColors.ControlDarkDark;
            BookMeetingButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BookMeetingButton.ForeColor = SystemColors.Window;
            BookMeetingButton.Location = new Point(1082, 568);
            BookMeetingButton.Margin = new Padding(5);
            BookMeetingButton.Name = "BookMeetingButton";
            BookMeetingButton.Size = new Size(245, 100);
            BookMeetingButton.TabIndex = 9;
            BookMeetingButton.Text = "Book Meeting Room";
            BookMeetingButton.UseVisualStyleBackColor = false;
            BookMeetingButton.Click += button1_Click;
            // 
            // startTimeComboBox
            // 
            startTimeComboBox.FormattingEnabled = true;
            startTimeComboBox.Location = new Point(400, 276);
            startTimeComboBox.Name = "startTimeComboBox";
            startTimeComboBox.Size = new Size(307, 48);
            startTimeComboBox.TabIndex = 10;
            // 
            // endTimeComboBox
            // 
            endTimeComboBox.FormattingEnabled = true;
            endTimeComboBox.Location = new Point(400, 376);
            endTimeComboBox.Name = "endTimeComboBox";
            endTimeComboBox.Size = new Size(307, 48);
            endTimeComboBox.TabIndex = 11;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDarkDark;
            BackButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.Window;
            BackButton.Location = new Point(792, 568);
            BackButton.Margin = new Padding(5);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(245, 100);
            BackButton.TabIndex = 12;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // locationComboBox
            // 
            locationComboBox.Location = new Point(400, 476);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(307, 48);
            locationComboBox.TabIndex = 13;
            // 
            // NewTenantBooking
            // 
            AutoScaleDimensions = new SizeF(17F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1360, 720);
            Controls.Add(BackButton);
            Controls.Add(endTimeComboBox);
            Controls.Add(startTimeComboBox);
            Controls.Add(BookMeetingButton);
            Controls.Add(locationComboBox);
            Controls.Add(label1);
            Controls.Add(endTimeLable);
            Controls.Add(startTimeLable);
            Controls.Add(DatePicker);
            Controls.Add(dateLable);
            Controls.Add(createBookingLable);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "NewTenantBooking";
            Text = "NewTenantBooking";
            Load += NewTenantBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewTenantBooking_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private Label createBookingLable;
        private Label dateLable;
        private DateTimePicker DatePicker;
        private Label startTimeLable;
        private Label endTimeLable;
        private Label label1;
        private Button BookMeetingButton;
        private ComboBox startTimeComboBox;
        private ComboBox endTimeComboBox;
        private Button BackButton;
        private ComboBox locationComboBox;
    }
}