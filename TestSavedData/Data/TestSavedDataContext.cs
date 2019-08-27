using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestSavedData.Models
{
    public class TestSavedDataContext : DbContext
    {
        public TestSavedDataContext (DbContextOptions<TestSavedDataContext> options)
            : base(options)
        {
        }

        public DbSet<TestSavedData.Models.Person> Person { get; set; }
    }
}
