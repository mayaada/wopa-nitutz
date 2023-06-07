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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            textBox1.Location = new Point(287, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 122);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Lease ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 177);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(287, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 31);
            textBox3.TabIndex = 5;
            // 
            // EditLease
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
        private TextBox textBox3;
    }
}