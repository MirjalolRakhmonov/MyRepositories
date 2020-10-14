namespace blazorserver02.Data
{
    public class Carrot : Data.BioUnit
    {
        public Carrot(int x, int y, Data.Environment e) : base(x, y,e) => this.color = "#fa5511";
    }
}