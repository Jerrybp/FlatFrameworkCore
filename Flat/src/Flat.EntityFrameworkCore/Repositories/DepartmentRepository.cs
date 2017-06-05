using Flat.Domain.Entities;
using Flat.Domain.IRepositories;

namespace Flat.EntityFrameworkCore.Repositories
{
    public class DepartmentRepository : FlatRepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(FlatDBContext dbcontext) : base(dbcontext)
        {

        }
    }
}
