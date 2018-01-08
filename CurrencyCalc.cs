using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Currency_Converter
{
    public class CurrencyCalc
    {
        public double convToEuro(double theMoney)
        {
            double euroAmount = theMoney * 1.11;
            return euroAmount;
        }

        public double convToUSD(double theMoney)
        {
            double USDamount = theMoney * 1.23;
            return USDamount;
        }

        public double convToAUSD(double theMoney)
        {
            double AUSDamount = theMoney * 1.60;
            return AUSDamount;
        }
        public double convToYen(double theMoney)
        {
            double Yenamount = theMoney * 127.10;
            return Yenamount;
        }
    }


}