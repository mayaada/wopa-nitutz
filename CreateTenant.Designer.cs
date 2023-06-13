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
            Backbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // AddNewTenantLabel
            // 
            AddNewTenantLabel.AutoSize = true;
            AddNewTenantLabel.BackColor = SystemColors.InactiveCaption;
            AddNewTenantLabel.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewTenantLabel.Location = new Point(231, 26);
            AddNewTenantLabel.Name = "AddNewTenantLabel";
            AddNewTenantLabel.Size = new Size(357, 53);
            AddNewTenantLabel.TabIndex = 0;
            AddNewTenantLabel.Text = "Add New Tenant";
            AddNewTenantLabel.Click += AddNewTenantLabel_Click;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNameLabel.Location = new Point(59, 110);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(141, 25);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "Company Name";
            CompanyNameLabel.Click += CompanyNameLabel_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(59, 160);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email";
            // 
            // WebsiteLabel
            // 
            WebsiteLabel.AutoSize = true;
            WebsiteLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WebsiteLabel.Location = new Point(59, 213);
            WebsiteLabel.Name = "WebsiteLabel";
            WebsiteLabel.Size = new Size(75, 25);
            WebsiteLabel.TabIndex = 3;
            WebsiteLabel.Text = "Website";
            // 
            // NumEmpLabel
            // 
            NumEmpLabel.AutoSize = true;
            NumEmpLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumEmpLabel.Location = new Point(59, 266);
            NumEmpLabel.Name = "NumEmpLabel";
            NumEmpLabel.Size = new Size(193, 25);
            NumEmpLabel.TabIndex = 4;
            NumEmpLabel.Text = "Number Of Employees";
            NumEmpLabel.Click += NumEmpLabel_Click;
            // 
            // CompanyNameTB
            // 
            CompanyNameTB.Location = new Point(268, 104);
            CompanyNameTB.Margin = new Padding(3, 2, 3, 2);
            CompanyNameTB.Name = "CompanyNameTB";
            CompanyNameTB.Size = new Size(220, 27);
            CompanyNameTB.TabIndex = 5;
            CompanyNameTB.TextChanged += CompanyNameTB_TextChanged;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(268, 154);
            EmailTB.Margin = new Padding(3, 2, 3, 2);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(220, 27);
            EmailTB.TabIndex = 6;
            EmailTB.TextChanged += EmailTB_TextChanged;
            // 
            // WebsiteTB
            // 
            WebsiteTB.Location = new Point(268, 207);
            WebsiteTB.Margin = new Padding(3, 2, 3, 2);
            WebsiteTB.Name = "WebsiteTB";
            WebsiteTB.Size = new Size(220, 27);
            WebsiteTB.TabIndex = 7;
            WebsiteTB.TextChanged += WebsiteTB_TextChanged;
            // 
            // AddTenantButton
            // 
            AddTenantButton.BackColor = SystemColors.ControlDarkDark;
            AddTenantButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddTenantButton.ForeColor = SystemColors.Window;
            AddTenantButton.Location = new Point(293, 311);
            AddTenantButton.Margin = new Padding(3, 2, 3, 2);
            AddTenantButton.Name = "AddTenantButton";
            AddTenantButton.Size = new Size(180, 73);
            AddTenantButton.TabIndex = 9;
            AddTenantButton.Text = "Add Tenat";
            AddTenantButton.UseVisualStyleBackColor = false;
            AddTenantButton.Click += AddTenantButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(268, 260);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(222, 27);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Backbutton
            // 
            Backbutton.BackColor = SystemColors.ControlDarkDark;
            Backbutton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Backbutton.ForeColor = SystemColors.Window;
            Backbutton.Location = new Point(22, 14);
            Backbutton.Margin = new Padding(3, 2, 3, 2);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(84, 41);
            Backbutton.TabIndex = 11;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = false;
            Backbutton.Click += Backbutton_Click;
            // 
            // CreateTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(809, 395);
            Controls.Add(Backbutton);
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
            Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.InactiveCaptionText;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button Backbutton;
    }
}