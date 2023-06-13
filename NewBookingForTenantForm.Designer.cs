namespace nitutz
{
    partial class NewBookingForTenantForm
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
            DateLabel = new Label();
            StarDatecomboBox1 = new ComboBox();
            EndDatecomboBox1 = new ComboBox();
            LocationcomboBox1 = new ComboBox();
            BookMeetingRoomButton = new Button();
            BackButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            NewBooking = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(63, 102);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(50, 24);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Date:";
            // 
            // StarDatecomboBox1
            // 
            StarDatecomboBox1.FormattingEnabled = true;
            StarDatecomboBox1.Location = new Point(149, 167);
            StarDatecomboBox1.Name = "StarDatecomboBox1";
            StarDatecomboBox1.Size = new Size(166, 33);
            StarDatecomboBox1.TabIndex = 2;
            StarDatecomboBox1.SelectedIndexChanged += StarDatecomboBox1_SelectedIndexChanged;
            // 
            // EndDatecomboBox1
            // 
            EndDatecomboBox1.FormattingEnabled = true;
            EndDatecomboBox1.Location = new Point(150, 229);
            EndDatecomboBox1.Name = "EndDatecomboBox1";
            EndDatecomboBox1.Size = new Size(165, 33);
            EndDatecomboBox1.TabIndex = 3;
            EndDatecomboBox1.SelectedIndexChanged += EndDatecomboBox1_SelectedIndexChanged;
            // 
            // LocationcomboBox1
            // 
            LocationcomboBox1.FormattingEnabled = true;
            LocationcomboBox1.Location = new Point(150, 282);
            LocationcomboBox1.Name = "LocationcomboBox1";
            LocationcomboBox1.Size = new Size(218, 33);
            LocationcomboBox1.TabIndex = 4;
            LocationcomboBox1.SelectedIndexChanged += LocationcomboBox1_SelectedIndexChanged;
            // 
            // BookMeetingRoomButton
            // 
            BookMeetingRoomButton.BackColor = SystemColors.ControlDarkDark;
            BookMeetingRoomButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BookMeetingRoomButton.ForeColor = Color.White;
            BookMeetingRoomButton.Location = new Point(592, 282);
            BookMeetingRoomButton.Name = "BookMeetingRoomButton";
            BookMeetingRoomButton.Size = new Size(174, 97);
            BookMeetingRoomButton.TabIndex = 5;
            BookMeetingRoomButton.Text = "Book Meeting Room";
            BookMeetingRoomButton.UseVisualStyleBackColor = false;
            BookMeetingRoomButton.Click += BookMeetingRoomButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = SystemColors.ControlDarkDark;
            BackButton.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(33, 25);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(83, 32);
            BackButton.TabIndex = 6;
            BackButton.Text = "back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // NewBooking
            // 
            NewBooking.AutoSize = true;
            NewBooking.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NewBooking.Location = new Point(258, 25);
            NewBooking.Name = "NewBooking";
            NewBooking.Size = new Size(221, 40);
            NewBooking.TabIndex = 8;
            NewBooking.Text = "New Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 171);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 9;
            label1.Text = "Start Time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 232);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 10;
            label2.Text = "End Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 290);
            label3.Name = "label3";
            label3.Size = new Size(78, 24);
            label3.TabIndex = 11;
            label3.Text = "Location";
            // 
            // NewBookingForTenantForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NewBooking);
            Controls.Add(dateTimePicker1);
            Controls.Add(BackButton);
            Controls.Add(BookMeetingRoomButton);
            Controls.Add(LocationcomboBox1);
            Controls.Add(EndDatecomboBox1);
            Controls.Add(StarDatecomboBox1);
            Controls.Add(DateLabel);
            ForeColor = Color.Black;
            Name = "NewBookingForTenantForm";
            Text = "NewBookingForTenantForm";
            Load += NewBookingForTenantForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private ComboBox StarDatecomboBox1;
        private ComboBox EndDatecomboBox1;
        private ComboBox LocationcomboBox1;
        private Button BookMeetingRoomButton;
        private Button BackButton;
        private DateTimePicker dateTimePicker1;
        private Label NewBooking;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}