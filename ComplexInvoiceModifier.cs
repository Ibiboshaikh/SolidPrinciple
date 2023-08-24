using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_principle
{
    public class ComplexInvoiceModifier
    {
        private ComplexInvoice _invoice;
        public ComplexInvoiceModifier(ComplexInvoice invoice)
        {
            _invoice = invoice;
        }

        public void SetSubtotal(decimal subtotal)
        {
            _invoice.Subtotal = subtotal;
        }

        public void SetTaxRate(decimal taxRate)
        {
            _invoice.TaxRate = taxRate;
        }

        public ComplexInvoice GenerateInvoice()
        {
            return _invoice;
        }
    }
}
