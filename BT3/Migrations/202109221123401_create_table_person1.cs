namespace BT3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_person1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountID = c.String(nullable: false, maxLength: 128),
                        AccountName = c.String(),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.sinhviens",
                c => new
                    {
                        SinhvienID = c.String(nullable: false, maxLength: 128),
                        SinhvienName = c.String(),
                    })
                .PrimaryKey(t => t.SinhvienID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sinhviens");
            DropTable("dbo.Accounts");
        }
    }
}
