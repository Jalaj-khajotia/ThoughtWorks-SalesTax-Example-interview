using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using SalesTaxProject;
using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleTaxUnitTest
{
    [TestClass]
   public class UnitTest
    {
       private IItemCart items;
       public UnitTest()
       {
           SaleTaxHelpers helpers = new SaleTaxHelpers();
           IKernel kernel = new StandardKernel(new NinjectBindings());
           items = kernel.Get<IItemCart>();

           items.addItemToCart(helpers.createItem(4.11f, "bringle", false, true));
           items.addItemToCart(helpers.createItem(24.00f, "cauliflaur", false, true));
          
       }

         [TestMethod]
        public void CheckforTax(){
          items.calculateAndPrintReceiptWithTax();
          Assert.AreEqual(items.getSalesTax(), 0.00);
        }
    }
}
