using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice
{
  class CompuChipDesign : IBookReader
  {
    public int NumberOfTimesFound(string textToSearch, string wordToFind)
    {
      int startingPosition = 0;
      int numberOfOccurrences = 0;
      string text = textToSearch.ToLower();
      string word = wordToFind.ToLower();
      do
      {
        startingPosition = text.IndexOf(word, startingPosition + 1);
        if (startingPosition >= 0)
        {
          numberOfOccurrences++;
        }
      } while (startingPosition >= 0);
      return numberOfOccurrences;
    }
  }
}
