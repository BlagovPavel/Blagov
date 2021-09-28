namespace Яхтенная_верфь
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Доставка
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Salesperson_ID { get; set; }

        public int? Customer_ID { get; set; }

        public int? Boat_ID { get; set; }

        [StringLength(50)]
        public string DeliveryAdress { get; set; }

        [StringLength(50)]
        public string City { get; set; }
    }
}
