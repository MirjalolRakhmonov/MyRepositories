using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public class Program
    {
        public enum Level : byte
        {
            Beginner=1,
            Intermediate=2,
            Advanced=3
        }

        static void Main(string[]args)
        {
            var course = new Course();
            course.Level = CourseLevel.Beginner; // 1
        }
    }
}
