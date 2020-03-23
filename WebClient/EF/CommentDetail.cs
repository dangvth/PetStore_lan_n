namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommentDetail")]
    public partial class CommentDetail
    {
        public int? cmt_id { get; set; }

        [Key]
        public int cmtd_id { get; set; }

        [Column(TypeName = "ntext")]
        public string cmtd_content { get; set; }

        public DateTime? cmtd_published { get; set; }

        [StringLength(15)]
        public string cmtd_status { get; set; }

        public int? u_id { get; set; }

        public virtual Comment Comment { get; set; }

        public virtual User User { get; set; }
    }
}
