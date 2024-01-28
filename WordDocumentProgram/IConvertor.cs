using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public interface IConvertor
    {
        void  Convert(Paragraph prgh);
        void Convert(Header header);
        void Convert(HyperLink hyperlink);
        void Convert(Footer footer);
    }
}
