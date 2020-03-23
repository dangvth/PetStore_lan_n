namespace PetStoreWebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        [Key]
        public int bd_id { get; set; }

        public int? b_id { get; set; }

        [StringLength(50)]
        public string p_id { get; set; }

        [StringLength(50)]
        public string pt_id { get; set; }

        [StringLength(50)]
        public string pf_id { get; set; }

        [StringLength(50)]
        public string pa_id { get; set; }

        [StringLength(50)]
        public string pm_id { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual PetAccessories PetAccessories { get; set; }

        public virtual PetFood PetFood { get; set; }

        public virtual PetMedicine PetMedicine { get; set; }

        public virtual PetToys PetToys { get; set; }

        public virtual Pet Pet { get; set; }
    }
}
