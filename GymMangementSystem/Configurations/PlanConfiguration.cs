using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangementSystem.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(m => m.CreatedAt)
               .HasDefaultValueSql("GETDATE()");
            builder.ToTable(table =>
            {
                table.HasCheckConstraint(
                    "CK_Plan_DurationDays",
                    "DurationDays BETWEEN 1 AND 365");
            });

         
            builder.HasMany(p => p.Memberships)
                   .WithOne(m => m.Plan)
                   .HasForeignKey(m => m.PlanId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
    }

