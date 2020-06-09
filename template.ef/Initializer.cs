using System.Collections.Generic;
using System.Data.Entity;

namespace template.ef {
  public class Initializer
    : DropCreateDatabaseIfModelChanges<Context> {

    protected override void Seed(Context context) {
      List<Entities.category> categories = new List<Entities.category> {
        new Entities.category() { name = "Beverages", description = string.Empty }
      };
      categories.ForEach(c => context.Categories.Add(c));

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
      products.ForEach(pr => context.Products.Add(pr));


      base.Seed(context);
    }

  }
}