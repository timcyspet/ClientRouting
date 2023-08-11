using BaseProject;
using BaseProject.Model;

namespace ClientRouting.Model
{
    public class Client : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ClientType Type { get; set; }
        public Address Address { get; set; }
        public List<ClientResource> Resources { get; set; }
        public List<ClientProperty> Properties { get; set; }
    }

    public class ClientResource : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ResourceType ResourceType { get; set; }
        public List<ResourceConfiguration> ResourceConfigurations { get; set; }
    }

    public class ResourceType : BaseObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }

    public class ResourceConfiguration : BaseObject
    {
        public ConfigurationProperty Key { get; set; }
        public string Value { get; set; } = string.Empty;        
    }

    public class ConfigurationProperty : BaseObject
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }

    public class ClientProperty : BaseObject
    {
        public ClientCustomProperty Key { get; set; }
        public string Value { get; set; } = string.Empty;
    }

    public class ClientCustomProperty:BaseObject
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}