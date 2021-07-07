using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alcoCalk2.Models
{
    public class CalcResponce
    {
        public CalcResponce(string text)
        {
            this.responceText = text;
        }
        public string responceText { get; set; }
    }
}
