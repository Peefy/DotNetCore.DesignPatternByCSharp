using System;
using System.Collections.Generic;

namespace VsCodeProOne.Patterns.ServiceLocatorPattern
{
    public class ServiceCache
    {
        List<IService> services;

        public ServiceCache()
        {
            services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach(var service in services)
            {
                if(string.Equals(service.GetName(), serviceName, 
                    StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Return cached " + serviceName +
                        "object");
                    return service;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            bool isExist = false;
            foreach(var service in services)
            {
                if(string.Equals(service.GetName(), newService.GetName(), 
                    StringComparison.OrdinalIgnoreCase))
                {
                    isExist = true;
                }
            }
            if(!isExist)
                services.Add(newService);
        }

    }

}
