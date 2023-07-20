using BaseProject;
using BaseProject.Model;

namespace ClientRouting.Model
{
    public class Client :BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }            
        public List<ClientResource> Resources { get; set;}
    }

    public class ClientResource :BaseObject
    {
        public string Name { get; set; } 
        public string Description { get; set; }
        public ResourceType ResourceType { get; set; }
        public List<ResourceConfiguration> ResourceConfigurations { get; set; }
    }

    public class ResourceType :BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }

    }

    public class ResourceConfiguration :BaseObject
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class ConfigurationType : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}