
using System.ComponentModel.DataAnnotations;


namespace template.ef.Entities {
  public class category {

    // entity framework by convention create primary key if it were written as "id" instead of "category_id"

    //[Key]
    //public int category_id { get; set; }
    // [Key] data annotation or a seperate configuration file, as used in this case, 
    // can be used to specify that its a primary key if it does not fallow framework's convention
    public int category_id { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
    public string name { get; set; }
    public string description { get; set; }
  }
}
