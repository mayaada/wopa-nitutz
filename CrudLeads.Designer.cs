﻿namespace nitutz
{
    partial class CrudLeads
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
            ManageTenantsLable = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // ManageTenantsLable
            // 
            ManageTenantsLable.AutoSize = true;
            ManageTenantsLable.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ManageTenantsLable.Location = new Point(273, 86);
            ManageTenantsLable.Name = "ManageTenantsLable";
            ManageTenantsLable.Size = new Size(242, 37);
            ManageTenantsLable.TabIndex = 5;
            ManageTenantsLable.Text = "Manage Leads";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(150, 181);
            button1.Name = "button1";
            button1.Size = new Size(130, 81);
            button1.TabIndex = 6;
            button1.Text = "Add Lead";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(522, 181);
            button2.Name = "button2";
            button2.Size = new Size(151, 81);
            button2.TabIndex = 7;
            button2.Text = "Update Lead";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(328, 181);
            button3.Name = "button3";
            button3.Size = new Size(146, 81);
            button3.TabIndex = 8;
            button3.Text = "Delete Lead";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CrudLeads
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ManageTenantsLable);
            Name = "CrudLeads";
            Text = "CrudLeads";
            Load += CrudLeads_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ManageTenantsLable;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}