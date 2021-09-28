namespace Яхтенная_верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Аксессуары лодочные")]
    public partial class Аксессуары_лодочные
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Fit_ID { get; set; }

        public int? Accessory_ID { get; set; }

        public int? Boat_ID { get; set; }
    }
}
