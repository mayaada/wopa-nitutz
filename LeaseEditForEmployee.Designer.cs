namespace nitutz
{
    partial class LeaseEditForEmployee
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
            Savebutton1 = new Button();
            EditLease = new Label();
            LeaseIdtextBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TermianationNoticelabel5 = new Label();
            StartDatetextBox1 = new TextBox();
            button2 = new Button();
            EndDatetextBox1 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            listView1 = new ListView();
            Removebutton1 = new Button();
            addLeasedItem_combobox = new ComboBox();
            label5 = new Label();
            AddItem_Button = new Button();
            SuspendLayout();
            // 
            // Savebutton1
            // 
            Savebutton1.BackColor = SystemColors.ControlDarkDark;
            Savebutton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Savebutton1.ForeColor = SystemColors.ControlLightLight;
            Savebutton1.Location = new Point(172, 373);
            Savebutton1.Name = "Savebutton1";
            Savebutton1.Size = new Size(135, 54);
            Savebutton1.TabIndex = 0;
            Savebutton1.Text = "Save";
            Savebutton1.UseVisualStyleBackColor = false;
            Savebutton1.Click += Savebutton1_Click;
            // 
            // EditLease
            // 
            EditLease.AutoSize = true;
            EditLease.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EditLease.Location = new Point(359, 22);
            EditLease.Name = "EditLease";
            EditLease.Size = new Size(178, 40);
            EditLease.TabIndex = 1;
            EditLease.Text = "Edit Lease";
            // 
            // LeaseIdtextBox1
            // 
            LeaseIdtextBox1.Enabled = false;
            LeaseIdtextBox1.Location = new Point(160, 96);
            LeaseIdtextBox1.Name = "LeaseIdtextBox1";
            LeaseIdtextBox1.Size = new Size(150, 31);
            LeaseIdtextBox1.TabIndex = 2;
            LeaseIdtextBox1.TextChanged += LeaseIdtextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 96);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 3;
            label1.Text = "Lease Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 143);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Start Date:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 186);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 5;
            label3.Text = "End Date: ";
            // 
            // TermianationNoticelabel5
            // 
            TermianationNoticelabel5.AutoSize = true;
            TermianationNoticelabel5.Location = new Point(57, 253);
            TermianationNoticelabel5.Name = "TermianationNoticelabel5";
            TermianationNoticelabel5.Size = new Size(173, 25);
            TermianationNoticelabel5.TabIndex = 7;
            TermianationNoticelabel5.Text = "Termianation Notice:";
            TermianationNoticelabel5.Click += TermianationNoticelabel5_Click;
            // 
            // StartDatetextBox1
            // 
            StartDatetextBox1.Enabled = false;
            StartDatetextBox1.Location = new Point(172, 143);
            StartDatetextBox1.Name = "StartDatetextBox1";
            StartDatetextBox1.Size = new Size(150, 31);
            StartDatetextBox1.TabIndex = 9;
            StartDatetextBox1.TextChanged += StartDatetextBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(99, 35);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EndDatetextBox1
            // 
            EndDatetextBox1.Location = new Point(172, 186);
            EndDatetextBox1.Name = "EndDatetextBox1";
            EndDatetextBox1.Size = new Size(150, 31);
            EndDatetextBox1.TabIndex = 18;
            EndDatetextBox1.TextChanged += EndDatetextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 307);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 20;
            label6.Text = "Terms And Conditions:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(271, 307);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // listView1
            // 
            listView1.Location = new Point(429, 87);
            listView1.Name = "listView1";
            listView1.Size = new Size(394, 146);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Removebutton1
            // 
            Removebutton1.BackColor = SystemColors.ControlDarkDark;
            Removebutton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Removebutton1.ForeColor = SystemColors.Window;
            Removebutton1.Location = new Point(481, 253);
            Removebutton1.Name = "Removebutton1";
            Removebutton1.Size = new Size(112, 71);
            Removebutton1.TabIndex = 24;
            Removebutton1.Text = "Remove Item";
            Removebutton1.UseVisualStyleBackColor = false;
            Removebutton1.Click += button1_Click;
            // 
            // addLeasedItem_combobox
            // 
            addLeasedItem_combobox.FormattingEnabled = true;
            addLeasedItem_combobox.Location = new Point(624, 291);
            addLeasedItem_combobox.Name = "addLeasedItem_combobox";
            addLeasedItem_combobox.Size = new Size(156, 33);
            addLeasedItem_combobox.TabIndex = 26;
            addLeasedItem_combobox.SelectedIndexChanged += addLeasedItem_combobox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 256);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 27;
            label5.Text = "Add Item:";
            // 
            // AddItem_Button
            // 
            AddItem_Button.BackColor = SystemColors.ControlDarkDark;
            AddItem_Button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddItem_Button.ForeColor = SystemColors.Window;
            AddItem_Button.Location = new Point(624, 352);
            AddItem_Button.Name = "AddItem_Button";
            AddItem_Button.Size = new Size(94, 37);
            AddItem_Button.TabIndex = 28;
            AddItem_Button.Text = "Add";
            AddItem_Button.UseVisualStyleBackColor = false;
            AddItem_Button.Click += AddItem_Button_Click;
            // 
            // LeaseEditForEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(835, 450);
            Controls.Add(AddItem_Button);
            Controls.Add(label5);
            Controls.Add(addLeasedItem_combobox);
            Controls.Add(Removebutton1);
            Controls.Add(listView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(EndDatetextBox1);
            Controls.Add(button2);
            Controls.Add(StartDatetextBox1);
            Controls.Add(TermianationNoticelabel5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LeaseIdtextBox1);
            Controls.Add(EditLease);
            Controls.Add(Savebutton1);
            Name = "LeaseEditForEmployee";
            Text = "LeaseEditForEmployee";
            Load += LeaseEditForEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Savebutton1;
        private Label EditLease;
        private TextBox LeaseIdtextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label TermianationNoticelabel5;
        private TextBox StartDatetextBox1;
        private Button button2;
        private TextBox EndDatetextBox1;
        private TextBox LeasedItemtextBox1;
        private Label label6;
        private TextBox textBox1;
        private TextBox termsTextBox;
        private TextBox textBox2;
        private ListBox listBox1;
        private ListView listView1;
        private Button Removebutton1;
        private ComboBox addLeasedItem_combobox;
        private Label label5;
        private Button AddItem_Button;
    }
}