namespace TatilSitesiBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YorumlarAddColumnOtellerid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yorumlars", "Otellerid", c => c.Int(nullable: false));
            AddColumn("dbo.Yorumlars", "Restauranlartid", c => c.Int(nullable: false));
            AddColumn("dbo.Yorumlars", "Müzelerid", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yorumlars", "Müzelerid");
            DropColumn("dbo.Yorumlars", "Restauranlartid");
            DropColumn("dbo.Yorumlars", "Otellerid");
        }
    }
}
