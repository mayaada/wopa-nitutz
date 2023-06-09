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
            Searchbutton1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 50);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Delete Lead";
            // 
            // CompanyNamelabel
            // 
            CompanyNamelabel.AutoSize = true;
            CompanyNamelabel.Location = new Point(182, 112);
            CompanyNamelabel.Name = "CompanyNamelabel";
            CompanyNamelabel.Size = new Size(145, 25);
            CompanyNamelabel.TabIndex = 3;
            CompanyNamelabel.Text = "Company Name:";
            // 
            // CompanyNametextBox1
            // 
            CompanyNametextBox1.Location = new Point(353, 112);
            CompanyNametextBox1.Name = "CompanyNametextBox1";
            CompanyNametextBox1.Size = new Size(176, 31);
            CompanyNametextBox1.TabIndex = 4;
            CompanyNametextBox1.TextChanged += CompanyNametextBox1_TextChanged;
            // 
            // Searchbutton1
            // 
            Searchbutton1.Location = new Point(353, 197);
            Searchbutton1.Name = "Searchbutton1";
            Searchbutton1.Size = new Size(112, 74);
            Searchbutton1.TabIndex = 5;
            Searchbutton1.Text = "Delete Lead";
            Searchbutton1.UseVisualStyleBackColor = true;
            Searchbutton1.Click += Searchbutton1_Click;
            // 
            // DeleteLead
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Searchbutton1);
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
        private Button Searchbutton1;
    }
}