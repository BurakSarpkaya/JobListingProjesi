namespace JobListingProjesi.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version10 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Kategori", new[] { "UstKategoriId" });
            AlterColumn("dbo.Kategori", "UstKategoriId", c => c.Int());
            CreateIndex("dbo.Kategori", "UstKategoriId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kategori", new[] { "UstKategoriId" });
            AlterColumn("dbo.Kategori", "UstKategoriId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kategori", "UstKategoriId");
        }
    }
}
