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
    public interface IConfigurationPropertyRepository : IRepository<ConfigurationProperty>
    {

    }
    public class ConfigurationPropertyRepository : GenericRepository<ConfigurationProperty>, IConfigurationPropertyRepository
    {
        public ConfigurationPropertyRepository(ClientRoutingDBContext dbContext, string userEmail) : base(dbContext, userEmail)
        {
        }
    }
    
}
