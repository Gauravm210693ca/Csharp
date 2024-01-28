using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public class Header:DocumentParts
    {
        string title;
        public override void save()
        {
            Console.WriteLine("Header saved");
        }
        public override void paint()
        {
            Console.WriteLine("Header painted");
        }
        public override void convert(IConvertor iconverot)
        {
            iconverot.Convert(this);
        }
    }
}
