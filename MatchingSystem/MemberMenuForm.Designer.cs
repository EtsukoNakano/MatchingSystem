namespace MatchingSystem
{
    partial class MemberMenuForm
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
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnMemberUpdate = new System.Windows.Forms.Button();
            this.btnMemberSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "＜会員管理メニュー＞";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnNewMember.Location = new System.Drawing.Point(309, 102);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(200, 50);
            this.btnNewMember.TabIndex = 2;
            this.btnNewMember.Text = "会員新規登録";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnMemberUpdate
            // 
            this.btnMemberUpdate.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnMemberUpdate.Location = new System.Drawing.Point(309, 190);
            this.btnMemberUpdate.Name = "btnMemberUpdate";
            this.btnMemberUpdate.Size = new System.Drawing.Size(200, 50);
            this.btnMemberUpdate.TabIndex = 3;
            this.btnMemberUpdate.Text = "会員情報更新";
            this.btnMemberUpdate.UseVisualStyleBackColor = true;
            this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click);
            // 
            // btnMemberSearch
            // 
            this.btnMemberSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnMemberSearch.Location = new System.Drawing.Point(309, 281);
            this.btnMemberSearch.Name = "btnMemberSearch";
            this.btnMemberSearch.Size = new System.Drawing.Size(200, 50);
            this.btnMemberSearch.TabIndex = 4;
            this.btnMemberSearch.Text = "会員検索";
            this.btnMemberSearch.UseVisualStyleBackColor = true;
            this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
            // 
            // MemberMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMemberSearch);
            this.Controls.Add(this.btnMemberUpdate);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.label1);
            this.Name = "MemberMenuForm";
            this.Text = "MemberMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnMemberUpdate;
        private System.Windows.Forms.Button btnMemberSearch;
    }
}