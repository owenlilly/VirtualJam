using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Core
{
    public class Category : ICoreEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}