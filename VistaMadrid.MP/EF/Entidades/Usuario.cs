namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int ID_Usuario { get; set; }

        public int ID_Rol { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaCreacion { get; set; }

        [Column("Usuario")]
        [Required]
        [StringLength(50)]
        public string Usuario1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Contrasena { get; set; }

        [Required]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        public bool Activo { get; set; }
    }
}
