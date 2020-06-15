namespace PhoneBook
{
    partial class Form1
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLabel = new System.Windows.Forms.TextBox();
            this.lbxAll = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPhone1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPhone2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPhone3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPhone4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sPhone = new System.Windows.Forms.TextBox();
            this.searchAll = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(280, 517);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(374, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 517);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(261, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxPhone4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxPhone3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxPhone2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxPhone1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.tbxText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxLabel);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(280, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 498);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(6, 463);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(6, 262);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(368, 195);
            this.tbxText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текст записи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заголовок записи";
            // 
            // tbxLabel
            // 
            this.tbxLabel.Location = new System.Drawing.Point(3, 16);
            this.tbxLabel.Name = "tbxLabel";
            this.tbxLabel.Size = new System.Drawing.Size(371, 20);
            this.tbxLabel.TabIndex = 0;
            // 
            // lbxAll
            // 
            this.lbxAll.FormattingEnabled = true;
            this.lbxAll.Location = new System.Drawing.Point(12, 12);
            this.lbxAll.Name = "lbxAll";
            this.lbxAll.Size = new System.Drawing.Size(262, 498);
            this.lbxAll.TabIndex = 4;
            this.lbxAll.DoubleClick += new System.EventHandler(this.lbxAll_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "#1";
            // 
            // tbxPhone1
            // 
            this.tbxPhone1.Location = new System.Drawing.Point(3, 59);
            this.tbxPhone1.Name = "tbxPhone1";
            this.tbxPhone1.Size = new System.Drawing.Size(371, 20);
            this.tbxPhone1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "#2";
            // 
            // tbxPhone2
            // 
            this.tbxPhone2.Location = new System.Drawing.Point(3, 107);
            this.tbxPhone2.Name = "tbxPhone2";
            this.tbxPhone2.Size = new System.Drawing.Size(371, 20);
            this.tbxPhone2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "#3";
            // 
            // tbxPhone3
            // 
            this.tbxPhone3.Location = new System.Drawing.Point(3, 157);
            this.tbxPhone3.Name = "tbxPhone3";
            this.tbxPhone3.Size = new System.Drawing.Size(371, 20);
            this.tbxPhone3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "#4";
            // 
            // tbxPhone4
            // 
            this.tbxPhone4.Location = new System.Drawing.Point(3, 208);
            this.tbxPhone4.Name = "tbxPhone4";
            this.tbxPhone4.Size = new System.Drawing.Size(371, 20);
            this.tbxPhone4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.searchAll);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.sPhone);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.sName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(663, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 528);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Поиск";
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(3, 36);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(563, 20);
            this.sName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "ФИО";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Телефон";
            // 
            // sPhone
            // 
            this.sPhone.Location = new System.Drawing.Point(3, 73);
            this.sPhone.Name = "sPhone";
            this.sPhone.Size = new System.Drawing.Size(563, 20);
            this.sPhone.TabIndex = 3;
            // 
            // searchAll
            // 
            this.searchAll.FormattingEnabled = true;
            this.searchAll.Location = new System.Drawing.Point(6, 138);
            this.searchAll.Name = "searchAll";
            this.searchAll.Size = new System.Drawing.Size(560, 381);
            this.searchAll.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(491, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbxAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxLabel;
        private System.Windows.Forms.ListBox lbxAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPhone4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPhone3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPhone2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPhone1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sPhone;
        private System.Windows.Forms.ListBox searchAll;
        private System.Windows.Forms.Button btnSearch;
    }
}

