namespace nitutz
{
    partial class AddNewLeasedItem
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
            FloorLabel = new Label();
            TypeLabel = new Label();
            ECLabel = new Label();
            Available = new Label();
            Leases = new Label();
            numericUpDown1 = new NumericUpDown();
            TypetextBox1 = new TextBox();
            ECtextBox1 = new TextBox();
            AvailtextBox1 = new TextBox();
            LeasetextBox1 = new TextBox();
            Addbutton1 = new Button();
            BACKbutton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // FloorLabel
            // 
            FloorLabel.AutoSize = true;
            FloorLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FloorLabel.Location = new Point(206, 57);
            FloorLabel.Name = "FloorLabel";
            FloorLabel.Size = new Size(60, 23);
            FloorLabel.TabIndex = 1;
            FloorLabel.Text = "Floor";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TypeLabel.Location = new Point(207, 110);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(59, 23);
            TypeLabel.TabIndex = 2;
            TypeLabel.Text = "Type";
            // 
            // ECLabel
            // 
            ECLabel.AutoSize = true;
            ECLabel.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ECLabel.Location = new Point(206, 167);
            ECLabel.Name = "ECLabel";
            ECLabel.Size = new Size(181, 23);
            ECLabel.TabIndex = 3;
            ECLabel.Text = "Electric Charging";
            // 
            // Available
            // 
            Available.AutoSize = true;
            Available.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Available.Location = new Point(207, 219);
            Available.Name = "Available";
            Available.Size = new Size(115, 23);
            Available.TabIndex = 4;
            Available.Text = "Availability";
            // 
            // Leases
            // 
            Leases.AutoSize = true;
            Leases.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Leases.Location = new Point(207, 282);
            Leases.Name = "Leases";
            Leases.Size = new Size(69, 23);
            Leases.TabIndex = 5;
            Leases.Text = "Lease";
            Leases.Click += Leases_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(480, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(151, 31);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // TypetextBox1
            // 
            TypetextBox1.Location = new Point(483, 106);
            TypetextBox1.Name = "TypetextBox1";
            TypetextBox1.Size = new Size(148, 31);
            TypetextBox1.TabIndex = 7;
            TypetextBox1.TextChanged += TypetextBox1_TextChanged;
            // 
            // ECtextBox1
            // 
            ECtextBox1.Location = new Point(483, 163);
            ECtextBox1.Name = "ECtextBox1";
            ECtextBox1.Size = new Size(148, 31);
            ECtextBox1.TabIndex = 8;
            ECtextBox1.TextChanged += ECtextBox1_TextChanged;
            // 
            // AvailtextBox1
            // 
            AvailtextBox1.Location = new Point(483, 215);
            AvailtextBox1.Name = "AvailtextBox1";
            AvailtextBox1.Size = new Size(148, 31);
            AvailtextBox1.TabIndex = 9;
            AvailtextBox1.TextChanged += AvailtextBox1_TextChanged;
            // 
            // LeasetextBox1
            // 
            LeasetextBox1.Location = new Point(480, 278);
            LeasetextBox1.Name = "LeasetextBox1";
            LeasetextBox1.Size = new Size(150, 31);
            LeasetextBox1.TabIndex = 10;
            LeasetextBox1.TextChanged += LeasetextBox1_TextChanged;
            // 
            // Addbutton1
            // 
            Addbutton1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Addbutton1.Location = new Point(483, 331);
            Addbutton1.Name = "Addbutton1";
            Addbutton1.Size = new Size(147, 39);
            Addbutton1.TabIndex = 11;
            Addbutton1.Text = "Add Service";
            Addbutton1.UseVisualStyleBackColor = true;
            Addbutton1.Click += Addbutton1_Click;
            // 
            // BACKbutton1
            // 
            BACKbutton1.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            BACKbutton1.Location = new Point(12, 12);
            BACKbutton1.Name = "BACKbutton1";
            BACKbutton1.Size = new Size(68, 29);
            BACKbutton1.TabIndex = 12;
            BACKbutton1.Text = "BACK";
            BACKbutton1.UseVisualStyleBackColor = true;
            BACKbutton1.Click += BACKbutton1_Click;
            // 
            // AddNewLeasedItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BACKbutton1);
            Controls.Add(Addbutton1);
            Controls.Add(LeasetextBox1);
            Controls.Add(AvailtextBox1);
            Controls.Add(ECtextBox1);
            Controls.Add(TypetextBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(Leases);
            Controls.Add(Available);
            Controls.Add(ECLabel);
            Controls.Add(TypeLabel);
            Controls.Add(FloorLabel);
            Name = "AddNewLeasedItem";
            Text = "AddNewLeasedItem";
            Load += AddNewLeasedItem_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FloorLabel;
        private Label TypeLabel;
        private Label ECLabel;
        private Label Available;
        private Label Leases;
        private NumericUpDown numericUpDown1;
        private TextBox TypetextBox1;
        private TextBox ECtextBox1;
        private TextBox AvailtextBox1;
        private TextBox LeasetextBox1;
        private Button Addbutton1;
        private Button BACKbutton1;
    }
}