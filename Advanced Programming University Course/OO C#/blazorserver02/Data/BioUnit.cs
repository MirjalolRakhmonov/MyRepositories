namespace blazorserver02.Data
{
    public class BioUnit
    {
        protected string color;
        public int posx;
        public int posy;
        private bool alive;
        public BioUnit(int x, int y)
        {
            this.posx = x;
            this.posy = y;
            this.color = "#444444";
        }
        public string mycolor() => this.color;
    }
}