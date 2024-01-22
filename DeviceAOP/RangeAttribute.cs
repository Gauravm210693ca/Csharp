using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    internal class RangeAttribute:AttributeValidator
    {
        private int Min;
        private int Max;
        private string msg;
        public RangeAttribute() { }
        public RangeAttribute(int min, int max,string msg)
        {
                Min = min; 
                Max = max;
               this.msg = msg;  
        }
        public override bool isValid(object value)
        {
            int rng = Convert.ToInt32(value);
            return rng >= Min && rng <= Max;    
        }
    }
}
