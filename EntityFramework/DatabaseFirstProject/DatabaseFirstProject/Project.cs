using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstProject
{
    public class Project
    {
        //public static object Classification { get; private set; }

        static void Main()
        {
            var dbContext = new VidzyDbContext();
            dbContext.AddVideo("Transformers3", DateTime.UtcNow, "Sci-Fi", (byte)Classification.Gold);
            Console.WriteLine();
        }
    }
}
