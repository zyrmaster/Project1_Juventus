using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class Coupon
    {
        [Key]
        public int ID { get; set; }

        [StringLength(255)]
        [Required]
        public string TenMa { get; set; }

        [StringLength(255)]
        [Required]
        public string MaSuDung { get; set; }

        [Required]
        public int GiamGia { get; set; }

        [Required]
        public int TongLuotDung { get; set; }

        [Required]
        public string DanhSachDaDung { get; set; }

        [Required]
        public DateTime HanSuDung { get; set; }
    }
}
