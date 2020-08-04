namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Addresses
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PostalCode { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(100)]
        public string MyAddress { get; set; }

        public DateTime? InitDate { get; set; }

        public int MemberId { get; set; }

        public virtual Members Members { get; set; }
    }
}
