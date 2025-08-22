namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pago")]
    public partial class Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pago()
        {
            OrdenPago = new HashSet<OrdenPago>();
        }

        [Key]
        public int ID_Pago { get; set; }

        public int ID_MetodoPago { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaPago { get; set; }

        public decimal MontoTotal { get; set; }

        [StringLength(100)]
        public string Nota { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenPago> OrdenPago { get; set; }
    }
}
