using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    class ArabicMusic : UzbekPop
    {
        private new string Type;
        public ArabicMusic(string newAuthor, string newTitle)
            : base(newAuthor, newTitle)
        {
            this.Type = "ArabicMusic";
        }
        public override void Play()
        {
            base.Play();
            Console.WriteLine(" of genre: ", this.Type);
        }
    }
}
