using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice
{
  interface IBookReader
  {
    int NumberOfTimesFound(string textToSearch, string wordToFind);
  }
}
