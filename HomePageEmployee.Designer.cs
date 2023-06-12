namespace nitutz
{
    partial class HomePageEmployee
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
            ExistingEvents_Buttons = new Button();
            BookingAndEvents_Button = new Button();
            button5 = new Button();
            maintenanceTickets_Button = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ExistingEvents_Buttons
            // 
            ExistingEvents_Buttons.Location = new Point(929, 292);
            ExistingEvents_Buttons.Margin = new Padding(5);
            ExistingEvents_Buttons.Name = "ExistingEvents_Buttons";
            ExistingEvents_Buttons.Size = new Size(327, 103);
            ExistingEvents_Buttons.TabIndex = 2;
            ExistingEvents_Buttons.Text = "Existing Events";
            ExistingEvents_Buttons.UseVisualStyleBackColor = true;
            ExistingEvents_Buttons.Click += bookigsAndEvents_Click;
            // 
            // BookingAndEvents_Button
            // 
            BookingAndEvents_Button.Location = new Point(241, 693);
            BookingAndEvents_Button.Margin = new Padding(5);
            BookingAndEvents_Button.Name = "BookingAndEvents_Button";
            BookingAndEvents_Button.Size = new Size(323, 110);
            BookingAndEvents_Button.TabIndex = 3;
            BookingAndEvents_Button.Text = "Bookings And Events";
            BookingAndEvents_Button.UseVisualStyleBackColor = true;
            BookingAndEvents_Button.Click += bookigsAndEvents_Click;
            // 
            // button5
            // 
            button5.Location = new Point(241, 494);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(323, 110);
            button5.TabIndex = 4;
            button5.Text = "Leads";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // maintenanceTickets_Button
            // 
            maintenanceTickets_Button.Location = new Point(929, 494);
            maintenanceTickets_Button.Margin = new Padding(8);
            maintenanceTickets_Button.Name = "maintenanceTickets_Button";
            maintenanceTickets_Button.Size = new Size(327, 110);
            maintenanceTickets_Button.TabIndex = 5;
            maintenanceTickets_Button.Text = "Maintenance Tickets";
            maintenanceTickets_Button.UseVisualStyleBackColor = true;
            maintenanceTickets_Button.Click += maintenanceTickets_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(557, 111);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 67);
            label1.TabIndex = 6;
            label1.Text = "Home Page";
            // 
            // button1
            // 
            button1.Location = new Point(241, 279);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(323, 103);
            button1.TabIndex = 7;
            button1.Text = "Tenants";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(479, 220);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Leases";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HomePageEmployee
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 955);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(maintenanceTickets_Button);
            Controls.Add(button5);
            Controls.Add(BookingAndEvents_Button);
            Controls.Add(ExistingEvents_Buttons);
            Margin = new Padding(5);
            Name = "HomePageEmployee";
            Text = "Form1";
            Load += HomePageEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExistingEvents_Buttons;
        private Button BookingAndEvents_Button;
        private Button button5;
        private Button maintenanceTickets_Button;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}