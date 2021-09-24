namespace BT3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altr_column_student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            DropTable("dbo.sinhviens");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.sinhviens",
                c => new
                    {
                        SinhvienID = c.String(nullable: false, maxLength: 128),
                        SinhvienName = c.String(),
                    })
                .PrimaryKey(t => t.SinhvienID);
            
            DropTable("dbo.Students");
        }
    }
}
