using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DotNet_JWT_6.Services.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Name = "User", NormalizedName = "user".ToUpper() },
                new IdentityRole { Name = "Admin", NormalizedName = "admin".ToUpper() }
            );
        }
    }
}