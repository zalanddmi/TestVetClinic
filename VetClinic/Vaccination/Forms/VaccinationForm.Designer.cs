namespace VetClinic.vaccination.Forms
{
    partial class VaccinationForm
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
            this.dataGridViewVaccinations = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxVaccination = new System.Windows.Forms.GroupBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.labelService = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.labelAnimal = new System.Windows.Forms.Label();
            this.dateTimePickerDateVac = new System.Windows.Forms.DateTimePicker();
            this.labelDateVac = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccinations)).BeginInit();
            this.groupBoxVaccination.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVaccinations
            // 
            this.dataGridViewVaccinations.AllowUserToAddRows = false;
            this.dataGridViewVaccinations.AllowUserToDeleteRows = false;
            this.dataGridViewVaccinations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVaccinations.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewVaccinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccinations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dateVac,
            this.animal,
            this.doctor,
            this.service});
            this.dataGridViewVaccinations.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVaccinations.Name = "dataGridViewVaccinations";
            this.dataGridViewVaccinations.ReadOnly = true;
            this.dataGridViewVaccinations.RowHeadersVisible = false;
            this.dataGridViewVaccinations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVaccinations.Size = new System.Drawing.Size(665, 211);
            this.dataGridViewVaccinations.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dateVac
            // 
            this.dateVac.HeaderText = "Дата прививки";
            this.dateVac.Name = "dateVac";
            this.dateVac.ReadOnly = true;
            // 
            // animal
            // 
            this.animal.HeaderText = "Животное";
            this.animal.Name = "animal";
            this.animal.ReadOnly = true;
            // 
            // doctor
            // 
            this.doctor.HeaderText = "Врач";
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            // 
            // service
            // 
            this.service.HeaderText = "Услуга";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            // 
            // groupBoxVaccination
            // 
            this.groupBoxVaccination.Controls.Add(this.comboBoxService);
            this.groupBoxVaccination.Controls.Add(this.labelService);
            this.groupBoxVaccination.Controls.Add(this.comboBoxDoctor);
            this.groupBoxVaccination.Controls.Add(this.labelDoctor);
            this.groupBoxVaccination.Controls.Add(this.buttonCancel);
            this.groupBoxVaccination.Controls.Add(this.buttonOk);
            this.groupBoxVaccination.Controls.Add(this.comboBoxAnimal);
            this.groupBoxVaccination.Controls.Add(this.labelAnimal);
            this.groupBoxVaccination.Controls.Add(this.dateTimePickerDateVac);
            this.groupBoxVaccination.Controls.Add(this.labelDateVac);
            this.groupBoxVaccination.Location = new System.Drawing.Point(701, 12);
            this.groupBoxVaccination.Name = "groupBoxVaccination";
            this.groupBoxVaccination.Size = new System.Drawing.Size(200, 211);
            this.groupBoxVaccination.TabIndex = 8;
            this.groupBoxVaccination.TabStop = false;
            this.groupBoxVaccination.Text = "Прививка";
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(8, 149);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(185, 21);
            this.comboBoxService.TabIndex = 14;
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(6, 134);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(46, 13);
            this.labelService.TabIndex = 13;
            this.labelService.Text = "Услуга:";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(8, 110);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(185, 21);
            this.comboBoxDoctor.TabIndex = 12;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(6, 95);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(34, 13);
            this.labelDoctor.TabIndex = 11;
            this.labelDoctor.Text = "Врач:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(119, 182);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(38, 182);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxAnimal
            // 
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Location = new System.Drawing.Point(8, 71);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(185, 21);
            this.comboBoxAnimal.TabIndex = 9;
            // 
            // labelAnimal
            // 
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Location = new System.Drawing.Point(6, 56);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(62, 13);
            this.labelAnimal.TabIndex = 8;
            this.labelAnimal.Text = "Животное:";
            // 
            // dateTimePickerDateVac
            // 
            this.dateTimePickerDateVac.Location = new System.Drawing.Point(9, 33);
            this.dateTimePickerDateVac.Name = "dateTimePickerDateVac";
            this.dateTimePickerDateVac.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerDateVac.TabIndex = 3;
            // 
            // labelDateVac
            // 
            this.labelDateVac.AutoSize = true;
            this.labelDateVac.Location = new System.Drawing.Point(6, 16);
            this.labelDateVac.Name = "labelDateVac";
            this.labelDateVac.Size = new System.Drawing.Size(87, 13);
            this.labelDateVac.TabIndex = 2;
            this.labelDateVac.Text = "Дата прививки:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(756, 87);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(756, 41);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(756, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // VaccinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 242);
            this.Controls.Add(this.groupBoxVaccination);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewVaccinations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VaccinationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прививки";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccinations)).EndInit();
            this.groupBoxVaccination.ResumeLayout(false);
            this.groupBoxVaccination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVaccinations;
        private System.Windows.Forms.GroupBox groupBoxVaccination;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateVac;
        private System.Windows.Forms.Label labelDateVac;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVac;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
    }
}