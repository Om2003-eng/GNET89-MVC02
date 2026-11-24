using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangementSystem.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(p => p.Name).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Phone).HasColumnType("varchar").HasMaxLength(11).IsRequired();
            builder.Property(p => p.Email).HasColumnType("varchar").IsRequired();
            builder.HasIndex(p => p.Email).IsUnique();

            builder.ComplexProperty(p => p.Address, s => s.IsRequired());
            builder.ToTable(table =>
            {
                table.HasCheckConstraint(
                    "CK_GymUser_Email",
                    "Email LIKE '_%@_%._%'");

                table.HasCheckConstraint(
                    "CK_GymUser_Phone",
                    "LEN(Phone) = 11 AND " +
                    "(Phone LIKE '010%' OR " +
                    "Phone LIKE '011%' OR " +
                    "Phone LIKE '012%' OR " +
                    "Phone LIKE '015%')");
            });
          
            builder.Property(p => p.CreatedAt).HasColumnName("JoinDate").HasDefaultValueSql("GETDATE()");
        }
    }
}
