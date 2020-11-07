
namespace blazorserver02.Data
{
    public class Carrot : Data.BioUnit
    {
        private int living = 0;
        private int livingTop = 3;
        public Carrot(int x, int y, Data.Environment e) : base(x, y, e) { }

        public override bool will_I_live()
        {
            return this.living++ < this.livingTop;
        }
    }
}