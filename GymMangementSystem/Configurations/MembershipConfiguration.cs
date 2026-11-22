using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMangementSystem.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Membership> builder)
        {
            throw new NotImplementedException();
        }
    }
}
