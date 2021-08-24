
namespace EntityFramework
{
    partial class Turnike
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
            this.components = new System.ComponentModel.Container();
            this.cbxPortlar = new System.Windows.Forms.ComboBox();
            this.lblBağlantıDurumu = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnLedAc = new System.Windows.Forms.Button();
            this.btnLedKapa = new System.Windows.Forms.Button();
            this.tbxGelenId = new System.Windows.Forms.TextBox();
            this.dgwTurnike = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eTradeDataSet = new EntityFramework.ETradeDataSet();
            this.productsTableAdapter = new EntityFramework.ETradeDataSetTableAdapters.ProductsTableAdapter();
            this.btnBypass = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgwLog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTurnike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPortlar
            // 
            this.cbxPortlar.FormattingEnabled = true;
            this.cbxPortlar.Location = new System.Drawing.Point(119, 116);
            this.cbxPortlar.Name = "cbxPortlar";
            this.cbxPortlar.Size = new System.Drawing.Size(102, 24);
            this.cbxPortlar.TabIndex = 0;
            // 
            // lblBağlantıDurumu
            // 
            this.lblBağlantıDurumu.AutoSize = true;
            this.lblBağlantıDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBağlantıDurumu.Location = new System.Drawing.Point(45, 64);
            this.lblBağlantıDurumu.Name = "lblBağlantıDurumu";
            this.lblBağlantıDurumu.Size = new System.Drawing.Size(150, 20);
            this.lblBağlantıDurumu.TabIndex = 1;
            this.lblBağlantıDurumu.Text = "Bağlantı Durumu";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 119);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(50, 17);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port  =";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.Lime;
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.ForeColor = System.Drawing.Color.White;
            this.btnBaglan.Location = new System.Drawing.Point(62, 163);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(121, 38);
            this.btnBaglan.TabIndex = 3;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(62, 226);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(121, 40);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnLedAc
            // 
            this.btnLedAc.Location = new System.Drawing.Point(680, 24);
            this.btnLedAc.Name = "btnLedAc";
            this.btnLedAc.Size = new System.Drawing.Size(120, 49);
            this.btnLedAc.TabIndex = 5;
            this.btnLedAc.Text = "LED AÇ";
            this.btnLedAc.UseVisualStyleBackColor = true;
            this.btnLedAc.Click += new System.EventHandler(this.btnLedAc_Click);
            // 
            // btnLedKapa
            // 
            this.btnLedKapa.Location = new System.Drawing.Point(680, 93);
            this.btnLedKapa.Name = "btnLedKapa";
            this.btnLedKapa.Size = new System.Drawing.Size(120, 47);
            this.btnLedKapa.TabIndex = 6;
            this.btnLedKapa.Text = "LED KAPAT";
            this.btnLedKapa.UseVisualStyleBackColor = true;
            this.btnLedKapa.Click += new System.EventHandler(this.btnLedKapa_Click);
            // 
            // tbxGelenId
            // 
            this.tbxGelenId.Location = new System.Drawing.Point(281, 163);
            this.tbxGelenId.Name = "tbxGelenId";
            this.tbxGelenId.Size = new System.Drawing.Size(179, 22);
            this.tbxGelenId.TabIndex = 8;
            this.tbxGelenId.Text = "Okutulan Kartın Numarası";
            // 
            // dgwTurnike
            // 
            this.dgwTurnike.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTurnike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTurnike.Location = new System.Drawing.Point(8, 305);
            this.dgwTurnike.Name = "dgwTurnike";
            this.dgwTurnike.RowHeadersWidth = 51;
            this.dgwTurnike.RowTemplate.Height = 24;
            this.dgwTurnike.Size = new System.Drawing.Size(871, 78);
            this.dgwTurnike.TabIndex = 9;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.eTradeDataSet;
            // 
            // eTradeDataSet
            // 
            this.eTradeDataSet.DataSetName = "ETradeDataSet";
            this.eTradeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnBypass
            // 
            this.btnBypass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBypass.ForeColor = System.Drawing.Color.White;
            this.btnBypass.Location = new System.Drawing.Point(629, 205);
            this.btnBypass.Name = "btnBypass";
            this.btnBypass.Size = new System.Drawing.Size(180, 82);
            this.btnBypass.TabIndex = 10;
            this.btnBypass.Text = "BYPASS";
            this.btnBypass.UseVisualStyleBackColor = false;
            this.btnBypass.Click += new System.EventHandler(this.btnBypass_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgwLog
            // 
            this.dgwLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLog.Location = new System.Drawing.Point(8, 389);
            this.dgwLog.Name = "dgwLog";
            this.dgwLog.RowHeadersWidth = 51;
            this.dgwLog.RowTemplate.Height = 24;
            this.dgwLog.Size = new System.Drawing.Size(871, 106);
            this.dgwLog.TabIndex = 11;
            // 
            // Turnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 507);
            this.Controls.Add(this.dgwLog);
            this.Controls.Add(this.btnBypass);
            this.Controls.Add(this.dgwTurnike);
            this.Controls.Add(this.tbxGelenId);
            this.Controls.Add(this.btnLedKapa);
            this.Controls.Add(this.btnLedAc);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblBağlantıDurumu);
            this.Controls.Add(this.cbxPortlar);
            this.Name = "Turnike";
            this.Text = "Turnike";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Turnike_FormClosed);
            this.Load += new System.EventHandler(this.Turnike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTurnike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPortlar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnLedAc;
        private System.Windows.Forms.Button btnLedKapa;
        private System.Windows.Forms.TextBox tbxGelenId;
        protected internal System.Windows.Forms.Label lblBağlantıDurumu;
        protected internal System.Windows.Forms.Label lblPort;
        protected internal System.Windows.Forms.Button btnBaglan;
        protected internal System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dgwTurnike;
        private ETradeDataSet eTradeDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ETradeDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Timer timer1;
        protected internal System.Windows.Forms.Button btnBypass;
        private System.Windows.Forms.DataGridView dgwLog;
        //private EntityFramework.logTablosuCekme logTablosuCekme;
        //private EntityFramework.logTablosuCekmeTableAdapters.LogsTableAdapter logsTableAdapter;
    }
}