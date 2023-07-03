namespace VetClinic.doctor.Forms
{
    partial class DoctorForm
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
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxSpecialization = new System.Windows.Forms.TextBox();
            this.labelSpecialization = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.labelFio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.groupBoxDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoctors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.specialization});
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.RowHeadersVisible = false;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(462, 211);
            this.dataGridViewDoctors.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // fio
            // 
            this.fio.FillWeight = 150F;
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // specialization
            // 
            this.specialization.HeaderText = "Специализация";
            this.specialization.Name = "specialization";
            this.specialization.ReadOnly = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(558, 87);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(558, 41);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(558, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.buttonCancel);
            this.groupBoxDoctor.Controls.Add(this.buttonOk);
            this.groupBoxDoctor.Controls.Add(this.textBoxSpecialization);
            this.groupBoxDoctor.Controls.Add(this.labelSpecialization);
            this.groupBoxDoctor.Controls.Add(this.textBoxFio);
            this.groupBoxDoctor.Controls.Add(this.labelFio);
            this.groupBoxDoctor.Location = new System.Drawing.Point(500, 12);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(200, 137);
            this.groupBoxDoctor.TabIndex = 7;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Врач";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(119, 103);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(38, 103);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxSpecialization
            // 
            this.textBoxSpecialization.Location = new System.Drawing.Point(10, 77);
            this.textBoxSpecialization.Name = "textBoxSpecialization";
            this.textBoxSpecialization.Size = new System.Drawing.Size(184, 20);
            this.textBoxSpecialization.TabIndex = 5;
            // 
            // labelSpecialization
            // 
            this.labelSpecialization.AutoSize = true;
            this.labelSpecialization.Location = new System.Drawing.Point(7, 60);
            this.labelSpecialization.Name = "labelSpecialization";
            this.labelSpecialization.Size = new System.Drawing.Size(89, 13);
            this.labelSpecialization.TabIndex = 4;
            this.labelSpecialization.Text = "Специализация:";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(10, 37);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(184, 20);
            this.textBoxFio.TabIndex = 1;
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Location = new System.Drawing.Point(7, 20);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(37, 13);
            this.labelFio.TabIndex = 0;
            this.labelFio.Text = "ФИО:";
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 236);
            this.Controls.Add(this.groupBoxDoctor);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Врачи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxSpecialization;
        private System.Windows.Forms.Label labelSpecialization;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label labelFio;
    }
}