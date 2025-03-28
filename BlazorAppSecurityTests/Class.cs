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

      public string MyProp { get; set; } = "";

        private void DoStuff(int a, int b, int c, int d, int e, int f, int g, int h, int j, int k, string myprop)
        {

            myprop = myprop;

            MyProp = MyProp;

        }
    }
