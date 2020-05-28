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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            Buy = new HashSet<Buy>();
            Song = new HashSet<Song>();
            Style = new HashSet<Style>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Album_id { get; set; }

        public int Singer_id { get; set; }

        public DateTime Datetime { get; set; }

        [Required]
        [StringLength(50)]
        public string Album_Name { get; set; }

        [Required]
        [StringLength(64)]
        public string Pic { get; set; }

        public string About { get; set; }

        public decimal Price { get; set; }

        public virtual Singer Singer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy> Buy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song> Song { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Style> Style { get; set; }
    }
}
