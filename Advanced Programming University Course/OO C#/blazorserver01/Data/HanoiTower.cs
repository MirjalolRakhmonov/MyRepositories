using System;
using System.Collections.Generic;

namespace blazorserver01.Data
{
    public class HanoiTower : HanoiGame
    {
        private bool selected = false;
        public int currentDiskCounter = 0;
        public List<HanoiDisk> hanoiDisks = new List<HanoiDisk>();
        public HanoiGame parent;

        public HanoiTower(HanoiGame parent)
        {
            this.parent = parent;
        }

        public bool pushDisk(HanoiDisk d)
        {
            hanoiDisks.Add(d);
            hanoiDisks.Remove(null);
            currentDiskCounter++;

            if (currentDiskCounter == 1)
                startDiskCounter();
            return true;
        }

        public HanoiDisk popDisk()
        {
            HanoiDisk d = getNextDisk();
            this.hanoiDisks.Remove(d);
            currentDiskCounter--;
            return d;
        }

        public void startDiskCounter()
        {
            HanoiDisk startDisk;
            if (hanoiDisks.Count == 0)
                startDisk = null;
            else
                startDisk = this.hanoiDisks[0];

        }

        public HanoiDisk getNextDisk()
        {
            if (this.hanoiDisks.Count != 0)
                return this.hanoiDisks[this.hanoiDisks.Count - 1];
            return null;
        }

        public bool is_selected()
        {
            return selected;
        }

        public void selection(bool trueForSelected)
        {
            selected = trueForSelected;
        }
    }
}