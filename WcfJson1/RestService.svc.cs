using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfJson1
{
   
    public class RestService : IRestService
    {
        public Auto json(string id)
        {
            return new Auto { Id = id, Company = "Bmw", Model = "x5", Price = "30000" };
        }
    }
}
