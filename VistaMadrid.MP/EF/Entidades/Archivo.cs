namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Archivo")]
    public partial class Archivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Archivo()
        {
            ProductoArchivo = new HashSet<ProductoArchivo>();
        }

        [Key]
        public int ID_Archivo { get; set; }

        [Required]
        [StringLength(255)]
        public string NombreArchivo { get; set; }

        [Required]
        [StringLength(100)]
        public string TipoArchivo { get; set; }

        [Required]
        public byte[] Datos { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaSubida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoArchivo> ProductoArchivo { get; set; }
    }
}
