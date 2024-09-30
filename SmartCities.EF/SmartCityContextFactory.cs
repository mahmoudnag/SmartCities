using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF
{
    public class SmartCityContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private readonly IConfiguration configuration;
        public SmartCityContextFactory() 
        { }
        //public SmartCityContextFactory(IConfiguration configuration)
        //{ 
        //    this.configuration = configuration;
        //}
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder=new DbContextOptionsBuilder<ApplicationDbContext>();
            //var connectionstring = configuration.GetConnectionString("DefaultContext");
            //if(connectionstring == null) 
            //    throw new ArgumentNullException(nameof(connectionstring));
            builder.UseSqlServer("Data Source=.; Initial Catalog=Smart_Cities;Integrated Security=true;TrustServerCertificate=True;");
            return new ApplicationDbContext(builder.Options);
        }
    }
}
