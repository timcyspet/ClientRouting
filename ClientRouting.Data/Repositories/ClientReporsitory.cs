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
    public interface IClientRepository : IRepository<Client>
    {

    }
    public class ClientReporsitory : GenericRepository<Client>, IClientRepository
    {
        public ClientReporsitory(DbContext dbContext, string userEmail) : base(dbContext, userEmail)
        {
        }
    }
}
