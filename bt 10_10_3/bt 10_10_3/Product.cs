namespace bt_10_10_3
{
    public class Product
    {
        public string ProductId { get; set; }     // Mã sản phẩm
        public string ProductName { get; set; }   // Tên sản phẩm
        public decimal UnitPrice { get; set; }    // Đơn giá
        public int Quantity { get; set; }         // Số lượng
        public string Category { get; set; }      // Danh mục

        public Product() { }

        public Product(string productId, string productName, decimal unitPrice, int quantity, string category)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Category = category;
        }
    }
}
