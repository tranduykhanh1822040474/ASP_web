namespace Project.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // e.g., Pending, Shipped, Delivered, Cancelled

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // Navigation property
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
