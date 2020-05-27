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
                new Language {Language_id=1,Language_type="JPN" },
                new Language {Language_id=2,Language_type= "KOR" },
                new Language {Language_id=3,Language_type= "USA" },
                new Language {Language_id=4,Language_type= "TWN" },
                new Language {Language_id=5,Language_type= "SWE" },
                new Language {Language_id=6,Language_type= "RUS" }
                );

            
        }
    }
}
