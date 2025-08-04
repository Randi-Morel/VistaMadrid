namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sala")]
    public partial class Sala
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sala()
        {
            Mesa = new HashSet<Mesa>();
        }

        [Key]
        public int ID_Sala { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesa> Mesa { get; set; }
    }
}
