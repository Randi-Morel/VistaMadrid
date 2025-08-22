namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using VistaMadrid.MP.EF.Entidades;

    [Table("MovimientoTipo")]
    public partial class MovimientoTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MovimientoTipo()
        {
            MovimientoInventario = new HashSet<MovimientoInventario>();
        }

        [Key]
        public int ID_MovimientoTipo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int AfectaStock { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovimientoInventario> MovimientoInventario { get; set; }
    }
}
