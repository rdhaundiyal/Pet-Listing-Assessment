using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
namespace AGL.Assessment.Web.Mvc.App_Start
{
    public class IocContainer
    {
        /// <summary>
        /// Initialises the IocContainer.
        /// </summary>
        public static void Initialize()
        {
            var container = RegisterServices(new ContainerBuilder());
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

        /// <summary>
        /// Registers the container modules, xml configuration overrides, and web api controllers.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns>The <see cref="IContainer"/>.</returns>
        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // register all modules here
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);
            return builder.Build();
        }

    }
}