namespace VetClinic
{
    partial class MenuForm
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
            this.buttonAnimals = new System.Windows.Forms.Button();
            this.buttonDoctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnimals
            // 
            this.buttonAnimals.Location = new System.Drawing.Point(349, 118);
            this.buttonAnimals.Name = "buttonAnimals";
            this.buttonAnimals.Size = new System.Drawing.Size(75, 23);
            this.buttonAnimals.TabIndex = 0;
            this.buttonAnimals.Text = "Животные";
            this.buttonAnimals.UseVisualStyleBackColor = true;
            this.buttonAnimals.Click += new System.EventHandler(this.buttonAnimals_Click);
            // 
            // buttonDoctors
            // 
            this.buttonDoctors.Location = new System.Drawing.Point(349, 147);
            this.buttonDoctors.Name = "buttonDoctors";
            this.buttonDoctors.Size = new System.Drawing.Size(75, 23);
            this.buttonDoctors.TabIndex = 1;
            this.buttonDoctors.Text = "Врачи";
            this.buttonDoctors.UseVisualStyleBackColor = true;
            this.buttonDoctors.Click += new System.EventHandler(this.buttonDoctors_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDoctors);
            this.Controls.Add(this.buttonAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnimals;
        private System.Windows.Forms.Button buttonDoctors;
    }
}

