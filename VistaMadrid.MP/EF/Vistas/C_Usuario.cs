namespace VistaMadrid.MP.EF.Vistas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_Usuario
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Rol { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "smalldatetime")]
        public DateTime FechaCreacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Contrasena { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Rol { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Activo { get; set; }
    }
}
