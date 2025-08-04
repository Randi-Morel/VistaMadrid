namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesa")]
    public partial class Mesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesa()
        {
            Orden = new HashSet<Orden>();
        }

        [Key]
        public int ID_Mesa { get; set; }

        public int ID_Sala { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int Asientos { get; set; }

        public bool Activo { get; set; }

        public virtual Sala Sala { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden> Orden { get; set; }
    }
}
