
namespace EntityFramework
{
    partial class Remove
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblAciklama4 = new System.Windows.Forms.Label();
            this.tbxGetByCartIdRemoveEkranı = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshRemoveEkranı = new System.Windows.Forms.Button();
            this.productsTableAdapter = new EntityFramework.ETradeDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).BeginInit();
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
            this.dgwProducts.Location = new System.Drawing.Point(22, 41);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(831, 237);
            this.dgwProducts.TabIndex = 1;
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
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(345, 324);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 51);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblAciklama4
            // 
            this.lblAciklama4.AutoSize = true;
            this.lblAciklama4.Location = new System.Drawing.Point(65, 294);
            this.lblAciklama4.Name = "lblAciklama4";
            this.lblAciklama4.Size = new System.Drawing.Size(723, 17);
            this.lblAciklama4.TabIndex = 5;
            this.lblAciklama4.Text = "Silmek istediğiniz kullanıcının satırını seçip \'Sil\' butonuna basmalısınız.(Satır" +
    "ı seçmeden \'Sil\' butonuna basmayınız!!)";
            // 
            // tbxGetByCartIdRemoveEkranı
            // 
            this.tbxGetByCartIdRemoveEkranı.Location = new System.Drawing.Point(22, 12);
            this.tbxGetByCartIdRemoveEkranı.Name = "tbxGetByCartIdRemoveEkranı";
            this.tbxGetByCartIdRemoveEkranı.Size = new System.Drawing.Size(120, 22);
            this.tbxGetByCartIdRemoveEkranı.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get By Cart Id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshRemoveEkranı
            // 
            this.refreshRemoveEkranı.Location = new System.Drawing.Point(762, 12);
            this.refreshRemoveEkranı.Name = "refreshRemoveEkranı";
            this.refreshRemoveEkranı.Size = new System.Drawing.Size(75, 23);
            this.refreshRemoveEkranı.TabIndex = 8;
            this.refreshRemoveEkranı.Text = "Refresh";
            this.refreshRemoveEkranı.UseVisualStyleBackColor = true;
            this.refreshRemoveEkranı.Click += new System.EventHandler(this.refreshRemoveEkranı_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 429);
            this.Controls.Add(this.refreshRemoveEkranı);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxGetByCartIdRemoveEkranı);
            this.Controls.Add(this.lblAciklama4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Remove";
            this.Text = "Remove";
            this.Load += new System.EventHandler(this.Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTradeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblAciklama4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshRemoveEkranı;
        public System.Windows.Forms.TextBox tbxGetByCartIdRemoveEkranı;
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
    }
}