namespace Яхтенная_верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class КритерииДоставки
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Detail_ID { get; set; }

        public int? Accessory_ID { get; set; }

        public int? Order_ID { get; set; }
    }
}
