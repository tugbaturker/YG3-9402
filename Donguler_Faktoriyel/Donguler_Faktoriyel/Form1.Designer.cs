﻿namespace Donguler_Faktoriyel
{
    partial class Form1
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnFaktoriyelHesapla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(24, 23);
            this.txtDeger.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(225, 32);
            this.txtDeger.TabIndex = 0;
            // 
            // btnFaktoriyelHesapla
            // 
            this.btnFaktoriyelHesapla.Location = new System.Drawing.Point(24, 64);
            this.btnFaktoriyelHesapla.Name = "btnFaktoriyelHesapla";
            this.btnFaktoriyelHesapla.Size = new System.Drawing.Size(225, 79);
            this.btnFaktoriyelHesapla.TabIndex = 1;
            this.btnFaktoriyelHesapla.Text = "Faktoriyel Hesapla FOR";
            this.btnFaktoriyelHesapla.UseVisualStyleBackColor = true;
            this.btnFaktoriyelHesapla.Click += new System.EventHandler(this.btnFaktoriyelHesapla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Faktoriyel Hesapla WHILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 79);
            this.button2.TabIndex = 1;
            this.button2.Text = "Faktoriyel Hesapla DO WHILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFaktoriyelHesapla);
            this.Controls.Add(this.txtDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Faktoriyel Bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnFaktoriyelHesapla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
