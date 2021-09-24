namespace BT3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            DropTable("dbo.Account");
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Usename = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Usename);
            
            DropTable("dbo.People");
        }
    }
}
