namespace VetClinic.animal.Forms
{
    partial class AnimalForm
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
            this.dataGridViewAnimals = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAnimal = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.textBoxTypeAnimal = new System.Windows.Forms.TextBox();
            this.labelTypeAnimal = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).BeginInit();
            this.groupBoxAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAnimals
            // 
            this.dataGridViewAnimals.AllowUserToAddRows = false;
            this.dataGridViewAnimals.AllowUserToDeleteRows = false;
            this.dataGridViewAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAnimals.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthDate,
            this.typeAnimal,
            this.sex,
            this.owner});
            this.dataGridViewAnimals.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAnimals.Name = "dataGridViewAnimals";
            this.dataGridViewAnimals.ReadOnly = true;
            this.dataGridViewAnimals.RowHeadersVisible = false;
            this.dataGridViewAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnimals.Size = new System.Drawing.Size(665, 211);
            this.dataGridViewAnimals.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Кличка";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "Дата рождения";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            // 
            // typeAnimal
            // 
            this.typeAnimal.HeaderText = "Вид";
            this.typeAnimal.Name = "typeAnimal";
            this.typeAnimal.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.FillWeight = 25F;
            this.sex.HeaderText = "Пол";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // owner
            // 
            this.owner.FillWeight = 150F;
            this.owner.HeaderText = "Хозяин";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(763, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(763, 41);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(763, 87);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxAnimal
            // 
            this.groupBoxAnimal.Controls.Add(this.buttonCancel);
            this.groupBoxAnimal.Controls.Add(this.buttonOk);
            this.groupBoxAnimal.Controls.Add(this.comboBoxOwner);
            this.groupBoxAnimal.Controls.Add(this.labelOwner);
            this.groupBoxAnimal.Controls.Add(this.comboBoxSex);
            this.groupBoxAnimal.Controls.Add(this.labelSex);
            this.groupBoxAnimal.Controls.Add(this.textBoxTypeAnimal);
            this.groupBoxAnimal.Controls.Add(this.labelTypeAnimal);
            this.groupBoxAnimal.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxAnimal.Controls.Add(this.labelBirthDate);
            this.groupBoxAnimal.Controls.Add(this.textBoxName);
            this.groupBoxAnimal.Controls.Add(this.labelName);
            this.groupBoxAnimal.Location = new System.Drawing.Point(709, 12);
            this.groupBoxAnimal.Name = "groupBoxAnimal";
            this.groupBoxAnimal.Size = new System.Drawing.Size(200, 211);
            this.groupBoxAnimal.TabIndex = 4;
            this.groupBoxAnimal.TabStop = false;
            this.groupBoxAnimal.Text = "Животное";
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
            // comboBoxOwner
            // 
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(9, 155);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(185, 21);
            this.comboBoxOwner.TabIndex = 9;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(7, 140);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(47, 13);
            this.labelOwner.TabIndex = 8;
            this.labelOwner.Text = "Хозяин:";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Ж",
            "М"});
            this.comboBoxSex.Location = new System.Drawing.Point(140, 115);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(54, 21);
            this.comboBoxSex.TabIndex = 7;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(138, 100);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(30, 13);
            this.labelSex.TabIndex = 6;
            this.labelSex.Text = "Пол:";
            // 
            // textBoxTypeAnimal
            // 
            this.textBoxTypeAnimal.Location = new System.Drawing.Point(10, 117);
            this.textBoxTypeAnimal.Name = "textBoxTypeAnimal";
            this.textBoxTypeAnimal.Size = new System.Drawing.Size(123, 20);
            this.textBoxTypeAnimal.TabIndex = 5;
            // 
            // labelTypeAnimal
            // 
            this.labelTypeAnimal.AutoSize = true;
            this.labelTypeAnimal.Location = new System.Drawing.Point(7, 100);
            this.labelTypeAnimal.Name = "labelTypeAnimal";
            this.labelTypeAnimal.Size = new System.Drawing.Size(29, 13);
            this.labelTypeAnimal.TabIndex = 4;
            this.labelTypeAnimal.Text = "Вид:";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(10, 77);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerBirthDate.TabIndex = 3;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(7, 60);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(89, 13);
            this.labelBirthDate.TabIndex = 2;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(10, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(184, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Кличка:";
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 238);
            this.Controls.Add(this.groupBoxAnimal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Животные";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimals)).EndInit();
            this.groupBoxAnimal.ResumeLayout(false);
            this.groupBoxAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnimals;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxAnimal;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxTypeAnimal;
        private System.Windows.Forms.Label labelTypeAnimal;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}