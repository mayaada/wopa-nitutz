namespace nitutz
{
    partial class CreatLead
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NumEmpLabel = new Label();
            NumOfWorkstationumericUpDown1 = new NumericUpDown();
            button1 = new Button();
            CompanyNameTextBox = new TextBox();
            ContacttextBox1 = new TextBox();
            PhontextBox1 = new TextBox();
            EmailtextBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumOfWorkstationumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // AddNewTenantLabel
            // 
            AddNewTenantLabel.AutoSize = true;
            AddNewTenantLabel.Location = new Point(322, 38);
            AddNewTenantLabel.Name = "AddNewTenantLabel";
            AddNewTenantLabel.Size = new Size(128, 25);
            AddNewTenantLabel.TabIndex = 1;
            AddNewTenantLabel.Text = "Add New Lead";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 92);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 2;
            label1.Text = "Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 144);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Contact:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 192);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 4;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 241);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // NumEmpLabel
            // 
            NumEmpLabel.AutoSize = true;
            NumEmpLabel.Location = new Point(115, 288);
            NumEmpLabel.Name = "NumEmpLabel";
            NumEmpLabel.Size = new Size(213, 25);
            NumEmpLabel.TabIndex = 6;
            NumEmpLabel.Text = "Number Of Work Station:";
            // 
            // NumOfWorkstationumericUpDown1
            // 
            NumOfWorkstationumericUpDown1.Location = new Point(355, 288);
            NumOfWorkstationumericUpDown1.Name = "NumOfWorkstationumericUpDown1";
            NumOfWorkstationumericUpDown1.Size = new Size(186, 31);
            NumOfWorkstationumericUpDown1.TabIndex = 11;
            NumOfWorkstationumericUpDown1.ValueChanged += NumOfWorkstationumericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(304, 364);
            button1.Name = "button1";
            button1.Size = new Size(146, 54);
            button1.TabIndex = 12;
            button1.Text = "Creat Lead";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CompanyNameTextBox
            // 
            CompanyNameTextBox.Location = new Point(345, 86);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.Size = new Size(150, 31);
            CompanyNameTextBox.TabIndex = 13;
            CompanyNameTextBox.TextChanged += CompanyNameTextBox_TextChanged;
            // 
            // ContacttextBox1
            // 
            ContacttextBox1.Location = new Point(345, 144);
            ContacttextBox1.Name = "ContacttextBox1";
            ContacttextBox1.Size = new Size(150, 31);
            ContacttextBox1.TabIndex = 14;
            ContacttextBox1.TextChanged += ContacttextBox1_TextChanged;
            // 
            // PhontextBox1
            // 
            PhontextBox1.Location = new Point(345, 192);
            PhontextBox1.Name = "PhontextBox1";
            PhontextBox1.Size = new Size(150, 31);
            PhontextBox1.TabIndex = 15;
            PhontextBox1.TextChanged += PhontextBox1_TextChanged;
            // 
            // EmailtextBox1
            // 
            EmailtextBox1.Location = new Point(345, 241);
            EmailtextBox1.Name = "EmailtextBox1";
            EmailtextBox1.Size = new Size(150, 31);
            EmailtextBox1.TabIndex = 16;
            EmailtextBox1.TextChanged += EmailtextBox1_TextChanged;
            // 
            // CreatLead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EmailtextBox1);
            Controls.Add(PhontextBox1);
            Controls.Add(ContacttextBox1);
            Controls.Add(CompanyNameTextBox);
            Controls.Add(button1);
            Controls.Add(NumOfWorkstationumericUpDown1);
            Controls.Add(NumEmpLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddNewTenantLabel);
            Name = "CreatLead";
            Text = "CreatLead";
            Load += CreatLead_Load;
            ((System.ComponentModel.ISupportInitialize)NumOfWorkstationumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddNewTenantLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label NumEmpLabel;
        private NumericUpDown NumOfWorkstationumericUpDown1;
        private Button button1;
        private TextBox CompanyNameTextBox;
        private TextBox ContacttextBox1;
        private TextBox PhontextBox1;
        private TextBox EmailtextBox1;
    }
}