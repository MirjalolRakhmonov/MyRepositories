namespace blazorserver02.Data
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
                    this.cell[i, j] = null;
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
            return ((i >= 0) && (i < this.rows) && (j >= 0) && (j < this.cols));
        }
        public void insert(int i, int j, BioUnit been)
        {
            if (this.rightPos(i, j))
            {
                this.cell[i, j] = been;
            }
        }
        public BioUnit biounit(int i, int j)
        {
            if (this.rightPos(i, j))
            {
                return this.cell[i, j];
            }
            return null;
        }
        /*public void nextConwayStep() {
                int n;
                bool[,] aux = new bool[this.rows,this.cols];
                for(var i=0; i<this.rows; i++)
                for(var j=0; j<this.cols; j++) {
                    n = this.aliveNeighbors(i,j); 
                if(n==3) //Conway’s original rule
                    aux[i,j] = true;
                else if (n==2 && this.is_alive(i,j))
                    aux[i,j] = true;
                else
                    aux[i,j] = false;
                }
                for(var i=0; i<this.rows; i++)
                for(var j=0; j<this.cols; j++) {
                    if(aux[i,j])
                        this.live(i,j);
                    else
                    this.die(i,j);
                    }
            }*/
    }
}