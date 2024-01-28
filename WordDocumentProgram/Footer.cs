using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public class Footer:DocumentParts
    {
        string text;
        public override void save()
        {
            Console.WriteLine("Footer saved");
        }
        public override void paint()
        {
            Console.WriteLine("Footer painted");
        }
        public override void convert(IConvertor iconvertor)
        {
            iconvertor.Convert(this);
        }
    }
}
