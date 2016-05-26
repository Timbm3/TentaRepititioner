using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_6.Models
{
    public class ArtistContext : DbContext
    {
        public ArtistContext() : base("ArtistTentaDB6")
        {
            Database.SetInitializer<ArtistContext>(new ArtistInitializer());
        }





        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
    }

    public class ArtistInitializer : DropCreateDatabaseAlways<ArtistContext>
    {
        protected override void Seed(ArtistContext context)
        {
            var artists = new List<Artist>()
            {
                new Artist() { Songs = new List<Song>()
                {
                    new Song() { },
                    new Song() { }
                } },
                new Artist() { Songs = new List<Song>()
                {
                    new Song() { },
                    new Song() { }
                } },
                new Artist() { Songs = new List<Song>()
                {
                    new Song() { },
                    new Song() { }
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
