using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VirtualJam.Models
{
    /// <summary>
    /// This class holds the Google Maps coordinates.
    /// </summary>
    public class Coordinates : ICoreEntity
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        [Key]
        public virtual int Id { get; set; }

        /// <summary>
        /// Gets or sets the coordinate's longitude.
        /// </summary>
        public virtual float Longitude { get; set; }

        /// <summary>
        /// Gets or set the coordinate's latitude.
        /// </summary>
        public virtual float Latitude { get; set; }
    }
}