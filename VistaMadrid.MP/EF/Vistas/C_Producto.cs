namespace VistaMadrid.MP.EF.Vistas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class C_Producto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Producto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ProductoCategoria { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_UnidadMedida { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal StockActual { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal StockMinimo { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal PrecioCosto { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PrecioVenta { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Categoria { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string UnidadMedida { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool Activo { get; set; }
    }
}
