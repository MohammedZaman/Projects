using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriverSystem.Interfaces
{
    public interface IView
    {
         void ActivateView(IController myController);
         int getTabindex();
   }
}
