namespace Paket_Barkod_Kontrol.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Error_List : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Error_List");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Error_List",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Meter_ID = c.String(),
                        Meter_Count_In_Box = c.Int(nullable: false),
                        Package_Code = c.String(),
                        Product_Code = c.String(),
                        Packing_Date = c.DateTime(nullable: false),
                        Transferred_Public = c.String(),
                        Error_Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
