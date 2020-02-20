

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace template.ef.Configurations {
  public class category
    : EntityTypeConfiguration<Entities.category> {

    public category() {

      // primary key can be configured in configuration file
      HasKey(c => new { c.category_id });

      // specify primary key generation, in this case generated from database
      Property(c => c.category_id)
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

      // make "name" property required and unique as well, as string data type is by default is nullable compare to integer data type
      // if "name" property were integer IsRequired would not be necessary
      Property(c => c.name)
        .IsRequired()
        .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

      Property(c => c.description)
        .HasMaxLength(128);

    }

  }
}
