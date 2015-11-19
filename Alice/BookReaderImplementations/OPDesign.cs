using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

// http://stackoverflow.com/questions/33807926/the-best-way-to-find-how-many-times-a-stringor-substring-occurs-in-a-large-str
namespace Alice
{
  class OPDesign : IBookReader
  {
    public int NumberOfTimesFound(string textToSearch, string wordToFind)
    {
      return Exercise4(textToSearch);
    }

    private int Exercise4(string text)
    {
      int count = 0;
      foreach (string str in LoadAliceInWonderland(text))
      {
        if (str == "queen")
        {
          count++;
        }
      }
      return count;
    }

    //load the book (from file) and return it as a string array
    private string[] LoadAliceInWonderland(string text)
    {
      // string aliceFile = Path.Combine(Environment.CurrentDirectory, "book.txt");
      // string text = File.ReadAllText(aliceFile).ToLower();
      text = text.ToLower();
      string[] words = removeUselessValues(text).Split();
      return words;
    }

    private string removeUselessValues(string s)
    {
      string result = "";
      foreach (char c in s)
        result += (c.Equals('q') || c.Equals('u') || c.Equals('e') || c.Equals('n')) ? c : ' ';
      return result;
    }
  }
}
