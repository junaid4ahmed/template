using System;

namespace template.ConsoleApp {
  class Program {


    static void Main(string[] args) {

      Console.Title = "Template.ConsoleApp";
      // System.Linq.Expressions

      using (ef.Context _context = new ef.Context()) {

        class1.simple_group(_context);

      }
      Console.WriteLine();
      Console.WriteLine($"press any key ...");
      Console.ReadKey();
    }
  }
}
