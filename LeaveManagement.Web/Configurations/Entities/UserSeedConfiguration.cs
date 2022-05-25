using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "7713e334-7817-47b1-b1cc-11f37a47a56b",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true

                },
                new Employee
                {
                    Id = "a9d6684d-947f-4f90-b78e-c3c28c5ca297",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "t4f8!Km.m6UdXME"),
                    EmailConfirmed =true

                });
        }
    }
}