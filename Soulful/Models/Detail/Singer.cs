namespace Soulful.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Singer")]
    public partial class Singer
    {
 
        [Key]
        public int Singer_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(6)]
        public string Gender { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        public int Language_id { get; set; }

        public virtual ICollection<Album> Album { get; set; }

        public virtual ICollection<Event> Event { get; set; }

        public virtual Language Language { get; set; }

    }
}
