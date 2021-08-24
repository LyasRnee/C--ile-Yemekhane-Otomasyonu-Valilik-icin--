
namespace EntityFramework
{
    partial class YemekhaneYöneticisi
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MisafirUcreti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eTradeDataSet2 = new EntityFramework.ETradeDataSet2();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eTradeDataSet1 = new EntityFramework.ETradeDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eTradeDataSet = new EntityFramework.ETradeDataSet();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnGetByCartId = new System.Windows.Forms.Button();
            this.AddGit = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnUpdateGit = new System.Windows.Forms.Button();
            this.btnRemoveGit = new System.Windows.Forms.Button();
            this.tbxSearchCartId = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new EntityFramework.ETradeDataSetTableAdapters.ProductsTableAdapter();
            this.eTradeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new EntityFramework.ETradeDataSet1TableAdapters.ProductsTableAdapter();
            this.btnTopluİslemler = new System.Windows.Forms.Button();
            this.productsTableAdapter2 = new EntityFramework.ETradeDataSet2TableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoGenerateColumns = false;
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.cartIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cardTypeDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.foodPriceDataGridViewTextBoxColumn,
            this.Gun,
            this.MisafirUcreti});
            this.dgwProducts.DataSource = this.productsBindingSource2;
            this.dgwProducts.Location = new System.Drawing.Point(12, 47);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(880, 240);
            this.dgwProducts.TabIndex = 0;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.FillWeight = 64.17113F;
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartIdDataGridViewTextBoxColumn
            // 
            this.cartIdDataGridViewTextBoxColumn.DataPropertyName = "CartId";
            this.cartIdDataGridViewTextBoxColumn.FillWeight = 118.0569F;
            this.cartIdDataGridViewTextBoxColumn.HeaderText = "CartId";
            this.cartIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartIdDataGridViewTextBoxColumn.Name = "cartIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 101.3322F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 99.10222F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // cardTypeDataGridViewTextBoxColumn
            // 
            this.cardTypeDataGridViewTextBoxColumn.DataPropertyName = "CardType";
            this.cardTypeDataGridViewTextBoxColumn.FillWeight = 118.0569F;
            this.cardTypeDataGridViewTextBoxColumn.HeaderText = "CardType";
            this.cardTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardTypeDataGridViewTextBoxColumn.Name = "cardTypeDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.FillWeight = 118.0569F;
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // foodPriceDataGridViewTextBoxColumn
            // 
            this.foodPriceDataGridViewTextBoxColumn.DataPropertyName = "FoodPrice";
            this.foodPriceDataGridViewTextBoxColumn.FillWeight = 63.16674F;
            this.foodPriceDataGridViewTextBoxColumn.HeaderText = "FoodPrice";
            this.foodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodPriceDataGridViewTextBoxColumn.Name = "foodPriceDataGridViewTextBoxColumn";
            // 
            // Gun
            // 
            this.Gun.DataPropertyName = "Gun";
            this.Gun.FillWeight = 118.0569F;
            this.Gun.HeaderText = "Gun";
            this.Gun.MinimumWidth = 6;
            this.Gun.Name = "Gun";
            // 
            // MisafirUcreti
            // 
            this.MisafirUcreti.DataPropertyName = "MisafirUcreti";
            this.MisafirUcreti.HeaderText = "MisafirUcreti";
            this.MisafirUcreti.MinimumWidth = 6;
            this.MisafirUcreti.Name = "MisafirUcreti";
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.eTradeDataSet2;
            // 
            // eTradeDataSet2
            // 
            this.eTradeDataSet2.DataSetName = "ETradeDataSet2";
            this.eTradeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.eTradeDataSet1;
            // 
            // eTradeDataSet1
            // 
            this.eTradeDataSet1.DataSetName = "ETradeDataSet1";
            this.eTradeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(500, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(94, 17);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search Name";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(600, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(117, 22);
            this.tbxSearch.TabIndex = 5;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnGetByCartId
            // 
            this.btnGetByCartId.Location = new System.Drawing.Point(153, 7);
            this.btnGetByCartId.Name = "btnGetByCartId";
            this.btnGetByCartId.Size = new System.Drawing.Size(133, 34);
            this.btnGetByCartId.TabIndex = 6;
            this.btnGetByCartId.Text = "Get By Cart Id";
            this.btnGetByCartId.UseVisualStyleBackColor = true;
            this.btnGetByCartId.Click += new System.EventHandler(this.btnGetByCartId_Click);
            // 
            // AddGit
            // 
            this.AddGit.BackColor = System.Drawing.Color.Lime;
            this.AddGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddGit.ForeColor = System.Drawing.Color.Black;
            this.AddGit.Location = new System.Drawing.Point(90, 324);
            this.AddGit.Name = "AddGit";
            this.AddGit.Size = new System.Drawing.Size(146, 60);
            this.AddGit.TabIndex = 7;
            this.AddGit.Text = "Kullanıcı Ekle";
            this.AddGit.UseVisualStyleBackColor = false;
            this.AddGit.Click += new System.EventHandler(this.AddGit_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(785, 7);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(79, 34);
            this.btnrefresh.TabIndex = 8;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnUpdateGit
            // 
            this.btnUpdateGit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateGit.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateGit.Location = new System.Drawing.Point(317, 324);
            this.btnUpdateGit.Name = "btnUpdateGit";
            this.btnUpdateGit.Size = new System.Drawing.Size(175, 60);
            this.btnUpdateGit.TabIndex = 9;
            this.btnUpdateGit.Text = "Kullanıcı Düzenle";
            this.btnUpdateGit.UseVisualStyleBackColor = false;
            this.btnUpdateGit.Click += new System.EventHandler(this.btnUpdateGit_Click);
            // 
            // btnRemoveGit
            // 
            this.btnRemoveGit.BackColor = System.Drawing.Color.Red;
            this.btnRemoveGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveGit.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveGit.Location = new System.Drawing.Point(585, 324);
            this.btnRemoveGit.Name = "btnRemoveGit";
            this.btnRemoveGit.Size = new System.Drawing.Size(144, 60);
            this.btnRemoveGit.TabIndex = 10;
            this.btnRemoveGit.Text = "Kullanıcı Sil";
            this.btnRemoveGit.UseVisualStyleBackColor = false;
            this.btnRemoveGit.Click += new System.EventHandler(this.btnRemoveGit_Click);
            // 
            // tbxSearchCartId
            // 
            this.tbxSearchCartId.Location = new System.Drawing.Point(12, 13);
            this.tbxSearchCartId.Name = "tbxSearchCartId";
            this.tbxSearchCartId.Size = new System.Drawing.Size(122, 22);
            this.tbxSearchCartId.TabIndex = 11;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // eTradeDataSetBindingSource
            // 
            this.eTradeDataSetBindingSource.DataSource = this.eTradeDataSet;
            this.eTradeDataSetBindingSource.Position = 0;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnTopluİslemler
            // 
            this.btnTopluİslemler.BackColor = System.Drawing.Color.Yellow;
            this.btnTopluİslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopluİslemler.Location = new System.Drawing.Point(654, 412);
            this.btnTopluİslemler.Name = "btnTopluİslemler";
            this.btnTopluİslemler.Size = new System.Drawing.Size(210, 61);
            this.btnTopluİslemler.TabIndex = 12;
            this.btnTopluİslemler.Text = "Toplu İşlemler";
            this.btnTopluİslemler.UseVisualStyleBackColor = false;
            this.btnTopluİslemler.Click += new System.EventHandler(this.btnTopluİslemler_Click);
            // 
            // productsTableAdapter2
            // 
            this.productsTableAdapter2.ClearBeforeFill = true;
            // 
            // YemekhaneYöneticisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 481);
            this.Controls.Add(this.btnTopluİslemler);
            this.Controls.Add(this.tbxSearchCartId);
            this.Controls.Add(this.btnRemoveGit);
            this.Controls.Add(this.btnUpdateGit);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.AddGit);
            this.Controls.Add(this.btnGetByCartId);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgwProducts);
            this.Name = "YemekhaneYöneticisi";
            this.Text = "Kullanıcı Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearch;
        protected internal System.Windows.Forms.Button btnRemoveGit;
        protected internal System.Windows.Forms.Button btnUpdateGit;
        protected internal System.Windows.Forms.Button btnGetByCartId;
        protected internal System.Windows.Forms.Label lblSearch;
        protected internal System.Windows.Forms.Button btnrefresh;
        public System.Windows.Forms.Button AddGit;
        protected internal System.Windows.Forms.DataGridView dgwProducts;
        public System.Windows.Forms.TextBox tbxSearchCartId;
        private ETradeDataSet eTradeDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ETradeDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource eTradeDataSetBindingSource;
        private ETradeDataSet1 eTradeDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private ETradeDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gun;
        private System.Windows.Forms.Button btnTopluİslemler;
        private ETradeDataSet2 eTradeDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private ETradeDataSet2TableAdapters.ProductsTableAdapter productsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MisafirUcreti;
    }
}

