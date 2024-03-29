﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Core
{
    public class Project : ICoreEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Place Place { get; set; }
    }
}