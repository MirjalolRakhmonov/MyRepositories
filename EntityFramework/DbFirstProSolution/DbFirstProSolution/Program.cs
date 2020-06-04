using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstProSolution
{
    public class Program
    {
        static void Main()
        {
            var dbContext = new VidzySolutionModel();
            dbContext.spAddVideo("Transformers3", DateTime.Today, "Horror", (byte)VidzyClassification.Gold);
            Console.WriteLine();
        }
    }
}
