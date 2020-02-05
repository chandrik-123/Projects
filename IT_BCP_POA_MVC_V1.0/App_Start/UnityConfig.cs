using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using IT_BCP_POA_MVC_V1._0.Interface;
using IT_BCP_POA_MVC_V1._0.Concrete;

namespace IT_BCP_POA_MVC_V1._0
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<ITx_Poa, Tx_poaConcrete>();
        }
    }
}