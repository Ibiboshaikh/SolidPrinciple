namespace Solid_principle
{
    public class InvoiceTotalValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            if (invoice.CalculateTotal() < 0)
                return false;

            return true;
        }
    }
}
