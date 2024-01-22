using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class RequiredAttribute:AttributeValidator
    {
        public override bool isValid(object value)
        {
            string msg = value as string;
           return msg != null && msg.Length > 0;
        }
    }
}
