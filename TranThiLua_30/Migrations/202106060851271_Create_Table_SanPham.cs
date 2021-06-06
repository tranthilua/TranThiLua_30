namespace TranThiLua_30.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SanPham : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        TenSanPham = c.String(nullable: false, maxLength: 128),
                        MaSanPham = c.String(),
                        MaNhaCungCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TenSanPham);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SanPhams");
        }
    }
}
