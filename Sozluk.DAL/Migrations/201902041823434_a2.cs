namespace Sozluk.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kullanicilar", "AktifMi", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kullanicilar", "AktifMi", c => c.Boolean(nullable: false));
        }
    }
}
