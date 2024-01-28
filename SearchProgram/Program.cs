using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = { "hello", "car", "far", "boy","bat" };
            Console.WriteLine("Enter the word to search");
            string wordToSearch = Console.ReadLine();
            SearchWord searchWordObj = new SearchWord(inputString,wordToSearch);
            List<string> filteredList = new List<string>();
            filteredList = searchWordObj.CheckForWord();
            DisplayInTerminal displayInTerminal = new DisplayInTerminal(filteredList);
            Console.ReadLine(); 
        }
    }
}
