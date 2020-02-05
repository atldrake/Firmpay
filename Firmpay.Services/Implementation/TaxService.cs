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

            }
        }
    }
}
