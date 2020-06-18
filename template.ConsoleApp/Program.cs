using System;
using System.Collections.Generic;
using System.Linq;

namespace template.ConsoleApp {
  class Program {


    static void Main(string[] args) {

      Console.Title = "Template.ConsoleApp";
      // System.Linq.Expressions

      using (ef.Context _context = new ef.Context()) {

        class1.simple_query(_context);

      }
      Console.WriteLine("");
      Console.WriteLine($"press any key ...");
      Console.ReadKey();
    }
  }
}
