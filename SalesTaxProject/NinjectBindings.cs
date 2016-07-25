using SalesTaxProject.Classes;
using SalesTaxProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTaxProject
{
   public class NinjectBindings: Ninject.Modules.NinjectModule
    {
       public override void Load()
       {
           Bind<IItemCart>().To<ItemCart>();
           Bind<ITaxCalculator>().To<TaxCalculator>();
       }
    }
}
