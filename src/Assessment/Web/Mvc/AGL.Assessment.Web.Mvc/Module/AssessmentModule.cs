using Autofac;
using AGL.Assessment.Domain;
using AGL.Assessment.Domain.Helpers;
using AGL.Assessment.Domain.Repositories;
using AGL.Components.Logger;
using AGL.Components.Providers.Inteface;
using AGL.Components.Providers.RestSharp;

namespace AGL.Assessment.Web.Mvc.Module
{
    public class AssessmentModule:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmptyLogger>().As<ILogger>();
            builder.RegisterType<RestSharpProvider>().As<IProvider>().WithParameter("baseUrl", ConfigSettings.BaseUrl);
            builder.RegisterType<PeopleRepository>().As<IPeopleRepository>();
            builder.RegisterType<PeopleDomain>().As<IPeopleDomain>();
           

        }
    }
}