using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject.Classes
{
   public class TaxCalculator : ITaxCalculator
    {
        const float salesTax = 10f/100;
        const float salesTaxImported = 5f/100;
        const float ROUNDOFF = 0.05f;
        float applicableTax;
        public TaxCalculator()
        {
            applicableTax = 0.00f;
        }
        public float calculateTax(bool isExempted, float itemPrice, bool isImported)
        {
            if(!isExempted)
            {
                applicableTax += salesTax * itemPrice;
            }
            if (isImported) 
            {
                applicableTax += salesTaxImported * itemPrice;
            }
            return (float) System.Math.Ceiling(applicableTax / ROUNDOFF) * ROUNDOFF;
        }
    }
}
