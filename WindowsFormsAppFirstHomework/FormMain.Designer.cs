
namespace WindowsFormsAppFirstHomework
{
    partial class FormMain
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
            this.dataGridViewPhoneNumbers = new System.Windows.Forms.DataGridView();
            this.buttonPhoneNumbersFromTxtFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddPhoneNumber = new System.Windows.Forms.Button();
            this.buttonLoadPhoneNumbersFromBinFile = new System.Windows.Forms.Button();
            this.buttonSavePhoneNumbersTxtToFile = new System.Windows.Forms.Button();
            this.buttonSavePhoneNumbersBinToFile = new System.Windows.Forms.Button();
            this.textBoxIndexForDelete = new System.Windows.Forms.TextBox();
            this.buttonDeletePhoneNumber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxReplaceInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReplaceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxReplaceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxReplaceIndex = new System.Windows.Forms.TextBox();
            this.butbuttonReplacePhoneNumber = new System.Windows.Forms.Button();
            this.buttonPrintByGrade = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.comboBoxByGrade = new System.Windows.Forms.ComboBox();
            this.buttonResetRetrive = new System.Windows.Forms.Button();
            this.comboBoxReplaceGrade = new System.Windows.Forms.ComboBox();
            this.buttonOpenNewForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhoneNumbers
            // 
            this.dataGridViewPhoneNumbers.AllowUserToAddRows = false;
            this.dataGridViewPhoneNumbers.AllowUserToDeleteRows = false;
            this.dataGridViewPhoneNumbers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPhoneNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneNumbers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewPhoneNumbers.Location = new System.Drawing.Point(16, 16);
            this.dataGridViewPhoneNumbers.Name = "dataGridViewPhoneNumbers";
            this.dataGridViewPhoneNumbers.ReadOnly = true;
            this.dataGridViewPhoneNumbers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhoneNumbers.Size = new System.Drawing.Size(544, 280);
            this.dataGridViewPhoneNumbers.TabIndex = 0;
            this.dataGridViewPhoneNumbers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhoneNumbers_CellClick);
            // 
            // buttonPhoneNumbersFromTxtFile
            // 
            this.buttonPhoneNumbersFromTxtFile.Location = new System.Drawing.Point(16, 311);
            this.buttonPhoneNumbersFromTxtFile.Name = "buttonPhoneNumbersFromTxtFile";
            this.buttonPhoneNumbersFromTxtFile.Size = new System.Drawing.Size(265, 23);
            this.buttonPhoneNumbersFromTxtFile.TabIndex = 1;
            this.buttonPhoneNumbersFromTxtFile.Text = "Загрузить список телефонов из txt файла";
            this.buttonPhoneNumbersFromTxtFile.UseVisualStyleBackColor = true;
            this.buttonPhoneNumbersFromTxtFile.Click += new System.EventHandler(this.buttonPhoneNumbersFromTxtFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "номер телефона";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(603, 32);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(125, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(603, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(125, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "имя контакта";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(603, 110);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(125, 20);
            this.textBoxInfo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "информацию о контакте";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(776, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 80);
            this.label4.TabIndex = 8;
            this.label4.Text = "Важность контакта\r\nкем является контакт\r\n0 - коллега,\r\n1 - друг,\r\n2 - родственник" +
    ",\r\n3 - важный контакт: ";
            // 
            // buttonAddPhoneNumber
            // 
            this.buttonAddPhoneNumber.Location = new System.Drawing.Point(600, 152);
            this.buttonAddPhoneNumber.Name = "buttonAddPhoneNumber";
            this.buttonAddPhoneNumber.Size = new System.Drawing.Size(302, 23);
            this.buttonAddPhoneNumber.TabIndex = 10;
            this.buttonAddPhoneNumber.Text = "Добавить номер";
            this.buttonAddPhoneNumber.UseVisualStyleBackColor = true;
            this.buttonAddPhoneNumber.Click += new System.EventHandler(this.buttonAddPhoneNumber_Click);
            // 
            // buttonLoadPhoneNumbersFromBinFile
            // 
            this.buttonLoadPhoneNumbersFromBinFile.Location = new System.Drawing.Point(295, 311);
            this.buttonLoadPhoneNumbersFromBinFile.Name = "buttonLoadPhoneNumbersFromBinFile";
            this.buttonLoadPhoneNumbersFromBinFile.Size = new System.Drawing.Size(265, 23);
            this.buttonLoadPhoneNumbersFromBinFile.TabIndex = 11;
            this.buttonLoadPhoneNumbersFromBinFile.Text = "Загрузить список телефонов из bin файла";
            this.buttonLoadPhoneNumbersFromBinFile.UseVisualStyleBackColor = true;
            this.buttonLoadPhoneNumbersFromBinFile.Click += new System.EventHandler(this.buttonLoadPhoneNumbersFromBinFile_Click);
            // 
            // buttonSavePhoneNumbersTxtToFile
            // 
            this.buttonSavePhoneNumbersTxtToFile.Location = new System.Drawing.Point(16, 341);
            this.buttonSavePhoneNumbersTxtToFile.Name = "buttonSavePhoneNumbersTxtToFile";
            this.buttonSavePhoneNumbersTxtToFile.Size = new System.Drawing.Size(265, 23);
            this.buttonSavePhoneNumbersTxtToFile.TabIndex = 12;
            this.buttonSavePhoneNumbersTxtToFile.Text = "Сохранить список телефонов в txt файл";
            this.buttonSavePhoneNumbersTxtToFile.UseVisualStyleBackColor = true;
            this.buttonSavePhoneNumbersTxtToFile.Click += new System.EventHandler(this.buttonSavePhoneNumbersTxtToFile_Click);
            // 
            // buttonSavePhoneNumbersBinToFile
            // 
            this.buttonSavePhoneNumbersBinToFile.Location = new System.Drawing.Point(295, 341);
            this.buttonSavePhoneNumbersBinToFile.Name = "buttonSavePhoneNumbersBinToFile";
            this.buttonSavePhoneNumbersBinToFile.Size = new System.Drawing.Size(265, 23);
            this.buttonSavePhoneNumbersBinToFile.TabIndex = 13;
            this.buttonSavePhoneNumbersBinToFile.Text = "Сохранить список телефонов в bin файл";
            this.buttonSavePhoneNumbersBinToFile.UseVisualStyleBackColor = true;
            this.buttonSavePhoneNumbersBinToFile.Click += new System.EventHandler(this.buttonSavePhoneNumbersBinToFile_Click);
            // 
            // textBoxIndexForDelete
            // 
            this.textBoxIndexForDelete.Location = new System.Drawing.Point(792, 248);
            this.textBoxIndexForDelete.Name = "textBoxIndexForDelete";
            this.textBoxIndexForDelete.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndexForDelete.TabIndex = 16;
            // 
            // buttonDeletePhoneNumber
            // 
            this.buttonDeletePhoneNumber.Location = new System.Drawing.Point(600, 280);
            this.buttonDeletePhoneNumber.Name = "buttonDeletePhoneNumber";
            this.buttonDeletePhoneNumber.Size = new System.Drawing.Size(296, 23);
            this.buttonDeletePhoneNumber.TabIndex = 19;
            this.buttonDeletePhoneNumber.Text = "удалить контакт";
            this.buttonDeletePhoneNumber.UseVisualStyleBackColor = true;
            this.buttonDeletePhoneNumber.Click += new System.EventHandler(this.buttonDeletePhoneNumber_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(776, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 80);
            this.label5.TabIndex = 27;
            this.label5.Text = "Важность контакта\r\nкем является контакт\r\n0 - коллега,\r\n1 - друг,\r\n2 - родственник" +
    ",\r\n3 - важный контакт: ";
            // 
            // textBoxReplaceInfo
            // 
            this.textBoxReplaceInfo.Location = new System.Drawing.Point(603, 520);
            this.textBoxReplaceInfo.Name = "textBoxReplaceInfo";
            this.textBoxReplaceInfo.Size = new System.Drawing.Size(117, 20);
            this.textBoxReplaceInfo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "информацию о контакте";
            // 
            // textBoxReplaceName
            // 
            this.textBoxReplaceName.Location = new System.Drawing.Point(603, 481);
            this.textBoxReplaceName.Name = "textBoxReplaceName";
            this.textBoxReplaceName.Size = new System.Drawing.Size(117, 20);
            this.textBoxReplaceName.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "имя контакта";
            // 
            // textBoxReplaceNumber
            // 
            this.textBoxReplaceNumber.Location = new System.Drawing.Point(603, 442);
            this.textBoxReplaceNumber.Name = "textBoxReplaceNumber";
            this.textBoxReplaceNumber.Size = new System.Drawing.Size(117, 20);
            this.textBoxReplaceNumber.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "номер телефона";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Введите индекс контакта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Введите индекс контакта:";
            // 
            // textBoxReplaceIndex
            // 
            this.textBoxReplaceIndex.Location = new System.Drawing.Point(768, 386);
            this.textBoxReplaceIndex.Name = "textBoxReplaceIndex";
            this.textBoxReplaceIndex.ReadOnly = true;
            this.textBoxReplaceIndex.Size = new System.Drawing.Size(128, 20);
            this.textBoxReplaceIndex.TabIndex = 30;
            // 
            // butbuttonReplacePhoneNumber
            // 
            this.butbuttonReplacePhoneNumber.Location = new System.Drawing.Point(600, 554);
            this.butbuttonReplacePhoneNumber.Name = "butbuttonReplacePhoneNumber";
            this.butbuttonReplacePhoneNumber.Size = new System.Drawing.Size(296, 23);
            this.butbuttonReplacePhoneNumber.TabIndex = 32;
            this.butbuttonReplacePhoneNumber.Text = "Изменить контакт";
            this.butbuttonReplacePhoneNumber.UseVisualStyleBackColor = true;
            this.butbuttonReplacePhoneNumber.Click += new System.EventHandler(this.butbuttonReplacePhoneNumber_Click);
            // 
            // buttonPrintByGrade
            // 
            this.buttonPrintByGrade.Location = new System.Drawing.Point(152, 432);
            this.buttonPrintByGrade.Name = "buttonPrintByGrade";
            this.buttonPrintByGrade.Size = new System.Drawing.Size(152, 40);
            this.buttonPrintByGrade.TabIndex = 33;
            this.buttonPrintByGrade.Text = "Выбрать";
            this.buttonPrintByGrade.UseVisualStyleBackColor = true;
            this.buttonPrintByGrade.Click += new System.EventHandler(this.buttonPrintByGrade_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(16, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 112);
            this.label11.TabIndex = 34;
            this.label11.Text = "Введите какие контакты нужно выбрать по важности:\r\n\r\n0 - коллега,\r\n1 - друг,\r\n2 -" +
    " родственник,\r\n3 - важный контакт: ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Индекс";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Имя";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Инфо";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Степень важности";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "коллега",
            "друг",
            "родственник",
            "важный контакт"});
            this.comboBoxGrade.Location = new System.Drawing.Point(776, 112);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(128, 21);
            this.comboBoxGrade.TabIndex = 36;
            // 
            // comboBoxByGrade
            // 
            this.comboBoxByGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxByGrade.FormattingEnabled = true;
            this.comboBoxByGrade.Items.AddRange(new object[] {
            "коллега",
            "друг",
            "родственник",
            "важный контакт"});
            this.comboBoxByGrade.Location = new System.Drawing.Point(152, 400);
            this.comboBoxByGrade.Name = "comboBoxByGrade";
            this.comboBoxByGrade.Size = new System.Drawing.Size(152, 21);
            this.comboBoxByGrade.TabIndex = 37;
            // 
            // buttonResetRetrive
            // 
            this.buttonResetRetrive.Location = new System.Drawing.Point(152, 480);
            this.buttonResetRetrive.Name = "buttonResetRetrive";
            this.buttonResetRetrive.Size = new System.Drawing.Size(152, 32);
            this.buttonResetRetrive.TabIndex = 38;
            this.buttonResetRetrive.Text = "Сбросить поиск";
            this.buttonResetRetrive.UseVisualStyleBackColor = true;
            this.buttonResetRetrive.Click += new System.EventHandler(this.buttonResetRetrive_Click);
            // 
            // comboBoxReplaceGrade
            // 
            this.comboBoxReplaceGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReplaceGrade.FormattingEnabled = true;
            this.comboBoxReplaceGrade.Items.AddRange(new object[] {
            "коллега",
            "друг",
            "родственник",
            "важный контакт"});
            this.comboBoxReplaceGrade.Location = new System.Drawing.Point(776, 520);
            this.comboBoxReplaceGrade.Name = "comboBoxReplaceGrade";
            this.comboBoxReplaceGrade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReplaceGrade.TabIndex = 39;
            // 
            // buttonOpenNewForm
            // 
            this.buttonOpenNewForm.Location = new System.Drawing.Point(296, 552);
            this.buttonOpenNewForm.Name = "buttonOpenNewForm";
            this.buttonOpenNewForm.Size = new System.Drawing.Size(264, 23);
            this.buttonOpenNewForm.TabIndex = 40;
            this.buttonOpenNewForm.Text = "OpenNewForm";
            this.buttonOpenNewForm.UseVisualStyleBackColor = true;
            this.buttonOpenNewForm.Click += new System.EventHandler(this.buttonOpenNewForm_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 598);
            this.Controls.Add(this.buttonOpenNewForm);
            this.Controls.Add(this.comboBoxReplaceGrade);
            this.Controls.Add(this.buttonResetRetrive);
            this.Controls.Add(this.comboBoxByGrade);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonPrintByGrade);
            this.Controls.Add(this.butbuttonReplacePhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxReplaceIndex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxReplaceInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxReplaceName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxReplaceNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDeletePhoneNumber);
            this.Controls.Add(this.textBoxIndexForDelete);
            this.Controls.Add(this.buttonSavePhoneNumbersBinToFile);
            this.Controls.Add(this.buttonSavePhoneNumbersTxtToFile);
            this.Controls.Add(this.buttonLoadPhoneNumbersFromBinFile);
            this.Controls.Add(this.buttonAddPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPhoneNumbersFromTxtFile);
            this.Controls.Add(this.dataGridViewPhoneNumbers);
            this.Name = "FormMain";
            this.Text = "Список контактов";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhoneNumbers;
        private System.Windows.Forms.Button buttonPhoneNumbersFromTxtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddPhoneNumber;
        private System.Windows.Forms.Button buttonLoadPhoneNumbersFromBinFile;
        private System.Windows.Forms.Button buttonSavePhoneNumbersTxtToFile;
        private System.Windows.Forms.Button buttonSavePhoneNumbersBinToFile;
        private System.Windows.Forms.TextBox textBoxIndexForDelete;
        private System.Windows.Forms.Button buttonDeletePhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxReplaceInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReplaceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxReplaceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxReplaceIndex;
        private System.Windows.Forms.Button butbuttonReplacePhoneNumber;
        private System.Windows.Forms.Button buttonPrintByGrade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxByGrade;
        private System.Windows.Forms.Button buttonResetRetrive;
        private System.Windows.Forms.ComboBox comboBoxReplaceGrade;
        private System.Windows.Forms.Button buttonOpenNewForm;
    }
}

