using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject.Interfaces
{
   public interface IItemInfo
    {
       bool isItemImported();
       float getItemPrice();
       void setItemPrice(float price);
       void setItemType(bool exepmted, bool imported);
       void setItemDescription(string description);
       string getItemDescription();
       bool isExempted();
       float getSalesTax();
       float getItemPriceWithSalesTax();
       void setItemExempted(bool exempted);
       void setItemImported(bool imported);
    }
}
