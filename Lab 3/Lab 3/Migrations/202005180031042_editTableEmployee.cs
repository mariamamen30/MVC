namespace Lab_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editTableEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Employee", "Address", c => c.String(maxLength: 256));
            AddColumn("dbo.Employee", "Gender", c => c.Byte(nullable: false));
            AlterColumn("dbo.Employee", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employee", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Employee", "Gender");
            DropColumn("dbo.Employee", "Address");
            DropColumn("dbo.Employee", "Email");
        }
    }
}
