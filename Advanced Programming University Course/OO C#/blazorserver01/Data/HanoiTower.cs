using System;
using System.Collections.Generic;

namespace blazorserver01.Data
{
    public class HanoiTower : HanoiGame
    {
        private boolean selected; 

        private int currentDiskCounter=0;   

        private List<HanoiDisk> disks=new List<HanoiDisk>();

        public boolean pushDisk(HanoiDisk d){
            currentDiskCounter++;
            disks.Add(d);
        }

        public HanoiDisk popDisk() {
            HanoiDisk pop=disks[disks.Count-1];
            disks.RemoveAt(disks.Count-1);
            currentDiskCounter--;
            
            return pop;
        }

        public void startDiskCounter() {
            Console.WriteLine("Tower: "+{HanoiGame.getTower()} + {currentDiskCounter}" disks");
        }

        public HanoiDisk getNextDisk() {

        }

        public bool is_selected() {
            return selected;
        }

        public void selection(bool trueForSelected) {
            
        }
    }
}