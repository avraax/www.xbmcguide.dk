using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using CommonServiceLocator.WindsorAdapter;
using Microsoft.Practices.ServiceLocation;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using www.xbmcguide.dk.BusinessLogic.CastleWindsor;
using www.xbmcguide.dk.BusinessLogic.Interfaces;
using www.xbmcguide.dk.Core.Models.Entities;
using www.xbmcguide.dk.NHibernate;

namespace www.xbmcguide.dk.BackEnd.Tests
{
    [TestFixture]
    class BaseTest
    {
            //private Configuration _configuration;
            protected IWindsorContainer Container;

            [TestFixtureSetUp]
            public void TestFixtureSetUp()
            {
                Container = new WindsorContainer();
                Container.Install(
                    new BusinessLogicComponentInstaller()
                    );

                ServiceLocator.SetLocatorProvider(() => new WindsorServiceLocator(Container));
                //_configuration = new Configuration();
                //_configuration.Configure();
                //_configuration.AddAssembly(typeof(Article).Assembly);
            }

            [SetUp]
            public void SetupContext()
            {
                //new SchemaExport(_configuration).Create(false, true);
                //new SchemaExport(_configuration).Execute(false, true);
            }

            [TearDown]
            public virtual void TestCleanup()
            {
            }

            protected IArticleLogic ArticleLogic { get { return Container.Resolve<IArticleLogic>(); } }
    }
}
