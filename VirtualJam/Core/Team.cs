using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Core
{
    public class Team : ICoreEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<User> Members { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}