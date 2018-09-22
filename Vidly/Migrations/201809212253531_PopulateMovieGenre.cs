namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (1, 'Horror')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (3, 'Thriller')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (4, 'Action')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (5, 'Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
