using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principle
{
    public class PrintingSystem : IInvoicePrint
    {
        public void Print(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void PrintWithLogo(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
