namespace blazorserver02.Data.GameOfLife
{
    public class Environment
    {
        private int rows = 1;
        private int cols = 1;
        private BioUnit[,] cell;
        public Environment(int rows_, int columns_)
        {
            this.rows = rows_;
            this.cols = columns_;
            this.cell = new BioUnit[this.rows, this.cols];
            for (var i = 0; i < this.rows; i++)
                for (var j = 0; j < this.cols; j++)
                    this.cell[i, j] = new BioUnit();
        }
        public int total_of_rows()
        {
            return this.rows;
        }
        public int total_of_cols()
        {
            return this.cols;
        }
        public void live(int i, int j)
        {
            if (this.rightPos(i, j))
                this.cell[i, j].live();
        }
        public void die(int i, int j)
        {
            if (this.rightPos(i, j))
                this.cell[i, j].die();
        }
        private bool rightPos(int i, int j)
        {
            return i >= 0 && i < this.rows && j >= 0 && j < this.cols;
        }
        public bool is_alive(int i, int j)
        {
            if (this.rightPos(i, j))
                return this.cell[i, j].is_alive();
            return false;
        }

        public void insert(int i, int j, BioUnit bioUnit)
        {
            if (this.rightPos(i, j))
            {
                this.cell[i, j] = bioUnit;
            }
        }

        public int aliveNeighbors(int i, int j)
        {
            int c = 0;
            c += this.is_alive(i - 1, j - 1) ? 1 : 0;
            c += this.is_alive(i - 1, j) ? 1 : 0;
            c += this.is_alive(i - 1, j + 1) ? 1 : 0;
            c += this.is_alive(i, j - 1) ? 1 : 0;
            c += this.is_alive(i, j + 1) ? 1 : 0;
            c += this.is_alive(i + 1, j - 1) ? 1 : 0;
            c += this.is_alive(i + 1, j) ? 1 : 0;
            c += this.is_alive(i + 1, j + 1) ? 1 : 0;
            return c;
        }

        public void nextConwayStep()
        {
            int n;
            bool[,] aux = new bool[this.rows, this.cols];
            for (var i = 0; i < this.rows; i++)
                for (var j = 0; j < this.cols; j++)
                {
                    n = this.aliveNeighbors(i, j);

                    if (this.is_alive(i, j))
                    {
                        if (n < 2)
                            aux[i, j] = false;
                        else if (n == 2 || n == 3)
                            aux[i, j] = true;
                        else if (n > 3)
                            aux[i, j] = false;
                    }
                    else
                    {
                        if (n == 3)
                            aux[i, j] = true;
                    }

                }
            for (var i = 0; i < this.rows; i++)
                for (var j = 0; j < this.cols; j++)
                {
                    if (aux[i, j])
                        this.live(i, j);
                    else
                        this.die(i, j);
                }
        }

        public void put_pattern(int x, int y, string pattern)
        {
            if (pattern.Equals("Toad"))
            {
                for (var i = 0; i < 4; i++)// rows
                    for (var j = 0; j < 2; j++)//cols
                        if (!((i == 0 && j == 1) || (i == 3 && j == 0)))
                        {
                            this.insert(x + i, y + j, new BioUnit(true));
                        }
            }

            if (pattern.Equals("Pulsar"))
            {
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                        if (!((i == 0 && j == 2) || (i == 1 && j == 1) || (i == 2 && j == 0)))
                        {
                            this.insert(x + i, y + j, new BioUnit(true));
                        }
                }
            }
        }
    }
}