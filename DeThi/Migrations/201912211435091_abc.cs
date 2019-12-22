namespace DeThi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        MaHp = c.String(nullable: false, maxLength: 128),
                        TenHp = c.String(),
                        DinhMucSv = c.Int(nullable: false),
                        SoLuongSv = c.Int(nullable: false),
                        GiaoVienPhuTrach = c.String(),
                        MaMh = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaHp)
                .ForeignKey("dbo.MonHocs", t => t.MaMh)
                .Index(t => t.MaMh);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        MaMh = c.String(nullable: false, maxLength: 128),
                        TenMh = c.String(),
                    })
                .PrimaryKey(t => t.MaMh);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        HoDem = c.String(),
                        Ten = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(),
                        MaHp = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSV)
                .ForeignKey("dbo.HocPhans", t => t.MaHp)
                .Index(t => t.MaHp);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaHp", "dbo.HocPhans");
            DropForeignKey("dbo.HocPhans", "MaMh", "dbo.MonHocs");
            DropIndex("dbo.SinhViens", new[] { "MaHp" });
            DropIndex("dbo.HocPhans", new[] { "MaMh" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.MonHocs");
            DropTable("dbo.HocPhans");
        }
    }
}
