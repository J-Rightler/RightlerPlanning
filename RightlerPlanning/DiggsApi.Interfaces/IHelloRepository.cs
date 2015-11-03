using DiggsApi.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiggsApi.Interfaces
{
    public interface IHelloRepository
    {
        string SayHello(Hello input);
    }
}
