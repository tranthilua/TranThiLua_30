namespace TranThiLua_30.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_SanPhams : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.SanPhams");
        }
        
        public override void Down()
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
    }
}
