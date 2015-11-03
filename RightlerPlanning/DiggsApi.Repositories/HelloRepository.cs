using DiggsApi.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiggsApi.Repositories
{
    public class HelloRepository
    {
        public string SayHello(Hello input)
        {
            return string.Format("SayHello called with : {0}", input.Name);
        }
    }
}
