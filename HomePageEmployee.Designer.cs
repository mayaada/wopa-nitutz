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
            button6 = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ExistingEvents_Buttons
            // 
            ExistingEvents_Buttons.Location = new Point(822, 265);
            ExistingEvents_Buttons.Name = "ExistingEvents_Buttons";
            ExistingEvents_Buttons.Size = new Size(215, 94);
            ExistingEvents_Buttons.TabIndex = 2;
            ExistingEvents_Buttons.Text = "Existing Events";
            ExistingEvents_Buttons.UseVisualStyleBackColor = true;
            ExistingEvents_Buttons.Click += button3_Click;
            // 
            // bookigsAndEvents_Click
            // 
            BookingAndEvents_Button.Location = new Point(300, 514);
            BookingAndEvents_Button.Name = "bookigsAndEvents_Click";
            BookingAndEvents_Button.Size = new Size(190, 110);
            BookingAndEvents_Button.TabIndex = 3;
            BookingAndEvents_Button.Text = "Bookings And Events";
            BookingAndEvents_Button.UseVisualStyleBackColor = true;
            BookingAndEvents_Button.Click += bookigsAndEvents_Click;
            // 
            // button5
            // 
            button5.Location = new Point(300, 399);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "Leads";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(822, 399);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(126, 67);
            button6.TabIndex = 5;
            button6.Text = "Maintenance Tickets";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(261, 44);
            label1.Name = "label1";
            label1.Size = new Size(196, 40);
            label1.TabIndex = 6;
            label1.Text = "Home Page";
            // 
            // button1
            // 
            button1.Location = new Point(300, 265);
            button1.Name = "button1";
            button1.Size = new Size(190, 63);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 820);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(BookingAndEvents_Button);
            Controls.Add(ExistingEvents_Buttons);
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
        private Button button6;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}