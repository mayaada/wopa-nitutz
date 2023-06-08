namespace nitutz
{
    partial class CreateTenant
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
            AddNewTenantLabel = new Label();
            CompanyNameLabel = new Label();
            EmailLabel = new Label();
            WebsiteLabel = new Label();
            NumEmpLabel = new Label();
            CompanyNameTB = new TextBox();
            EmailTB = new TextBox();
            WebsiteTB = new TextBox();
            AddTenantButton = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // AddNewTenantLabel
            // 
            AddNewTenantLabel.AutoSize = true;
            AddNewTenantLabel.Location = new Point(310, 39);
            AddNewTenantLabel.Name = "AddNewTenantLabel";
            AddNewTenantLabel.Size = new Size(142, 25);
            AddNewTenantLabel.TabIndex = 0;
            AddNewTenantLabel.Text = "Add New Tenant";
            AddNewTenantLabel.Click += AddNewTenantLabel_Click;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Location = new Point(59, 150);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(141, 25);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "Company Name";
            CompanyNameLabel.Click += CompanyNameLabel_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(59, 187);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email";
            // 
            // WebsiteLabel
            // 
            WebsiteLabel.AutoSize = true;
            WebsiteLabel.Location = new Point(59, 224);
            WebsiteLabel.Name = "WebsiteLabel";
            WebsiteLabel.Size = new Size(75, 25);
            WebsiteLabel.TabIndex = 3;
            WebsiteLabel.Text = "Website";
            // 
            // NumEmpLabel
            // 
            NumEmpLabel.AutoSize = true;
            NumEmpLabel.Location = new Point(59, 261);
            NumEmpLabel.Name = "NumEmpLabel";
            NumEmpLabel.Size = new Size(193, 25);
            NumEmpLabel.TabIndex = 4;
            NumEmpLabel.Text = "Number Of Employees";
            NumEmpLabel.Click += NumEmpLabel_Click;
            // 
            // CompanyNameTB
            // 
            CompanyNameTB.Location = new Point(268, 150);
            CompanyNameTB.Name = "CompanyNameTB";
            CompanyNameTB.Size = new Size(184, 31);
            CompanyNameTB.TabIndex = 5;
            CompanyNameTB.TextChanged += CompanyNameTB_TextChanged;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(268, 187);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(184, 31);
            EmailTB.TabIndex = 6;
            EmailTB.TextChanged += EmailTB_TextChanged;
            // 
            // WebsiteTB
            // 
            WebsiteTB.Location = new Point(268, 224);
            WebsiteTB.Name = "WebsiteTB";
            WebsiteTB.Size = new Size(184, 31);
            WebsiteTB.TabIndex = 7;
            WebsiteTB.TextChanged += WebsiteTB_TextChanged;
            // 
            // AddTenantButton
            // 
            AddTenantButton.Location = new Point(130, 325);
            AddTenantButton.Name = "AddTenantButton";
            AddTenantButton.Size = new Size(163, 40);
            AddTenantButton.TabIndex = 9;
            AddTenantButton.Text = "Add Tenat";
            AddTenantButton.UseVisualStyleBackColor = true;
            AddTenantButton.Click += AddTenantButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(271, 269);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(186, 31);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // CreateTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(AddTenantButton);
            Controls.Add(WebsiteTB);
            Controls.Add(EmailTB);
            Controls.Add(CompanyNameTB);
            Controls.Add(NumEmpLabel);
            Controls.Add(WebsiteLabel);
            Controls.Add(EmailLabel);
            Controls.Add(CompanyNameLabel);
            Controls.Add(AddNewTenantLabel);
            Name = "CreateTenant";
            Text = "CreateTenant";
            Load += CreateTenant_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewTenantLabel;
        private Label CompanyNameLabel;
        private Label EmailLabel;
        private Label WebsiteLabel;
        private Label NumEmpLabel;
        private TextBox CompanyNameTB;
        private TextBox EmailTB;
        private TextBox WebsiteTB;
        private Button AddTenantButton;
        private NumericUpDown numericUpDown1;
    }
}