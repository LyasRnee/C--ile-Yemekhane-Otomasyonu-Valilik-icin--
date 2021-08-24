
namespace EntityFramework.Formlar
{
    partial class Topluİslemler
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
            this.lblMisafirUcreti = new System.Windows.Forms.Label();
            this.tbxMisUcr = new System.Windows.Forms.TextBox();
            this.btnMisUcrKaydet = new System.Windows.Forms.Button();
            this.lblYemekUcretMudur = new System.Windows.Forms.Label();
            this.tbxYemekUcret = new System.Windows.Forms.TextBox();
            this.btnYemUcrKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMemurBkySifirla = new System.Windows.Forms.Button();
            this.lblYemUcrMemur = new System.Windows.Forms.Label();
            this.tbxYemUcrMemur = new System.Windows.Forms.TextBox();
            this.btnYemUcrKaydetMemur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMisafirUcreti
            // 
            this.lblMisafirUcreti.AutoSize = true;
            this.lblMisafirUcreti.Location = new System.Drawing.Point(63, 38);
            this.lblMisafirUcreti.Name = "lblMisafirUcreti";
            this.lblMisafirUcreti.Size = new System.Drawing.Size(102, 17);
            this.lblMisafirUcreti.TabIndex = 0;
            this.lblMisafirUcreti.Text = "Misafir Ücreti =";
            // 
            // tbxMisUcr
            // 
            this.tbxMisUcr.Location = new System.Drawing.Point(226, 38);
            this.tbxMisUcr.Name = "tbxMisUcr";
            this.tbxMisUcr.Size = new System.Drawing.Size(100, 22);
            this.tbxMisUcr.TabIndex = 1;
            // 
            // btnMisUcrKaydet
            // 
            this.btnMisUcrKaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnMisUcrKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMisUcrKaydet.Location = new System.Drawing.Point(360, 28);
            this.btnMisUcrKaydet.Name = "btnMisUcrKaydet";
            this.btnMisUcrKaydet.Size = new System.Drawing.Size(130, 40);
            this.btnMisUcrKaydet.TabIndex = 2;
            this.btnMisUcrKaydet.Text = "Kaydet";
            this.btnMisUcrKaydet.UseVisualStyleBackColor = false;
            this.btnMisUcrKaydet.Click += new System.EventHandler(this.btnMisUcrKaydet_Click);
            // 
            // lblYemekUcretMudur
            // 
            this.lblYemekUcretMudur.AutoSize = true;
            this.lblYemekUcretMudur.Location = new System.Drawing.Point(63, 104);
            this.lblYemekUcretMudur.Name = "lblYemekUcretMudur";
            this.lblYemekUcretMudur.Size = new System.Drawing.Size(154, 17);
            this.lblYemekUcretMudur.TabIndex = 3;
            this.lblYemekUcretMudur.Text = "Yemek Ücreti(Müdür) =";
            // 
            // tbxYemekUcret
            // 
            this.tbxYemekUcret.Location = new System.Drawing.Point(226, 103);
            this.tbxYemekUcret.Name = "tbxYemekUcret";
            this.tbxYemekUcret.Size = new System.Drawing.Size(100, 22);
            this.tbxYemekUcret.TabIndex = 4;
            // 
            // btnYemUcrKaydet
            // 
            this.btnYemUcrKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnYemUcrKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemUcrKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnYemUcrKaydet.Location = new System.Drawing.Point(360, 94);
            this.btnYemUcrKaydet.Name = "btnYemUcrKaydet";
            this.btnYemUcrKaydet.Size = new System.Drawing.Size(130, 38);
            this.btnYemUcrKaydet.TabIndex = 5;
            this.btnYemUcrKaydet.Text = "Kaydet";
            this.btnYemUcrKaydet.UseVisualStyleBackColor = false;
            this.btnYemUcrKaydet.Click += new System.EventHandler(this.btnYemUcrKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log Kayıtlarını Silme İşlemi  =>";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(314, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kayıtları Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Memur Bakiyesini Sıfırla(0)  =";
            // 
            // btnMemurBkySifirla
            // 
            this.btnMemurBkySifirla.BackColor = System.Drawing.Color.Lime;
            this.btnMemurBkySifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemurBkySifirla.ForeColor = System.Drawing.Color.Black;
            this.btnMemurBkySifirla.Location = new System.Drawing.Point(305, 213);
            this.btnMemurBkySifirla.Name = "btnMemurBkySifirla";
            this.btnMemurBkySifirla.Size = new System.Drawing.Size(175, 53);
            this.btnMemurBkySifirla.TabIndex = 9;
            this.btnMemurBkySifirla.Text = "Bakiye Sıfırla(Memur)";
            this.btnMemurBkySifirla.UseVisualStyleBackColor = false;
            this.btnMemurBkySifirla.Click += new System.EventHandler(this.btnMemurBkySifirla_Click);
            // 
            // lblYemUcrMemur
            // 
            this.lblYemUcrMemur.AutoSize = true;
            this.lblYemUcrMemur.Location = new System.Drawing.Point(62, 163);
            this.lblYemUcrMemur.Name = "lblYemUcrMemur";
            this.lblYemUcrMemur.Size = new System.Drawing.Size(157, 17);
            this.lblYemUcrMemur.TabIndex = 10;
            this.lblYemUcrMemur.Text = "Yemek Ücreti(Memur) =";
            // 
            // tbxYemUcrMemur
            // 
            this.tbxYemUcrMemur.Location = new System.Drawing.Point(226, 157);
            this.tbxYemUcrMemur.Name = "tbxYemUcrMemur";
            this.tbxYemUcrMemur.Size = new System.Drawing.Size(100, 22);
            this.tbxYemUcrMemur.TabIndex = 11;
            // 
            // btnYemUcrKaydetMemur
            // 
            this.btnYemUcrKaydetMemur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYemUcrKaydetMemur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYemUcrKaydetMemur.Location = new System.Drawing.Point(360, 148);
            this.btnYemUcrKaydetMemur.Name = "btnYemUcrKaydetMemur";
            this.btnYemUcrKaydetMemur.Size = new System.Drawing.Size(130, 39);
            this.btnYemUcrKaydetMemur.TabIndex = 12;
            this.btnYemUcrKaydetMemur.Text = "Kaydet";
            this.btnYemUcrKaydetMemur.UseVisualStyleBackColor = false;
            this.btnYemUcrKaydetMemur.Click += new System.EventHandler(this.btnYemUcrKaydetMemur_Click);
            // 
            // Topluİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 363);
            this.Controls.Add(this.btnYemUcrKaydetMemur);
            this.Controls.Add(this.tbxYemUcrMemur);
            this.Controls.Add(this.lblYemUcrMemur);
            this.Controls.Add(this.btnMemurBkySifirla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYemUcrKaydet);
            this.Controls.Add(this.tbxYemekUcret);
            this.Controls.Add(this.lblYemekUcretMudur);
            this.Controls.Add(this.btnMisUcrKaydet);
            this.Controls.Add(this.tbxMisUcr);
            this.Controls.Add(this.lblMisafirUcreti);
            this.Name = "Topluİslemler";
            this.Text = "Topluİslemler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMisafirUcreti;
        private System.Windows.Forms.TextBox tbxMisUcr;
        private System.Windows.Forms.Button btnMisUcrKaydet;
        private System.Windows.Forms.Label lblYemekUcretMudur;
        private System.Windows.Forms.TextBox tbxYemekUcret;
        private System.Windows.Forms.Button btnYemUcrKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMemurBkySifirla;
        private System.Windows.Forms.Label lblYemUcrMemur;
        private System.Windows.Forms.TextBox tbxYemUcrMemur;
        private System.Windows.Forms.Button btnYemUcrKaydetMemur;
    }
}