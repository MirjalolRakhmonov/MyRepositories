using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(); //object

            while (true)
            {
                string initialType;
                while (true)
                {
                    Console.WriteLine("Please choose type of music => \nThese are options  " +
                        "ArabicMusic, LatinaMusic, OldRetro,  UzbekPop  ");
                    initialType = Console.ReadLine();
                    if (initialType == "ArabicMusic"
                        || initialType == "LatinaMusic"
                        || initialType == "OldRetro"
                        || initialType == "UzbekPop" || initialType == "ArabicMusic")
                        break;
                }
                Console.WriteLine("Provide the name of the Artist : ");
                string initialArtist = Console.ReadLine();
                Console.WriteLine("Provide the song name : ");
                string initialSongName = Console.ReadLine();

                if (initialType == "ArabicMusic")
                {
                    ArabicMusic ar = new ArabicMusic(initialSongName, initialArtist);
                    player.Add(ar);
                }

                if (initialType == "LatinaMusic")
                {
                    LatinaMusic lm = new LatinaMusic(initialSongName, initialArtist);
                    player.Add(lm);
                }

                if (initialType == "OldRetro")
                {
                    OldRetro or = new OldRetro(initialSongName, initialArtist);
                    player.Add(or);
                }

                if (initialType == "UzbekPop")
                {
                    UzbekPop up = new UzbekPop(initialSongName, initialArtist);
                    player.Add(up);
                }
                Console.WriteLine("Press A if you want to add other song, Or press and key to listen playlist");
                string Exit = Console.ReadLine();

                if (Exit != "A" && Exit != "a")
                {
                    break;
                }
            }
            Console.Clear();

            Console.WriteLine("Player starting ...");
            Console.WriteLine("Successfully started and playing a playlist ...");
            player.PlaylistPlay();
        }
    }
}