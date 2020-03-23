namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PetAccessories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetAccessories()
        {
            BillDetail = new HashSet<BillDetail>();
            Cart = new HashSet<Cart>();
        }

        [Key]
        [StringLength(50)]
        public string pa_id { get; set; }

        [Required]
        [StringLength(150)]
        public string pa_name { get; set; }

        public int pa_prices { get; set; }

        public int pa_salePrice { get; set; }

        [StringLength(100)]
        public string pa_material { get; set; }

        public int? pa_amount { get; set; }

        public DateTime? pa_published { get; set; }

        [StringLength(15)]
        public string pa_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
