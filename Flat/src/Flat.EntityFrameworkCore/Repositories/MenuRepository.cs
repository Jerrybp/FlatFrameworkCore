using Flat.Domain.Entities;
using Flat.Domain.IRepositories;

namespace Flat.EntityFrameworkCore.Repositories
{
    public class MenuRepository : FlatRepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(FlatDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
