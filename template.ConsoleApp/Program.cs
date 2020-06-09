using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template.ConsoleApp {
  class Program {
    static void Main(string[] args) {
      Console.Title = "Template.ConsoleApp";

      using (template.ef.Context _context = new ef.Context()) {
        foreach (var item in _context.Products) {
          Console.WriteLine($"{ item.name }");
        }
      }

      Console.ReadKey();

    }
  }
}
