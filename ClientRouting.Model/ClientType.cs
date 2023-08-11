using BaseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Model
{
    public class ClientType : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

    }

    public class ClientTemmpalte : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ClientType ClientType { get; set; }
        public List<ClientCustomProperty> Properties { get; set; }
    }
}
