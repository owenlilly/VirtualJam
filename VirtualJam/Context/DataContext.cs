using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VirtualJam.Entities;

namespace VirtualJam.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}