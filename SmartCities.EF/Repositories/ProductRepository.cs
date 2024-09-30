using SmartCities.Core.Interfaces;
using SmartCities.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF.Repositories
{
    public  class ProductRepository:BaseRepository<Product>, IProductRepository
    {

        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
