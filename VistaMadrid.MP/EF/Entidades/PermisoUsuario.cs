namespace VistaMadrid.MP.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PermisoUsuario")]
    public partial class PermisoUsuario
    {
        [Key]
        public int ID_PermisoUsuario { get; set; }

        public int ID_Permiso { get; set; }

        public int ID_Usuario { get; set; }

        public virtual Permiso Permiso { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
