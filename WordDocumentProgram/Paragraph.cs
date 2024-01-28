using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public class Paragraph : DocumentParts
    {
        string content;
        public override void save()
        {
            Console.WriteLine("Paragraph saved");
        }
        public override void paint()
        {
            Console.WriteLine("Paragraph painted");
        }
        public override void convert(IConvertor iConvertor)
        {
            iConvertor.Convert(this);
        }
    }
}
