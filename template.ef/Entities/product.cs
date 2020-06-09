﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template.ef.Entities {
  public class product {
    public int product_id { get; set; }
    public string code { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    [StringLength(50, MinimumLength = 3)]
    public string name { get; set; }
    public decimal standard_cast { get; set; }
    public decimal list_price { get; set; }
    public int recoder_level { get; set; }
    public int traget_level { get; set; }
    public string quantity_per_unit { get; set; }
    public bool discontinued { get; set; }

    //navigational property
    public int category_id { get; set; }
    public virtual category category { get; set; }
  }

}
