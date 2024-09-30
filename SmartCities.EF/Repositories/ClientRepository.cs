using SmartCities.Core.Interfaces;
using SmartCities.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCities.EF.Repositories
{
    public class ClientRepository : BaseRepository<Client>,IClientRepository
    {

        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
