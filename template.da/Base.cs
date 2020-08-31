using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template.ef;

namespace template.da {
  public class Base {
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
    // _context instance variable must be initialized 
    // (through constructor or in declaration) at run time, 
    // readony is a runtime constant as compare to const

    // protected, assessable in inherited classes only
    protected static readonly Context _context = null;
    static Base() {
      _context = new Context();
    }
  }

}
