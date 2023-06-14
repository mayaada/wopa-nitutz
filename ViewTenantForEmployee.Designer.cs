namespace nitutz
{
    partial class ViewTenantForEmployee
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
            Searchbutton1 = new Button();
            label1 = new Label();
            CompanytextBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ViewLeasebutton1 = new Button();
            button1 = new Button();
            EmailtextBox4 = new TextBox();
            NOEtextBox4 = new TextBox();
            CompanyNameTEXTBOX = new TextBox();
            SuspendLayout();
            // 
            // Searchbutton1
            // 
            Searchbutton1.BackColor = SystemColors.ControlDarkDark;
            Searchbutton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Searchbutton1.ForeColor = SystemColors.Window;
            Searchbutton1.Location = new Point(559, 72);
            Searchbutton1.Name = "Searchbutton1";
            Searchbutton1.Size = new Size(112, 34);
            Searchbutton1.TabIndex = 0;
            Searchbutton1.Text = "Search";
            Searchbutton1.UseVisualStyleBackColor = false;
            Searchbutton1.Click += Searchbutton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 77);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 1;
            label1.Text = "Search For Tenant:";
            // 
            // CompanytextBox1
            // 
            CompanytextBox1.Location = new Point(321, 74);
            CompanytextBox1.Name = "CompanytextBox1";
            CompanytextBox1.Size = new Size(174, 31);
            CompanytextBox1.TabIndex = 2;
            CompanytextBox1.TextChanged += CompanytextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(345, 137);
            label2.Name = "label2";
            label2.Size = new Size(192, 31);
            label2.TabIndex = 3;
            label2.Text = "Tenant Details";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 197);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 4;
            label3.Text = "Company Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 318);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 5;
            label4.Text = "Number Of Employee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 249);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // ViewLeasebutton1
            // 
            ViewLeasebutton1.BackColor = SystemColors.ControlDarkDark;
            ViewLeasebutton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ViewLeasebutton1.ForeColor = SystemColors.Window;
            ViewLeasebutton1.Location = new Point(359, 368);
            ViewLeasebutton1.Name = "ViewLeasebutton1";
            ViewLeasebutton1.Size = new Size(139, 55);
            ViewLeasebutton1.TabIndex = 10;
            ViewLeasebutton1.Text = "View Lease";
            ViewLeasebutton1.UseVisualStyleBackColor = false;
            ViewLeasebutton1.Click += ViewLeasebutton1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(95, 44);
            button1.TabIndex = 11;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EmailtextBox4
            // 
            EmailtextBox4.Location = new Point(450, 249);
            EmailtextBox4.Name = "EmailtextBox4";
            EmailtextBox4.Size = new Size(150, 31);
            EmailtextBox4.TabIndex = 13;
            EmailtextBox4.TextChanged += EmailtextBox4_TextChanged;
            // 
            // NOEtextBox4
            // 
            NOEtextBox4.Location = new Point(450, 315);
            NOEtextBox4.Name = "NOEtextBox4";
            NOEtextBox4.Size = new Size(150, 31);
            NOEtextBox4.TabIndex = 14;
            NOEtextBox4.TextChanged += NOEtextBox4_TextChanged;
            // 
            // CompanyNameTEXTBOX
            // 
            CompanyNameTEXTBOX.Location = new Point(450, 197);
            CompanyNameTEXTBOX.Name = "CompanyNameTEXTBOX";
            CompanyNameTEXTBOX.Size = new Size(141, 31);
            CompanyNameTEXTBOX.TabIndex = 15;
            CompanyNameTEXTBOX.TextChanged += CompanyNameTEXTBOX_TextChanged;
            // 
            // ViewTenantForEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(CompanyNameTEXTBOX);
            Controls.Add(NOEtextBox4);
            Controls.Add(EmailtextBox4);
            Controls.Add(button1);
            Controls.Add(ViewLeasebutton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CompanytextBox1);
            Controls.Add(label1);
            Controls.Add(Searchbutton1);
            Name = "ViewTenantForEmployee";
            Text = "ViewTenantForEmployee";
            Load += ViewTenantForEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Searchbutton1;
        private Label label1;
        private TextBox CompanytextBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button ViewLeasebutton1;
        private Button button1;
        private TextBox EmailtextBox4;
        private TextBox NOEtextBox4;
        private TextBox CompanyNameTEXTBOX;
    }
}