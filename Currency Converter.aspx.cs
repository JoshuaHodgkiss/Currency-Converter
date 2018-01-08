using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Currency_Converter
{
    public partial class Currency_Converter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CurrencyCalc converter = new CurrencyCalc();

            int choice = Convert.ToInt16(CurrencySelect.SelectedValue);

            double gbp = Convert.ToDouble(Amount.Text);

            switch (choice)
            {
                case 1:
                    Result.Text = Convert.ToString(converter.convToEuro(gbp));
                    break;
                case 2:
                    Result.Text = Convert.ToString(converter.convToUSD(gbp));
                    break;
                case 3:
                    Result.Text = Convert.ToString(converter.convToAUSD(gbp));
                    break;
                case 4:
                    Result.Text = Convert.ToString(converter.convToYen(gbp));
                    break;

            }
        }
    
    }

}