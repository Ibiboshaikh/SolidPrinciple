using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principle
{
    class PrintingSystemClient2 : IInvoicePrint, IPrintWithLogo
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
