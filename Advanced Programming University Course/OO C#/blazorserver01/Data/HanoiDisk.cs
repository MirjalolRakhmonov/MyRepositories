using System;

namespace blazorserver01.Data
{
    public class HanoiDisk
    {
        private int size { get; set; }
        private string color { get; set; }

        public HanoiDisk(int size, string color){
            this.size = size;
            this.color = color; 
        }
    }
}