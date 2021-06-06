using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TranThiLua_30.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public int MaNhaCungCap { get; set; }
    }
}