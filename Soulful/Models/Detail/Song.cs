namespace Soulful.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Song")]
    public partial class Song
    {

        [Key]
        public int Song_id { get; set; }

        public int Album_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Song_name { get; set; }


        public virtual Album Album { get; set; }

        public virtual ICollection<Like> Like { get; set; }
    }
}
