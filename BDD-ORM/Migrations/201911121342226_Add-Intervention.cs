namespace BDD_ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIntervention : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Intervenants",
                c => new
                    {
                        Matricule = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 50),
                        Prenom = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Matricule);
            
            CreateTable(
                "dbo.Interventions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mission = c.String(),
                        Ouverture = c.DateTime(nullable: false),
                        Cloture = c.DateTime(nullable: false),
                        Intervenants_Matricule = c.Int(),
                        Materiels_NumeroDeSerie = c.Int(),
                        Vehicules_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Intervenants", t => t.Intervenants_Matricule)
                .ForeignKey("dbo.Materiels", t => t.Materiels_NumeroDeSerie)
                .ForeignKey("dbo.Vehicules", t => t.Vehicules_Id)
                .Index(t => t.Intervenants_Matricule)
                .Index(t => t.Materiels_NumeroDeSerie)
                .Index(t => t.Vehicules_Id);
            
            CreateTable(
                "dbo.Materiels",
                c => new
                    {
                        NumeroDeSerie = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        Description = c.String(),
                        Achat = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NumeroDeSerie);
            
            CreateTable(
                "dbo.Vehicules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Immatriculation = c.String(),
                        Marque = c.String(maxLength: 30),
                        Modele = c.String(maxLength: 30),
                        VolumeUtile = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interventions", "Vehicules_Id", "dbo.Vehicules");
            DropForeignKey("dbo.Interventions", "Materiels_NumeroDeSerie", "dbo.Materiels");
            DropForeignKey("dbo.Interventions", "Intervenants_Matricule", "dbo.Intervenants");
            DropIndex("dbo.Interventions", new[] { "Vehicules_Id" });
            DropIndex("dbo.Interventions", new[] { "Materiels_NumeroDeSerie" });
            DropIndex("dbo.Interventions", new[] { "Intervenants_Matricule" });
            DropTable("dbo.Vehicules");
            DropTable("dbo.Materiels");
            DropTable("dbo.Interventions");
            DropTable("dbo.Intervenants");
        }
    }
}
