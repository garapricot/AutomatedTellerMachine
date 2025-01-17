namespace AutoMatedAutomatedTellerMachine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountNumberChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CheckingAccounts", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.CheckingAccounts", new[] { "ApplicationUserId" });
            AlterColumn("dbo.CheckingAccounts", "ApplicationUserId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.CheckingAccounts", "ApplicationUserId");
            AddForeignKey("dbo.CheckingAccounts", "ApplicationUserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CheckingAccounts", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.CheckingAccounts", new[] { "ApplicationUserId" });
            AlterColumn("dbo.CheckingAccounts", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.CheckingAccounts", "ApplicationUserId");
            AddForeignKey("dbo.CheckingAccounts", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
    }
}
