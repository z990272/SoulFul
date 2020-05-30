namespace Soulful.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Language")]
    public partial class Language
    {
        [Key]
        public int Language_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Language_type { get; set; }

        public virtual ICollection<Singer> Singer { get; set; }

    }
}
