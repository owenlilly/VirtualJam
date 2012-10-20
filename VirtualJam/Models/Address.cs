using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Models
{
    public class Address : ICoreEntity
    {
        public virtual int Id { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Parish { get; set; }
    }
}