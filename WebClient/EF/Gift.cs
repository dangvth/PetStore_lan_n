namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gift")]
    public partial class Gift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gift()
        {
            Bill = new HashSet<Bill>();
        }

        [Key]
        [StringLength(50)]
        public string g_id { get; set; }

        [StringLength(150)]
        public string g_name { get; set; }

        [StringLength(250)]
        public string g_image { get; set; }

        [StringLength(15)]
        public string g_status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }
    }
}
