using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    class UzbekPop : Song
    {
        private string Type;
        public UzbekPop(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            this.Type = "UzbekPop";
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" of genre: ", this.Type);
        }
    }
}
