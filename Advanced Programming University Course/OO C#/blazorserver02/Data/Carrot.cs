
namespace blazorserver02.Data
{
    public class Carrot : Data.RabbitsAndCarrots.BioUnit
    {
        private int living = 0;
        private int livingTop = 3;
        public Carrot(int x, int y, Data.RabbitsAndCarrots.Environment e) : base(x, y, e, "#fa5511") { }

        public override bool will_i_live()
        {
            return this.living++ < this.livingTop;
        }
    }
}