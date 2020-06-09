
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace template.ef.Entities {
  public class category {

    // [Id or id] like "id" or "ID"
    // [ClassName][Id or id] like "Categoryid" or "CategoryID" is entity framework convention for 
    // defining primary key without specifying [key] data annotation or in configuration file  or 
    // in "OnModelCreating" Overridden method of Context class

    //[Key]
    //public int identifier { get; set; }

    // primary key can be defined using [Key] data annotation or in "OnModelCreating" Overridden 
    // method of Context class or in a seperate configuration file, as used in this case, can be
    // used to specify that its a primary key if it does not fallow framework's convention
    public int category_id { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    public string name { get; set; }
    public string description { get; set; }

    public virtual ICollection<product> products { get; set; }
  }
}
