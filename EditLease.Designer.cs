namespace nitutz
{
    partial class EditLease
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            EdnDate = new TextBox();
            label4 = new Label();
            label5 = new Label();
            LeasedItem = new TextBox();
            label6 = new Label();
            TermsAndCondition = new TextBox();
            label7 = new Label();
            SteartDate = new ListBox();
            StartDate = new Label();
            TerminationNotice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 31);
            label1.Name = "label1";
            label1.Size = new Size(237, 53);
            label1.TabIndex = 0;
            label1.Text = "Edit Lease";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 98);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Lease ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 146);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 3;
            label3.Text = "Start Date:";
            // 
            // EdnDate
            // 
            EdnDate.Location = new Point(287, 206);
            EdnDate.Name = "EdnDate";
            EdnDate.Size = new Size(192, 31);
            EdnDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 191);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 6;
            label4.Text = "End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 281);
            label5.Name = "label5";
            label5.Size = new Size(164, 25);
            label5.TabIndex = 7;
            label5.Text = "Termination Notice:";
            // 
            // LeasedItem
            // 
            LeasedItem.Location = new Point(287, 243);
            LeasedItem.Name = "LeasedItem";
            LeasedItem.Size = new Size(200, 31);
            LeasedItem.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 330);
            label6.Name = "label6";
            label6.Size = new Size(187, 25);
            label6.TabIndex = 9;
            label6.Text = "Terms And Conditions";
            // 
            // TermsAndCondition
            // 
            TermsAndCondition.Location = new Point(345, 324);
            TermsAndCondition.Name = "TermsAndCondition";
            TermsAndCondition.Size = new Size(200, 31);
            TermsAndCondition.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 239);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 11;
            label7.Text = "Leased Items:";
            // 
            // SteartDate
            // 
            SteartDate.FormattingEnabled = true;
            SteartDate.ItemHeight = 25;
            SteartDate.Location = new Point(287, 135);
            SteartDate.Name = "SteartDate";
            SteartDate.Size = new Size(192, 54);
            SteartDate.TabIndex = 12;
            // 
            // StartDate
            // 
            StartDate.AutoSize = true;
            StartDate.Location = new Point(287, 146);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(0, 25);
            StartDate.TabIndex = 13;
            StartDate.Click += label8_Click;
            // 
            // TerminationNotice
            // 
            TerminationNotice.Location = new Point(324, 287);
            TerminationNotice.Name = "TerminationNotice";
            TerminationNotice.Size = new Size(200, 31);
            TerminationNotice.TabIndex = 14;
            // 
            // EditLease
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TerminationNotice);
            Controls.Add(StartDate);
            Controls.Add(SteartDate);
            Controls.Add(label7);
            Controls.Add(TermsAndCondition);
            Controls.Add(label6);
            Controls.Add(LeasedItem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EdnDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EditLease";
            Text = "EditLease";
            Load += EditLease_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox EdnDate;
        private Label label4;
        private Label label5;
        private TextBox LeasedItem;
        private Label label6;
        private TextBox TermsAndCondition;
        private Label label7;
        private ListBox SteartDate;
        private Label StartDate;
        private TextBox TerminationNotice;
    }
}