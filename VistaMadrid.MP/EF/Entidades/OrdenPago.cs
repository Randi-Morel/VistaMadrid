namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenPago")]
    public partial class OrdenPago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_OrdenPago { get; set; }

        public int ID_Orden { get; set; }

        public int ID_Pago { get; set; }

        public virtual Pago Pago { get; set; }
    }
}
