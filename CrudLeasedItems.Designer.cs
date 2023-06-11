namespace nitutz
{
    partial class CrudLeasedItems
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
            listView1 = new ListView();
            UpdateButton = new Button();
            ECtextBox1 = new TextBox();
            AvailtextBox1 = new TextBox();
            leasetextBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BACKbutton = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.LabelEdit = true;
            listView1.Location = new Point(26, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(762, 270);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(626, 362);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(137, 56);
            UpdateButton.TabIndex = 1;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ECtextBox1
            // 
            ECtextBox1.Location = new Point(26, 387);
            ECtextBox1.Name = "ECtextBox1";
            ECtextBox1.Size = new Size(144, 31);
            ECtextBox1.TabIndex = 2;
            ECtextBox1.TextChanged += ECtextBox1_TextChanged;
            // 
            // AvailtextBox1
            // 
            AvailtextBox1.Location = new Point(203, 387);
            AvailtextBox1.Name = "AvailtextBox1";
            AvailtextBox1.Size = new Size(144, 31);
            AvailtextBox1.TabIndex = 3;
            AvailtextBox1.TextChanged += AvailtextBox1_TextChanged;
            // 
            // leasetextBox1
            // 
            leasetextBox1.Location = new Point(378, 387);
            leasetextBox1.Name = "leasetextBox1";
            leasetextBox1.Size = new Size(144, 31);
            leasetextBox1.TabIndex = 4;
            leasetextBox1.TextChanged += leasetextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 347);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 6;
            label1.Text = "Electric Charging";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(220, 347);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 7;
            label2.Text = "Availability";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(417, 347);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 8;
            label3.Text = "Lease";
            // 
            // BACKbutton
            // 
            BACKbutton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BACKbutton.Location = new Point(26, 12);
            BACKbutton.Name = "BACKbutton";
            BACKbutton.Size = new Size(70, 41);
            BACKbutton.TabIndex = 9;
            BACKbutton.Text = "BACK";
            BACKbutton.UseVisualStyleBackColor = true;
            BACKbutton.Click += BACKbutton_Click;
            // 
            // CrudLeasedItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BACKbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(leasetextBox1);
            Controls.Add(AvailtextBox1);
            Controls.Add(ECtextBox1);
            Controls.Add(UpdateButton);
            Controls.Add(listView1);
            Name = "CrudLeasedItems";
            Text = "CrudLeasedItems";
            Load += CrudLeasedItems_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button UpdateButton;
        private TextBox ECtextBox1;
        private TextBox AvailtextBox1;
        private TextBox leasetextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BACKbutton;
    }
}