using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TranThiLua_30.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }
        public virtual DbSet<NhaCungCap> NhaCungCapss { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
