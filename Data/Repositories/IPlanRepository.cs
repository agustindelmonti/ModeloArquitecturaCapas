using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IPlanRepository : IRepository<Plan>
    {
        IEnumerable<Plan> GetAll();
    }
}