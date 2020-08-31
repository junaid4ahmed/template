﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using template.ef;


namespace template.da {
  public class category
    : Base {

    public ef.Entities.category select(int category_id) {
      ef.Entities.category category =
        _context.Categories.Find(new object[] { category_id });

      return category;
    }

    public IList<ef.Entities.category> select() {
      return _context.Categories.ToList();
    }

    public bool insert(ef.Entities.category category) {
      bool result = false;
      try {
        _context.Categories.Add(category);
        _context.SaveChanges();
        result = true;
      } catch (System.Data.Entity.Infrastructure.DbUpdateException) {
        // log; cannot insert the category
      }
      return result;
    }

    public bool update(ef.Entities.category category) {
      bool result = false;
      ef.Entities.category temp = select(category.category_id);
      if (temp != null) {
        try {
          temp.name = category.name;
          temp.description = category.description;
          _context.SaveChanges();
        } catch (System.Data.Entity.Infrastructure.DbUpdateException) {
          // log; error occur while updating the category;
        }
      } else {
        // log; cannot find the category for updating
      }
      return result;
    }

    public bool delect(int category_id) {
      bool result = false;
      ef.Entities.category category = select(category_id);
      if (category != null) {
        _context.Categories.Remove(category);
        _context.SaveChanges();
        result = true;
      } else {
        // log; cannot find the category
      }
      return result;
    }


  }

}
