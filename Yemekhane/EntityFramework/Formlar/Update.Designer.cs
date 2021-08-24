
namespace EntityFramework
{
    partial class Update
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
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eTradeDataSet = new EntityFramework.ETradeDataSet();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxUpdateMisUcr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFoodPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.tbxBalanceUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateBalance = new System.Windows.Forms.Label();
            this.cbxTypeUpdate = new System.Windows.Forms.ComboBox();
            this.lblUpdateType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxCartIdUpdate1 = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.lblaciklama3 = new System.Windows.Forms.Label();
            this.tbxSearchCartIdUpdateEkranı = new System.Windows.Forms.TextBox();
            this.btnGetByCartIdUpdateEkranı = new System.Windows.Forms.Button();
            this.btnRefreshUpdateEkranı = new System.Windows.Forms.Button();
            this.productsTableAdapter = new EntityFramework.ETradeDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).BeginInit();
            this.gbxUpdate.SuspendLayout();
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
            this.foodPriceDataGridViewTextBoxColumn});
            this.dgwProducts.DataSource = this.productsBindingSource;
            this.dgwProducts.Location = new System.Drawing.Point(12, 46);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(871, 222);
            this.dgwProducts.TabIndex = 1;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick_1);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartIdDataGridViewTextBoxColumn
            // 
            this.cartIdDataGridViewTextBoxColumn.DataPropertyName = "CartId";
            this.cartIdDataGridViewTextBoxColumn.HeaderText = "CartId";
            this.cartIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cartIdDataGridViewTextBoxColumn.Name = "cartIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // cardTypeDataGridViewTextBoxColumn
            // 
            this.cardTypeDataGridViewTextBoxColumn.DataPropertyName = "CardType";
            this.cardTypeDataGridViewTextBoxColumn.HeaderText = "CardType";
            this.cardTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardTypeDataGridViewTextBoxColumn.Name = "cardTypeDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // foodPriceDataGridViewTextBoxColumn
            // 
            this.foodPriceDataGridViewTextBoxColumn.DataPropertyName = "FoodPrice";
            this.foodPriceDataGridViewTextBoxColumn.HeaderText = "FoodPrice";
            this.foodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.foodPriceDataGridViewTextBoxColumn.Name = "foodPriceDataGridViewTextBoxColumn";
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
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxUpdateMisUcr);
            this.gbxUpdate.Controls.Add(this.label1);
            this.gbxUpdate.Controls.Add(this.tbxFoodPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblFoodPrice);
            this.gbxUpdate.Controls.Add(this.tbxBalanceUpdate);
            this.gbxUpdate.Controls.Add(this.lblUpdateBalance);
            this.gbxUpdate.Controls.Add(this.cbxTypeUpdate);
            this.gbxUpdate.Controls.Add(this.lblUpdateType);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCartIdUpdate1);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(105, 291);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(633, 250);
            this.gbxUpdate.TabIndex = 3;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a product";
            // 
            // tbxUpdateMisUcr
            // 
            this.tbxUpdateMisUcr.Location = new System.Drawing.Point(404, 131);
            this.tbxUpdateMisUcr.Name = "tbxUpdateMisUcr";
            this.tbxUpdateMisUcr.Size = new System.Drawing.Size(117, 22);
            this.tbxUpdateMisUcr.TabIndex = 22;
            this.tbxUpdateMisUcr.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Misafir Ücreti";
            // 
            // tbxFoodPriceUpdate
            // 
            this.tbxFoodPriceUpdate.Location = new System.Drawing.Point(404, 77);
            this.tbxFoodPriceUpdate.Name = "tbxFoodPriceUpdate";
            this.tbxFoodPriceUpdate.Size = new System.Drawing.Size(117, 22);
            this.tbxFoodPriceUpdate.TabIndex = 18;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(308, 77);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(76, 17);
            this.lblFoodPrice.TabIndex = 17;
            this.lblFoodPrice.Text = "Food Price";
            // 
            // tbxBalanceUpdate
            // 
            this.tbxBalanceUpdate.Location = new System.Drawing.Point(404, 24);
            this.tbxBalanceUpdate.Name = "tbxBalanceUpdate";
            this.tbxBalanceUpdate.Size = new System.Drawing.Size(117, 22);
            this.tbxBalanceUpdate.TabIndex = 13;
            // 
            // lblUpdateBalance
            // 
            this.lblUpdateBalance.AutoSize = true;
            this.lblUpdateBalance.Location = new System.Drawing.Point(308, 27);
            this.lblUpdateBalance.Name = "lblUpdateBalance";
            this.lblUpdateBalance.Size = new System.Drawing.Size(59, 17);
            this.lblUpdateBalance.TabIndex = 13;
            this.lblUpdateBalance.Text = "Balance";
            // 
            // cbxTypeUpdate
            // 
            this.cbxTypeUpdate.FormattingEnabled = true;
            this.cbxTypeUpdate.Items.AddRange(new object[] {
            "Mudur",
            "Memur",
            "SuperVisior"});
            this.cbxTypeUpdate.Location = new System.Drawing.Point(112, 129);
            this.cbxTypeUpdate.Name = "cbxTypeUpdate";
            this.cbxTypeUpdate.Size = new System.Drawing.Size(117, 24);
            this.cbxTypeUpdate.TabIndex = 12;
            this.cbxTypeUpdate.Text = "Choose..";
            // 
            // lblUpdateType
            // 
            this.lblUpdateType.AutoSize = true;
            this.lblUpdateType.Location = new System.Drawing.Point(13, 134);
            this.lblUpdateType.Name = "lblUpdateType";
            this.lblUpdateType.Size = new System.Drawing.Size(40, 17);
            this.lblUpdateType.TabIndex = 11;
            this.lblUpdateType.Text = "Type";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(211, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 48);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxLastNameUpdate
            // 
            this.tbxLastNameUpdate.Location = new System.Drawing.Point(112, 95);
            this.tbxLastNameUpdate.Name = "tbxLastNameUpdate";
            this.tbxLastNameUpdate.Size = new System.Drawing.Size(117, 22);
            this.tbxLastNameUpdate.TabIndex = 11;
            // 
            // tbxCartIdUpdate1
            // 
            this.tbxCartIdUpdate1.Location = new System.Drawing.Point(112, 19);
            this.tbxCartIdUpdate1.Name = "tbxCartIdUpdate1";
            this.tbxCartIdUpdate1.Size = new System.Drawing.Size(117, 22);
            this.tbxCartIdUpdate1.TabIndex = 9;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(112, 55);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(117, 22);
            this.tbxNameUpdate.TabIndex = 10;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(13, 95);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(76, 17);
            this.lblStockAmountUpdate.TabIndex = 2;
            this.lblStockAmountUpdate.Text = "Last Name";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(13, 24);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(49, 17);
            this.lblUnitPriceUpdate.TabIndex = 1;
            this.lblUnitPriceUpdate.Text = "Cart Id";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(13, 60);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(76, 17);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "First Name";
            // 
            // lblaciklama3
            // 
            this.lblaciklama3.AutoSize = true;
            this.lblaciklama3.Location = new System.Drawing.Point(130, 271);
            this.lblaciklama3.Name = "lblaciklama3";
            this.lblaciklama3.Size = new System.Drawing.Size(567, 17);
            this.lblaciklama3.TabIndex = 21;
            this.lblaciklama3.Text = "Güncellemek istediğiniz kullanıcının satırına tıklayıp bilgilerini güncelleme ekr" +
    "anına çekiniz";
            // 
            // tbxSearchCartIdUpdateEkranı
            // 
            this.tbxSearchCartIdUpdateEkranı.Location = new System.Drawing.Point(12, 12);
            this.tbxSearchCartIdUpdateEkranı.Name = "tbxSearchCartIdUpdateEkranı";
            this.tbxSearchCartIdUpdateEkranı.Size = new System.Drawing.Size(122, 22);
            this.tbxSearchCartIdUpdateEkranı.TabIndex = 23;
            // 
            // btnGetByCartIdUpdateEkranı
            // 
            this.btnGetByCartIdUpdateEkranı.Location = new System.Drawing.Point(154, 6);
            this.btnGetByCartIdUpdateEkranı.Name = "btnGetByCartIdUpdateEkranı";
            this.btnGetByCartIdUpdateEkranı.Size = new System.Drawing.Size(136, 34);
            this.btnGetByCartIdUpdateEkranı.TabIndex = 22;
            this.btnGetByCartIdUpdateEkranı.Text = "Get By Cart Id";
            this.btnGetByCartIdUpdateEkranı.UseVisualStyleBackColor = true;
            this.btnGetByCartIdUpdateEkranı.Click += new System.EventHandler(this.btnGetByCartIdUpdateEkranı_Click);
            // 
            // btnRefreshUpdateEkranı
            // 
            this.btnRefreshUpdateEkranı.Location = new System.Drawing.Point(779, 12);
            this.btnRefreshUpdateEkranı.Name = "btnRefreshUpdateEkranı";
            this.btnRefreshUpdateEkranı.Size = new System.Drawing.Size(88, 28);
            this.btnRefreshUpdateEkranı.TabIndex = 24;
            this.btnRefreshUpdateEkranı.Text = "Refresh";
            this.btnRefreshUpdateEkranı.UseVisualStyleBackColor = true;
            this.btnRefreshUpdateEkranı.Click += new System.EventHandler(this.btnRefreshUpdateEkranı_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 553);
            this.Controls.Add(this.btnRefreshUpdateEkranı);
            this.Controls.Add(this.tbxSearchCartIdUpdateEkranı);
            this.Controls.Add(this.btnGetByCartIdUpdateEkranı);
            this.Controls.Add(this.lblaciklama3);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxFoodPriceUpdate;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.TextBox tbxBalanceUpdate;
        private System.Windows.Forms.Label lblUpdateBalance;
        private System.Windows.Forms.ComboBox cbxTypeUpdate;
        private System.Windows.Forms.Label lblUpdateType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxLastNameUpdate;
        private System.Windows.Forms.TextBox tbxCartIdUpdate1;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Label lblaciklama3;
        private System.Windows.Forms.Button btnGetByCartIdUpdateEkranı;
        private System.Windows.Forms.Button btnRefreshUpdateEkranı;
        public System.Windows.Forms.TextBox tbxSearchCartIdUpdateEkranı;
        private ETradeDataSet eTradeDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ETradeDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbxUpdateMisUcr;
        private System.Windows.Forms.Label label1;
    }
}