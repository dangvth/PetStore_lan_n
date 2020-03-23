namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            User = new HashSet<User>();
        }

        [Key]
        public int ac_id { get; set; }

        [Required]
        [StringLength(100)]
        public string ac_userName { get; set; }

        [Required]
        [StringLength(64)]
        public string ac_pwd { get; set; }

        [StringLength(15)]
        public string ac_status { get; set; }

        public int? r_id { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User { get; set; }
    }
}
