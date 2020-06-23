using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    class OldRetro : Song
    {
        private string Type;
        public OldRetro(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            this.Type = "OldRetro";
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" of genre: ", this.Type);
        }
    }
}
