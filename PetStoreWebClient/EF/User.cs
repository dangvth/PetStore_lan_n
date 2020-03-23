namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Bill = new HashSet<Bill>();
            Cart = new HashSet<Cart>();
            Comment = new HashSet<Comment>();
            CommentDetail = new HashSet<CommentDetail>();
        }

        [Key]
        public int u_id { get; set; }

        [Required]
        [StringLength(150)]
        public string u_name { get; set; }

        [StringLength(15)]
        public string u_gender { get; set; }

        [StringLength(250)]
        public string u_email { get; set; }

        [StringLength(15)]
        public string u_phone { get; set; }

        [StringLength(200)]
        public string u_address { get; set; }

        [StringLength(15)]
        public string u_status { get; set; }

        public int? ac_id { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bill { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentDetail> CommentDetail { get; set; }
    }
}
