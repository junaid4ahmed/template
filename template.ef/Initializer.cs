using System.Data.Entity;

namespace template.ef {
  public class Initializer
    : DropCreateDatabaseIfModelChanges<Context> {

    protected override void Seed(Context context) {
      base.Seed(context);
    }

  }
}