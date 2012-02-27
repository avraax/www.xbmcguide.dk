using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using www.xbmcguide.dk.Core.Models.Entities;

namespace www.xbmcguide.dk.NHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                var connection = MsSqlConfiguration.MsSql2008.ConnectionString(
               m => m.FromConnectionStringWithKey("xbmcguideConnectionString"))
               .AdoNetBatchSize(100)
               .MaxFetchDepth(3)
               .UseReflectionOptimizer();

                return Fluently.Configure()
                  .Database(connection)
                  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Article>())
                  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Comment>())
                  .ExposeConfiguration(BuildSchema)
                  .BuildSessionFactory();
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }


        private static void BuildSchema(Configuration configuration)
        {
            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(configuration)
              .Create(false, true);
        }
    }
}
