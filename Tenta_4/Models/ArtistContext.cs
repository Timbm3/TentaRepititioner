using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_4.Models
{
    public class ArtistContext : DbContext
    {

        public ArtistContext() : base("ArtistTentaDB4")
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
               new Artist() { Name = "3423", Age = 23, Band = "efs", Songs = new List<Song>()
               {
                   new Song() { Title = "rr3r", Genre = "werw", Duration = 2.3},
                   new Song() { Title = "re", Genre = "ew", Duration = 2.4}
               } },
               new Artist() { Name = "rwer", Age = 43, Band = "324", Songs = new List<Song>()
               {
                   new Song() { Title = "erw", Genre = "4243", Duration = 3.2},
                   new Song() { Title = "3423", Genre = "rsd", Duration = 3.4}
               } },
               new Artist() { Name = "rwer", Age = 34, Band = "432", Songs = new List<Song>()
               {
                   new Song() {Title = "23r", Genre = "234", Duration = 3.5},
                   new Song() { Title = "342r", Genre = "ewr", Duration = 5.2}
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
