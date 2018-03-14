using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppNumberToWords.Service
{
    public class NumberToWordServices
    {
        public ServiceNumberToWords.ServiceNumberToWordsClient obj;
        public NumberToWordServices()
        {
            obj = new ServiceNumberToWords.ServiceNumberToWordsClient();
        }
        public string GetName(string Name)
        {
            return obj.GetName(Name);
        }
        public string GetConvertedNumber(string Number)
        {
            return obj.ConvertNumbertoWord(Number);
        }
    }
}