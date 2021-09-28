namespace Яхтенная_верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Счет
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Invoice_ID { get; set; }

        public int? Contract_ID { get; set; }

        [StringLength(50)]
        public string Settled { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sum { get; set; }

        public int? Sum_inclVAT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
