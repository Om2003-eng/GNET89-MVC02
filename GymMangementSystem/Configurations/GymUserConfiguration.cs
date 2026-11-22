using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMangementSystem.Configurations
{
    public class GymUserConfiguration : IEntityTypeConfiguration<GymUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<GymUser> builder)
        {
            throw new NotImplementedException();
        }
    }
}
