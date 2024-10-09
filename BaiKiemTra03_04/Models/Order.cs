using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_04.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }

        public string OrderStatus { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
