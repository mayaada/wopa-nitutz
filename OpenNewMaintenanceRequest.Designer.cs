﻿namespace nitutz
{
    partial class OpenNewMaintenanceRequest
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(230, 29);
            label1.Name = "label1";
            label1.Size = new Size(523, 40);
            label1.TabIndex = 0;
            label1.Text = "Open New Maintenance Request";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(330, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 130);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 227);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 3;
            label3.Text = "Add Picture:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(330, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 85);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "Ticket ID:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(345, 31);
            textBox2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 9);
            label5.Name = "label5";
            label5.Size = new Size(122, 25);
            label5.TabIndex = 7;
            label5.Text = "Date Opened:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 85);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 8;
            label6.Text = "Time Opened:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 31);
            textBox4.TabIndex = 10;
            // 
            // OpenNewMaintenanceRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "OpenNewMaintenanceRequest";
            Text = "OpenNewMaintenanceRequest";
            Load += OpenNewMaintenanceRequest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}