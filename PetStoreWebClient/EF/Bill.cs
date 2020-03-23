namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            BillDetail = new HashSet<BillDetail>();
        }

        [Key]
        public int b_id { get; set; }

        public DateTime? b_purchaseDate { get; set; }

        [StringLength(15)]
        public string b_status { get; set; }

        public int? u_id { get; set; }

        [StringLength(50)]
        public string g_id { get; set; }

        [StringLength(150)]
        public string b_address { get; set; }

        public int? b_total { get; set; }

        public virtual Gift Gift { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }
    }
}
