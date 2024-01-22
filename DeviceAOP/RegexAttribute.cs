using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Device
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class RegexAttribute:AttributeValidator
    {
        public string Pattern { get; set; }
        string msg;
        public RegexAttribute(string pattern,string msg)
        {
            Pattern = pattern;
            this.msg = msg;
        }
        public override bool isValid(object value)
        {
            string text = value as string;
            return Regex.IsMatch(text, Pattern);
        }
    }
}
