using System.Collections.Generic;
using System.Linq;

namespace Solid_principle
{
    public class InvoiceValidator
    {
        private List<Validator> _validators;
        public InvoiceValidator(List<Validator> validator)
        {
            _validators = validator;
        }

        public bool Validate(Invoice invoice) 
        {
            return _validators.All(v => v.Validate(invoice));
        }
    }
}
