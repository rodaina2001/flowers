using System.Diagnostics;
using flowershop.domain.flowershop;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace flowerdatabase
{
   
    public class flowercontext : DbContext
    {
        public DbSet<flowers> MyProperty { get; set; }
        public DbSet<customer> customers { get; set; }




    }

}
