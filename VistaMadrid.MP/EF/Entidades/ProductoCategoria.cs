namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoCategoria")]
    public partial class ProductoCategoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductoCategoria()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        public int ID_ProductoCategoria { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
