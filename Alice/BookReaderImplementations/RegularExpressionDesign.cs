using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Alice
{
  class RegularExpressionDesign : IBookReader
  {
    public int NumberOfTimesFound(string textToSearch, string wordToFind)
    {
      // Regex re = new Regex(wordToFind, RegexOptions.IgnoreCase | RegexOptions.Compiled);
      string text = textToSearch.ToLower();
      string word = wordToFind.ToLower();
      Regex re = new Regex(word, RegexOptions.Compiled);
      MatchCollection mc = re.Matches(text);
      return mc.Count;
    }
  }
}
