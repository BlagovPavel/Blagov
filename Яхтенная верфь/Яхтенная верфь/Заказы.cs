namespace Яхтенная_верфь
{
    using Google.Type;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказы
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Contract_ID { get; set; }

        [Column(TypeName = "date")]
        public System.DateTime? Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? DepositePayed { get; set; }

        public int? Order_ID { get; set; }

        [Column("ContractTotalPrice ContractTotalPrice", TypeName = "Money")]
        public decimal? ContractTotalPrice__ContractTotalPrice___ { get; set; }

        [Column(TypeName = "money")]
        public decimal? ContractTotalPrice_inclVAT { get; set; }

        [StringLength(50)]
        public string ProductionProcess { get; set; }
    }
}
