namespace StudentManagement.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        CampusId = c.Int(nullable: false, identity: true),
                        CampusName = c.String(),
                        Address_AddressType = c.Int(nullable: false),
                        Address_AddressLine1 = c.String(),
                        Address_AddressLine2 = c.String(),
                        Address_City = c.String(),
                        Address_County = c.String(),
                        Address_State = c.String(),
                        Address_ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.CampusId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Grade = c.String(),
                        CampusId = c.Int(nullable: false),
                        Title = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Campus", t => t.CampusId, cascadeDelete: true)
                .Index(t => t.CampusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CampusId", "dbo.Campus");
            DropIndex("dbo.Students", new[] { "CampusId" });
            DropTable("dbo.Students");
            DropTable("dbo.Campus");
        }
    }
}
