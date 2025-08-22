namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using VistaMadrid.MP.EF.Entidades;

    [Table("Producto")]
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            OrdenDetalle = new HashSet<OrdenDetalle>();
            ProductoArchivo = new HashSet<ProductoArchivo>();
        }

        [Key]
        public int ID_Producto { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        public int ID_ProductoCategoria { get; set; }

        public int ID_UnidadMedida { get; set; }

        public decimal StockActual { get; set; }

        public decimal StockMinimo { get; set; }

        public decimal PrecioCosto { get; set; }

        public decimal PrecioVenta { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDetalle> OrdenDetalle { get; set; }

        public virtual ProductoCategoria ProductoCategoria { get; set; }

        public virtual UnidadMedida UnidadMedida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoArchivo> ProductoArchivo { get; set; }
    }
}
