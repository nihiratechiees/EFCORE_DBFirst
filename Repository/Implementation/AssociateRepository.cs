using DBFirst.Data;
using DBFirst.Data.Model;
using DBFirst.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace DBFirst.Repository.Implementation
{
    public class AssociateRepository : IAssociateRepository
    {
        private readonly dbFirstContext _context;
        public AssociateRepository(dbFirstContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Associate>> GetAllAssociatesAsync()
        {
           return await this._context.Associates.ToListAsync();
        }
    }
}
