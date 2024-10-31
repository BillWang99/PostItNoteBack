using FluentMigrator;
using FluentMigrator.SqlServer;

namespace PostItNoteBack.Migrations
{
    [Migration(20241021)]
    public class CreateTable_20241021:Migration
    {
        public override void Up()
        {
            Create.Table("PostIt")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Message").AsString()
                .WithColumn("CreateTime").AsDateTime()
                .WithColumn("IsDelete").AsBoolean();
        }

        public override void Down() 
        {
        
        }
    }
}
