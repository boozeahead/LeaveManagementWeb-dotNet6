using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()

                },

                 new IdentityRole
                 {
                     Id = "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                     Name = Roles.User,
                     NormalizedName = Roles.User.ToUpper()

                 }

                );
        }
    }
}