namespace VetClinic.owner.Forms
{
    partial class OwnerForm
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
            this.dataGridViewOwners = new System.Windows.Forms.DataGridView();
            this.groupBoxOwner = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.labelFio = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).BeginInit();
            this.groupBoxOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOwners
            // 
            this.dataGridViewOwners.AllowUserToAddRows = false;
            this.dataGridViewOwners.AllowUserToDeleteRows = false;
            this.dataGridViewOwners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOwners.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.passport,
            this.address,
            this.phone});
            this.dataGridViewOwners.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOwners.Name = "dataGridViewOwners";
            this.dataGridViewOwners.ReadOnly = true;
            this.dataGridViewOwners.RowHeadersVisible = false;
            this.dataGridViewOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOwners.Size = new System.Drawing.Size(665, 211);
            this.dataGridViewOwners.TabIndex = 1;
            // 
            // groupBoxOwner
            // 
            this.groupBoxOwner.Controls.Add(this.textBoxPhone);
            this.groupBoxOwner.Controls.Add(this.labelPhone);
            this.groupBoxOwner.Controls.Add(this.textBoxAddress);
            this.groupBoxOwner.Controls.Add(this.labelAddress);
            this.groupBoxOwner.Controls.Add(this.buttonCancel);
            this.groupBoxOwner.Controls.Add(this.buttonOk);
            this.groupBoxOwner.Controls.Add(this.textBoxPassport);
            this.groupBoxOwner.Controls.Add(this.labelPassport);
            this.groupBoxOwner.Controls.Add(this.textBoxFio);
            this.groupBoxOwner.Controls.Add(this.labelFio);
            this.groupBoxOwner.Location = new System.Drawing.Point(683, 12);
            this.groupBoxOwner.Name = "groupBoxOwner";
            this.groupBoxOwner.Size = new System.Drawing.Size(200, 211);
            this.groupBoxOwner.TabIndex = 5;
            this.groupBoxOwner.TabStop = false;
            this.groupBoxOwner.Text = "Хозяин";
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
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(9, 77);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(185, 20);
            this.textBoxPassport.TabIndex = 5;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(6, 60);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(135, 13);
            this.labelPassport.TabIndex = 4;
            this.labelPassport.Text = "Серия и номер паспорта:";
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
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(9, 157);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(185, 20);
            this.textBoxPhone.TabIndex = 14;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(6, 140);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(96, 13);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Номер телефона:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(10, 117);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(184, 20);
            this.textBoxAddress.TabIndex = 12;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(7, 100);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(106, 13);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Адрес проживания:";
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
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // passport
            // 
            this.passport.HeaderText = "Серия и номер паспорта";
            this.passport.Name = "passport";
            this.passport.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес проживания";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Номер телефона";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(757, 87);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(757, 41);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(757, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 241);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBoxOwner);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewOwners);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OwnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хозяева";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwners)).EndInit();
            this.groupBoxOwner.ResumeLayout(false);
            this.groupBoxOwner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOwners;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.GroupBox groupBoxOwner;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
    }
}