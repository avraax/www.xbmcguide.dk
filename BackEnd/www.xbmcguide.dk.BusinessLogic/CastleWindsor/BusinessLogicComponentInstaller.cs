using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using www.xbmcguide.dk.Core.Data.CastleWindsor;
using www.xbmcguide.dk.BusinessLogic.Interfaces;

namespace www.xbmcguide.dk.BusinessLogic.CastleWindsor
{
    public class BusinessLogicComponentInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For(typeof(IArticleLogic))
                    .ImplementedBy(typeof(ArticleLogic))
            );
        }
    }
}
