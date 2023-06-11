namespace nitutz
{
    partial class DeleteLead
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
            CompanyNamelabel = new Label();
            CompanyNametextBox1 = new TextBox();
            Deletebutton1 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(272, 59);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 0;
            label1.Text = "Delete Lead";
            // 
            // CompanyNamelabel
            // 
            CompanyNamelabel.AutoSize = true;
            CompanyNamelabel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyNamelabel.Location = new Point(168, 154);
            CompanyNamelabel.Name = "CompanyNamelabel";
            CompanyNamelabel.Size = new Size(187, 26);
            CompanyNamelabel.TabIndex = 3;
            CompanyNamelabel.Text = "Company Name:";
            // 
            // CompanyNametextBox1
            // 
            CompanyNametextBox1.Location = new Point(361, 154);
            CompanyNametextBox1.Name = "CompanyNametextBox1";
            CompanyNametextBox1.Size = new Size(176, 31);
            CompanyNametextBox1.TabIndex = 4;
            CompanyNametextBox1.TextChanged += CompanyNametextBox1_TextChanged;
            // 
            // Deletebutton1
            // 
            Deletebutton1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Deletebutton1.Location = new Point(361, 208);
            Deletebutton1.Name = "Deletebutton1";
            Deletebutton1.Size = new Size(176, 52);
            Deletebutton1.TabIndex = 6;
            Deletebutton1.Text = "Delete Lead";
            Deletebutton1.UseVisualStyleBackColor = true;
            Deletebutton1.Click += Deletebutton1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(17, 19);
            button1.Name = "button1";
            button1.Size = new Size(80, 36);
            button1.TabIndex = 7;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteLead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Deletebutton1);
            Controls.Add(CompanyNametextBox1);
            Controls.Add(CompanyNamelabel);
            Controls.Add(label1);
            Name = "DeleteLead";
            Text = "DeleteLead";
            Load += DeleteLead_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CompanyNamelabel;
        private TextBox CompanyNametextBox1;
        private Button Deletebutton1;
        private Button button1;
    }
}