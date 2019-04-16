using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFIntroduction.Console
{
    public class UsersContext : DbContext
    {
        public UsersContext() : base("appConnection")
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
