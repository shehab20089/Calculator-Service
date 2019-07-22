using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceLibrary
{
    public class UserContext : DbContext
    {

        public UserContext() : base("UsersCS")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
