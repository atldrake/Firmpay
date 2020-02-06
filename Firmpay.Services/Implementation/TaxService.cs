using System;
using System.Collections.Generic;
using System.Text;

namespace Firmpay.Services.Implementation
{
    public class TaxService : ITaxService
    {
        private decimal taxRate;
        private decimal tax;
        public decimal TaxAmount(decimal totalAmount)
        {
            if (totalAmount <= 1000)
            {
                //Tax free Rate
                taxRate = .0m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 1000 && totalAmount <= 3000)
            {
                //Basic Tax Rate
                taxRate = .20m;
                //Income Tax
                tax = (1000 * .0m) + ((totalAmount - 1000) * taxRate);
            }
            else if (totalAmount > 3000 && totalAmount <= 12500)
            {
                //Higher  Tax Rate
                taxRate = .40m;
                //Income Tax 
                tax = (1000 * .0m) + ((3000 - 1000) * .20m) + ((totalAmount - 3000) * taxRate);
            }
            else if (totalAmount > 12500)
            {
                //Additional tax rate
                taxRate = .45m;
                tax = (1000 * .0m) + ((3000 - 1000) * .20m) + 
                    ((12500 - 3000) * .40m) + ((totalAmount - 12500) * taxRate);
            }
            return tax;
        }
    }
}
