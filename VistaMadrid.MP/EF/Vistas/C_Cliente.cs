namespace VistaMadrid.MP.EF.Vistas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_Cliente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Cliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Condicion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Telefono { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(150)]
        public string Direccion { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Condicion { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Activo { get; set; }
    }
}
