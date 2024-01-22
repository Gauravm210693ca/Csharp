using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    [AttributeUsage(AttributeTargets.   Property)]
    public abstract class AttributeValidator:Attribute
    {
        public string ErrorMessage {  get; set; }
        public abstract bool isValid(object value);
    }
}
