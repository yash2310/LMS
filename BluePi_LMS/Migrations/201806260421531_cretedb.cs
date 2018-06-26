namespace BluePi_LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cretedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Email = c.String(),
                        Password = c.Int(nullable: false),
                        HashCode = c.String(),
                        LoginTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Reporting_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Branches", t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Id)
                .ForeignKey("dbo.Designations", t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Reporting_Id)
                .ForeignKey("dbo.Roles", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Reporting_Id);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Comment = c.String(),
                        Category_Id = c.Int(),
                        Status_Id = c.Int(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LeaveCategories", t => t.Category_Id)
                .ForeignKey("dbo.LeaveStatus", t => t.Status_Id)
                .ForeignKey("dbo.LeaveTypes", t => t.Type_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.LeaveCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Leaves = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeaveStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeaveTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Leaves", "Type_Id", "dbo.LeaveTypes");
            DropForeignKey("dbo.Leaves", "Status_Id", "dbo.LeaveStatus");
            DropForeignKey("dbo.Leaves", "Category_Id", "dbo.LeaveCategories");
            DropForeignKey("dbo.Accounts", "Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Id", "dbo.Roles");
            DropForeignKey("dbo.Employees", "Reporting_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Id", "dbo.Organizations");
            DropForeignKey("dbo.Employees", "Id", "dbo.Designations");
            DropForeignKey("dbo.Employees", "Id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "Id", "dbo.Branches");
            DropIndex("dbo.Leaves", new[] { "Type_Id" });
            DropIndex("dbo.Leaves", new[] { "Status_Id" });
            DropIndex("dbo.Leaves", new[] { "Category_Id" });
            DropIndex("dbo.Employees", new[] { "Reporting_Id" });
            DropIndex("dbo.Employees", new[] { "Id" });
            DropIndex("dbo.Accounts", new[] { "Id" });
            DropTable("dbo.LeaveTypes");
            DropTable("dbo.LeaveStatus");
            DropTable("dbo.LeaveCategories");
            DropTable("dbo.Leaves");
            DropTable("dbo.Roles");
            DropTable("dbo.Organizations");
            DropTable("dbo.Designations");
            DropTable("dbo.Departments");
            DropTable("dbo.Branches");
            DropTable("dbo.Employees");
            DropTable("dbo.Accounts");
        }
    }
}
