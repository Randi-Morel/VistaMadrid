namespace VistaMadrid.MP.EF.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientoProducto")]
    public partial class MovimientoProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MovimientoProducto { get; set; }

        public int ID_MovimientoInventario { get; set; }

        public int ID_Producto { get; set; }

        public virtual MovimientoInventario MovimientoInventario { get; set; }
    }
}
