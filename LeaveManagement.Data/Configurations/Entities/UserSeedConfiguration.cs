using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var harsher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "bab4a6e-f7bb-4448-baaf-ladd431ccbbf",
                    Email = "admin@localhost",
                    NormalizedEmail = "ADMIN@LOCALHOST",
                    NormalizedUserName = "ADMIN@LOCALHOST",
                    UserName = "admin@localhost",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = harsher.HashPassword(null, "P@ssword"),
                    TaxId = "Test",
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "dad4a6e-f7bb-4448-baaf-ladd431ccbbf",
                    Email = "user@localhost",
                    NormalizedEmail = "USER@LOCALHOST",
                    NormalizedUserName = "USER@LOCALHOST",
                    UserName = "user@localhost",
                    FirstName = "System",
                    LastName = "User",
                    TaxId = "Test",
                    PasswordHash = harsher.HashPassword(null, "P@ssword"),
                    EmailConfirmed = true
                }
                );
        }
    }
}
