using System.Diagnostics;
using flowershop.domain.flowershop;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace flowerdatabase

{
   
    public class flowercontext : DbContext

    {



        public flowercontext(DbContextOptions<flowercontext> options) :
            base(options)

        {

        }


                public DbSet<flowers> flowerss { get; set; }
                public DbSet<customer> customers { get; set; }


    }

}


