using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Models
{
    public class Place : ICoreEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Address Address { get; set; }
        public virtual Coordinates Coordinates{ get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}