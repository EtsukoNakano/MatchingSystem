namespace MatchingSystem
{
    partial class MachingMenuForm
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
            this.btnMatchingSearch = new System.Windows.Forms.Button();
            this.btnMatchiCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "＜マッチングメニュー＞";
            // 
            // btnMatchingSearch
            // 
            this.btnMatchingSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnMatchingSearch.Location = new System.Drawing.Point(292, 170);
            this.btnMatchingSearch.Name = "btnMatchingSearch";
            this.btnMatchingSearch.Size = new System.Drawing.Size(200, 50);
            this.btnMatchingSearch.TabIndex = 2;
            this.btnMatchingSearch.Text = "マッチする会員を探す";
            this.btnMatchingSearch.UseVisualStyleBackColor = true;
            this.btnMatchingSearch.Click += new System.EventHandler(this.btnMatchingSearch_Click);
            // 
            // btnMatchiCheck
            // 
            this.btnMatchiCheck.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnMatchiCheck.Location = new System.Drawing.Point(292, 249);
            this.btnMatchiCheck.Name = "btnMatchiCheck";
            this.btnMatchiCheck.Size = new System.Drawing.Size(200, 50);
            this.btnMatchiCheck.TabIndex = 2;
            this.btnMatchiCheck.Text = "マッチ度を判定する";
            this.btnMatchiCheck.UseVisualStyleBackColor = true;
            this.btnMatchiCheck.Click += new System.EventHandler(this.btnMatchiCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(229, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "マッチさせる会員のID又は氏名を入力してください";
            // 
            // txtIDName
            // 
            this.txtIDName.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txtIDName.Location = new System.Drawing.Point(292, 111);
            this.txtIDName.Name = "txtIDName";
            this.txtIDName.Size = new System.Drawing.Size(200, 29);
            this.txtIDName.TabIndex = 4;
            // 
            // MachingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIDName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMatchiCheck);
            this.Controls.Add(this.btnMatchingSearch);
            this.Controls.Add(this.label1);
            this.Name = "MachingMenuForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatchingSearch;
        private System.Windows.Forms.Button btnMatchiCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDName;
    }
}