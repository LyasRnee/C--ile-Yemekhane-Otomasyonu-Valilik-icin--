
namespace EntityFramework
{
    partial class Add
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
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddMisUcr = new System.Windows.Forms.TextBox();
            this.lblaciklama2 = new System.Windows.Forms.Label();
            this.lblaciklama1 = new System.Windows.Forms.Label();
            this.tbxFoodPrice = new System.Windows.Forms.TextBox();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.tbxBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxCartId = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCartId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.tbxAddMisUcr);
            this.gbxAdd.Controls.Add(this.lblaciklama2);
            this.gbxAdd.Controls.Add(this.lblaciklama1);
            this.gbxAdd.Controls.Add(this.tbxFoodPrice);
            this.gbxAdd.Controls.Add(this.lblFoodPrice);
            this.gbxAdd.Controls.Add(this.tbxBalance);
            this.gbxAdd.Controls.Add(this.lblBalance);
            this.gbxAdd.Controls.Add(this.comboBox1);
            this.gbxAdd.Controls.Add(this.lblType);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxLastName);
            this.gbxAdd.Controls.Add(this.tbxCartId);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblLastName);
            this.gbxAdd.Controls.Add(this.lblCartId);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(35, 44);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(549, 296);
            this.gbxAdd.TabIndex = 2;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Misafir Ücreti";
            // 
            // tbxAddMisUcr
            // 
            this.tbxAddMisUcr.Location = new System.Drawing.Point(414, 222);
            this.tbxAddMisUcr.Name = "tbxAddMisUcr";
            this.tbxAddMisUcr.Size = new System.Drawing.Size(100, 22);
            this.tbxAddMisUcr.TabIndex = 15;
            this.tbxAddMisUcr.Text = "15";
            // 
            // lblaciklama2
            // 
            this.lblaciklama2.AutoSize = true;
            this.lblaciklama2.Location = new System.Drawing.Point(15, 250);
            this.lblaciklama2.Name = "lblaciklama2";
            this.lblaciklama2.Size = new System.Drawing.Size(213, 17);
            this.lblaciklama2.TabIndex = 14;
            this.lblaciklama2.Text = "(food price 5\'ten küçük olmalıdır)";
            // 
            // lblaciklama1
            // 
            this.lblaciklama1.AutoSize = true;
            this.lblaciklama1.Location = new System.Drawing.Point(15, 185);
            this.lblaciklama1.Name = "lblaciklama1";
            this.lblaciklama1.Size = new System.Drawing.Size(213, 17);
            this.lblaciklama1.TabIndex = 13;
            this.lblaciklama1.Text = "(balance 50\'den büyük olmalıdır)";
            // 
            // tbxFoodPrice
            // 
            this.tbxFoodPrice.Location = new System.Drawing.Point(126, 222);
            this.tbxFoodPrice.Name = "tbxFoodPrice";
            this.tbxFoodPrice.Size = new System.Drawing.Size(117, 22);
            this.tbxFoodPrice.TabIndex = 8;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(13, 222);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(76, 17);
            this.lblFoodPrice.TabIndex = 12;
            this.lblFoodPrice.Text = "Food Price";
            // 
            // tbxBalance
            // 
            this.tbxBalance.Location = new System.Drawing.Point(126, 160);
            this.tbxBalance.Name = "tbxBalance";
            this.tbxBalance.Size = new System.Drawing.Size(117, 22);
            this.tbxBalance.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(13, 165);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "Balance";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mudur",
            "Memur",
            "SuperVisior"});
            this.comboBox1.Location = new System.Drawing.Point(126, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Choose..";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 132);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(355, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 57);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(126, 95);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(117, 22);
            this.tbxLastName.TabIndex = 5;
            // 
            // tbxCartId
            // 
            this.tbxCartId.Location = new System.Drawing.Point(126, 21);
            this.tbxCartId.Name = "tbxCartId";
            this.tbxCartId.Size = new System.Drawing.Size(117, 22);
            this.tbxCartId.TabIndex = 3;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(126, 55);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(117, 22);
            this.tbxName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(13, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblCartId
            // 
            this.lblCartId.AutoSize = true;
            this.lblCartId.Location = new System.Drawing.Point(15, 24);
            this.lblCartId.Name = "lblCartId";
            this.lblCartId.Size = new System.Drawing.Size(49, 17);
            this.lblCartId.TabIndex = 1;
            this.lblCartId.Text = "Cart Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 390);
            this.Controls.Add(this.gbxAdd);
            this.Name = "Add";
            this.Text = "Add";
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblaciklama2;
        private System.Windows.Forms.Label lblaciklama1;
        private System.Windows.Forms.TextBox tbxFoodPrice;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.TextBox tbxBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCartId;
        private System.Windows.Forms.Label lblName;
        protected internal System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox tbxCartId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddMisUcr;
    }
}