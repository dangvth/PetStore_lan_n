namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pet")]
    public partial class Pet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pet()
        {
            BillDetail = new HashSet<BillDetail>();
            Comment = new HashSet<Comment>();
        }

        [Key]
        [StringLength(50)]
        public string p_id { get; set; }

        [Required]
        [StringLength(150)]
        public string p_name { get; set; }

        public int p_prices { get; set; }

        public int p_salePrice { get; set; }

        [StringLength(250)]
        public string p_image { get; set; }

        [StringLength(500)]
        public string p_description { get; set; }

        public DateTime? p_published { get; set; }

        [StringLength(15)]
        public string p_status { get; set; }

        public int? t_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }

        public virtual Type Type { get; set; }
    }
}
