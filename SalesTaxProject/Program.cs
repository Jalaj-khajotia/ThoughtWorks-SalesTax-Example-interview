using Ninject;
using Ninject.Modules;
using SalesTaxProject.Classes;
using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject
{
    class Program
    {
        static IItemCart items;
        static void Main(string[] args)
        {
            SaleTaxHelpers helpers = new SaleTaxHelpers();
            IKernel kernel = new StandardKernel(new NinjectBindings());            
            items = kernel.Get<IItemCart>();
            var lines = helpers.readFile("input1.txt");
            foreach(var line in lines){
                items.addItemToCart(helpers.extractInfofromLine(line));
            }           
            
           items.calculateAndPrintReceiptWithTax();
           Console.ReadLine();
        }        
    }
}
