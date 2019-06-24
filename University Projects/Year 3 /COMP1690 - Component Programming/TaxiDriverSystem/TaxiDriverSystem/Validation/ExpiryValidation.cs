using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class ExpiryValidation
    {
        private ExpiryView expiryV = new ExpiryView();

        public ExpiryValidation(ExpiryView expView)
        {
            this.expiryV = expView;

        }
    }
}
