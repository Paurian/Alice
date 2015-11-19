using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Reflection;

namespace Alice
{
  public class EfficiencyTestRunner
  {
    // Load the items to test from the APPLICATION'S config file (it's the App.config from the interface that calls this class).
    // Cycle through each item and run the "NumberOfTimesFound" method, wrapped in stopwatch calls to measure their efficiency.
    // create a series of strings that capture the measurements so that the output interface (either a webforms app or a console app) can display the results.

    // TODO: allow run() to take parameters for the file name and the search word.
    public string run()
    {
      string aliceFile = Path.Combine(Environment.CurrentDirectory, "book.txt");
      string text = File.ReadAllText(aliceFile);

      NameValueCollection sAll;
      sAll = ConfigurationManager.AppSettings;
      int numberFound;
      StringBuilder sbResults = new StringBuilder();

      foreach (string s in sAll.AllKeys)
      {
        object design = CreateInstance(sAll.Get(s));
        TimeSpan ts = RunInstance((IBookReader)design, text, "Queen", out numberFound);
        // TODO: Add Localization
        sbResults.AppendLine("The '" + s + "' design yielded " + numberFound.ToString() + " finds in " + ts.ToString() + " time.");
      }

      return sbResults.ToString();
    }

    private TimeSpan RunInstance(IBookReader instance, string textToSearch, string wordToFind, out int count)
    {
      Stopwatch sw = new Stopwatch();

      sw.Start();
      count = instance.NumberOfTimesFound(textToSearch, wordToFind);
      sw.Stop();
      return sw.Elapsed;
    }

    private object CreateInstance(string className)
    {
      var assembly = Assembly.GetExecutingAssembly();
      var type = assembly.GetTypes().First(t => t.Name == className);
      return Activator.CreateInstance(type);
    }
  }
}
