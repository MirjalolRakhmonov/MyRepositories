
namespace blazorserver02.Data
{
    public class Rabbit : Data.RabbitsAndCarrots.BioUnit
    {
        private int living = 0;
        private int livingTop = 6;

        private int hungry = 0;

        private int hungryTop = 4;

        public Rabbit(int x, int y, Data.RabbitsAndCarrots.Environment e) : base(x, y, e, "#fafafa") { }

        public override bool will_i_live()
        {
            this.hungry++;
            this.living++;

            if ((this.living - 1) >= this.livingTop) return false;

            if (this.hungry - 1 >= this.hungryTop) return false;

            return true;
        }

        public void eat() {
            this.hungry = 0;
        }
    }
}