namespace WebClient.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cart")]
    public partial class Cart
    {
        [Key]
        public int c_id { get; set; }

        public int? u_id { get; set; }

        [StringLength(50)]
        public string pt_id { get; set; }

        [StringLength(50)]
        public string pf_id { get; set; }

        [StringLength(50)]
        public string pa_id { get; set; }

        [StringLength(50)]
        public string pm_id { get; set; }

        public virtual PetAccessories PetAccessories { get; set; }

        public virtual PetFood PetFood { get; set; }

        public virtual PetMedicine PetMedicine { get; set; }

        public virtual PetToys PetToys { get; set; }

        public virtual User User { get; set; }
    }
}
