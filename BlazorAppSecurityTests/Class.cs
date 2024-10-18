using Microsoft.EntityFrameworkCore;

namespace BlazorAppSecurityTests
{
    public class UserDBContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }

    public class User
    {

    }
}
