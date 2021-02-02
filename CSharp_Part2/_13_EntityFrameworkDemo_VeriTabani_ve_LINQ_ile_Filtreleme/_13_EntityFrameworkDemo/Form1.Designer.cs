
namespace _13_EntityFrameworkDemo
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
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbxSearchByName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearchById = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSearchByUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxSearchMinPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSearchMaxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxUpdateProduct.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdateProduct.Controls.Add(this.label1);
            this.gbxUpdateProduct.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdateProduct.Controls.Add(this.label2);
            this.gbxUpdateProduct.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdateProduct.Controls.Add(this.label3);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(290, 137);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(237, 172);
            this.gbxUpdateProduct.TabIndex = 12;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Update Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(102, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(102, 67);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(99, 20);
            this.tbxUnitPriceUpdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stock Amount :";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(102, 30);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(99, 20);
            this.tbxProductNameUpdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unit Price :";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(102, 102);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(99, 20);
            this.tbxStockAmountUpdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name :";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAddProduct);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Controls.Add(this.tbxProductName);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Location = new System.Drawing.Point(35, 137);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(237, 172);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add Product";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(102, 143);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(99, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(102, 67);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(99, 20);
            this.tbxUnitPrice.TabIndex = 2;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(13, 109);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(80, 13);
            this.lblStockAmount.TabIndex = 6;
            this.lblStockAmount.Text = "Stock Amount :";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(102, 30);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(99, 20);
            this.tbxProductName.TabIndex = 1;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(13, 70);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(59, 13);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(102, 102);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(99, 20);
            this.tbxStockAmount.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Product Name :";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(35, 12);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(606, 107);
            this.dgwProduct.TabIndex = 10;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(651, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbxSearchByName
            // 
            this.tbxSearchByName.Location = new System.Drawing.Point(651, 160);
            this.tbxSearchByName.Name = "tbxSearchByName";
            this.tbxSearchByName.Size = new System.Drawing.Size(99, 20);
            this.tbxSearchByName.TabIndex = 9;
            this.tbxSearchByName.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(671, 137);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearchById
            // 
            this.tbxSearchById.Location = new System.Drawing.Point(651, 200);
            this.tbxSearchById.Name = "tbxSearchById";
            this.tbxSearchById.Size = new System.Drawing.Size(99, 20);
            this.tbxSearchById.TabIndex = 14;
            this.tbxSearchById.TextChanged += new System.EventHandler(this.tbxSearchById_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID    :";
            // 
            // tbxSearchByUnitPrice
            // 
            this.tbxSearchByUnitPrice.Location = new System.Drawing.Point(651, 239);
            this.tbxSearchByUnitPrice.Name = "tbxSearchByUnitPrice";
            this.tbxSearchByUnitPrice.Size = new System.Drawing.Size(99, 20);
            this.tbxSearchByUnitPrice.TabIndex = 16;
            this.tbxSearchByUnitPrice.TextChanged += new System.EventHandler(this.tbxSearchByUnitPrice_TextChanged);
            // 
            // tbxSearchMinPrice
            // 
            this.tbxSearchMinPrice.Location = new System.Drawing.Point(651, 280);
            this.tbxSearchMinPrice.Name = "tbxSearchMinPrice";
            this.tbxSearchMinPrice.Size = new System.Drawing.Size(37, 20);
            this.tbxSearchMinPrice.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Unit Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(560, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Price Range :";
            // 
            // tbxSearchMaxPrice
            // 
            this.tbxSearchMaxPrice.Location = new System.Drawing.Point(713, 280);
            this.tbxSearchMaxPrice.Name = "tbxSearchMaxPrice";
            this.tbxSearchMaxPrice.Size = new System.Drawing.Size(37, 20);
            this.tbxSearchMaxPrice.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 353);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxSearchMaxPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxSearchMinPrice);
            this.Controls.Add(this.tbxSearchByUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSearchById);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearchByName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxSearchByName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearchById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSearchByUnitPrice;
        private System.Windows.Forms.TextBox tbxSearchMinPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSearchMaxPrice;
        private System.Windows.Forms.Label label8;
    }
}

