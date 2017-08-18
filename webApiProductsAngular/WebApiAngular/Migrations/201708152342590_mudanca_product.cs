namespace WebApiAngular.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mudanca_product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "Nome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Nome", c => c.String());
            DropColumn("dbo.Products", "Name");
        }
    }
}
