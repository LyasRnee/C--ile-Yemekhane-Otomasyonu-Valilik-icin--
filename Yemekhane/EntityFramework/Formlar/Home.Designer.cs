
namespace EntityFramework
{
    partial class Home
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
            this.btnKullanıcıSistemi = new System.Windows.Forms.Button();
            this.btnTurnike = new System.Windows.Forms.Button();
            this.lblYemekhaneOtomasyonu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dilSeçimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türkçeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKullanıcıSistemi
            // 
            this.btnKullanıcıSistemi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnKullanıcıSistemi.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıSistemi.Location = new System.Drawing.Point(123, 166);
            this.btnKullanıcıSistemi.Name = "btnKullanıcıSistemi";
            this.btnKullanıcıSistemi.Size = new System.Drawing.Size(178, 98);
            this.btnKullanıcıSistemi.TabIndex = 0;
            this.btnKullanıcıSistemi.Text = "Kullanıcı Sistemi";
            this.btnKullanıcıSistemi.UseVisualStyleBackColor = false;
            this.btnKullanıcıSistemi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTurnike
            // 
            this.btnTurnike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTurnike.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTurnike.ForeColor = System.Drawing.Color.Black;
            this.btnTurnike.Location = new System.Drawing.Point(445, 166);
            this.btnTurnike.Name = "btnTurnike";
            this.btnTurnike.Size = new System.Drawing.Size(173, 98);
            this.btnTurnike.TabIndex = 1;
            this.btnTurnike.Text = "Turnike";
            this.btnTurnike.UseVisualStyleBackColor = false;
            this.btnTurnike.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblYemekhaneOtomasyonu
            // 
            this.lblYemekhaneOtomasyonu.AutoSize = true;
            this.lblYemekhaneOtomasyonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lblYemekhaneOtomasyonu.ForeColor = System.Drawing.Color.Black;
            this.lblYemekhaneOtomasyonu.Location = new System.Drawing.Point(208, 60);
            this.lblYemekhaneOtomasyonu.Name = "lblYemekhaneOtomasyonu";
            this.lblYemekhaneOtomasyonu.Size = new System.Drawing.Size(319, 31);
            this.lblYemekhaneOtomasyonu.TabIndex = 2;
            this.lblYemekhaneOtomasyonu.Text = "Yemekhane Otomasyonu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilSeçimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dilSeçimiToolStripMenuItem
            // 
            this.dilSeçimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türkçeToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.dilSeçimiToolStripMenuItem.Name = "dilSeçimiToolStripMenuItem";
            this.dilSeçimiToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.dilSeçimiToolStripMenuItem.Text = "Dil Seçimi";
            // 
            // türkçeToolStripMenuItem
            // 
            this.türkçeToolStripMenuItem.Name = "türkçeToolStripMenuItem";
            this.türkçeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.türkçeToolStripMenuItem.Text = "Türkçe";
            this.türkçeToolStripMenuItem.Click += new System.EventHandler(this.türkçeToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblYemekhaneOtomasyonu);
            this.Controls.Add(this.btnTurnike);
            this.Controls.Add(this.btnKullanıcıSistemi);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullanıcıSistemi;
        private System.Windows.Forms.Button btnTurnike;
        private System.Windows.Forms.Label lblYemekhaneOtomasyonu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem türkçeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem dilSeçimiToolStripMenuItem;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.Button button4;
    }
}