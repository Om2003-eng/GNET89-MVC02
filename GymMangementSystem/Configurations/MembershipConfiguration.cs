using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMangementSystem.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Membership> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(m => m.Id)
                 .ValueGeneratedOnAdd()
                 .HasDefaultValueSql(
                     "NEXT VALUE FOR dbo.MembershipSequence");

            builder.Property(m => m.CreatedAt)
                 .HasDefaultValueSql("GETDATE()");
        }
    }
}
