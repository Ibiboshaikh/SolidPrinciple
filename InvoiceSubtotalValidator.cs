namespace Solid_principle
{
    public class InvoiceSubtotalValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            if (invoice.Subtotal < 0)
                return false;

            return true;
        }
    }
}
