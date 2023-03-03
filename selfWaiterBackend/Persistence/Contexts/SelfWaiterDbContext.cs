using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class SelfWaiterDbContext : DbContext
    {
        public SelfWaiterDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
