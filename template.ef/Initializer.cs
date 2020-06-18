using System.Collections.Generic;
using System.Data.Entity;

namespace template.ef {
  public class Initializer
    : DropCreateDatabaseIfModelChanges<Context> {

    protected override void Seed(Context _context) {
      List<Entities.category> categories = new List<Entities.category> {
        new Entities.category() { name = "Beverages", description = string.Empty }
      };
      categories.ForEach(c => _context.Categories.Add(c));

      List<template.ef.Entities.product> products = new List<template.ef.Entities.product>() {
        new template.ef.Entities.product() {
          category_id = 1,
          code = "NWTB-1",
          name = "Northwind Traders Chai",
          recoder_level = 10,
          traget_level = 40,
          quantity_per_unit = "10 boxes x 20 bags",
          standard_cast = 13.50m,
          list_price = 18.00m,
          discontinued = false
        },
        new template.ef.Entities.product() {
          category_id = 1,
          code = "NWTB-34",
          name = "Northwind Traders Beer",
          recoder_level = 15,
          traget_level = 60,
          quantity_per_unit = "24 - 12 oz bottles",
          standard_cast = 10.50m,
          list_price = 14.00m,
          discontinued = false
        },
        new template.ef.Entities.product() {
          category_id = 1,
          code = "NWTB-43",
          name = "Northwind Traders Coffee",
          recoder_level = 25,
          traget_level = 100,
          quantity_per_unit = "16 - 500 g tins",
          standard_cast = 34.50m,
          list_price = 46.00m,
          discontinued = false
        },
        new template.ef.Entities.product() {
          category_id = 1,
          code = "NWTB-81",
          name = "Northwind Traders Green Tea",
          recoder_level = 100,
          traget_level = 125,
          quantity_per_unit = "20 bags per box",
          standard_cast = 2.00m,
          list_price = 2.99m,
          discontinued = false
        }
      };
      products.ForEach(pr => _context.Products.Add(pr));

      ef.Entities.category Pasta = new ef.Entities.category() {
        name = "Pasta", description = "",
        products = new List<ef.Entities.product>() {
            new ef.Entities.product(){
              code = "NWTP-56",
              name = "Northwind Traders Gnocchi",
              standard_cast = 28.50M,
              list_price = 38.00M,
              quantity_per_unit = "24 - 250 g pkgs",
              recoder_level = 30,
              traget_level = 120,
              discontinued = false
            },
            new ef.Entities.product(){
              code = "NWTP-57",
              name = "Northwind Traders Ravioli",
              standard_cast = 14.625M,
              list_price = 19.50M,
              quantity_per_unit = "24 - 250 g pkgs",
              recoder_level = 20,
              traget_level = 80,
              discontinued = false
            }
          }
      };

      ef.Entities.category Cereal = new ef.Entities.category() {
        name = "Cereal", description = "",
        products = new List<ef.Entities.product>() {
          new ef.Entities.product() {
            code = "NWTC-82",
            name = "Northwind Traders Granola",
            standard_cast = 2.00M,
            list_price = 4.00M,
            quantity_per_unit = string.Empty,
            recoder_level = 20,
            traget_level = 100,
            discontinued = false
          },
          new ef.Entities.product() {
            code = "NWTC-83",
            name = "Northwind Traders Hot Cereal",
            standard_cast = 3.00M,
            list_price = 5.00M,
            quantity_per_unit = string.Empty,
            recoder_level = 50,
            traget_level = 200,
            discontinued = false
          }
        }
      };

      ef.Entities.category Condiments = new ef.Entities.category() {
        name = "Condiments", description = "",
        products = new List<ef.Entities.product>() {
          new ef.Entities.product() {
            code = "NWTCO-3",
            name = "Northwind Traders Syrup",
            standard_cast = 7.50M,
            list_price = 10.00M,
            quantity_per_unit = "12 - 550 ml bottles",
            recoder_level = 25,
            traget_level = 100,
            discontinued = false
          },
          new ef.Entities.product() {
            code = "NWTCO-4",
            name = "Northwind Traders Cajun Seasoning",
            standard_cast = 16.50M,
            list_price = 22.00M,
            quantity_per_unit = "48 - 6 oz jars",
            recoder_level = 10,
            traget_level = 40,
            discontinued = false
          },
          new ef.Entities.product() {
            code = "NWTCO-77",
            name = "Northwind Traders Mustard",
            standard_cast = 9.75M,
            list_price = 13.00M,
            quantity_per_unit = "12 boxes",
            recoder_level = 15,
            traget_level = 60,
            discontinued = false
          }
        }
      };

      ef.Entities.category Sauces = new ef.Entities.category() {
        name = "Sauces", description = "",
        products = new List<ef.Entities.product>() {
            new ef.Entities.product(){
              code = "NWTS-8",
              name = "Northwind Traders Curry Sauce",
              standard_cast = 30.00M,
              list_price = 40.00M,
              quantity_per_unit = "12 - 12 oz jars",
              recoder_level = 10,
              traget_level = 40,
              discontinued = false
            },
            new ef.Entities.product(){
              code = "NWTS-65",
              name = "Northwind Traders Hot Pepper Sauce",
              standard_cast = 5.7875M,
              list_price = 21.05M,
              quantity_per_unit = "32 - 8 oz bottles",
              recoder_level = 10,
              traget_level = 40,
              discontinued = false
            },
            new ef.Entities.product(){
              code = "NWTS-66",
              name = "Northwind Traders Tomato Sauce",
              standard_cast = 12.75M,
              list_price = 17.00M,
              quantity_per_unit = "24 - 8 oz jars",
              recoder_level = 20,
              traget_level = 80,
              discontinued = false
            }
          }
      };

      _context.Categories.Add(Pasta);
      _context.Categories.Add(Cereal);
      _context.Categories.Add(Condiments);
      _context.Categories.Add(Sauces);

      base.Seed(_context);

    }

  }
}