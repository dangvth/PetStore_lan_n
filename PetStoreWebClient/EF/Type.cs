namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Type")]
    public partial class Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Type()
        {
            Pet = new HashSet<Pet>();
            PetFood = new HashSet<PetFood>();
        }

        [Key]
        public int t_id { get; set; }

        [Required]
        [StringLength(150)]
        public string t_name { get; set; }

        [StringLength(15)]
        public string t_status { get; set; }

        public int? org_id { get; set; }

        public virtual Origin Origin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pet> Pet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PetFood> PetFood { get; set; }
    }
}
