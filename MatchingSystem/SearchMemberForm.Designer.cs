namespace MatchingSystem
{
    partial class SearchMemberForm
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
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdoBirthday = new System.Windows.Forms.RadioButton();
            this.rdoRegisterDate = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "＜会員検索一覧＞";
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(12, 60);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowTemplate.Height = 21;
            this.dgvMember.Size = new System.Drawing.Size(775, 232);
            this.dgvMember.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(12, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "IDまたは氏名";
            // 
            // txtIDName
            // 
            this.txtIDName.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txtIDName.Location = new System.Drawing.Point(111, 323);
            this.txtIDName.Name = "txtIDName";
            this.txtIDName.Size = new System.Drawing.Size(180, 29);
            this.txtIDName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "検索条件";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dtpBirthday.Location = new System.Drawing.Point(111, 298);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(180, 23);
            this.dtpBirthday.TabIndex = 25;
            this.dtpBirthday.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(355, 298);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 23);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // rdoBirthday
            // 
            this.rdoBirthday.AutoSize = true;
            this.rdoBirthday.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rdoBirthday.Location = new System.Drawing.Point(546, 301);
            this.rdoBirthday.Name = "rdoBirthday";
            this.rdoBirthday.Size = new System.Drawing.Size(122, 20);
            this.rdoBirthday.TabIndex = 27;
            this.rdoBirthday.TabStop = true;
            this.rdoBirthday.Text = "生年月日検索";
            this.rdoBirthday.UseVisualStyleBackColor = true;
            // 
            // rdoRegisterDate
            // 
            this.rdoRegisterDate.AutoSize = true;
            this.rdoRegisterDate.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.rdoRegisterDate.Location = new System.Drawing.Point(682, 301);
            this.rdoRegisterDate.Name = "rdoRegisterDate";
            this.rdoRegisterDate.Size = new System.Drawing.Size(106, 20);
            this.rdoRegisterDate.TabIndex = 27;
            this.rdoRegisterDate.TabStop = true;
            this.rdoRegisterDate.Text = "登録日検索";
            this.rdoRegisterDate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(309, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "～";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(301, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "性別";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "全て",
            "男性",
            "女性"});
            this.cmbGender.Location = new System.Drawing.Point(357, 327);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(180, 24);
            this.cmbGender.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(561, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "住所";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txtAddress.Location = new System.Drawing.Point(607, 327);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 29);
            this.txtAddress.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label12.Location = new System.Drawing.Point(25, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "検索項目1";
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteCustomSource.AddRange(new string[] {
            "会員ステータス",
            "身長",
            "体重",
            "血液型",
            "学歴",
            "職業",
            "雇用形態",
            "年収(万円単位)",
            "共働き",
            "子供",
            "婚姻歴",
            "子供の有無",
            "趣味"});
            this.comboBox4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "住所",
            "身長",
            "体重",
            "血液型",
            "学歴",
            "職業",
            "雇用形態",
            "年収",
            "共働き",
            "子供",
            "婚姻歴",
            "子供の有無",
            "趣味"});
            this.comboBox4.Location = new System.Drawing.Point(111, 359);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(180, 24);
            this.comboBox4.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label13.Location = new System.Drawing.Point(301, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "条件1";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.textBox4.Location = new System.Drawing.Point(357, 357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 26);
            this.textBox4.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(25, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "検索項目2";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "会員ステータス",
            "身長",
            "体重",
            "血液型",
            "学歴",
            "職業",
            "雇用形態",
            "年収(万円単位)",
            "共働き",
            "子供",
            "婚姻歴",
            "子供の有無",
            "趣味"});
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "住所",
            "身長",
            "体重",
            "血液型",
            "学歴",
            "職業",
            "雇用形態",
            "年収",
            "共働き",
            "子供",
            "婚姻歴",
            "子供の有無",
            "趣味"});
            this.comboBox1.Location = new System.Drawing.Point(111, 391);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(301, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "条件2";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.textBox1.Location = new System.Drawing.Point(357, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.textBox2.Location = new System.Drawing.Point(357, 421);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(301, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "条件3";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "会員ステータス",
            "身長",
            "体重",
            "血液型",
            "学歴",
            "職業",
            "雇用形態",
            "年収(万円単位)",
            "共働き",
            "子供",
            "婚姻歴",
            "子供の有無",
            "趣味"});
            this.comboBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "住所",
            "身長",
            "体重",
            "血液型",
            "学歴",
            "職業",
            "雇用形態",
            "年収",
            "共働き",
            "子供",
            "婚姻歴",
            "子供の有無",
            "趣味"});
            this.comboBox2.Location = new System.Drawing.Point(111, 423);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(180, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(25, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "検索項目3";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnSearchMember.Location = new System.Drawing.Point(588, 396);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(200, 50);
            this.btnSearchMember.TabIndex = 34;
            this.btnSearchMember.Text = "この条件で検索する";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            // 
            // SearchMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdoRegisterDate);
            this.Controls.Add(this.rdoBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtIDName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.label1);
            this.Name = "SearchMemberForm";
            this.Text = "SearchMemberForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdoBirthday;
        private System.Windows.Forms.RadioButton rdoRegisterDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearchMember;
    }
}