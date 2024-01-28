using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public class HyperLink:DocumentParts
    {
        string text;
        public override void save()
        {
            Console.WriteLine("HyperLink saved");
        }
        public override void paint()
        {
            Console.WriteLine("HyperLink painted");
        }
        public override void convert(IConvertor iconverot)
        {
            iconverot.Convert(this);
        }
    }
}
