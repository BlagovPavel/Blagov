namespace Яхтенная_верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Аксессуары
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Accessory_ID { get; set; }

        [StringLength(50)]
        public string AccName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [StringLength(50)]
        public string VAT { get; set; }

        public int? Inventory { get; set; }

        public int? OrderLevel { get; set; }

        public int? OrderBatch { get; set; }

        public int? Partner_ID { get; set; }
    }
}
