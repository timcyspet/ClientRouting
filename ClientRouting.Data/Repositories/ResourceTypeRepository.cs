using BaseProject.Data;
using BaseProject.Interface;
using ClientRouting.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Data.Repositories
{
    public interface IResourceTypeRepository : IRepository<ResourceType>
    {

    }
    public class ResourceTypeRepository : GenericRepository<ResourceType>, IResourceTypeRepository
    {
        public ResourceTypeRepository(ClientRoutingDBContext dbContext, string userEmail) : base(dbContext, userEmail)
        {
        }
    }    
}
