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
            label5 = new Label();
            SourcecomboBox1 = new ComboBox();
            label6 = new Label();
            StatuscomboBox1 = new ComboBox();
            Backbutton2 = new Button();
            ((System.ComponentModel.ISupportInitialize)NumOfWorkstationumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // AddNewTenantLabel
            // 
            AddNewTenantLabel.AutoSize = true;
            AddNewTenantLabel.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewTenantLabel.Location = new Point(247, 9);
            AddNewTenantLabel.Name = "AddNewTenantLabel";
            AddNewTenantLabel.Size = new Size(313, 53);
            AddNewTenantLabel.TabIndex = 1;
            AddNewTenantLabel.Text = "Add New Lead";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 89);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 2;
            label1.Text = "Company Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 148);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Contact:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 196);
            label3.Name = "label3";
            label3.Size = new Size(136, 25);
            label3.TabIndex = 4;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 247);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // NumEmpLabel
            // 
            NumEmpLabel.AutoSize = true;
            NumEmpLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumEmpLabel.Location = new Point(15, 299);
            NumEmpLabel.Name = "NumEmpLabel";
            NumEmpLabel.Size = new Size(213, 25);
            NumEmpLabel.TabIndex = 6;
            NumEmpLabel.Text = "Number Of Work Station:";
            // 
            // NumOfWorkstationumericUpDown1
            // 
            NumOfWorkstationumericUpDown1.Location = new Point(248, 294);
            NumOfWorkstationumericUpDown1.Name = "NumOfWorkstationumericUpDown1";
            NumOfWorkstationumericUpDown1.Size = new Size(150, 31);
            NumOfWorkstationumericUpDown1.TabIndex = 11;
            NumOfWorkstationumericUpDown1.ValueChanged += NumOfWorkstationumericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(574, 271);
            button1.Name = "button1";
            button1.Size = new Size(146, 54);
            button1.TabIndex = 12;
            button1.Text = "Creat Lead";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CompanyNameTextBox
            // 
            CompanyNameTextBox.Location = new Point(248, 86);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.Size = new Size(150, 31);
            CompanyNameTextBox.TabIndex = 13;
            CompanyNameTextBox.TextChanged += CompanyNameTextBox_TextChanged;
            // 
            // ContacttextBox1
            // 
            ContacttextBox1.Location = new Point(248, 139);
            ContacttextBox1.Name = "ContacttextBox1";
            ContacttextBox1.Size = new Size(150, 31);
            ContacttextBox1.TabIndex = 14;
            ContacttextBox1.TextChanged += ContacttextBox1_TextChanged;
            // 
            // PhontextBox1
            // 
            PhontextBox1.Location = new Point(248, 193);
            PhontextBox1.Name = "PhontextBox1";
            PhontextBox1.Size = new Size(150, 31);
            PhontextBox1.TabIndex = 15;
            PhontextBox1.TextChanged += PhontextBox1_TextChanged;
            // 
            // EmailtextBox1
            // 
            EmailtextBox1.Location = new Point(247, 247);
            EmailtextBox1.Name = "EmailtextBox1";
            EmailtextBox1.Size = new Size(150, 31);
            EmailtextBox1.TabIndex = 16;
            EmailtextBox1.TextChanged += EmailtextBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(445, 139);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 17;
            label5.Text = "Lead Source";
            // 
            // SourcecomboBox1
            // 
            SourcecomboBox1.FormattingEnabled = true;
            SourcecomboBox1.Location = new Point(570, 140);
            SourcecomboBox1.Name = "SourcecomboBox1";
            SourcecomboBox1.Size = new Size(150, 33);
            SourcecomboBox1.TabIndex = 18;
            SourcecomboBox1.SelectedIndexChanged += SourcecomboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(445, 89);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 19;
            label6.Text = "Lead Status";
            // 
            // StatuscomboBox1
            // 
            StatuscomboBox1.FormattingEnabled = true;
            StatuscomboBox1.Location = new Point(570, 81);
            StatuscomboBox1.Name = "StatuscomboBox1";
            StatuscomboBox1.Size = new Size(150, 33);
            StatuscomboBox1.TabIndex = 20;
            StatuscomboBox1.SelectedIndexChanged += StatuscomboBox1_SelectedIndexChanged;
            // 
            // Backbutton2
            // 
            Backbutton2.BackColor = SystemColors.ControlDarkDark;
            Backbutton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Backbutton2.ForeColor = Color.White;
            Backbutton2.Location = new Point(15, 15);
            Backbutton2.Name = "Backbutton2";
            Backbutton2.Size = new Size(71, 37);
            Backbutton2.TabIndex = 21;
            Backbutton2.Text = "BACK";
            Backbutton2.UseVisualStyleBackColor = false;
            Backbutton2.Click += Backbutton2_Click;
            // 
            // CreatLead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Backbutton2);
            Controls.Add(StatuscomboBox1);
            Controls.Add(label6);
            Controls.Add(SourcecomboBox1);
            Controls.Add(label5);
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
        private Label label5;
        private ComboBox SourcecomboBox1;
        private Label label6;
        private ComboBox StatuscomboBox1;
        private Button Backbutton2;
    }
}