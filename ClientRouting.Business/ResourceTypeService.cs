using ClientRouting.Data.Repositories;
using ClientRouting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Business
{
    public interface IResourceTypeService
    {
        IEnumerable<ResourceType> GetResourceTypes();
    }
    public class ResourceTypeService : IResourceTypeService
    {
        private readonly IResourceTypeRepository resourceTypeRepository;
        public ResourceTypeService(IResourceTypeRepository resourceTypeRepository) { 
            this.resourceTypeRepository = resourceTypeRepository;
        }

        public IEnumerable<ResourceType> GetResourceTypes()
        {
            return this.resourceTypeRepository.ListAll();
        }
    }
}
