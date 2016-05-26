using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_7.Models
{
    public class ArtistContext : DbContext
    {


        public ArtistContext() : base("ArtistTentaDB7")
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
                new Artist() { Name = "aaf", Age = 23, Band = "add", Songs = new List<Song>()
                {
                    new Song() { Title = "3r2", Duration = 2.3, Genre = "werwr"},
                    new Song() {Title = "3r2", Duration = 2.3, Genre = "werwr" }
                } },
                new Artist() { Name = "aaf", Age = 23, Band = "add", Songs = new List<Song>() { new Song() { Title = "3r2", Duration = 2.3, Genre = "werwr" }, new Song() { Title = "3r2", Duration = 2.3, Genre = "werwr" } } },
                new Artist() {Name = "aaf", Age = 23, Band = "add", Songs = new List<Song>()
                {
                    new Song() {Title = "3r2", Duration = 2.3, Genre = "werwr"},
                    new Song() { Title = "3r2", Duration = 2.3, Genre = "werwr"}
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
