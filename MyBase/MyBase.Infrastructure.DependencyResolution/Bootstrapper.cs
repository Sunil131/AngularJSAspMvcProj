using MyBase.Domain.Core;
using MyBase.Domain.Interface;
using MyBase.Infrastructure.Core;
using MyBase.Infrastructure.Data;
using MyBase.Infrastructure.Data.Repositories;
using MyBase.Infrastructure.Core.ServiceInterface;
using MyBase.Infrastructure.Service;

using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace MyBase.Infrastructure.DependencyResolution
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
    

      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<IUserRepo, UsersRepo>();
        container.RegisterType<IUserMetaService, UserMetaService>();
    }
  }
}