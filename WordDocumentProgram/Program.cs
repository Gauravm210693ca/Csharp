using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Header headerObj = new Header();
            Footer footerObj = new Footer();
            Paragraph paragraphObj = new Paragraph();
            HyperLink hyperLinkObj = new HyperLink();
            DocumentParts[] documentPartList = new DocumentParts[] { headerObj, paragraphObj, hyperLinkObj, footerObj };
            WordDocument wordDocumentObj = new WordDocument(documentPartList);
            IConvertor htmlConvertor = new HTMLConvertor();
            wordDocumentObj.convert(htmlConvertor);
        }
    }
}
