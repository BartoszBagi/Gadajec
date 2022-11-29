using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadajec.Persistance
{
    public class GadajecDbContextFactory : DesignTimeDbContextFactoryBase<GadajecDBContext>
    {
        public GadajecDbContextFactory()
        {

        }

        protected override GadajecDBContext CreateNewInstance(DbContextOptions<GadajecDBContext> options)
        {
            return new GadajecDBContext(options);
        }
    }
}
