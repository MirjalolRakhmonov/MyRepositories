using System.Collections.Generic;
using System.Collections.ObjectModel;
using CodeFirstProject.Migrations;

namespace CodeFirstProject
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public ICollection<Video> Videos { get; set; }

        public Genre()
        {
            Videos = new Collection<Video>();
        }
    }
}