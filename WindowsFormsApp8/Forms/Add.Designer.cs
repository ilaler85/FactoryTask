namespace WindowsFormsApp8.Forms
{
    partial class Add
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SquareBox = new System.Windows.Forms.TextBox();
            this.OpeningJearBox = new System.Windows.Forms.TextBox();
            this.OwnerComboBox = new System.Windows.Forms.ComboBox();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название завода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Площадь";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год основания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Владелец";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(114, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 20);
            this.NameBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Адрес";
            // 
            // SquareBox
            // 
            this.SquareBox.Location = new System.Drawing.Point(114, 50);
            this.SquareBox.Name = "SquareBox";
            this.SquareBox.Size = new System.Drawing.Size(121, 20);
            this.SquareBox.TabIndex = 6;
            // 
            // OpeningJearBox
            // 
            this.OpeningJearBox.Location = new System.Drawing.Point(135, 82);
            this.OpeningJearBox.Name = "OpeningJearBox";
            this.OpeningJearBox.Size = new System.Drawing.Size(100, 20);
            this.OpeningJearBox.TabIndex = 7;
            this.OpeningJearBox.Visible = false;
            // 
            // OwnerComboBox
            // 
            this.OwnerComboBox.FormattingEnabled = true;
            this.OwnerComboBox.Location = new System.Drawing.Point(114, 112);
            this.OwnerComboBox.Name = "OwnerComboBox";
            this.OwnerComboBox.Size = new System.Drawing.Size(121, 21);
            this.OwnerComboBox.TabIndex = 8;
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Location = new System.Drawing.Point(114, 139);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.AddressComboBox.TabIndex = 9;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(160, 176);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(114, 85);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 12;
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 211);
            this.Controls.Add(this.check);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddressComboBox);
            this.Controls.Add(this.OwnerComboBox);
            this.Controls.Add(this.OpeningJearBox);
            this.Controls.Add(this.SquareBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Введите завод";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SquareBox;
        private System.Windows.Forms.TextBox OpeningJearBox;
        private System.Windows.Forms.ComboBox OwnerComboBox;
        private System.Windows.Forms.ComboBox AddressComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckBox check;
    }
}