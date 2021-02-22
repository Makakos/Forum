using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class ForumDBContext : IdentityDbContext<User>
    {
        public override DbSet<User> Users { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Discussion> Discussions { get; set; }

        public DbSet<Message> Messages { get; set; }

        public ForumDBContext(DbContextOptions<ForumDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new DiscussionConfiguration());

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "User",
                NormalizedName = "USER"
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "54321g86-1846-3ag8-v38q-h387ae1b6eab",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "Makakos",
                NormalizedUserName = "MAKAKOS",
                Email = "maximgaber65@gmail.com",
                NormalizedEmail = "MAXIMGABER65@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "qwerty1337"),
                PhoneNumber = "+380974675806",
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "TestUser",
                NormalizedUserName = "TESTUSER",
                Email = "tuser@gmail.com",
                NormalizedEmail = "TUSER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "testpass"),
                PhoneNumber = "+380967839945",
                SecurityStamp = string.Empty
            });

            //Makakos-user and admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "54321g86-1846-3ag8-v38q-h387ae1b6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });


            //TestUser-just user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "6g29322e-4f66-49fa-a20f-e7685b9565d8"
            });

            //3 topics by default
            modelBuilder.Entity<Topic>().HasData(new Topic {
                Id=1,
                Name="C#"
            });
            modelBuilder.Entity<Topic>().HasData(new Topic
            {
                Id = 2,
                Name = "Java"
            });
            modelBuilder.Entity<Topic>().HasData(new Topic
            {
                Id = 3,
                Name = "Python"
            });

            //2 discussions by default
            modelBuilder.Entity<Discussion>().HasData(new Discussion
            {
                Id = 1,
                Name="What is LINQ",
                Description = "I need to use LINQ but I dont know how",
                Date=DateTime.Now,
                UserId= "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                TopicId=1
            });
            modelBuilder.Entity<Discussion>().HasData(new Discussion
            {
                Id = 2,
                Name = "Interfaces",
                Description = "How to implement intefaces?",
                Date = DateTime.Now,
                UserId = "6g29322e-4f66-49fa-a20f-e7685b9565d8",
                TopicId = 1
            });


        }

    }

    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasOne(x => x.User).WithMany(y => y.Messages).HasForeignKey(z => z.UserId);
            builder.HasOne(x => x.Discussion).WithMany(y => y.Messages).HasForeignKey(z => z.DiscussionId);
        }
    }

    public class DiscussionConfiguration : IEntityTypeConfiguration<Discussion>
    {
        public void Configure(EntityTypeBuilder<Discussion> builder)
        {
            builder.HasOne(x => x.User).WithMany(y => y.Discussions).HasForeignKey(z => z.UserId);
        }
    }
}
