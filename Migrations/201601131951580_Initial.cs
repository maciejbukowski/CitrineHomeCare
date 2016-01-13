namespace CitrineHomeHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        ApplicantId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(maxLength: 15),
                        Message = c.String(),
                        fileUpload = c.Binary(),
                    })
                .PrimaryKey(t => t.ApplicantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applicants");
        }
    }
}
