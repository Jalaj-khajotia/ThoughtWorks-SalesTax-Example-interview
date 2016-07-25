using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject.Interfaces
{
   public interface ITaxCalculator
   {
       float calculateTax(bool isExempted, float itemPrice, bool isImported);
    }
}
