namespace Soulful.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [Key]
        public int News_id { get; set; }

        public int Singer_id { get; set; }

        [Required]
        public string About { get; set; }

        [Required]
        [StringLength(64)]
        public string Pic { get; set; }

        [Required]
        [StringLength(50)]
        public string News_title { get; set; }

        public virtual Singer Singer { get; set; }
    }
}
