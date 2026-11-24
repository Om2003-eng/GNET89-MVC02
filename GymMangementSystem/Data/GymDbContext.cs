using GymMangementSystem.Configurations;
using GymMangementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace GymMangementSystem.Data
{
  
      public class GymDbContext : DbContext
        {
        public GymDbContext()
        {
        }

        public GymDbContext(DbContextOptions<GymDbContext> options)
                : base(options)
            {
            }

      
            public DbSet<Member> Members { get; set; }

            public DbSet<Trainer> Trainers { get; set; }

            public DbSet<Plan> Plans { get; set; }

            public DbSet<Session> Sessions { get; set; }

            public DbSet<Membership> Memberships { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

               
                modelBuilder.HasSequence<int>("MembershipSequence", "dbo")
                            .StartsAt(1)
                            .IncrementsBy(1);


                modelBuilder.ApplyConfiguration(new GymUserConfiguration());
                modelBuilder.ApplyConfiguration(new MemberConfiguration());
                modelBuilder.ApplyConfiguration(new TrainerConfiguration());
                modelBuilder.ApplyConfiguration(new PlanConfiguration());
                modelBuilder.ApplyConfiguration(new SessionConfiguration());
                modelBuilder.ApplyConfiguration(new MembershipConfiguration());
            }
        }
    }

