using ContactInformation.Business;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace ContactInformation.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
           
            container.RegisterType<IContactManager, ContactManager>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}