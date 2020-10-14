namespace blazorserver02.Data
{
    public class BioUnit
    {
        protected string color;
        public int posx;
        public int posy;
        public Environment parent;
        private bool alive;
        public BioUnit(int x, int y, Environment e)
        {
            this.posx = x;
            this.posy = y;
            this.color = "#444444";
            this.parent=e;
        }
        public string mycolor() => this.color;
    }
}