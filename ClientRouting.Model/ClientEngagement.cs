using BaseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Model
{
    public class ClientEngagement : BaseObject
    {
        public List<Service>  Services { get; set; }
    }

    public class Service : BaseObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<ResourceType> Resources { get; set; }
    }
}
