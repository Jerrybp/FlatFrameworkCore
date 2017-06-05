using Flat.Domain.Entities;
using System;

namespace Flat.Domain.IRepositories
{
    public interface IDepartmentRepository : IRepository<Department, Guid>
    {
    }
}
