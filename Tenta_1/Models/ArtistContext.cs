using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Tenta_1_1.Models
{
    public class ArtistContext : DbContext
    {

        public ArtistContext() : base("ArtistTentaDB1")
        {
            Database.SetInitializer<ArtistContext>(new ArtistInitializer());
        }



        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }


    public class ArtistInitializer : DropCreateDatabaseAlways<ArtistContext>
    {
        protected override void Seed(ArtistContext context)
        {
            var artists = new List<Artist>()
            {
                new Artist() { Age = 42, Name = "Janny", Band = "Droggs", Songs = new List<Song>()
                {
                    new Song() { Titel = "I want flowers", Duration = 2.34, Genre = "Flower Power"},
                    new Song() { Titel = "I like rainbows", Duration = 3.23, Genre = "Flower Healing"}
                }},
                new Artist() { Age = 22, Name = "Henrik Schyffert", Band = "Hail church", Songs = new List<Song>()
                {
                    new Song() { Titel = "Hallelulja", Duration = 5.23, Genre = "Opera"},
                    new Song() { Titel = "Throw away hate", Duration = 4.55, Genre = "Love"}
                } },
                new Artist() { Age = 37, Name = "Mac", Band = "Machines", Songs = new List<Song>()
                {
                    new Song() { Titel = "Deadly sins", Duration = 6.34, Genre = "Hard Rock"},
                    new Song() { Titel = "Killer", Duration = 3.51, Genre = "Hard Rock"}
                } }    
            };

            foreach (var artist in artists)
            {
                context.Artists.Add(artist);

            }
            context.SaveChanges();






        }
    }
}
