namespace Solid_principle
{
    public class InvoicePrinter
    {
        private IInvoicePrint _printSystem;
        public InvoicePrinter(IInvoicePrint printSystem)
        {
            _printSystem = printSystem;
        }
        public void Print(Invoice invoice)
        {
            _printSystem.Print(invoice);
        }
    }
}
