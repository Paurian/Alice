using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliceConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Alice.EfficiencyTestRunner etr = new Alice.EfficiencyTestRunner();
      Console.WriteLine(etr.run());
      Console.WriteLine("Done.");
      Console.ReadKey();
    }
  }
}
