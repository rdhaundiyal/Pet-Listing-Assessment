using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using AGL.Assessment.Domain;
using AGL.Assessment.Domain.Repositories;
using AGL.Components.Helpers;
using AGL.Components.Providers.Inteface;
using AGL.Components.Providers.RestSharp;

namespace AGL.Assessment.Web.Mvc.Module
{
    public class AssessmentModule:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RestSharpProvider>().As<IProvider>().WithParameter("baseUrl", ConfigHelper.GetValue<string>("BaseUrl"));
            builder.RegisterType<PeopleRepository>().As<IPeopleRepository>();
            builder.RegisterType<PeopleDomain>().As<IPeopleDomain>();
           

        }
    }
}