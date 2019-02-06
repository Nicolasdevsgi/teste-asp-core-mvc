using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nicolas.Web.Core.Mvc.Models.Domain;

namespace Nicolas.Web.Core.Mvc.Models
{
    public class NicolasWebCoreMvcContext : DbContext
    {
        public NicolasWebCoreMvcContext (DbContextOptions<NicolasWebCoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Nicolas.Web.Core.Mvc.Models.Domain.Cliente> Cliente { get; set; }
    }
}
