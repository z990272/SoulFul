namespace Soulful.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        [Key]
        public int Album_id { get; set; }

        public int Singer_id { get; set; }

        public DateTime Datetime { get; set; }

        [Required]
        [StringLength(256)]
        public string Album_Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Pic { get; set; }

        public string About { get; set; }
        [StringLength(50)]

        public string Company { get; set; }
        public decimal Price { get; set; }

        public virtual Singer Singer { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Song> Song { get; set; }

        public virtual ICollection<Style> Style { get; set; }
    }
}
