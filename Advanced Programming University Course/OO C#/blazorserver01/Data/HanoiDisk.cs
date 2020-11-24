using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorserver01.Data
{
    public class HanoiDisk
    {
        public int size { get; set; }
        public string color { get; set; }

        public HanoiDisk(int size, string color)
        {
            this.size = size;
            this.color = color;
        }
    }
}