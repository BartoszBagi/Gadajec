using Gadajec.Application.Common.Interfaces;
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
        private readonly IDateTime _dateTime;
        public GadajecDbContextFactory()
        {

        }
        public GadajecDbContextFactory(IDateTime dateTime)
        {
            _dateTime = dateTime;
        }

        protected override GadajecDBContext CreateNewInstance(DbContextOptions<GadajecDBContext> options)
        {
            return new GadajecDBContext(options, _dateTime);
        }
    }
}
