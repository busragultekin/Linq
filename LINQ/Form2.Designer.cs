namespace LINQ
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
            this.btn_yeniPers = new System.Windows.Forms.Button();
            this.lbl_personel_sayi = new System.Windows.Forms.Label();
            this.lbl_ort_maas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_yas = new System.Windows.Forms.Label();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yeniPers
            // 
            this.btn_yeniPers.Location = new System.Drawing.Point(24, 24);
            this.btn_yeniPers.Name = "btn_yeniPers";
            this.btn_yeniPers.Size = new System.Drawing.Size(96, 34);
            this.btn_yeniPers.TabIndex = 0;
            this.btn_yeniPers.Text = "Yeni Personel";
            this.btn_yeniPers.UseVisualStyleBackColor = true;
            this.btn_yeniPers.Click += new System.EventHandler(this.btn_yeniPers_Click);
            // 
            // lbl_personel_sayi
            // 
            this.lbl_personel_sayi.AutoSize = true;
            this.lbl_personel_sayi.Location = new System.Drawing.Point(21, 89);
            this.lbl_personel_sayi.Name = "lbl_personel_sayi";
            this.lbl_personel_sayi.Size = new System.Drawing.Size(120, 13);
            this.lbl_personel_sayi.TabIndex = 1;
            this.lbl_personel_sayi.Text = "Şu anda 0 personel var.";
            // 
            // lbl_ort_maas
            // 
            this.lbl_ort_maas.AutoSize = true;
            this.lbl_ort_maas.Location = new System.Drawing.Point(21, 114);
            this.lbl_ort_maas.Name = "lbl_ort_maas";
            this.lbl_ort_maas.Size = new System.Drawing.Size(149, 13);
            this.lbl_ort_maas.TabIndex = 2;
            this.lbl_ort_maas.Text = "Personel maaşı ortalama 0 TL.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son eklenen personelin";
            // 
            // lbl_yas
            // 
            this.lbl_yas.AutoSize = true;
            this.lbl_yas.Location = new System.Drawing.Point(48, 166);
            this.lbl_yas.Name = "lbl_yas";
            this.lbl_yas.Size = new System.Drawing.Size(34, 13);
            this.lbl_yas.TabIndex = 4;
            this.lbl_yas.Text = "yaşı 0";
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.Location = new System.Drawing.Point(48, 188);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(43, 13);
            this.lbl_maas.TabIndex = 5;
            this.lbl_maas.Text = "maaşı 0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 210);
            this.Controls.Add(this.lbl_maas);
            this.Controls.Add(this.lbl_yas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ort_maas);
            this.Controls.Add(this.lbl_personel_sayi);
            this.Controls.Add(this.btn_yeniPers);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yeniPers;
        private System.Windows.Forms.Label lbl_personel_sayi;
        private System.Windows.Forms.Label lbl_ort_maas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_yas;
        private System.Windows.Forms.Label lbl_maas;
    }
}