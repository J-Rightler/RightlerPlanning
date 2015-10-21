using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funq;

namespace DiggsApi
{
    public class PlanningCenterAppHost : AppHostBase
    {
        public PlanningCenterAppHost() : base("Planning Center", typeof (PlanningCenterAppHost).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            throw new NotImplementedException();
        }
    }
}
