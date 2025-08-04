namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetodoPago")]
    public partial class MetodoPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetodoPago()
        {
            Pago = new HashSet<Pago>();
        }

        [Key]
        public int ID_MetodoPago { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pago> Pago { get; set; }
    }
}
