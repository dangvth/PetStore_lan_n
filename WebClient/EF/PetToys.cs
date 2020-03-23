namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PetToys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetToys()
        {
            BillDetail = new HashSet<BillDetail>();
            Cart = new HashSet<Cart>();
        }

        [Key]
        [StringLength(50)]
        public string pt_id { get; set; }

        [Required]
        [StringLength(150)]
        public string pt_name { get; set; }

        [Required]
        [StringLength(250)]
        public string pt_image { get; set; }

        public int? pt_prices { get; set; }

        public int? pt_salePrice { get; set; }

        public int? pt_amount { get; set; }

        [StringLength(500)]
        public string pt_description { get; set; }

        public DateTime? pt_published { get; set; }

        [StringLength(15)]
        public string pt_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
