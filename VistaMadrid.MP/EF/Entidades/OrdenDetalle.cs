namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrdenDetalle")]
    public partial class OrdenDetalle
    {
        [Key]
        public int ID_OrdenDetalle { get; set; }

        public int ID_Orden { get; set; }

        public int ID_Producto { get; set; }

        public decimal Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public bool Activo { get; set; }

        public virtual Orden Orden { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
