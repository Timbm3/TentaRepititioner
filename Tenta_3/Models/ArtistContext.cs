using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_3.Models
{
    public class ArtistContext : DbContext
    {

        public ArtistContext() : base("ArtistTentaDB3")
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
                new Artist() {Name = "dsfgd", Band = "34242", Age = 23, Songs = new List<Song>()
                {
                    new Song() { Title = "sdfsd", Genre = "sdf", Duration = 3.2},
                    new Song() { Title = "sdfsdf", Genre = "sdf", Duration = 2.3}
                } },
                new Artist() { Name = "sfsdf", Band = "sdfsd", Age = 23, Songs = new List<Song>()
                {
                    new Song() { Title = "sdfs", Genre = "sdfsd", Duration = 3.4},
                    new Song() { Title = "sdf", Genre = "sdfsdf", Duration = 3.2}
                } },
                new Artist() { Name = "sdf", Age = 23, Band = "sfsd", Songs = new List<Song>()
                {
                    new Song() {Title = "sdffs", Genre = "sdf", Duration = 5.6},
                    new Song() {Title = "wewr", Genre = "sf", Duration = 2.43}
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
