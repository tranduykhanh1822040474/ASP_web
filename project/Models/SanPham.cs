﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.Models
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public double price { get; set; }
        public string Description { get; set; }
        public double ImageUrl { get; set; }
        [Required]
        public int TheLoaiId {  get; set; }
        [ForeignKey("TheLoaiId")]
        public TheLoai TheLoai { get; set; }
    }
}
