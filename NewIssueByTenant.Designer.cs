namespace nitutz
{
    partial class NewIssueByTenant
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
            IssueLabel = new Label();
            LocationLabel = new Label();
            TypeLabel = new Label();
            PriorityLabel = new Label();
            DescroptionLabel = new Label();
            IssuetextBox1 = new TextBox();
            LocationtextBox1 = new TextBox();
            TypecomboBox1 = new ComboBox();
            PrioritycomboBox1 = new ComboBox();
            DescriptiontextBox1 = new TextBox();
            CreateNewButton = new Button();
            SuspendLayout();
            // 
            // IssueLabel
            // 
            IssueLabel.AutoSize = true;
            IssueLabel.Location = new Point(145, 93);
            IssueLabel.Name = "IssueLabel";
            IssueLabel.Size = new Size(52, 25);
            IssueLabel.TabIndex = 0;
            IssueLabel.Text = "Issue";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(145, 140);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(79, 25);
            LocationLabel.TabIndex = 1;
            LocationLabel.Text = "Location";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(143, 194);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(49, 25);
            TypeLabel.TabIndex = 2;
            TypeLabel.Text = "Type";
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Location = new Point(145, 245);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(68, 25);
            PriorityLabel.TabIndex = 3;
            PriorityLabel.Text = "Priority";
            // 
            // DescroptionLabel
            // 
            DescroptionLabel.AutoSize = true;
            DescroptionLabel.Location = new Point(145, 297);
            DescroptionLabel.Name = "DescroptionLabel";
            DescroptionLabel.Size = new Size(102, 25);
            DescroptionLabel.TabIndex = 4;
            DescroptionLabel.Text = "Description";
            // 
            // IssuetextBox1
            // 
            IssuetextBox1.Location = new Point(263, 93);
            IssuetextBox1.Name = "IssuetextBox1";
            IssuetextBox1.Size = new Size(268, 31);
            IssuetextBox1.TabIndex = 5;
            IssuetextBox1.TextChanged += IssuetextBox1_TextChanged;
            // 
            // LocationtextBox1
            // 
            LocationtextBox1.Location = new Point(263, 140);
            LocationtextBox1.Name = "LocationtextBox1";
            LocationtextBox1.Size = new Size(268, 31);
            LocationtextBox1.TabIndex = 6;
            LocationtextBox1.TextChanged += LocationtextBox1_TextChanged;
            // 
            // TypecomboBox1
            // 
            TypecomboBox1.FormattingEnabled = true;
            TypecomboBox1.Location = new Point(353, 194);
            TypecomboBox1.Name = "TypecomboBox1";
            TypecomboBox1.Size = new Size(178, 33);
            TypecomboBox1.TabIndex = 7;
            TypecomboBox1.SelectedIndexChanged += TypecomboBox1_SelectedIndexChanged;
            // 
            // PrioritycomboBox1
            // 
            PrioritycomboBox1.FormattingEnabled = true;
            PrioritycomboBox1.Location = new Point(353, 245);
            PrioritycomboBox1.Name = "PrioritycomboBox1";
            PrioritycomboBox1.Size = new Size(178, 33);
            PrioritycomboBox1.TabIndex = 8;
            PrioritycomboBox1.SelectedIndexChanged += PrioritycomboBox1_SelectedIndexChanged;
            // 
            // DescriptiontextBox1
            // 
            DescriptiontextBox1.Location = new Point(273, 308);
            DescriptiontextBox1.Name = "DescriptiontextBox1";
            DescriptiontextBox1.Size = new Size(264, 31);
            DescriptiontextBox1.TabIndex = 9;
            DescriptiontextBox1.TextChanged += DescriptiontextBox1_TextChanged;
            // 
            // CreateNewButton
            // 
            CreateNewButton.Location = new Point(283, 367);
            CreateNewButton.Name = "CreateNewButton";
            CreateNewButton.Size = new Size(248, 39);
            CreateNewButton.TabIndex = 10;
            CreateNewButton.Text = "Create New Ticket";
            CreateNewButton.UseVisualStyleBackColor = true;
            CreateNewButton.Click += CreateNewButton_Click;
            // 
            // NewIssueByTenant
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreateNewButton);
            Controls.Add(DescriptiontextBox1);
            Controls.Add(PrioritycomboBox1);
            Controls.Add(TypecomboBox1);
            Controls.Add(LocationtextBox1);
            Controls.Add(IssuetextBox1);
            Controls.Add(DescroptionLabel);
            Controls.Add(PriorityLabel);
            Controls.Add(TypeLabel);
            Controls.Add(LocationLabel);
            Controls.Add(IssueLabel);
            Name = "NewIssueByTenant";
            Text = "NewIssueByTenant";
            Load += NewIssueByTenant_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IssueLabel;
        private Label LocationLabel;
        private Label TypeLabel;
        private Label PriorityLabel;
        private Label DescroptionLabel;
        private TextBox IssuetextBox1;
        private TextBox LocationtextBox1;
        private ComboBox TypecomboBox1;
        private ComboBox PrioritycomboBox1;
        private TextBox DescriptiontextBox1;
        private Button CreateNewButton;
    }
}