using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NavigationDrawerPopUpMenu2
{
    class AppContextUser : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppContextUser() : base("DefaultConnection") { }


    }
}
