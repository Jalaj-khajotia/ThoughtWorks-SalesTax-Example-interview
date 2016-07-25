using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject.Classes
{
   public class ItemInfo: IItemInfo
   {
       string itemName;
       float itemPrice;
       bool itemImported;
       bool itemExepmted;
       ITaxCalculator CALCULATOR;

       public ItemInfo(ITaxCalculator calulator)
       {
           CALCULATOR = calulator;
       }

        public bool isItemImported()
        {
            return itemImported;
        }
        public void setItemImported(bool imported)
        {
            itemImported = imported;
        }
        public void setItemExempted(bool exempted)
        {
            itemExepmted = exempted;
        }

        public float getItemPrice()
        {
            return itemPrice;
        }

        public void setItemPrice(float price)
        {
            itemPrice = price;
        }

        public void setItemType(bool exepmted, bool imported)
        {
            itemImported = imported;
            itemExepmted = exepmted;
        }

        public void setItemDescription(string description)
        {
            itemName = description;
        }

        public string getItemDescription()
        {
            return itemName;
        }
        public bool isExempted()
        {
            return itemExepmted;
        }

        public float getSalesTax()
        {
           return CALCULATOR.calculateTax(this.isExempted(),this.getItemPrice(),this.isItemImported());
        }

        public float getItemPriceWithSalesTax()
        {
            return CALCULATOR.calculateTax(this.isExempted(), this.getItemPrice(), this.isItemImported()) +getItemPrice();
        }

    }
}
