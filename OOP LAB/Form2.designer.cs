namespace WindowsFormsApp7
{
    partial class Form2
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
            this.txtVarOne = new System.Windows.Forms.TextBox();
            this.txtVarTwo = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.btnCıkartma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVarOne
            // 
            this.txtVarOne.Location = new System.Drawing.Point(64, 32);
            this.txtVarOne.Name = "txtVarOne";
            this.txtVarOne.Size = new System.Drawing.Size(100, 20);
            this.txtVarOne.TabIndex = 0;
            // 
            // txtVarTwo
            // 
            this.txtVarTwo.Location = new System.Drawing.Point(183, 32);
            this.txtVarTwo.Name = "txtVarTwo";
            this.txtVarTwo.Size = new System.Drawing.Size(100, 20);
            this.txtVarTwo.TabIndex = 1;
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(64, 86);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(75, 23);
            this.btnToplama.TabIndex = 2;
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.click);
            this.btnToplama.MouseHover += new System.EventHandler(this.hover);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(155, 161);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(38, 13);
            this.lblFinal.TabIndex = 3;
            this.lblFinal.Text = "Sonuc";
            // 
            // btnCıkartma
            // 
            this.btnCıkartma.Location = new System.Drawing.Point(174, 86);
            this.btnCıkartma.Name = "btnCıkartma";
            this.btnCıkartma.Size = new System.Drawing.Size(75, 23);
            this.btnCıkartma.TabIndex = 4;
            this.btnCıkartma.Text = "Çıkartma";
            this.btnCıkartma.UseVisualStyleBackColor = true;
            this.btnCıkartma.Click += new System.EventHandler(this.click);
            this.btnCıkartma.MouseHover += new System.EventHandler(this.hover);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(292, 86);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(75, 23);
            this.btnCarpma.TabIndex = 5;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.click);
            this.btnCarpma.MouseHover += new System.EventHandler(this.hover);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(401, 86);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(75, 23);
            this.btnBolme.TabIndex = 6;
            this.btnBolme.Text = "Bölme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.click);
            this.btnBolme.MouseHover += new System.EventHandler(this.hover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCıkartma);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.txtVarTwo);
            this.Controls.Add(this.txtVarOne);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVarOne;
        private System.Windows.Forms.TextBox txtVarTwo;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Button btnCıkartma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
    }
}