namespace VistaMadrid.MP.EF.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientoInventario")]
    public partial class MovimientoInventario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovimientoInventario()
        {
            MovimientoProducto = new HashSet<MovimientoProducto>();
        }

        [Key]
        public int ID_MovimientoInventario { get; set; }

        public int ID_MovimientoTipo { get; set; }

        public decimal? Cantidad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        public int? ID_Proveedor { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoProducto> MovimientoProducto { get; set; }
    }
}
