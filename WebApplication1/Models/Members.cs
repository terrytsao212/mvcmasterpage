namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Members()
        {
            Addresses = new HashSet<Addresses>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public string PasswordSalt { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        public DateTime? InitDate { get; set; }

        public int Gender { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Addresses> Addresses { get; set; }
    }
}
