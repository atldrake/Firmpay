using System;
using System.Collections.Generic;
using System.Text;

namespace Firmpay.Services
{
    public interface ITaxService
    {
        decimal TaxAmount(decimal totalAmount);
    }
}
