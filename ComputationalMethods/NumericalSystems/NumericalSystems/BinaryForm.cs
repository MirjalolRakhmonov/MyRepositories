using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSystems
{
    class BinaryForm : INumericalForm
    {
        protected string binary { get; private set; }

        public BinaryForm(string newBinary)
        {
            binary = newBinary;

        }

        public string ToDecimal()
        {
            var convert = new DecimalForm();
            return convert.AnySystemToDecimal(this.binary, 2);
        }

        public string ToOcta()
        {
            var binaryToDecimal = ToDecimal();
            var convert = new DecimalForm(binaryToDecimal);
            return convert.ToOcta();
        }

        public string ToBinary()
        {
            return this.binary;
        }

        public string ToHex()
        {
            var binaryToDecimal = ToDecimal();
            var convert = new DecimalForm(binaryToDecimal);
            return convert.ToHex();
        }
    }
}
