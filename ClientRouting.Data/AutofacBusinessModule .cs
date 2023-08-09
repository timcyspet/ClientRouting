using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Data
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (type.Name[0] == 'I') continue;
                var InterfaceType = types.Where(item => string.Compare(item.Name, string.Format("I{0}", type.Name)) == 0).FirstOrDefault();
                if (InterfaceType != null)
                {
                    builder.RegisterType(type)
                           .As(InterfaceType).InstancePerDependency();
                }
            }
        }
    }
}
