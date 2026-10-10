namespace bt_10_10_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnClear = new Button();
            label2 = new Label();
            btnDelete = new Button();
            label1 = new Label();
            btnEdit = new Button();
            cboCategory = new ComboBox();
            btnAdd = new Button();
            nudQuantity = new NumericUpDown();
            nudUnitPrice = new NumericUpDown();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            groupBox2 = new GroupBox();
            dgvProducts = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(cboCategory);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(nudUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 239);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 8;
            label5.Text = "Danh mục";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 194);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 149);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 6;
            label3.Text = "Giá";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(215, 369);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(115, 35);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm Mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 99);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên sản phẩm";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(36, 369);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã sản phẩm";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(215, 297);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(115, 35);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(130, 236);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(200, 28);
            cboCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(36, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(130, 192);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(200, 27);
            nudQuantity.TabIndex = 3;
            // 
            // nudUnitPrice
            // 
            nudUnitPrice.Location = new Point(130, 147);
            nudUnitPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudUnitPrice.Name = "nudUnitPrice";
            nudUnitPrice.Size = new Size(200, 27);
            nudUnitPrice.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(130, 96);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 27);
            txtProductName.TabIndex = 1;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(130, 44);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(200, 27);
            txtProductId.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvProducts);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Location = new Point(415, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(6, 140);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(361, 270);
            dgvProducts.TabIndex = 6;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(140, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(41, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(290, 27);
            txtSearch.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sản Phẩm";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudUnitPrice).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboCategory;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private GroupBox groupBox2;
        private DataGridView dgvProducts;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}