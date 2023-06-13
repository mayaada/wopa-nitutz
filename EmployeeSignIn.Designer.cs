namespace nitutz
{
    partial class employeeSignIn
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            wopaSignIn_Label = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(215, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 192);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 31);
            textBox2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 195);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 274);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // button1
            // 
            button1.Location = new Point(354, 350);
            button1.Name = "button1";
            button1.Size = new Size(111, 65);
            button1.TabIndex = 6;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // wopaSignIn_Label
            // 
            wopaSignIn_Label.AutoSize = true;
            wopaSignIn_Label.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            wopaSignIn_Label.Location = new Point(211, 78);
            wopaSignIn_Label.Name = "wopaSignIn_Label";
            wopaSignIn_Label.Size = new Size(288, 40);
            wopaSignIn_Label.TabIndex = 7;
            wopaSignIn_Label.Text = "WOPA User Login";
            wopaSignIn_Label.TextAlign = ContentAlignment.TopCenter;
            wopaSignIn_Label.Click += label3_Click;
            // 
            // employeeSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wopaSignIn_Label);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Name = "employeeSignIn";
            Text = "EmployeeSignIn";
            Load += EmployeeSignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label wopaSignIn_Label;
    }
}