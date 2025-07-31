namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductoArchivo")]
    public partial class ProductoArchivo
    {
        [Key]
        public int ID_ProductoArchivo { get; set; }

        public int ID_Producto { get; set; }

        public int ID_Archivo { get; set; }

        public virtual Archivo Archivo { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
