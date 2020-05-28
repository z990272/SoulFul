namespace Soulful.Migrations
{
    using Soulful.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Soulful.Models.SoulfulContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Soulful.Models.SoulfulContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Singer.AddOrUpdate(x => x.Singer_id,
                new Singer { Singer_id = 1, Name = "Hiroumi", Gender = "Man", Country = "JPN", Language_id = 1 },
                new Singer { Singer_id = 2, Name = "YEIZON", Gender = "Man", Country = "KOR", Language_id = 2 },
                new Singer { Singer_id = 3, Name = "TRIBE MAFIA", Gender = "Group", Country = "USA", Language_id = 3 },
                new Singer { Singer_id = 4, Name = "BLAIREKO", Gender = "Woman", Country = "TWN", Language_id = 4 },
                new Singer { Singer_id = 5, Name = "Seth Power", Gender = "Man", Country = "USA", Language_id = 3 },
                new Singer { Singer_id = 6, Name = "Alfonso Lugo", Gender = "Man", Country = "USA", Language_id = 3 },
                new Singer { Singer_id = 7, Name = "Emerald Park", Gender = "Group", Country = "SWE", Language_id = 5 },
                new Singer { Singer_id = 8, Name = "Rex Hudson", Gender = "Man", Country = "USA", Language_id = 3 },
                new Singer { Singer_id = 9, Name = "DARK SAMURAI", Gender = "Man", Country = "RUS", Language_id = 6 }
                );

            context.Language.AddOrUpdate(x => x.Language_id,
                new Language { Language_id = 1, Language_type = "JPN" },
                new Language { Language_id = 2, Language_type = "KOR" },
                new Language { Language_id = 3, Language_type = "USA" },
                new Language { Language_id = 4, Language_type = "TWN" },
                new Language { Language_id = 5, Language_type = "SWE" },
                new Language { Language_id = 6, Language_type = "RUS" }
                );

            context.Album.AddOrUpdate(x => x.Album_id,
                new Album { Album_id = 1, Singer_id = 1, Datetime = new DateTime(2009, 04, 05), Album_Name = "Kokoro No Furyoku", Pic = "Kokoro_No_Furyoku.jpg", Price = 500 },
                new Album { Album_id = 2, Singer_id = 2, Datetime = new DateTime(2011, 01, 20), Album_Name = "YEIZON", Pic = "Yeizon.jpg", Price = 500 },
                new Album { Album_id = 3, Singer_id = 3, Datetime = new DateTime(2020, 04, 24), Album_Name = "Teepee Gang", Pic = "Teepee_Gang.jpg", About = "Teepee Gang by Tribe Mafia Written by Chinasa Broxton and Carlos Moore.The following Themes of this Album consist of: Partying Street Life Celebration  City Life Conflict This mood of this album: extroverted Exuberant Boisterous Exciting Joyous Striding Bouncy Dramatic Menacing Swaggering Brash Rollicking Tense / Anxious Rowdy Urgent.", Price = 500 },
                new Album { Album_id = 4, Singer_id = 4, Datetime = new DateTime(2014, 02, 12), Album_Name = "¨D·Rª«»y tracing love story", Pic = "Ttracing_Love_Story.jpg", About ="", Price = 500 },
                new Album { Album_id = 5, Singer_id = 5, Datetime = new DateTime(2020, 01, 10), Album_Name = "Souvenir", Pic = "Souvenir.jpg", About = "NULL", Price = 500 },
                new Album { Album_id = 6, Singer_id = 8, Datetime = new DateTime(2019, 09, 06), Album_Name = "Persona", Pic = "Persona.jpg", About = "NULL", Price = 500 },
                new Album { Album_id = 7, Singer_id = 6, Datetime = new DateTime(2020, 04, 09), Album_Name = "Intimo", Pic = "Intimo.jpg", About = "NULL", Price = 500 },
                new Album { Album_id = 8, Singer_id = 7, Datetime = new DateTime(2020, 02, 21), Album_Name = "Basement Session CC", Pic = "Basement_Session_CC.jpg", About = "NULL", Price = 500 }
                );
        }
    }
}
