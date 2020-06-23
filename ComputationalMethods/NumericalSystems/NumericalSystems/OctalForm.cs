using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSystems
{
    public class OctalForm : INumericalForm
    {
        protected string octa { get; private set; }

        public OctalForm(string newOcta)
        {
            octa = newOcta;
        }

        public string ToDecimal()
        {
            var convert = new DecimalForm();
            return convert.AnySystemToDecimal(this.octa, 8);

        }

        public string ToOcta()
        {
            return this.octa;
        }

        public string ToBinary()
        {
            var octaToDecimal = ToDecimal();
            var convert = new DecimalForm(octaToDecimal);
            return convert.ToBinary();
        }

        public string ToHex()
        {
            var octaToDecimal = ToDecimal();
            var convert = new DecimalForm(octaToDecimal);
            return convert.ToHex();
        }
    }
    }
