namespace VistaMadrid.MP.EF.Vistas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_Orden
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Orden { get; set; }

        public int? ID_Cliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Mesa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Usuario { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Condicion { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaVencimiento { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Total { get; set; }

        public decimal? SaldoPendiente { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool Finalizada { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Activo { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string Mesa { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string Condicion { get; set; }
    }
}
