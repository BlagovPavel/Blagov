namespace Яхтенная_верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Лодки
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int boat_ID { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string BoatType { get; set; }

        public int? NumberOfRovers { get; set; }

        [StringLength(50)]
        public string Mast { get; set; }

        [StringLength(50)]
        public string Colour { get; set; }

        [StringLength(50)]
        public string Wood { get; set; }

        [StringLength(50)]
        public string BasePrice { get; set; }

        [StringLength(50)]
        public string VAT { get; set; }
    }
}
