using Entities;
using System.Collections.Generic;

namespace Data.Repositories
{
    interface IPlanRepository : IRepository<Plan>
    {
        IEnumerable<Plan> GetAll();
    }
}