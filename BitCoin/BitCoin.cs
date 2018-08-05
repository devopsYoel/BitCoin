using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoin
{
    class Bitcoin
    {    
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public string chartName { get; set; }
        public BPI bpi { get; set; }
        
    }

    class Time
    {
        public string updated { get; set; }
        public string updatedISO { get; set; }
        public string updateduk { get; set; }
    }

    class BPI
    {
        public USD usd { get; set; }      
    }

    class USD
    {
        public string code { get; set; }
        public string symbol { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public string rate_float { get; set; }
    }



}
