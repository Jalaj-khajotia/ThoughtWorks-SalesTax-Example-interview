using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject.Classes
{
   public class ItemCart: IItemCart
    {
       List<IItemInfo> itemList;
       float totalCost;
       float totalSaleTax;

       public ItemCart()
       {
           itemList = new List<IItemInfo>();          
       }
        public void addItemToCart(IItemInfo item)
        {
            itemList.Add(item);
        }

        public void calculateAndPrintReceiptWithTax()
        {
            resetCart();
            StringBuilder message = new StringBuilder();
            foreach(var item in itemList){
                message.Append("1 "+item.getItemDescription()+" : "+item.getItemPrice()+"\n");
                totalCost += item.getItemPriceWithSalesTax();
                totalSaleTax += item.getSalesTax();
            }
            message.Append("\nSales Tax: "+ totalSaleTax);
            message.Append("\nTotal :" + totalCost);
            Console.WriteLine(message.ToString());
        }


        void resetCart()
        {
            totalCost = 0.00f;
            totalSaleTax = 0.00f;
        }

        public float getTotalCost()
        {
            return totalCost;
        }

        public float getSalesTax()
        {
            return totalSaleTax;
        }
    }
}
