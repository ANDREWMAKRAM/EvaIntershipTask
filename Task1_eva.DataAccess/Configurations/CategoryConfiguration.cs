using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task1_eva.Models;

namespace Task1_eva.DataAccess.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "MasterSchema");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.CatName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(c => c.CatOrder)
                   .IsRequired();

            builder.Ignore(c => c.CreatedDate);

            builder.Property(c => c.IsDeleted)
                   .HasColumnName("isDeleted");
        }
    }
}
