namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PetFood")]
    public partial class PetFood
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PetFood()
        {
            BillDetail = new HashSet<BillDetail>();
            Cart = new HashSet<Cart>();
        }

        [Key]
        [StringLength(50)]
        public string pf_id { get; set; }

        [Required]
        [StringLength(150)]
        public string pf_name { get; set; }

        [StringLength(250)]
        public string pf_image { get; set; }

        public int? pf_prices { get; set; }

        public int? pf_salePrice { get; set; }

        public int? pf_amount { get; set; }

        [StringLength(15)]
        public string pf_status { get; set; }

        public int? t_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }

        public virtual Type Type { get; set; }
    }
}
