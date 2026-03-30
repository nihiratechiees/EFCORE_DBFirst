using DBFirst.Data.Model;

namespace DBFirst.Repository.Interface
{
    public interface IAssociateRepository
    {
       Task<IEnumerable<Associate>> GetAllAssociatesAsync();
    }
}
