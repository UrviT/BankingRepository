using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int principle, int years, int rateOfInterest)
        {
            int SimpleInterest = (principle * years * rateOfInterest) / 100;
            return SimpleInterest;
        }
    }
}
