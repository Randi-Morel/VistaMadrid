namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_Mesa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Mesa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Sala { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Sala { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Mesa { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Asientos { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Activo { get; set; }
    }
}
