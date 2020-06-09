using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace template.ef.Configurations {
  public class product
    : EntityTypeConfiguration<Entities.product> {

    public product() {
      HasKey(p => new { p.product_id });

      Property(p => p.product_id)
          .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

      Property(c => c.name)
          .IsRequired()
          .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }));

      Property(p => p.standard_cast).IsRequired();

      Property(p => p.list_price).IsRequired();


    }
  }
}
