namespace blazorserver02.Data.RabbitsAndCarrots
{
    public class BioUnit
    {
        protected string color;

        public int posx;

        public int posy;

        private Environment environment;

        public BioUnit(int x, int y, Environment e, string color = "#444") {
            this.posx = x;
            this.posy = y;
            this.color = color;
            this.environment = e;
        }
        public string myColor() => this.color;

        public virtual bool will_i_live() => true;
    }
}