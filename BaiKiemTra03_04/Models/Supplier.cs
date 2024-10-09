using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_04.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Required]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        [Display(Name = "Contact Info")]
        public string ContactInfo { get; set; }
    }
}
