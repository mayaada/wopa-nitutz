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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(311, 215);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(190, 56);
            button1.TabIndex = 0;
            button1.Text = "Tenants";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(898, 310);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(215, 56);
            button2.TabIndex = 1;
            button2.Text = "Leases";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(311, 428);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Size = new Size(190, 110);
            button4.TabIndex = 3;
            button4.Text = "Bookings And Events";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(311, 310);
            button5.Margin = new Padding(5);
            button5.Name = "button5";
            button5.Size = new Size(190, 56);
            button5.TabIndex = 4;
            button5.Text = "Leads";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(898, 428);
            button6.Margin = new Padding(5);
            button6.Name = "button6";
            button6.Size = new Size(215, 110);
            button6.TabIndex = 5;
            button6.Text = "Maintenance Tickets";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(532, 77);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 67);
            label1.TabIndex = 6;
            label1.Text = "Home Page";
            // 
            // button3
            // 
            button3.Location = new Point(898, 215);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Size = new Size(215, 56);
            button3.TabIndex = 2;
            button3.Text = "Events";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HomePageEmployee
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 738);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(5);
            Name = "HomePageEmployee";
            Text = "d";
            Load += HomePageEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button3;
    }
}