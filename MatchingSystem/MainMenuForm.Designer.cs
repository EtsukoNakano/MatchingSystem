namespace MatchingSystem
{
    partial class MainMenuForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnMemberMenu = new System.Windows.Forms.Button();
            this.btnMachingMenu = new System.Windows.Forms.Button();
            this.btnReferralMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "＜マッチングシステム＞";
            // 
            // btnMemberMenu
            // 
            this.btnMemberMenu.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnMemberMenu.Location = new System.Drawing.Point(303, 99);
            this.btnMemberMenu.Name = "btnMemberMenu";
            this.btnMemberMenu.Size = new System.Drawing.Size(200, 50);
            this.btnMemberMenu.TabIndex = 1;
            this.btnMemberMenu.Text = "会員管理メニュー";
            this.btnMemberMenu.UseVisualStyleBackColor = true;
            this.btnMemberMenu.Click += new System.EventHandler(this.btnMemberMenu_Click);
            // 
            // btnMachingMenu
            // 
            this.btnMachingMenu.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnMachingMenu.Location = new System.Drawing.Point(303, 182);
            this.btnMachingMenu.Name = "btnMachingMenu";
            this.btnMachingMenu.Size = new System.Drawing.Size(200, 50);
            this.btnMachingMenu.TabIndex = 2;
            this.btnMachingMenu.Text = "マッチングメニュー";
            this.btnMachingMenu.UseVisualStyleBackColor = true;
            this.btnMachingMenu.Click += new System.EventHandler(this.btnMachingMenu_Click);
            // 
            // btnReferralMenu
            // 
            this.btnReferralMenu.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnReferralMenu.Location = new System.Drawing.Point(303, 263);
            this.btnReferralMenu.Name = "btnReferralMenu";
            this.btnReferralMenu.Size = new System.Drawing.Size(200, 50);
            this.btnReferralMenu.TabIndex = 3;
            this.btnReferralMenu.Text = "紹介管理メニュー";
            this.btnReferralMenu.UseVisualStyleBackColor = true;
            this.btnReferralMenu.Click += new System.EventHandler(this.btnReferralMenu_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReferralMenu);
            this.Controls.Add(this.btnMachingMenu);
            this.Controls.Add(this.btnMemberMenu);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMemberMenu;
        private System.Windows.Forms.Button btnMachingMenu;
        private System.Windows.Forms.Button btnReferralMenu;
    }
}

