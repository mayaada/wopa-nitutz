namespace nitutz
{
    partial class TenantDetailsForEmployee
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
            CompanyNameLabel = new Label();
            companyName = new TextBox();
            email = new TextBox();
            emailLabel = new Label();
            label1 = new Label();
            TenantSearchTextBox = new TextBox();
            button1 = new Button();
            numberOfEmployeesLabel = new Label();
            NumberOfEmployees = new TextBox();
            Lease = new Label();
            viewLeaseButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Location = new Point(114, 167);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(145, 25);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "Company Name:";
            CompanyNameLabel.Click += label1_Click_1;
            // 
            // companyName
            // 
            companyName.Location = new Point(379, 176);
            companyName.Name = "companyName";
            companyName.Size = new Size(212, 31);
            companyName.TabIndex = 2;
            companyName.TextChanged += textBox2_TextChanged_1;
            // 
            // email
            // 
            email.Location = new Point(379, 220);
            email.Name = "email";
            email.Size = new Size(212, 31);
            email.TabIndex = 3;
            email.TextChanged += email_TextChanged;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(114, 220);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 25);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            emailLabel.Click += label1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 36);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 5;
            label1.Text = "Search For Tenant:";
            label1.Click += label1_Click_3;
            // 
            // TenantSearchTextBox
            // 
            TenantSearchTextBox.Location = new Point(283, 41);
            TenantSearchTextBox.Name = "TenantSearchTextBox";
            TenantSearchTextBox.Size = new Size(255, 31);
            TenantSearchTextBox.TabIndex = 6;
            TenantSearchTextBox.TextChanged += TenantSearchTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(585, 41);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 7;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += searchTenant_Button;
            // 
            // numberOfEmployeesLabel
            // 
            numberOfEmployeesLabel.AutoSize = true;
            numberOfEmployeesLabel.Location = new Point(114, 278);
            numberOfEmployeesLabel.Name = "numberOfEmployeesLabel";
            numberOfEmployeesLabel.Size = new Size(197, 25);
            numberOfEmployeesLabel.TabIndex = 9;
            numberOfEmployeesLabel.Text = "Number Of Employees:";
            // 
            // NumberOfEmployees
            // 
            NumberOfEmployees.Location = new Point(379, 278);
            NumberOfEmployees.Name = "NumberOfEmployees";
            NumberOfEmployees.Size = new Size(212, 31);
            NumberOfEmployees.TabIndex = 8;
            // 
            // Lease
            // 
            Lease.AutoSize = true;
            Lease.Location = new Point(234, 402);
            Lease.Name = "Lease";
            Lease.Size = new Size(59, 25);
            Lease.TabIndex = 10;
            Lease.Text = "Lease:";
            // 
            // viewLeaseButton
            // 
            viewLeaseButton.Location = new Point(379, 390);
            viewLeaseButton.Name = "viewLeaseButton";
            viewLeaseButton.Size = new Size(172, 48);
            viewLeaseButton.TabIndex = 11;
            viewLeaseButton.Text = "View Lease";
            viewLeaseButton.UseVisualStyleBackColor = true;
            viewLeaseButton.Click += viewLeaseButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(292, 96);
            label2.Name = "label2";
            label2.Size = new Size(246, 40);
            label2.TabIndex = 12;
            label2.Text = "Tenant Details";
            // 
            // TenantDetailsForEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(viewLeaseButton);
            Controls.Add(Lease);
            Controls.Add(numberOfEmployeesLabel);
            Controls.Add(NumberOfEmployees);
            Controls.Add(button1);
            Controls.Add(TenantSearchTextBox);
            Controls.Add(label1);
            Controls.Add(emailLabel);
            Controls.Add(email);
            Controls.Add(companyName);
            Controls.Add(CompanyNameLabel);
            Name = "TenantDetailsForEmployee";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CompanyNameLabel;
        private TextBox companyName;
        private TextBox email;
        private Label emailLabel;
        private Label label1;
        private TextBox TenantSearchTextBox;
        private Button button1;
        private Label numberOfEmployeesLabel;
        private TextBox NumberOfEmployees;
        private Label Lease;
        private Button viewLeaseButton;
        private Label label2;
    }
}