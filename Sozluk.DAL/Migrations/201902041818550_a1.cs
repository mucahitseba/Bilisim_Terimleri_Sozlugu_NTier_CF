namespace Sozluk.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kelimeler",
                c => new
                    {
                        KelimeId = c.Int(nullable: false, identity: true),
                        Sozcuk = c.String(nullable: false),
                        SozcukAnlami = c.String(nullable: false),
                        ResimYolu = c.String(),
                        KullaniciId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KelimeId)
                .ForeignKey("dbo.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .Index(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        KullaniciId = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 20),
                        Soyad = c.String(nullable: false, maxLength: 20),
                        DogumTarihi = c.DateTime(nullable: false),
                        Meslek = c.String(nullable: false),
                        GizliCevap = c.String(nullable: false),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kelimeler", "KullaniciId", "dbo.Kullanicilar");
            DropIndex("dbo.Kelimeler", new[] { "KullaniciId" });
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.Kelimeler");
        }
    }
}
