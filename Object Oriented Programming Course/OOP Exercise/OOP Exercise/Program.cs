using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a1 = new Person();  //blank object (why blank we do not have ANY parameter for this moment)
            a1.SetData("Mirjalol ", "Rakhmonov ");  //a1 mening obyektim  SetData metodim , ijro etiladi obyekt bilan. my action is my method.
            Console.WriteLine($"{a1.FirstName}, {a1.FamilyName}");   //method is always followed by () 
            Console.WriteLine(a1.IntroduceYourself());

            PostalAddress NewAdress = new PostalAddress("sadasd", "asdasq", "trete", "uytuty", "yrtyrt", "zxczxcz");
            Console.WriteLine(NewAdress.WriteAdress);  //ctrl+k+d make all lines correct
        }
    }
}
