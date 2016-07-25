using Ninject;
using Ninject.Modules;
using SalesTaxProject.Classes;
using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject
{
    public class SaleTaxHelpers
    {
        IKernel kernel;
        public SaleTaxHelpers()
        {
            kernel = new StandardKernel(new NinjectBindings());           
        }
        public IItemInfo createItem(float price, string name, bool isImported, bool isExempted)
       {
           IItemInfo item = kernel.Get<ItemInfo>();
           item.setItemPrice(price);
           item.setItemDescription(name);
           item.setItemImported(isImported);
           item.setItemExempted(isExempted);           
           return item;
       }

        public string[] readFile(string fileName)
        {
            var file = File.ReadAllLines("D:\\" + fileName);
            return file;
        }

        public IItemInfo extractInfofromLine(string line)
        {
            var keywords = line.Split(' ');
            var itemPrice = 00f;
            var itemName = "";
            var imported = false;
            var exempted = false;
            for (var i = 0; i < keywords.Length && keywords.Length>3;i++ )
            {
                if (keywords[i] == "at")
                {
                    float.TryParse(keywords[i + 1],out itemPrice);
                    itemName = keywords[i - 1];
                }
                if(keywords[i] == "imported")
                {
                    imported = true;
                }
                if (keywords[i] == "book" || keywords[i] == "chocolate" || keywords[i] == "pills")
                {
                    exempted = true;
                }               
            }
            return createItem(itemPrice, itemName, imported, exempted);
        }
    }
}
