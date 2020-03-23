namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PetMedicine")]
    public partial class PetMedicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetMedicine()
        {
            BillDetail = new HashSet<BillDetail>();
            Cart = new HashSet<Cart>();
        }

        [Key]
        [StringLength(50)]
        public string pm_id { get; set; }

        [Required]
        [StringLength(150)]
        public string pm_name { get; set; }

        [StringLength(250)]
        public string pm_image { get; set; }

        public int? pm_prices { get; set; }

        public int? pm_salePrice { get; set; }

        public int? pm_amount { get; set; }

        [StringLength(500)]
        public string pm_description { get; set; }

        [StringLength(15)]
        public string pm_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
    }
}
