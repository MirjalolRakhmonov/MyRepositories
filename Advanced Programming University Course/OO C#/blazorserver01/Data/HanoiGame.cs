using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorserver01.Data
{
    public class HanoiGame
    {
        private int svgHeight = 200;
        private int svgWidth = 190;
        List<HanoiTower> towers = new List<HanoiTower>();

        public HanoiGame()
        {

        }

        public HanoiTower addTower(HanoiTower tower)
        {
            towers.Add(tower);
            return tower;
        }
        public HanoiTower getTower(int towerId)
        {
            return towers[towerId];
        }

        public void toConsole()
        {
            for (int i = 0; i < this.towers.Count; i++)
            {
                Console.WriteLine("Tower " + i + " - " + getTower(i).hanoiDisks.Count + " disks");
                for (int j = 0; j < getTower(i).hanoiDisks.Count; j++)
                {
                    Console.WriteLine("Disk " + j + " " + getTower(i).hanoiDisks[j].size + " " + getTower(i).hanoiDisks[j].color);
                }
            }
        }

        public int totalOfTowers()
        {
            return towers.Count;
        }

    }
}