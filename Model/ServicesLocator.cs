using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPR5100ToolDevAbgabe.Model
{
    public class ServicesLocator : IService
    {
        public Dictionary<object, object> servicesDic = null;
        public ServicesLocator()
        {
            servicesDic = new Dictionary<object, object>();
            servicesDic.Add(typeof(IFileIOService), new FileIOService());
        }
        public T GetService<T>()
        {
            return (T)servicesDic[typeof(T)];
        }
    }
}
