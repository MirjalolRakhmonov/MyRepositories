using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    class LatinaMusic : OldRetro
    {
        private new string Type;
        public LatinaMusic(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            this.Type = "Latina Music";
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" of genre: ",this.Type );
        }
    }
}
