using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace template.ConsoleApp {

  public static class class1 {
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords

    public static void simple_query(ef.Context _context) {
      IQueryable<ef.Entities.product> collection =

        // you can apply all sort of string and extension methods here
        _context.Products.Where(f => f.name.Contains("ch"));

      //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables
      // compiler will inferred the type from select clause, anonymous object
      var products =
        from product in collection

        // orderby clause to sort or order the selection in select clause 
        // by some property of the object
        orderby product.name ascending

        // where clause to filter or limit the output result by some property 
        // of the object
        //where product.category_id == 1

        // following select statement will create an anonymous object which 
        // contain id, product_id properties as properties and product object, 
        select new {

          // object name becomes the property of anonymous object
          product,

          // you can create property for anonymous object
          id = product.product_id,

          // you can let c# to create property for you for your anonymous object
          product.category_id,

        };

      foreach (var item in products) {
        Console.Write($"{ item.category_id } { Constants.vbTab } { item.product.name }");
        Console.Write($"{ Constants.vbNewLine }");
      }
    }

    public static void simple_join(ef.Context _context) {

      // selecting sequence/collection for join
      IQueryable<ef.Entities.category> categories =
        _context.Categories;

      IQueryable<ef.Entities.product> products =
        _context.Products;

      // compiler will inferred the type from select clause, anonymous object
      var products_and_categories =

        // left-side sequence/collection of join
        from category in categories

        // right-side sequence/collection of join
        join product in products

        // what property the join is base on
        on category.category_id equals product.category_id

        // orderby clause to sort or order the selection in select clause 
        // by some property of the object
        orderby product.name ascending

        // where clause to filter or limit the output result by some property 
        // of the object
        //where product.category_id == 1

        select new {
          //instead of selecting properties such as category.category_id, 
          //product.name, selecting whole objects, category and product
          Category_id = category.category_id,
          Name = category.name,
          ProductName = product.name
        };

      // above query setup will not cause entity framework to generate SQL 
      // for the database yet
      foreach (var item in products_and_categories) {
        Console.WriteLine($" { item.Category_id } { item.ProductName }");
      }

    }

  }
}
