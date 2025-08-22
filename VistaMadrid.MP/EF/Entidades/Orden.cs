namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orden")]
    public partial class Orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orden()
        {
            OrdenDetalle = new HashSet<OrdenDetalle>();
        }

        [Key]
        public int ID_Orden { get; set; }

        public int? ID_Cliente { get; set; }

        public int ID_Mesa { get; set; }

        public int ID_Usuario { get; set; }

        public int ID_Condicion { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaVencimiento { get; set; }

        public decimal Total { get; set; }

        public decimal? SaldoPendiente { get; set; }

        public bool Finalizada { get; set; }

        public bool Activo { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Condicion Condicion { get; set; }

        public virtual Mesa Mesa { get; set; }

        public virtual Usuario Usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
