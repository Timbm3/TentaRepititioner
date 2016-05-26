using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenta_2.Models
{
    public class ArtistContext : DbContext
    {

        public ArtistContext() : base("ArtistTentaDB2")
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
            var artists = new List<Artist>() { 
            new Artist(){
                Age = 43, Name = "sdfs", Band = "ewef", Songs = new List<Song>()
                {
                    new Song() {Titel = "4223", Duration = 3.33, Genre = "Ger"},
                    new Song() {Titel = "erwe", Duration = 3.22, Genre = "fsd"}
                }}, 
            new Artist()
            {
                Age = 27, Name = "ewf", Band = "sdgg", Songs = new List<Song>()
                {
                    new Song() {Titel = "sdf", Duration = 5.4, Genre = "wet"},
                    new Song() {Titel = "sfs", Duration = 2.4, Genre = "sfsg"}
                }
            },
            new Artist()
            {
                Age = 78, Name = "erw", Band = "sfsdf", Songs = new List<Song>()
                {
                    new Song() {Titel = "lblbl", Duration = 4.22, Genre = "gsg"},
                    new Song() {Titel = "sdfsg", Duration = 4.45, Genre = "fsdsg"}
                }
            }};
            foreach (var artist in artists)
            {
                context.Artists.Add(artist);
            }
            context.SaveChanges();

        }

    }

}
