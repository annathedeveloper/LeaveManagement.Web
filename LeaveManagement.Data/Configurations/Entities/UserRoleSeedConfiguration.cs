using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac4a6e-f7bb-4448-baaf-ladd431ccbbf",
                    UserId = "bab4a6e-f7bb-4448-baaf-ladd431ccbbf"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac4a6e-f8bb-4447-baaf-ladd431ccbbf",
                    UserId = "dad4a6e-f7bb-4448-baaf-ladd431ccbbf"
                });
        }
    }
}
