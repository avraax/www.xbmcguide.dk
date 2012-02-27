using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using www.xbmcguide.dk.Core.Models.Entities;
using Configuration = NHibernate.Cfg.Configuration;

namespace www.xbmcguide.dk
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("home",
                            "artikel/{articleHeading}-{id}",
                            new { controller = "Home", action = "Details", articleHeading = UrlParameter.Optional }
                           );
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            //var sessionFactory = CreateSessionFactory();

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }

        //private static ISessionFactory CreateSessionFactory()
        //{
        //    var connection = MsSqlConfiguration.MsSql2008.ConnectionString(
        //        m => m.FromConnectionStringWithKey("xbmcguideConnectionString"))
        //        .AdoNetBatchSize(100)
        //        .MaxFetchDepth(3)
        //        .UseReflectionOptimizer();

        //    return Fluently.Configure()
        //      .Database(connection)
        //      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Article>())
        //      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Comment>())
        //      .ExposeConfiguration(BuildSchema)
        //      .BuildSessionFactory();
        //}

        //private static void BuildSchema(Configuration configuration)
        //{
        //    // this NHibernate tool takes a configuration (with mapping info in)
        //    // and exports a database schema from it
        //    new SchemaExport(configuration)
        //      .Create(false, true);
        //}
    }
}