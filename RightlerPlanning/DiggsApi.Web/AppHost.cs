using Funq;
using ServiceStack;
using DiggsApi.ServiceDefinition;

namespace DiggsApi.Web
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("DiggsApi", typeof(DiggsApiServiceDefinitionInfo).Assembly)
        {

        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container"></param>
        public override void Configure(Container container)
        {
            InitializeContainer(container);
            InitializePlugins(container);
        }

        private void InitializeContainer(Container container)
        {
            //container.RegisterAutoWiredAs<InvoiceReviewRepository, IInvoiceReviewRepository>();
        }

        /// <summary>
        /// Initializes the plug-ins.
        /// </summary>
        /// <param name="container">The container.</param>
        private void InitializePlugins(Container container)
        {
            Plugins.Add(new PostmanFeature());
            Plugins.Add(new CorsFeature());
            //Plugins.Add(new ValidationFeature());
            //Plugins.Add(new ProtoBufFormat());
        }
    }
}