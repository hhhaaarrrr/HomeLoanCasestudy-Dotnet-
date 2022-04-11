namespace ASPHome.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calculations",
                c => new
                    {
                        id = c.Int(nullable: false),
                        CustomerName = c.String(),
                        Salary = c.Double(nullable: false),
                        ROI = c.Double(nullable: false),
                        loantenure = c.Double(nullable: false),
                        EMI = c.Double(nullable: false),
                        LoanAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.IncomeDetails",
                c => new
                    {
                        ApplicationId = c.Int(nullable: false, identity: true),
                        ProperityLocation = c.String(nullable: false),
                        ProperityName = c.String(nullable: false),
                        ESAmount = c.Double(nullable: false),
                        TypeofEmployeement = c.String(),
                        Retirementage = c.Int(nullable: false),
                        Organizationtype = c.String(),
                        EmployerName = c.String(),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EMI = c.Int(nullable: false),
                        ROI = c.Single(nullable: false),
                        Tenure = c.Int(nullable: false),
                        LoanAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personals",
                c => new
                    {
                        AppId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Id = c.Int(nullable: false),
                        LastName = c.String(),
                        EmailId = c.String(),
                        Phonenumber = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                        Gender = c.String(),
                        Nationality = c.String(),
                        Aadharnumber = c.Double(nullable: false),
                        Panno = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.AppId);
            
            CreateTable(
                "dbo.SignIns",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        User_Name = c.String(),
                        User_EmailId = c.String(),
                        Password = c.String(),
                        Conformword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SignIns");
            DropTable("dbo.Personals");
            DropTable("dbo.Loans");
            DropTable("dbo.IncomeDetails");
            DropTable("dbo.Calculations");
        }
    }
}
