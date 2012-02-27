using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using www.xbmcguide.dk.Core.Models.Entities;

namespace www.xbmcguide.dk.Core.Data.Mappings
{
    public class ArticleMap : ClassMap<Article>
    {
        public ArticleMap()
        {
            Table("Articles");

            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Heading);
            Map(x => x.Body);
            Map(x => x.Published);
            Map(x => x.Frontpage);
            Map(x => x.CreatedDate);
            Map(x => x.ModifiedDate);
            Map(x => x.UserId);
            //HasMany(x => x.Comments)
            //  .Inverse()
            //  .Cascade.All();
        }
    }
}
