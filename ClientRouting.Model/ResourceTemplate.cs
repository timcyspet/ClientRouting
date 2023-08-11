using BaseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Model
{
    public  class ResourceTemplate :BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ResourceType ResourceType { get; set; }
        public List<ConfigurationProperty> ConfigurationProperties { get; set; }

    }
}
