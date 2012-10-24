using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualJam.Core
{
    /// <summary>
    /// Each entity must implement this interface.
    /// </summary>
    public interface ICoreEntity
    {
        int Id { get; set; }
    }
}