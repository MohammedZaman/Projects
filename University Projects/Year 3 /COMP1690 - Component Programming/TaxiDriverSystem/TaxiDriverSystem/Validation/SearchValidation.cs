using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiDriverSystem.View;

namespace TaxiDriverSystem.Validation
{
    public class SearchValidation
    {
        private SearchView searchV = new SearchView();
        public SearchValidation(SearchView searchV)
        {
            this.searchV = searchV;
        }

        public Boolean onClickSearchValidate()
        {
            bool isOk = false;
            if (searchV.EditSelectTBox1.Text == String.Empty)
            {
                isOk = false;
                searchV.ErrorProvider1.SetError(searchV.EditSelectTBox1, "Select Driver");
            }
            else { isOk = true; }
         
            return isOk;
        }



        public void onChangeSearchValidate()
        {
            if (string.IsNullOrEmpty(searchV.EditSelectTBox1.Text.Trim()))
            {
                searchV.ErrorProvider1.SetError(searchV.EditSelectTBox1, "Select Driver");
            }
            else { searchV.ErrorProvider1.SetError(searchV.EditSelectTBox1, string.Empty); }

        }


    }
}
