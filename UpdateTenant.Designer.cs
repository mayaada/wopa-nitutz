namespace nitutz
{
    partial class UpdateTenant
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
            UpdateTenantLabel = new Label();
            CompanyNamelabel = new Label();
            CompanyNametextBox = new TextBox();
            SearchCNbutton = new Button();
            EmailLabel = new Label();
            WebsiteLabel = new Label();
            NumOfEmpLabel = new Label();
            EmailtextBox1 = new TextBox();
            WebsitetextBox = new TextBox();
            NumOfEmptextBox1 = new TextBox();
            UpdateButton = new Button();
            IsActivelabel1 = new Label();
            IsActiveTextBox = new TextBox();
            SuspendLayout();
            // 
            // UpdateTenantLabel
            // 
            UpdateTenantLabel.AutoSize = true;
            UpdateTenantLabel.Location = new Point(311, 78);
            UpdateTenantLabel.Name = "UpdateTenantLabel";
            UpdateTenantLabel.Size = new Size(126, 25);
            UpdateTenantLabel.TabIndex = 0;
            UpdateTenantLabel.Text = "Update Tenant";
            UpdateTenantLabel.Click += UpdateTenantLabel_Click;
            // 
            // CompanyNamelabel
            // 
            CompanyNamelabel.AutoSize = true;
            CompanyNamelabel.Location = new Point(133, 133);
            CompanyNamelabel.Name = "CompanyNamelabel";
            CompanyNamelabel.Size = new Size(141, 25);
            CompanyNamelabel.TabIndex = 1;
            CompanyNamelabel.Text = "Company Name";
            CompanyNamelabel.Click += CompanyNamelabel_Click;
            // 
            // CompanyNametextBox
            // 
            CompanyNametextBox.Location = new Point(295, 137);
            CompanyNametextBox.Name = "CompanyNametextBox";
            CompanyNametextBox.Size = new Size(249, 31);
            CompanyNametextBox.TabIndex = 2;
            CompanyNametextBox.TextChanged += CompanyNametextBox_TextChanged;
            // 
            // SearchCNbutton
            // 
            SearchCNbutton.Location = new Point(617, 130);
            SearchCNbutton.Name = "SearchCNbutton";
            SearchCNbutton.Size = new Size(134, 45);
            SearchCNbutton.TabIndex = 3;
            SearchCNbutton.Text = "Search";
            SearchCNbutton.UseVisualStyleBackColor = true;
            SearchCNbutton.Click += SearchCNbutton_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(133, 189);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email";
            // 
            // WebsiteLabel
            // 
            WebsiteLabel.AutoSize = true;
            WebsiteLabel.Location = new Point(133, 235);
            WebsiteLabel.Name = "WebsiteLabel";
            WebsiteLabel.Size = new Size(75, 25);
            WebsiteLabel.TabIndex = 5;
            WebsiteLabel.Text = "Website";
            WebsiteLabel.Click += WebsiteLabel_Click;
            // 
            // NumOfEmpLabel
            // 
            NumOfEmpLabel.AutoSize = true;
            NumOfEmpLabel.Location = new Point(133, 281);
            NumOfEmpLabel.Name = "NumOfEmpLabel";
            NumOfEmpLabel.Size = new Size(193, 25);
            NumOfEmpLabel.TabIndex = 6;
            NumOfEmpLabel.Text = "Number Of Employees";
            // 
            // EmailtextBox1
            // 
            EmailtextBox1.Location = new Point(295, 189);
            EmailtextBox1.Name = "EmailtextBox1";
            EmailtextBox1.Size = new Size(249, 31);
            EmailtextBox1.TabIndex = 7;
            EmailtextBox1.TextChanged += EmailtextBox1_TextChanged;
            // 
            // WebsitetextBox
            // 
            WebsitetextBox.Location = new Point(295, 235);
            WebsitetextBox.Name = "WebsitetextBox";
            WebsitetextBox.Size = new Size(249, 31);
            WebsitetextBox.TabIndex = 8;
            WebsitetextBox.TextChanged += WebsitetextBox_TextChanged;
            // 
            // NumOfEmptextBox1
            // 
            NumOfEmptextBox1.Location = new Point(365, 281);
            NumOfEmptextBox1.Name = "NumOfEmptextBox1";
            NumOfEmptextBox1.Size = new Size(179, 31);
            NumOfEmptextBox1.TabIndex = 9;
            NumOfEmptextBox1.TextChanged += NumOfEmptextBox1_TextChanged;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(622, 355);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(129, 46);
            UpdateButton.TabIndex = 10;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // IsActivelabel1
            // 
            IsActivelabel1.AutoSize = true;
            IsActivelabel1.Location = new Point(133, 336);
            IsActivelabel1.Name = "IsActivelabel1";
            IsActivelabel1.Size = new Size(78, 25);
            IsActivelabel1.TabIndex = 11;
            IsActivelabel1.Text = "Is Active";
            IsActivelabel1.Click += IsActivelabel1_Click;
            // 
            // IsActiveTextBox
            // 
            IsActiveTextBox.Location = new Point(295, 333);
            IsActiveTextBox.Name = "IsActiveTextBox";
            IsActiveTextBox.Size = new Size(249, 31);
            IsActiveTextBox.TabIndex = 12;
            IsActiveTextBox.TextChanged += IsActiveTextBox_TextChanged;
            // 
            // UpdateTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IsActiveTextBox);
            Controls.Add(IsActivelabel1);
            Controls.Add(UpdateButton);
            Controls.Add(NumOfEmptextBox1);
            Controls.Add(WebsitetextBox);
            Controls.Add(EmailtextBox1);
            Controls.Add(NumOfEmpLabel);
            Controls.Add(WebsiteLabel);
            Controls.Add(EmailLabel);
            Controls.Add(SearchCNbutton);
            Controls.Add(CompanyNametextBox);
            Controls.Add(CompanyNamelabel);
            Controls.Add(UpdateTenantLabel);
            Name = "UpdateTenant";
            Text = "UpdateTenant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateTenantLabel;
        private Label CompanyNamelabel;
        private TextBox CompanyNametextBox;
        private Button SearchCNbutton;
        private Label EmailLabel;
        private Label WebsiteLabel;
        private Label NumOfEmpLabel;
        private TextBox EmailtextBox1;
        private TextBox WebsitetextBox;
        private TextBox NumOfEmptextBox1;
        private Button UpdateButton;
        private Label IsActivelabel1;
        private TextBox IsActiveTextBox;
    }
}