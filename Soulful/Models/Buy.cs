namespace Soulful
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Buy")]
    public partial class Buy
    {
        [Key]
        public int Buy_id { get; set; }

        public int Album_id { get; set; }

        [Required]
        [StringLength(128)]
        public string User_id { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public DateTime Datetime { get; set; }

        [Required]
        [StringLength(50)]
        public string Fedex { get; set; }

        [Required]
        [StringLength(20)]
        public string Credit_card { get; set; }

        public virtual Album Album { get; set; }
    }
}
