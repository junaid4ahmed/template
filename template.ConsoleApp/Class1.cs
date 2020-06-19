using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace template.ConsoleApp {

  public static class class1 {
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/query-keywords

    public static void simple_query(ef.Context _context) {

      IQueryable<ef.Entities.product> collection =
        _context.Products;

      //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/implicitly-typed-local-variables
      // compiler will inferred the type from select clause, anonymous object
      var products =
        from product in collection

        // orderby clause to sort or order the selection in select clause 
        // by some property of the object
        orderby product.name ascending

        // where clause to filter or limit the output result by some property 
        // of the object
        //where product.category_id == 1 || product.name.Contains("ch")

        // create a range variable using let keyword that will hold the result 
        // of sub-expression that can be used later in expression
        let conditions = product.category_id == 1 || product.name.Contains("ch")

        // now where clause is lot short than previous
        where conditions

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

    public static void simple_group(ef.Context _context) {

      // selecting sequence/collection for query expression
      IQueryable<ef.Entities.product> products =
        _context.Products;
      
      // compiler will inferred the type from select clause, anonymous object 
      // of the type IQueryable<IGrouping<int, product>>
      var groups =

        //product for product's collection
        from product in products

        //grouping products by category_id
        group product by product.category_id;

      //groups = IQueryable<IGrouping<int, product>>
      foreach (var group in groups) {
        Console.WriteLine($"{ group.Key }");

        //item = IGrouping<int, product>
        foreach (var item in group) {
          Console.WriteLine($" { item.name }");
        }
      }

    }

    public static void simple_into(ef.Context _context) {

      // follow the link for better understading
      // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause

      // associates elements in the left source sequence with one or more 
      // matching elements in the right side source sequence

      // if no elements from the right source sequence are found to match an element
      // in the left source, the join clause will produce an empty array for that item

      // have access to object's properties of left-side sequence 
      // not like GroupBy clause where we have access to only key property 
      // as a left-side

      IQueryable<ef.Entities.category> categories =
        _context.Categories;

      IQueryable<ef.Entities.product> products =
        _context.Products;

      var products_by_category =

        // left-side sequence/collection of join
        from category in categories

        // right-side sequence/collection of join
        join product in products

        // common property the join is base on
        on category.category_id equals product.category_id

        // storing the grouping products into range variable 
        // "category_related_products" for later access in Select clause 
        into category_related_products

        // ordering result by category's name
        orderby category.name

        // filtering by category's name or category's id
        where category.name == "Pasta" || category.category_id == 2

        // selecting or projecting, desire anonymous object
        select new {

          // have access to left-side object's properties not 
          // just primary-key
          category,
          _name = category.name,

          // there is a collection of products related to one category
          _products = category_related_products,
        };

      foreach (var items in products_by_category) {
        Console.WriteLine($"{items._name }");

        foreach (var item in items._products) {
          Console.WriteLine($" { item.name }");
        }
      }

    }


  }
}
