using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDocumentProgram
{
    public class WordDocument
    {
        DocumentParts[] documentParts;
        public WordDocument(DocumentParts[] documentPartList) 
        {
            this.documentParts = documentPartList;  
        }
        public void Open()
        {

        }
        public void save()
        {

        }
        public void convert(IConvertor iConvertor)
        {
            foreach(DocumentParts documentPart in documentParts)
            {
                documentPart.convert(iConvertor);
            }

        }
    }
}
