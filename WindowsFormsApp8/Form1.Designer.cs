namespace WindowsFormsApp8
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tab = new System.Windows.Forms.TabControl();
            this.FactoryTab = new System.Windows.Forms.TabPage();
            this.factoryUserControl1 = new WindowsFormsApp8.UserControls.FactoryUserControl();
            this.Tab.SuspendLayout();
            this.FactoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.FactoryTab);
            this.Tab.Location = new System.Drawing.Point(3, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(865, 482);
            this.Tab.TabIndex = 0;
            // 
            // FactoryTab
            // 
            this.FactoryTab.Controls.Add(this.factoryUserControl1);
            this.FactoryTab.Location = new System.Drawing.Point(4, 22);
            this.FactoryTab.Name = "FactoryTab";
            this.FactoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.FactoryTab.Size = new System.Drawing.Size(857, 456);
            this.FactoryTab.TabIndex = 0;
            this.FactoryTab.Text = "Завод";
            this.FactoryTab.UseVisualStyleBackColor = true;
            // 
            // factoryUserControl1
            // 
            this.factoryUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factoryUserControl1.Location = new System.Drawing.Point(3, 3);
            this.factoryUserControl1.Name = "factoryUserControl1";
            this.factoryUserControl1.Size = new System.Drawing.Size(851, 450);
            this.factoryUserControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 499);
            this.Controls.Add(this.Tab);
            this.Name = "Main";
            this.Text = "Шоколадные фабрики";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Tab.ResumeLayout(false);
            this.FactoryTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage FactoryTab;
        private UserControls.FactoryUserControl factoryUserControl1;
    }
}

