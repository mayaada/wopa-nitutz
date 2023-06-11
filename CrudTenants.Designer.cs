﻿namespace nitutz
{
    partial class CrudTenants
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
            UpdateTenantButton = new Button();
            AddTenantButton = new Button();
            ManageTenantsLable = new Label();
            SuspendLayout();
            // 
            // UpdateTenantButton
            // 
            UpdateTenantButton.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateTenantButton.Location = new Point(425, 247);
            UpdateTenantButton.Name = "UpdateTenantButton";
            UpdateTenantButton.Size = new Size(230, 79);
            UpdateTenantButton.TabIndex = 1;
            UpdateTenantButton.Text = "Update Tenant";
            UpdateTenantButton.UseVisualStyleBackColor = true;
            UpdateTenantButton.Click += UpdateTenantButton_Click;
            // 
            // AddTenantButton
            // 
            AddTenantButton.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AddTenantButton.Location = new Point(144, 247);
            AddTenantButton.Name = "AddTenantButton";
            AddTenantButton.Size = new Size(211, 79);
            AddTenantButton.TabIndex = 3;
            AddTenantButton.Text = "Add Tenant";
            AddTenantButton.UseVisualStyleBackColor = true;
            AddTenantButton.Click += AddTenantButton_Click;
            // 
            // ManageTenantsLable
            // 
            ManageTenantsLable.AutoSize = true;
            ManageTenantsLable.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ManageTenantsLable.Location = new Point(255, 102);
            ManageTenantsLable.Name = "ManageTenantsLable";
            ManageTenantsLable.Size = new Size(307, 42);
            ManageTenantsLable.TabIndex = 4;
            ManageTenantsLable.Text = "Manage Tenants";
            ManageTenantsLable.Click += ManageTenantsLable_Click;
            // 
            // CrudTenants
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ManageTenantsLable);
            Controls.Add(AddTenantButton);
            Controls.Add(UpdateTenantButton);
            Name = "CrudTenants";
            Text = "CrudTenants";
            Load += CrudTenants_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button UpdateTenantButton;
        private Button AddTenantButton;
        private Label ManageTenantsLable;
    }
}