using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSystems
{
    class HexadecimalForm : INumericalForm
    {
        protected string hexa { get; set; }

        public HexadecimalForm(string newHexa)
        {
            hexa = newHexa;
        }

        public string ToDecimal()
        {
            var convert = new DecimalForm();
            return convert.AnySystemToDecimal(this.hexa, 16);
        }

        public string ToOcta()
        {
            var octaToDecimal = ToDecimal();
            var convert = new DecimalForm(octaToDecimal);
            return convert.ToOcta();
        }

        public string ToBinary()
        {
            var octaToDecimal = ToDecimal();
            var convert = new DecimalForm(octaToDecimal);
            return convert.ToBinary();
        }

        public string ToHex()
        {
            return this.hexa;
        }
    }
}
