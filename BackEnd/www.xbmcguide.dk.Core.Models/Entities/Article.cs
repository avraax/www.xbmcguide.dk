using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using FluentNHibernate.Data;

namespace www.xbmcguide.dk.Core.Models.Entities
{
    public abstract class Article : Entity
    {
        public virtual string Heading { get; set; }
        public virtual string Body { get; set; }
        public virtual DateTime Published { get; set; }
        public virtual bool Frontpage { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime ModifiedDate { get; set; }
        //public virtual IList<Comment> Comments { get; set; }

        [Required]
        public int UserId { get; set; }


        //public virtual void AddComment(Comment comment)
        //{
        //    Comments.Add(comment);
        //}
    }
}
