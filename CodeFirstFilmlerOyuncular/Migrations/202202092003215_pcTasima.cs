namespace CodeFirstFilmlerOyuncular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pcTasima : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Filmler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(maxLength: 200),
                        Yil = c.Int(nullable: false),
                        IMDBPuani = c.Decimal(nullable: false, precision: 2, scale: 1),
                        Poster = c.String(),
                        imdbID = c.String(),
                        TurId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Turler", t => t.TurId)
                .Index(t => t.TurId);
            
            CreateTable(
                "dbo.Oyuncular",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IletisimBilgileri",
                c => new
                    {
                        OyuncuId = c.Int(nullable: false),
                        Telefon = c.String(nullable: false, maxLength: 13),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.OyuncuId)
                .ForeignKey("dbo.Oyuncular", t => t.OyuncuId)
                .Index(t => t.OyuncuId);
            
            CreateTable(
                "dbo.Turler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OyuncuFilms",
                c => new
                    {
                        Oyuncu_Id = c.Int(nullable: false),
                        Film_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Oyuncu_Id, t.Film_ID })
                .ForeignKey("dbo.Oyuncular", t => t.Oyuncu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Filmler", t => t.Film_ID, cascadeDelete: true)
                .Index(t => t.Oyuncu_Id)
                .Index(t => t.Film_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filmler", "TurId", "dbo.Turler");
            DropForeignKey("dbo.IletisimBilgileri", "OyuncuId", "dbo.Oyuncular");
            DropForeignKey("dbo.OyuncuFilms", "Film_ID", "dbo.Filmler");
            DropForeignKey("dbo.OyuncuFilms", "Oyuncu_Id", "dbo.Oyuncular");
            DropIndex("dbo.OyuncuFilms", new[] { "Film_ID" });
            DropIndex("dbo.OyuncuFilms", new[] { "Oyuncu_Id" });
            DropIndex("dbo.IletisimBilgileri", new[] { "OyuncuId" });
            DropIndex("dbo.Filmler", new[] { "TurId" });
            DropTable("dbo.OyuncuFilms");
            DropTable("dbo.Turler");
            DropTable("dbo.IletisimBilgileri");
            DropTable("dbo.Oyuncular");
            DropTable("dbo.Filmler");
        }
    }
}
