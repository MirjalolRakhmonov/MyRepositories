using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalSystems
{
    interface INumericalForm
    {
        string ToDecimal();
        string ToOcta();
        string ToBinary();
        string ToHex();

    }
}
