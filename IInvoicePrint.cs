using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principle
{
    public interface IInvoicePrint
    {
        void Print(Invoice invoice);
    }
}
