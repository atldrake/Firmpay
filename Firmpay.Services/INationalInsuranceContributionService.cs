using System;
using System.Collections.Generic;
using System.Text;

namespace Firmpay.Services
{
    public interface INationalInsuranceContributionService
    {
        decimal NIContribution(decimal totalAmount);
    }
}
