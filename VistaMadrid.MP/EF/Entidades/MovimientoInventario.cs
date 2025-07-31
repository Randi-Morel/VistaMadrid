namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientoInventario")]
    public partial class MovimientoInventario
    {
        [Key]
        [Column(Order = 0)]
        public int ID_MovimientoInventario { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Producto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_MovimientoTipo { get; set; }

        public decimal? Cantidad { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Proveedor { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Activo { get; set; }

        public virtual MovimientoTipo MovimientoTipo { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
