namespace MatchingSystem
{
    partial class ReferralMenuForm
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
            this.btnNewReferral = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnUpdateReferral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F);
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "＜紹介管理メニュー＞";
            // 
            // btnNewReferral
            // 
            this.btnNewReferral.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnNewReferral.Location = new System.Drawing.Point(307, 160);
            this.btnNewReferral.Name = "btnNewReferral";
            this.btnNewReferral.Size = new System.Drawing.Size(200, 50);
            this.btnNewReferral.TabIndex = 3;
            this.btnNewReferral.Text = "新規で紹介する";
            this.btnNewReferral.UseVisualStyleBackColor = true;
            this.btnNewReferral.Click += new System.EventHandler(this.btnNewReferral_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(256, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "紹介する会員のID又は氏名を入力してください";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txtID.Location = new System.Drawing.Point(307, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 29);
            this.txtID.TabIndex = 5;
            // 
            // btnUpdateReferral
            // 
            this.btnUpdateReferral.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btnUpdateReferral.Location = new System.Drawing.Point(307, 230);
            this.btnUpdateReferral.Name = "btnUpdateReferral";
            this.btnUpdateReferral.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateReferral.TabIndex = 3;
            this.btnUpdateReferral.Text = "紹介状況を一覧表示/更新";
            this.btnUpdateReferral.UseVisualStyleBackColor = true;
            this.btnUpdateReferral.Click += new System.EventHandler(this.btnUpdateReferral_Click);
            // 
            // ReferralMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdateReferral);
            this.Controls.Add(this.btnNewReferral);
            this.Controls.Add(this.label1);
            this.Name = "ReferralMenuForm";
            this.Text = "ReferralMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewReferral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnUpdateReferral;
    }
}