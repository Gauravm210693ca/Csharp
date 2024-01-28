using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchProgram
{
    public class SearchWord
    {
        string[] input;
        string wordToSearch;
        List<string> wordsList;
        public SearchWord(string[] inputString,string wordToSearch) { 
            this.input = inputString;
            this.wordToSearch = wordToSearch; 
            wordsList = new List<string>();
        } 
        public List<string> CheckForWord()
        {
            foreach(string word in input) { 
                if(word.StartsWith(wordToSearch))
                {
                    wordsList.Add(word);
                }
            }
            return wordsList;   
        }
        
    }
}
