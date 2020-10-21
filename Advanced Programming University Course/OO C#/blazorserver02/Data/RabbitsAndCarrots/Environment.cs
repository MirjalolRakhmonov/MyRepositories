using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace blazorserver02.Data.RabbitsAndCarrots
{
    public class Environment
    {
        private int rows = 1;
        private int cols = 1;
        private BioUnit[,] cell;
        public Environment(int rows, int columns)
        {
            this.rows = rows;
            this.cols = columns;
            this.cell = new BioUnit[this.rows, this.cols];
            for (var i = 0; i < this.rows; i++)
                for (var j = 0; j < this.cols; j++)
                    this.cell[i, j] = null;
        }

        public List<BioUnit> neighbors(int i, int j)
        {
            List<BioUnit> units = new List<BioUnit>();
            if (this.rightPos(i, j))
            {
                if (this.rightPos(i - 1, j - 1) && this.cell[i - 1, j - 1] != null) units.Add(this.cell[i - 1, j - 1]);
                if (this.rightPos(i - 1, j) && this.cell[i - 1, j] != null) units.Add(this.cell[i - 1, j]);
                if (this.rightPos(i - 1, j + 1) && this.cell[i - 1, j + 1] != null) units.Add(this.cell[i - 1, j + 1]);
                if (this.rightPos(i, j - 1) && this.cell[i, j - 1] != null) units.Add(this.cell[i, j - 1]);
                if (this.rightPos(i, j + 1) && this.cell[i, j + 1] != null) units.Add(this.cell[i, j + 1]);
                if (this.rightPos(i + 1, j - 1) && this.cell[i + 1, j - 1] != null) units.Add(this.cell[i + 1, j - 1]);
                if (this.rightPos(i + 1, j) && this.cell[i + 1, j] != null) units.Add(this.cell[i + 1, j]);
                if (this.rightPos(i + 1, j + 1) && this.cell[i + 1, j + 1] != null) units.Add(this.cell[i + 1, j + 1]);
            }

            return units;
        }

        public int surrondingNeighbors(int i, int j, String str)
        {
            int units = 0;

            List<BioUnit> surroundingUnits = this.neighbors(i, j);
            System.Console.WriteLine($"i={i}; j={j}");
            foreach (object unit in surroundingUnits)
            {
                if (this.specie(unit) == str) units++;
            }

            return units;
        }

        public String specie(Object obj)
        {
            String[] w;
            if (obj == null) return "";
            w = TypeDescriptor.GetClassName(obj).Split(".");
            return w[w.Length - 1];
        }

        public Rabbit firstRabbit(int i, int j)
        {
            List<BioUnit> neighbors = this.neighbors(i, j);
            foreach (object unit in neighbors)
            {
                if (this.specie(unit) == "Rabbit")
                    return (Rabbit)unit;
            }

            return null;
        }

        public void next_Rabbit_Carrot_Step()
        {
            BioUnit[,] aux = new BioUnit[this.rows, this.cols];
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    aux[i, j] = null;

                    if (this.specie(this.cell[i, j]) == "Carrot")
                    {
                        if (this.surrondingNeighbors(i, j, "Rabbit") == 0)
                        {
                            if (this.cell[i, j].will_i_live())
                                aux[i, j] = this.cell[i, j];
                        }
                        else
                        {
                            this.firstRabbit(i, j).eat();
                        }
                    }
                    else if (this.specie(this.cell[i, j]) == "Rabbit")
                    {
                        if (this.cell[i, j].will_i_live())
                        {
                            aux[i, j] = this.cell[i, j];
                        }
                    }
                    else
                    {
                        if (this.cell[i, j] == null)
                        {
                            if (this.surrondingNeighbors(i, j, "Rabbit") >= 2)
                                aux[i, j] = new Rabbit(i, j, this);
                            else if (this.surrondingNeighbors(i, j, "Carrot") >= 3)
                                aux[i, j] = new Carrot(i, j, this);
                        }
                    }
                }
            }

            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    this.cell[i, j] = aux[i, j];
                }
            }
        }

        public int total_of_rows()
        {
            return this.rows;
        }

        public int total_of_cols()
        {
            return this.cols;
        }

        private bool rightPos(int i, int j)
        {
            return i >= 0 && i < this.rows && j >= 0 && j < this.cols;
        }

        public void insert(int i, int j, BioUnit bioUnit)
        {
            if (this.rightPos(i, j))
            {
                this.cell[i, j] = bioUnit;
            }
        }

        public BioUnit bioUnit(int i, int j)
        {
            if (this.rightPos(i, j))
            {
                return this.cell[i, j];
            }
            return null;
        }

        // public void nextConwayStep()
        // {
        //     int n;
        //     bool[,] aux = new bool[this.rows, this.cols];
        //     for (var i = 0; i < this.rows; i++)
        //         for (var j = 0; j < this.cols; j++)
        //         {
        //             n = this.aliveNeighbors(i, j);

        //             // if (n == 2 || n == 3) //Conway’s original rule
        //             //     aux[i, j] = true;
        //             // if (n == 3 && !this.is_alive(i, j))
        //             //     aux[i, j] = true;
        //             // else
        //             //     aux[i, j] = false;

        //             if (this.is_alive(i, j))
        //             {
        //                 if (n < 2)
        //                     aux[i, j] = false;
        //                 else if (n == 2 || n == 3)
        //                     aux[i, j] = true;
        //                 else if (n > 3)
        //                     aux[i, j] = false;
        //             }
        //             else
        //             {
        //                 if (n == 3)
        //                     aux[i, j] = true;
        //             }


        //         }
        //     for (var i = 0; i < this.rows; i++)
        //         for (var j = 0; j < this.cols; j++)
        //         {
        //             if (aux[i, j])
        //                 this.live(i, j);
        //             else
        //                 this.die(i, j);
        //         }
        // }
    }
}