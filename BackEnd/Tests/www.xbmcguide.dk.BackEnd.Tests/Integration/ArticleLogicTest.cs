using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Shouldly;
using www.xbmcguide.dk.BusinessLogic;
using www.xbmcguide.dk.BusinessLogic.Interfaces;
using www.xbmcguide.dk.Core.Models.Entities;

namespace www.xbmcguide.dk.BackEnd.Tests.Integration
{
    class ArticleLogicTest: BaseTest
    {
        [Test]
        public void GetArticle()
        {
            // Arrange
            const int id = 2;

            // Act
            var article = ArticleLogic.GetArticle(id);

            //Assert
            article.ShouldBeTypeOf<Article>();
        }
    }
}
