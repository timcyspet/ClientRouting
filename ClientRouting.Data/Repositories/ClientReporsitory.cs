using BaseProject.Data;
using ClientRouting.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Data.Repositories
{
    public class ClientReporsitory : GenericRepository<Client>
    {
        public ClientReporsitory(DbContext dbContext, string userEmail) : base(dbContext, userEmail)
        {
        }
    }
}
