using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using VistaMadrid.MP.EF.Vistas;

namespace VistaMadrid.MP.EF
{
    public partial class BDVistaMadridEntidades : DbContext
    {
        static BDVistaMadridEntidades()
        {
            Database.SetInitializer<BDVistaMadridEntidades>(null);
        }

        public BDVistaMadridEntidades()
            : base("name=BDVistaMadridEntidades")
        {
        }

#region "Entidades"
        public virtual DbSet<Archivo> Archivo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Condicion> Condicion { get; set; }
        public virtual DbSet<Mesa> Mesa { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<MovimientoTipo> MovimientoTipo { get; set; }
        public virtual DbSet<Orden> Orden { get; set; }
        public virtual DbSet<OrdenDetalle> OrdenDetalle { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<Permiso> Permiso { get; set; }
        public virtual DbSet<PermisoUsuario> PermisoUsuario { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoArchivo> ProductoArchivo { get; set; }
        public virtual DbSet<ProductoCategoria> ProductoCategoria { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
        public virtual DbSet<UnidadMedida> UnidadMedida { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<MovimientoInventario> MovimientoInventario { get; set; }
        #endregion

        #region "Vistas"
        public virtual DbSet<C_Cliente> C_Cliente { get; set; }
        public virtual DbSet<C_Mesa> C_Mesa { get; set; }
        #endregion

        #region "ModelBuilder"
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_Cliente>()
              .Property(e => e.Nombre)
              .IsUnicode(false);

            modelBuilder.Entity<C_Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<C_Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C_Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<C_Cliente>()
                .Property(e => e.Condicion)
                .IsUnicode(false);

            modelBuilder.Entity<C_Mesa>()
                .Property(e => e.Sala)
                .IsUnicode(false);

            modelBuilder.Entity<C_Mesa>()
                .Property(e => e.Mesa)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Archivo>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivo>()
                .Property(e => e.TipoArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<Archivo>()
                .HasMany(e => e.ProductoArchivo)
                .WithRequired(e => e.Archivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Condicion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Condicion>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Condicion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Condicion>()
                .HasMany(e => e.Orden)
                .WithRequired(e => e.Condicion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mesa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Mesa>()
                .HasMany(e => e.Orden)
                .WithRequired(e => e.Mesa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MetodoPago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MetodoPago>()
                .HasMany(e => e.Pago)
                .WithRequired(e => e.MetodoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovimientoTipo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientoTipo>()
                .HasMany(e => e.MovimientoInventario)
                .WithRequired(e => e.MovimientoTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Orden>()
                .Property(e => e.SaldoPendiente)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Orden>()
                .HasMany(e => e.OrdenDetalle)
                .WithRequired(e => e.Orden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orden>()
                .HasMany(e => e.Pago)
                .WithRequired(e => e.Orden)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdenDetalle>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrdenDetalle>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pago>()
                .Property(e => e.MontoTotal)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pago>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Permiso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Permiso>()
                .HasMany(e => e.PermisoUsuario)
                .WithRequired(e => e.Permiso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.StockActual)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .Property(e => e.StockMinimo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .Property(e => e.PrecioCosto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .Property(e => e.PrecioVenta)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.OrdenDetalle)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.MovimientoInventario)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ProductoArchivo)
                .WithRequired(e => e.Producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductoCategoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoCategoria>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.ProductoCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.MovimientoInventario)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sala>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sala>()
                .HasMany(e => e.Mesa)
                .WithRequired(e => e.Sala)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnidadMedida>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<UnidadMedida>()
                .HasMany(e => e.Producto)
                .WithRequired(e => e.UnidadMedida)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientoInventario>()
                .Property(e => e.Cantidad)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MovimientoInventario>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);
        }
#endregion
    }
}
