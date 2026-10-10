using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace bt_10_10_3
{
    public partial class Form1 : Form
    {
        private BindingList<Product> listProducts = new BindingList<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.Items.AddRange(new string[] {
                "Điện thoại",
                "Laptop",
                "Phụ kiện",
                "Gia dụng"
            });
            cboCategory.SelectedIndex = 0;

            // Dữ liệu mẫu
            listProducts.Add(new Product("SP01", "iPhone 15 Pro", 28000000, 10, "Điện thoại"));
            listProducts.Add(new Product("SP02", "MacBook Air M2", 24000000, 5, "Laptop"));
            listProducts.Add(new Product("SP03", "Tai nghe AirPods 3", 4500000, 15, "Phụ kiện"));

            dgvProducts.DataSource = listProducts;
            DinhDangLuoi();
        }

        private void DinhDangLuoi()
        {
            if (dgvProducts.Columns["ProductId"] != null)
                dgvProducts.Columns["ProductId"].HeaderText = "Mã SP";
            if (dgvProducts.Columns["ProductName"] != null)
                dgvProducts.Columns["ProductName"].HeaderText = "Tên SP";
            if (dgvProducts.Columns["UnitPrice"] != null)
            {
                dgvProducts.Columns["UnitPrice"].HeaderText = "Đơn Giá";
                dgvProducts.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
            }
            if (dgvProducts.Columns["Quantity"] != null)
                dgvProducts.Columns["Quantity"].HeaderText = "Số Lượng";
            if (dgvProducts.Columns["Category"] != null)
                dgvProducts.Columns["Category"].HeaderText = "Danh Mục";
        }

        // Chức năng THÊM
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã SP!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            bool isExist = listProducts.Any(p => p.ProductId.Equals(txtProductId.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (isExist)
            {
                MessageBox.Show("Mã sản phẩm này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductId.Focus();
                return;
            }

            Product p = new Product(
                txtProductId.Text.Trim(),
                txtProductName.Text.Trim(),
                nudUnitPrice.Value,
                (int)nudQuantity.Value,
                cboCategory.SelectedItem.ToString()
            );

            listProducts.Add(p);
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInput();
        }

        // Click chọn dòng trên DataGridView
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();

                if (decimal.TryParse(row.Cells["UnitPrice"].Value?.ToString(), out decimal price))
                    nudUnitPrice.Value = price;

                if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int qty))
                    nudQuantity.Value = qty;

                cboCategory.SelectedItem = row.Cells["Category"].Value?.ToString();
                txtProductId.ReadOnly = true;
            }
        }

        // Chức năng SỬA
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product target = listProducts.FirstOrDefault(p => p.ProductId.Equals(txtProductId.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (target != null)
            {
                target.ProductName = txtProductName.Text.Trim();
                target.UnitPrice = nudUnitPrice.Value;
                target.Quantity = (int)nudQuantity.Value;
                target.Category = cboCategory.SelectedItem.ToString();

                dgvProducts.Refresh();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
        }

        // Chức năng XÓA
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productId = txtProductId.Text.Trim();
            string productName = txtProductName.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm [{productName}] (Mã: {productId}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                Product target = listProducts.FirstOrDefault(p => p.ProductId.Equals(productId, StringComparison.OrdinalIgnoreCase));
                if (target != null)
                {
                    listProducts.Remove(target);
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInput();
                }
            }
        }

        // Chức năng TÌM KIẾM
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                dgvProducts.DataSource = listProducts;
            }
            else
            {
                var filteredList = listProducts.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                dgvProducts.DataSource = new BindingList<Product>(filteredList);
            }
            DinhDangLuoi();
        }

        // Chức năng LÀM MỚI
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            dgvProducts.DataSource = listProducts;
            DinhDangLuoi();
        }

        private void ClearInput()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            nudUnitPrice.Value = 0;
            nudQuantity.Value = 0;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtProductId.ReadOnly = false;
            txtProductId.Focus();
        }
    }
}
