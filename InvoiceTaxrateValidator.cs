namespace Solid_principle
{
    public class InvoiceTaxrateValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            if (invoice.TaxRate < 0)
                return false;

            return true;
        }
    }
}
