namespace nitutz
{
    partial class UpdateLead
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
            CompanyTextBox = new TextBox();
            SearchCompanyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contactTextBox = new TextBox();
            EmailTextBox = new TextBox();
            WorkStationBox5 = new TextBox();
            PhoneTextBox = new TextBox();
            LeadStatuscomboBox1 = new ComboBox();
            Updatebutton = new Button();
            BACKbutton1 = new Button();
            SuspendLayout();
            // 
            // UpdateTenantLabel
            // 
            UpdateTenantLabel.AutoSize = true;
            UpdateTenantLabel.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateTenantLabel.Location = new Point(274, 18);
            UpdateTenantLabel.Name = "UpdateTenantLabel";
            UpdateTenantLabel.Size = new Size(215, 37);
            UpdateTenantLabel.TabIndex = 1;
            UpdateTenantLabel.Text = "Update Lead";
            // 
            // CompanyNamelabel
            // 
            CompanyNamelabel.AutoSize = true;
            CompanyNamelabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNamelabel.Location = new Point(145, 79);
            CompanyNamelabel.Name = "CompanyNamelabel";
            CompanyNamelabel.Size = new Size(156, 21);
            CompanyNamelabel.TabIndex = 2;
            CompanyNamelabel.Text = "Company Name:";
            // 
            // CompanyTextBox
            // 
            CompanyTextBox.Location = new Point(307, 69);
            CompanyTextBox.Name = "CompanyTextBox";
            CompanyTextBox.Size = new Size(184, 31);
            CompanyTextBox.TabIndex = 3;
            CompanyTextBox.TextChanged += textBox1_TextChanged;
            // 
            // SearchCompanyButton
            // 
            SearchCompanyButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCompanyButton.Location = new Point(214, 364);
            SearchCompanyButton.Name = "SearchCompanyButton";
            SearchCompanyButton.Size = new Size(136, 52);
            SearchCompanyButton.TabIndex = 4;
            SearchCompanyButton.Text = "Search";
            SearchCompanyButton.UseVisualStyleBackColor = true;
            SearchCompanyButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 123);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 5;
            label1.Text = "Contact:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 166);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 6;
            label2.Text = "Phone Number:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(146, 210);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 7;
            label3.Text = "Contact Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(146, 256);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 8;
            label4.Text = "Work station:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(146, 299);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 9;
            label5.Text = "Lead Status:";
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(307, 117);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(187, 31);
            contactTextBox.TabIndex = 10;
            contactTextBox.TextChanged += contactTextBox_TextChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(304, 204);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(187, 31);
            EmailTextBox.TabIndex = 11;
            EmailTextBox.TextChanged += EmailTextBox_TextChanged;
            // 
            // WorkStationBox5
            // 
            WorkStationBox5.Location = new Point(304, 250);
            WorkStationBox5.Name = "WorkStationBox5";
            WorkStationBox5.Size = new Size(187, 31);
            WorkStationBox5.TabIndex = 13;
            WorkStationBox5.TextChanged += WorkStationBox5_TextChanged;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(307, 160);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(187, 31);
            PhoneTextBox.TabIndex = 14;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // LeadStatuscomboBox1
            // 
            LeadStatuscomboBox1.FormattingEnabled = true;
            LeadStatuscomboBox1.Location = new Point(307, 296);
            LeadStatuscomboBox1.Name = "LeadStatuscomboBox1";
            LeadStatuscomboBox1.Size = new Size(182, 33);
            LeadStatuscomboBox1.TabIndex = 15;
            LeadStatuscomboBox1.SelectedIndexChanged += LeadStatuscomboBox1_SelectedIndexChanged;
            // 
            // Updatebutton
            // 
            Updatebutton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Updatebutton.Location = new Point(402, 364);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(124, 52);
            Updatebutton.TabIndex = 16;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += button2_Click;
            // 
            // BACKbutton1
            // 
            BACKbutton1.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BACKbutton1.Location = new Point(12, 14);
            BACKbutton1.Name = "BACKbutton1";
            BACKbutton1.Size = new Size(68, 34);
            BACKbutton1.TabIndex = 17;
            BACKbutton1.Text = "BACK";
            BACKbutton1.UseVisualStyleBackColor = true;
            BACKbutton1.Click += BACKbutton1_Click;
            // 
            // UpdateLead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BACKbutton1);
            Controls.Add(Updatebutton);
            Controls.Add(LeadStatuscomboBox1);
            Controls.Add(PhoneTextBox);
            Controls.Add(WorkStationBox5);
            Controls.Add(EmailTextBox);
            Controls.Add(contactTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchCompanyButton);
            Controls.Add(CompanyTextBox);
            Controls.Add(CompanyNamelabel);
            Controls.Add(UpdateTenantLabel);
            Name = "UpdateLead";
            Text = "UpdateLead";
            Load += UpdateLead_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateTenantLabel;
        private Label CompanyNamelabel;
        private TextBox CompanyTextBox;
        private Button SearchCompanyButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox contactTextBox;
        private TextBox EmailTextBox;
        private TextBox WorkStationBox5;
        private TextBox PhoneTextBox;
        private ComboBox LeadStatuscomboBox1;
        private Button Updatebutton;
        private Button BACKbutton1;
    }
}