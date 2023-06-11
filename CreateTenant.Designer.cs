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
            AddNewTenantLabel.BackColor = SystemColors.ButtonFace;
            AddNewTenantLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewTenantLabel.Location = new Point(235, 55);
            AddNewTenantLabel.Name = "AddNewTenantLabel";
            AddNewTenantLabel.Size = new Size(272, 37);
            AddNewTenantLabel.TabIndex = 0;
            AddNewTenantLabel.Text = "Add New Tenant";
            AddNewTenantLabel.Click += AddNewTenantLabel_Click;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNameLabel.Location = new Point(59, 150);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(150, 21);
            CompanyNameLabel.TabIndex = 1;
            CompanyNameLabel.Text = "Company Name";
            CompanyNameLabel.Click += CompanyNameLabel_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailLabel.Location = new Point(59, 193);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(59, 21);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email";
            // 
            // WebsiteLabel
            // 
            WebsiteLabel.AutoSize = true;
            WebsiteLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WebsiteLabel.Location = new Point(59, 230);
            WebsiteLabel.Name = "WebsiteLabel";
            WebsiteLabel.Size = new Size(81, 21);
            WebsiteLabel.TabIndex = 3;
            WebsiteLabel.Text = "Website";
            // 
            // NumEmpLabel
            // 
            NumEmpLabel.AutoSize = true;
            NumEmpLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumEmpLabel.Location = new Point(57, 274);
            NumEmpLabel.Name = "NumEmpLabel";
            NumEmpLabel.Size = new Size(208, 21);
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
            AddTenantButton.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddTenantButton.Location = new Point(289, 320);
            AddTenantButton.Name = "AddTenantButton";
            AddTenantButton.Size = new Size(144, 46);
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
            // Backbutton
            // 
            Backbutton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Backbutton.Location = new Point(22, 18);
            Backbutton.Name = "Backbutton";
            Backbutton.Size = new Size(72, 32);
            Backbutton.TabIndex = 11;
            Backbutton.Text = "Back";
            Backbutton.UseVisualStyleBackColor = true;
            Backbutton.Click += Backbutton_Click;
            // 
            // CreateTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
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