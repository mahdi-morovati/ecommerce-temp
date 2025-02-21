using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Identity.Data;

public class UserIdentityDbContext: IdentityDbContext<IdentityUser>
{
    public UserIdentityDbContext(DbContextOptions<UserIdentityDbContext> options) : base(options) { }
}