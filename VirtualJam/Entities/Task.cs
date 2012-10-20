using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Entities
{
    public class Task : Core
    {
        public string Title { get; set; }
        public string  Description { get; set; }
        public string Category { get; set; }
    }
}