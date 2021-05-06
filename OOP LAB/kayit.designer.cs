namespace WindowsFormsApp17
{
    partial class kayit
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
            this.lblKayitAd = new System.Windows.Forms.Label();
            this.lblKayitPass = new System.Windows.Forms.Label();
            this.lblKayitPass2 = new System.Windows.Forms.Label();
            this.txtKayitAd = new System.Windows.Forms.TextBox();
            this.txtKayitPass = new System.Windows.Forms.TextBox();
            this.txtKayitPass2 = new System.Windows.Forms.TextBox();
            this.btnKayitol = new System.Windows.Forms.Button();
            this.lblKayitSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKayitAd
            // 
            this.lblKayitAd.AutoSize = true;
            this.lblKayitAd.Location = new System.Drawing.Point(120, 54);
            this.lblKayitAd.Name = "lblKayitAd";
            this.lblKayitAd.Size = new System.Drawing.Size(64, 13);
            this.lblKayitAd.TabIndex = 0;
            this.lblKayitAd.Text = "Kullanıcı Adı";
            // 
            // lblKayitPass
            // 
            this.lblKayitPass.AutoSize = true;
            this.lblKayitPass.Location = new System.Drawing.Point(122, 105);
            this.lblKayitPass.Name = "lblKayitPass";
            this.lblKayitPass.Size = new System.Drawing.Size(37, 13);
            this.lblKayitPass.TabIndex = 1;
            this.lblKayitPass.Text = "Parola";
            // 
            // lblKayitPass2
            // 
            this.lblKayitPass2.AutoSize = true;
            this.lblKayitPass2.Location = new System.Drawing.Point(120, 149);
            this.lblKayitPass2.Name = "lblKayitPass2";
            this.lblKayitPass2.Size = new System.Drawing.Size(73, 13);
            this.lblKayitPass2.TabIndex = 2;
            this.lblKayitPass2.Text = "Parola Tekrarı";
            // 
            // txtKayitAd
            // 
            this.txtKayitAd.Location = new System.Drawing.Point(288, 54);
            this.txtKayitAd.Name = "txtKayitAd";
            this.txtKayitAd.Size = new System.Drawing.Size(100, 20);
            this.txtKayitAd.TabIndex = 3;
            // 
            // txtKayitPass
            // 
            this.txtKayitPass.Location = new System.Drawing.Point(288, 102);
            this.txtKayitPass.Name = "txtKayitPass";
            this.txtKayitPass.Size = new System.Drawing.Size(100, 20);
            this.txtKayitPass.TabIndex = 4;
            // 
            // txtKayitPass2
            // 
            this.txtKayitPass2.Location = new System.Drawing.Point(288, 146);
            this.txtKayitPass2.Name = "txtKayitPass2";
            this.txtKayitPass2.Size = new System.Drawing.Size(100, 20);
            this.txtKayitPass2.TabIndex = 5;
            // 
            // btnKayitol
            // 
            this.btnKayitol.Location = new System.Drawing.Point(288, 204);
            this.btnKayitol.Name = "btnKayitol";
            this.btnKayitol.Size = new System.Drawing.Size(75, 23);
            this.btnKayitol.TabIndex = 6;
            this.btnKayitol.Text = "Kayıt Ol";
            this.btnKayitol.UseVisualStyleBackColor = true;
            this.btnKayitol.Click += new System.EventHandler(this.btnKayitol_Click);
            // 
            // lblKayitSonuc
            // 
            this.lblKayitSonuc.AutoSize = true;
            this.lblKayitSonuc.Location = new System.Drawing.Point(578, 105);
            this.lblKayitSonuc.Name = "lblKayitSonuc";
            this.lblKayitSonuc.Size = new System.Drawing.Size(16, 13);
            this.lblKayitSonuc.TabIndex = 7;
            this.lblKayitSonuc.Text = "...";
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKayitSonuc);
            this.Controls.Add(this.btnKayitol);
            this.Controls.Add(this.txtKayitPass2);
            this.Controls.Add(this.txtKayitPass);
            this.Controls.Add(this.txtKayitAd);
            this.Controls.Add(this.lblKayitPass2);
            this.Controls.Add(this.lblKayitPass);
            this.Controls.Add(this.lblKayitAd);
            this.Name = "kayit";
            this.Text = "kayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKayitAd;
        private System.Windows.Forms.Label lblKayitPass;
        private System.Windows.Forms.Label lblKayitPass2;
        private System.Windows.Forms.TextBox txtKayitAd;
        private System.Windows.Forms.TextBox txtKayitPass;
        private System.Windows.Forms.TextBox txtKayitPass2;
        private System.Windows.Forms.Button btnKayitol;
        private System.Windows.Forms.Label lblKayitSonuc;
    }
}