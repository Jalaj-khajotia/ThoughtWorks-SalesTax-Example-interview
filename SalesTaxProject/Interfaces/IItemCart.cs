using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject.Interfaces
{
   public interface IItemCart
    {
        void addItemToCart(IItemInfo item);
        void calculateAndPrintReceiptWithTax();
        float getTotalCost();
        float getSalesTax();
    }
}
