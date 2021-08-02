
namespace CSharp_SQL
{
    partial class FormSQL
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
            this.labStudentName = new System.Windows.Forms.Label();
            this.txbStudentName = new System.Windows.Forms.TextBox();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.radWoman = new System.Windows.Forms.RadioButton();
            this.cmbStudentGrade = new System.Windows.Forms.ComboBox();
            this.labStudentGrade = new System.Windows.Forms.Label();
            this.labStudentGender = new System.Windows.Forms.Label();
            this.labStudentAddr = new System.Windows.Forms.Label();
            this.txbStudentAddr = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labStudentName
            // 
            this.labStudentName.AutoSize = true;
            this.labStudentName.Location = new System.Drawing.Point(37, 33);
            this.labStudentName.Name = "labStudentName";
            this.labStudentName.Size = new System.Drawing.Size(29, 12);
            this.labStudentName.TabIndex = 0;
            this.labStudentName.Text = "姓名";
            // 
            // txbStudentName
            // 
            this.txbStudentName.Location = new System.Drawing.Point(102, 30);
            this.txbStudentName.Name = "txbStudentName";
            this.txbStudentName.Size = new System.Drawing.Size(162, 21);
            this.txbStudentName.TabIndex = 1;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(102, 78);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(35, 16);
            this.radMan.TabIndex = 2;
            this.radMan.TabStop = true;
            this.radMan.Text = "男";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // radWoman
            // 
            this.radWoman.AutoSize = true;
            this.radWoman.Location = new System.Drawing.Point(167, 78);
            this.radWoman.Name = "radWoman";
            this.radWoman.Size = new System.Drawing.Size(35, 16);
            this.radWoman.TabIndex = 3;
            this.radWoman.TabStop = true;
            this.radWoman.Text = "女";
            this.radWoman.UseVisualStyleBackColor = true;
            // 
            // cmbStudentGrade
            // 
            this.cmbStudentGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentGrade.FormattingEnabled = true;
            this.cmbStudentGrade.Location = new System.Drawing.Point(102, 122);
            this.cmbStudentGrade.Name = "cmbStudentGrade";
            this.cmbStudentGrade.Size = new System.Drawing.Size(162, 20);
            this.cmbStudentGrade.TabIndex = 4;
            // 
            // labStudentGrade
            // 
            this.labStudentGrade.AutoSize = true;
            this.labStudentGrade.Location = new System.Drawing.Point(37, 125);
            this.labStudentGrade.Name = "labStudentGrade";
            this.labStudentGrade.Size = new System.Drawing.Size(29, 12);
            this.labStudentGrade.TabIndex = 5;
            this.labStudentGrade.Text = "班级";
            // 
            // labStudentGender
            // 
            this.labStudentGender.AutoSize = true;
            this.labStudentGender.Location = new System.Drawing.Point(37, 78);
            this.labStudentGender.Name = "labStudentGender";
            this.labStudentGender.Size = new System.Drawing.Size(29, 12);
            this.labStudentGender.TabIndex = 6;
            this.labStudentGender.Text = "性别";
            // 
            // labStudentAddr
            // 
            this.labStudentAddr.AutoSize = true;
            this.labStudentAddr.Location = new System.Drawing.Point(37, 269);
            this.labStudentAddr.Name = "labStudentAddr";
            this.labStudentAddr.Size = new System.Drawing.Size(29, 12);
            this.labStudentAddr.TabIndex = 7;
            this.labStudentAddr.Text = "地址";
            // 
            // txbStudentAddr
            // 
            this.txbStudentAddr.Location = new System.Drawing.Point(102, 251);
            this.txbStudentAddr.Multiline = true;
            this.txbStudentAddr.Name = "txbStudentAddr";
            this.txbStudentAddr.Size = new System.Drawing.Size(162, 51);
            this.txbStudentAddr.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "省份";
            // 
            // cmbProvince
            // 
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(102, 164);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(162, 20);
            this.cmbProvince.TabIndex = 14;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(102, 206);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(162, 20);
            this.cmbCity.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "城市";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 366);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbStudentAddr);
            this.Controls.Add(this.labStudentAddr);
            this.Controls.Add(this.labStudentGender);
            this.Controls.Add(this.labStudentGrade);
            this.Controls.Add(this.cmbStudentGrade);
            this.Controls.Add(this.radWoman);
            this.Controls.Add(this.radMan);
            this.Controls.Add(this.txbStudentName);
            this.Controls.Add(this.labStudentName);
            this.Name = "FormSQL";
            this.Opacity = 0.8D;
            this.Text = "FormSQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStudentName;
        private System.Windows.Forms.TextBox txbStudentName;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.RadioButton radWoman;
        private System.Windows.Forms.ComboBox cmbStudentGrade;
        private System.Windows.Forms.Label labStudentGrade;
        private System.Windows.Forms.Label labStudentGender;
        private System.Windows.Forms.Label labStudentAddr;
        private System.Windows.Forms.TextBox txbStudentAddr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label2;
    }
}