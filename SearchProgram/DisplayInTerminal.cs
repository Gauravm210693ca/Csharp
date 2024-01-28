using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgram
{
    public class DisplayInTerminal
    {
        public DisplayInTerminal(List<string> filteredList) {
             foreach(string item in filteredList)
            {
                Console.WriteLine(item);
            }
        }  
    }
}
