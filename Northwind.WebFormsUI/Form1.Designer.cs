namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCreateProductCategory = new System.Windows.Forms.ComboBox();
            this.tbxCreateProductStock = new System.Windows.Forms.TextBox();
            this.tbxCreateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxCreateProductUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxCreateProductName = new System.Windows.Forms.TextBox();
            this.lblCreateQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblCreateStock = new System.Windows.Forms.Label();
            this.lblCreateUnitPrice = new System.Windows.Forms.Label();
            this.lblCreateCategory = new System.Windows.Forms.Label();
            this.lblCreateProductName = new System.Windows.Forms.Label();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.tbxUpdateProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateProductCategory = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateProductStock = new System.Windows.Forms.Label();
            this.lblUpdateProductPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductCategory = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 304);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(1042, 246);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(1043, 114);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye göre Sırala";
            this.gbxCategory.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Location = new System.Drawing.Point(136, 55);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(145, 28);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategori Seç";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(287, 55);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(283, 36);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.Text = "Kategori Seç";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.Location = new System.Drawing.Point(12, 132);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(1043, 119);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün Adına Göre Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSearch.Location = new System.Drawing.Point(287, 58);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(283, 34);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearch.Location = new System.Drawing.Point(168, 61);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 28);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ürün Adı:";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.cbxCreateProductCategory);
            this.gbxAddProduct.Controls.Add(this.tbxCreateProductStock);
            this.gbxAddProduct.Controls.Add(this.tbxCreateQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.tbxCreateProductUnitPrice);
            this.gbxAddProduct.Controls.Add(this.tbxCreateProductName);
            this.gbxAddProduct.Controls.Add(this.lblCreateQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblCreateStock);
            this.gbxAddProduct.Controls.Add(this.lblCreateUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblCreateCategory);
            this.gbxAddProduct.Controls.Add(this.lblCreateProductName);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 600);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(495, 189);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(331, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCreateProductCategory
            // 
            this.cbxCreateProductCategory.FormattingEnabled = true;
            this.cbxCreateProductCategory.Location = new System.Drawing.Point(110, 81);
            this.cbxCreateProductCategory.Name = "cbxCreateProductCategory";
            this.cbxCreateProductCategory.Size = new System.Drawing.Size(143, 21);
            this.cbxCreateProductCategory.TabIndex = 9;
            // 
            // tbxCreateProductStock
            // 
            this.tbxCreateProductStock.Location = new System.Drawing.Point(110, 134);
            this.tbxCreateProductStock.Name = "tbxCreateProductStock";
            this.tbxCreateProductStock.Size = new System.Drawing.Size(141, 20);
            this.tbxCreateProductStock.TabIndex = 8;
            // 
            // tbxCreateQuantityPerUnit
            // 
            this.tbxCreateQuantityPerUnit.Location = new System.Drawing.Point(110, 160);
            this.tbxCreateQuantityPerUnit.Name = "tbxCreateQuantityPerUnit";
            this.tbxCreateQuantityPerUnit.Size = new System.Drawing.Size(141, 20);
            this.tbxCreateQuantityPerUnit.TabIndex = 7;
            // 
            // tbxCreateProductUnitPrice
            // 
            this.tbxCreateProductUnitPrice.Location = new System.Drawing.Point(110, 108);
            this.tbxCreateProductUnitPrice.Name = "tbxCreateProductUnitPrice";
            this.tbxCreateProductUnitPrice.Size = new System.Drawing.Size(141, 20);
            this.tbxCreateProductUnitPrice.TabIndex = 6;
            // 
            // tbxCreateProductName
            // 
            this.tbxCreateProductName.Location = new System.Drawing.Point(110, 57);
            this.tbxCreateProductName.Name = "tbxCreateProductName";
            this.tbxCreateProductName.Size = new System.Drawing.Size(141, 20);
            this.tbxCreateProductName.TabIndex = 5;
            this.tbxCreateProductName.Tag = "";
            // 
            // lblCreateQuantityPerUnit
            // 
            this.lblCreateQuantityPerUnit.AutoSize = true;
            this.lblCreateQuantityPerUnit.Location = new System.Drawing.Point(14, 167);
            this.lblCreateQuantityPerUnit.Name = "lblCreateQuantityPerUnit";
            this.lblCreateQuantityPerUnit.Size = new System.Drawing.Size(90, 13);
            this.lblCreateQuantityPerUnit.TabIndex = 4;
            this.lblCreateQuantityPerUnit.Text = "Quantity Per Unit:";
            // 
            // lblCreateStock
            // 
            this.lblCreateStock.AutoSize = true;
            this.lblCreateStock.Location = new System.Drawing.Point(72, 137);
            this.lblCreateStock.Name = "lblCreateStock";
            this.lblCreateStock.Size = new System.Drawing.Size(32, 13);
            this.lblCreateStock.TabIndex = 3;
            this.lblCreateStock.Text = "Stok:";
            // 
            // lblCreateUnitPrice
            // 
            this.lblCreateUnitPrice.AutoSize = true;
            this.lblCreateUnitPrice.Location = new System.Drawing.Point(72, 111);
            this.lblCreateUnitPrice.Name = "lblCreateUnitPrice";
            this.lblCreateUnitPrice.Size = new System.Drawing.Size(32, 13);
            this.lblCreateUnitPrice.TabIndex = 2;
            this.lblCreateUnitPrice.Text = "Fiyat:";
            // 
            // lblCreateCategory
            // 
            this.lblCreateCategory.AutoSize = true;
            this.lblCreateCategory.Location = new System.Drawing.Point(52, 84);
            this.lblCreateCategory.Name = "lblCreateCategory";
            this.lblCreateCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCreateCategory.TabIndex = 1;
            this.lblCreateCategory.Text = "Category:";
            // 
            // lblCreateProductName
            // 
            this.lblCreateProductName.AutoSize = true;
            this.lblCreateProductName.Location = new System.Drawing.Point(53, 60);
            this.lblCreateProductName.Name = "lblCreateProductName";
            this.lblCreateProductName.Size = new System.Drawing.Size(51, 13);
            this.lblCreateProductName.TabIndex = 0;
            this.lblCreateProductName.Text = "Ürün Adı:";
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductID);
            this.gbxUpdateProduct.Controls.Add(this.label1);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateProductCategory);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductStock);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductPrice);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductStock);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductCategory);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(513, 600);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(542, 189);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Ürün Güncelle";
            this.gbxUpdateProduct.Visible = false;
            // 
            // tbxUpdateProductID
            // 
            this.tbxUpdateProductID.Enabled = false;
            this.tbxUpdateProductID.Location = new System.Drawing.Point(157, 34);
            this.tbxUpdateProductID.Name = "tbxUpdateProductID";
            this.tbxUpdateProductID.Size = new System.Drawing.Size(141, 20);
            this.tbxUpdateProductID.TabIndex = 23;
            this.tbxUpdateProductID.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ürün ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(378, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 34);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateProductCategory
            // 
            this.cbxUpdateProductCategory.FormattingEnabled = true;
            this.cbxUpdateProductCategory.Location = new System.Drawing.Point(157, 81);
            this.cbxUpdateProductCategory.Name = "cbxUpdateProductCategory";
            this.cbxUpdateProductCategory.Size = new System.Drawing.Size(143, 21);
            this.cbxUpdateProductCategory.TabIndex = 20;
            // 
            // tbxUpdateProductStock
            // 
            this.tbxUpdateProductStock.Location = new System.Drawing.Point(157, 134);
            this.tbxUpdateProductStock.Name = "tbxUpdateProductStock";
            this.tbxUpdateProductStock.Size = new System.Drawing.Size(141, 20);
            this.tbxUpdateProductStock.TabIndex = 19;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(157, 160);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(141, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 18;
            // 
            // tbxUpdateProductPrice
            // 
            this.tbxUpdateProductPrice.Location = new System.Drawing.Point(157, 108);
            this.tbxUpdateProductPrice.Name = "tbxUpdateProductPrice";
            this.tbxUpdateProductPrice.Size = new System.Drawing.Size(141, 20);
            this.tbxUpdateProductPrice.TabIndex = 17;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(157, 60);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(141, 20);
            this.tbxUpdateProductName.TabIndex = 16;
            this.tbxUpdateProductName.Tag = "";
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(61, 167);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(90, 13);
            this.lblUpdateQuantityPerUnit.TabIndex = 15;
            this.lblUpdateQuantityPerUnit.Text = "Quantity Per Unit:";
            // 
            // lblUpdateProductStock
            // 
            this.lblUpdateProductStock.AutoSize = true;
            this.lblUpdateProductStock.Location = new System.Drawing.Point(119, 137);
            this.lblUpdateProductStock.Name = "lblUpdateProductStock";
            this.lblUpdateProductStock.Size = new System.Drawing.Size(32, 13);
            this.lblUpdateProductStock.TabIndex = 14;
            this.lblUpdateProductStock.Text = "Stok:";
            // 
            // lblUpdateProductPrice
            // 
            this.lblUpdateProductPrice.AutoSize = true;
            this.lblUpdateProductPrice.Location = new System.Drawing.Point(119, 111);
            this.lblUpdateProductPrice.Name = "lblUpdateProductPrice";
            this.lblUpdateProductPrice.Size = new System.Drawing.Size(32, 13);
            this.lblUpdateProductPrice.TabIndex = 13;
            this.lblUpdateProductPrice.Text = "Fiyat:";
            // 
            // lblUpdateProductCategory
            // 
            this.lblUpdateProductCategory.AutoSize = true;
            this.lblUpdateProductCategory.Location = new System.Drawing.Point(99, 84);
            this.lblUpdateProductCategory.Name = "lblUpdateProductCategory";
            this.lblUpdateProductCategory.Size = new System.Drawing.Size(52, 13);
            this.lblUpdateProductCategory.TabIndex = 12;
            this.lblUpdateProductCategory.Text = "Category:";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(100, 63);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(51, 13);
            this.lblUpdateProductName.TabIndex = 11;
            this.lblUpdateProductName.Text = "Ürün Adı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(916, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 801);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgvProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCreateProductCategory;
        private System.Windows.Forms.TextBox tbxCreateProductStock;
        private System.Windows.Forms.TextBox tbxCreateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxCreateProductUnitPrice;
        private System.Windows.Forms.TextBox tbxCreateProductName;
        private System.Windows.Forms.Label lblCreateQuantityPerUnit;
        private System.Windows.Forms.Label lblCreateStock;
        private System.Windows.Forms.Label lblCreateUnitPrice;
        private System.Windows.Forms.Label lblCreateCategory;
        private System.Windows.Forms.Label lblCreateProductName;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateProductCategory;
        private System.Windows.Forms.TextBox tbxUpdateProductStock;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateProductPrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateProductStock;
        private System.Windows.Forms.Label lblUpdateProductPrice;
        private System.Windows.Forms.Label lblUpdateProductCategory;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.TextBox tbxUpdateProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

