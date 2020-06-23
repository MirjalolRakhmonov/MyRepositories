using System.Data.Entity;
using CodeFirstProject.Migrations;

namespace CodeFirstProject
{
    public class VidzyContext : DbContext 
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Category> Categories { get; set; }

        public VidzyContext()
            : base("name=DefaultConnection")
        {

        }
    }
}