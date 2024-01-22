using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    internal class MaxLengthAttribute:AttributeValidator
    {
        private int maxLength { get; set; }
        string msg;

        public MaxLengthAttribute(int maxLength, string msg)
        {
            this.maxLength = maxLength;
            this.msg = msg;
        }

        public override bool isValid(object value)
        {
            string str = value as string;
            if(str != null)
            {
                return str.Length > maxLength;
            }
            return false;
        }
    }
}
