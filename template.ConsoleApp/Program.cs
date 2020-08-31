using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using template;
using template.ef.Entities;

namespace template.ConsoleApp {
  class Program {
    static void Main(string[] args) {
      Console.Title = "Template.ConsoleApp";

      // displaying categories
      da.category category = new da.category();
      IList<category> categories = category.select();

      foreach (category item in categories) {
        Console.WriteLine($" { item.category_id } { item.name }");
      }

      // displaying products
      da.product product = new da.product();
      IList<product> products = product.get_products_by_category_id(1);

      foreach (product item in products) {
        Console.WriteLine($" { item.category_id } { item.name }");
      }

      Console.ReadKey();

    }
  }
}
