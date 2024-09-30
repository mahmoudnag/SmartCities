using SmartCities.Core.Interfaces;
using SmartCities.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF.Repositories
{
    public class PartenerRepository : BaseRepository<Partener>,IPartenerRepository
    {

        private readonly ApplicationDbContext _context;

        public PartenerRepository(ApplicationDbContext context) : base(context)
        {
        }
    
    }
}
