using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "a5d6684d-947f-4f90-b78e-c3c28c5ca297",
                    UserId = "7713e334-7817-47b1-b1cc-11f37a47a56b"
                },
                 new IdentityUserRole<string>
                 {
                     RoleId = "a5e5684d-947f-4f90-e88e-c3c28c5ca296",
                     UserId = "a9d6684d-947f-4f90-b78e-c3c28c5ca297"
                 }
                );
        }
    }
}