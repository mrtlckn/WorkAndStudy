﻿namespace WindowsFormsApp7
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKuzey = new System.Windows.Forms.Label();
            this.lblGuney = new System.Windows.Forms.Label();
            this.lblDogu = new System.Windows.Forms.Label();
            this.lblBatı = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Neredeyim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yeni Koordinat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Ekseni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Ekseni";
            // 
            // lblKuzey
            // 
            this.lblKuzey.AutoSize = true;
            this.lblKuzey.Location = new System.Drawing.Point(554, 91);
            this.lblKuzey.Name = "lblKuzey";
            this.lblKuzey.Size = new System.Drawing.Size(46, 13);
            this.lblKuzey.TabIndex = 6;
            this.lblKuzey.Text = "lblKuzey";
            // 
            // lblGuney
            // 
            this.lblGuney.AutoSize = true;
            this.lblGuney.Location = new System.Drawing.Point(554, 215);
            this.lblGuney.Name = "lblGuney";
            this.lblGuney.Size = new System.Drawing.Size(48, 13);
            this.lblGuney.TabIndex = 7;
            this.lblGuney.Text = "lblGuney";
            // 
            // lblDogu
            // 
            this.lblDogu.AutoSize = true;
            this.lblDogu.Location = new System.Drawing.Point(646, 155);
            this.lblDogu.Name = "lblDogu";
            this.lblDogu.Size = new System.Drawing.Size(43, 13);
            this.lblDogu.TabIndex = 8;
            this.lblDogu.Text = "lblDogu";
            // 
            // lblBatı
            // 
            this.lblBatı.AutoSize = true;
            this.lblBatı.Location = new System.Drawing.Point(450, 155);
            this.lblBatı.Name = "lblBatı";
            this.lblBatı.Size = new System.Drawing.Size(35, 13);
            this.lblBatı.TabIndex = 9;
            this.lblBatı.Text = "lblBatı";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(211, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "X Gör";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Y Gör";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblBatı);
            this.Controls.Add(this.lblDogu);
            this.Controls.Add(this.lblGuney);
            this.Controls.Add(this.lblKuzey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKuzey;
        private System.Windows.Forms.Label lblGuney;
        private System.Windows.Forms.Label lblDogu;
        private System.Windows.Forms.Label lblBatı;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}