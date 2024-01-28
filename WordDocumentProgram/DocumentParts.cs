using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public abstract class DocumentParts
    {
        public string DocumentPartName;
        
        public abstract void save();
        public abstract void paint();
        public abstract void convert(IConvertor iConvertor);

    }
}
