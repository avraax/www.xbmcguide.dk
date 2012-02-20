using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.xbmcguide.dk.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
    }
}