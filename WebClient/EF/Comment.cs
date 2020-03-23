namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comment()
        {
            CommentDetail = new HashSet<CommentDetail>();
        }

        [Key]
        public int cmt_id { get; set; }

        [Column(TypeName = "ntext")]
        public string cmt_content { get; set; }

        public DateTime? cmt_published { get; set; }

        [StringLength(15)]
        public string cmt_status { get; set; }

        [StringLength(50)]
        public string p_id { get; set; }

        public int? u_id { get; set; }

        public virtual Pet Pet { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommentDetail> CommentDetail { get; set; }
    }
}
