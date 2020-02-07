using System;
using System.Collections.Generic;
using System.Text;

namespace Firmpay.Services.Implementation
{
    public class NationalInsuranceContributionService : INationalInsuranceContributionService
    {
        private decimal NIRate;
        private decimal NIC; 
        public decimal NIContribution(decimal totalAmount)
        {           
            if (totalAmount < 700)
            {
                //lower Earning Limit Rate and below Primary Threshold 
                NIRate = .0m;
                NIC = 0m;
            }
            else if (totalAmount >= 700 && totalAmount < 4000)
            {
                //Between Primary and Upper Earning Limit(UEL)
                NIRate = .12m;
                NIC = ((totalAmount - 700) * NIRate);
            }
            else if (totalAmount > 4000)
            {
                //Above Upper Earning Limit(UEL)
                NIRate = .02m;
                NIC = ((4000 - 700) * .12m) + ((totalAmount - 4000) * NIRate);
            }
            return NIC;
        }
    }
}
