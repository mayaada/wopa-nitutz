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
            SuspendLayout();
            // 
            // Savebutton1
            // 
            Savebutton1.Location = new Point(341, 380);
            Savebutton1.Name = "Savebutton1";
            Savebutton1.Size = new Size(135, 54);
            Savebutton1.TabIndex = 0;
            Savebutton1.Text = "Save";
            Savebutton1.UseVisualStyleBackColor = true;
            Savebutton1.Click += Savebutton1_Click;
            // 
            // EditLease
            // 
            EditLease.AutoSize = true;
            EditLease.Location = new Point(371, 47);
            EditLease.Name = "EditLease";
            EditLease.Size = new Size(90, 25);
            EditLease.TabIndex = 1;
            EditLease.Text = "Edit Lease";
            // 
            // LeaseIdtextBox1
            // 
            LeaseIdtextBox1.Location = new Point(341, 96);
            LeaseIdtextBox1.Name = "LeaseIdtextBox1";
            LeaseIdtextBox1.Size = new Size(150, 31);
            LeaseIdtextBox1.TabIndex = 2;
            LeaseIdtextBox1.TextChanged += LeaseIdtextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 96);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 3;
            label1.Text = "Lease Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 143);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 4;
            label2.Text = "Start Date:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 195);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 5;
            label3.Text = "End Date: ";
            // 
            // TermianationNoticelabel5
            // 
            TermianationNoticelabel5.AutoSize = true;
            TermianationNoticelabel5.Location = new Point(131, 259);
            TermianationNoticelabel5.Name = "TermianationNoticelabel5";
            TermianationNoticelabel5.Size = new Size(173, 25);
            TermianationNoticelabel5.TabIndex = 7;
            TermianationNoticelabel5.Text = "Termianation Notice:";
            TermianationNoticelabel5.Click += TermianationNoticelabel5_Click;
            // 
            // StartDatetextBox1
            // 
            StartDatetextBox1.Location = new Point(337, 143);
            StartDatetextBox1.Name = "StartDatetextBox1";
            StartDatetextBox1.Size = new Size(150, 31);
            StartDatetextBox1.TabIndex = 9;
            StartDatetextBox1.TextChanged += StartDatetextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(25, 21);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EndDatetextBox1
            // 
            EndDatetextBox1.Location = new Point(337, 195);
            EndDatetextBox1.Name = "EndDatetextBox1";
            EndDatetextBox1.Size = new Size(150, 31);
            EndDatetextBox1.TabIndex = 18;
            EndDatetextBox1.TextChanged += EndDatetextBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 307);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 20;
            label6.Text = "Terms And Conditions:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(326, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(326, 307);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 22;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // listView1
            // 
            listView1.Location = new Point(557, 128);
            listView1.Name = "listView1";
            listView1.Size = new Size(182, 146);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // LeaseEditForEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 450);
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
    }
}