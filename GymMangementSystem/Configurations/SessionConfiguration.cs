using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymMangementSystem.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable(table =>
            {
                table.HasCheckConstraint(
                    "CK_Session_Capacity",
                    "Capacity BETWEEN 1 AND 25");

                table.HasCheckConstraint(
                    "CK_Session_Dates",
                    "EndDate > StartDate");
            });
        }
    }
}
