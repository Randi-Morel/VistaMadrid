using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VistaMadrid.MP;
using VistaMadrid.MP.EF;
using VistaMadrid.MP.EF.Vistas;
using VistaMadrid.Vista.Mantenimientos.Producto;

namespace VistaMadrid 
{
    /// Configura frmProducto: estilos, accesibilidad, eventos y validaciones.
    /// NO crea controles nuevos; solo modifica los existentes del diseñador.

    public sealed class ConfiguracionControlesProducto
    {
        private readonly frmProducto _frmVista;
        private readonly PresentadorProducto _Presentador;

        public ConfiguracionControlesProducto(frmProducto frm, PresentadorProducto presenter)
        {
            _frmVista = frm ?? throw new ArgumentNullException(nameof(frm));
            _Presentador = presenter ?? throw new ArgumentNullException(nameof(presenter));
        }

        public void Configuracion()
        {
            AgregarEventos();
            CargarCombox();
            ConfiguracionGRD();
        }

        #region Eventos
        private void AgregarEventos()
        {
            // evita dobles suscripciones
            _frmVista.GRD.CellDoubleClick -= GRD_CellDoubleClick;
            _frmVista.GRD.CellDoubleClick += GRD_CellDoubleClick;

            _frmVista.Archivo.DoubleClick -= Archivo_DoubleClick;
            _frmVista.Archivo.DoubleClick += Archivo_DoubleClick;
        }

        private void GRD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // cabecera

            var row = _frmVista.GRD.Rows[e.RowIndex];
            var item = row.DataBoundItem as C_Producto;
            if (item == null) return;

            // Cargar datos al formulario
            _frmVista.ID_Producto = item.ID_Producto;
            _frmVista.ID_ProductoCategoria = item.ID_ProductoCategoria;
            _frmVista.ID_UnidadMedida = item.ID_UnidadMedida;
            _frmVista.Nombre = item.Nombre;
            _frmVista.Descripcion = item.Descripcion;
            _frmVista.StockMinimo = item.StockMinimo;
            _frmVista.PrecioCosto = item.PrecioCosto;
            _frmVista.PrecioVenta = item.PrecioVenta;
            _frmVista.Activo = item.Activo;

            // Cargar imagen si existe
            var productoArchivo = _Presentador.ObtenerProductoArchivo(item.ID_Producto);
            if (productoArchivo != null)
            {
                var archivo = _Presentador.ObtenerArchivo(productoArchivo.ID_Archivo);
                if (archivo?.Datos?.Length > 0)
                {
                    _frmVista.ArchivoContenido = archivo.Datos;
                    using (var ms = new MemoryStream(archivo.Datos))
                    using (var img = Image.FromStream(ms))
                        _frmVista.Archivo.Image = new Bitmap(img);
                        _frmVista.Archivo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    _frmVista.ArchivoContenido = null;
                    _frmVista.Archivo.Image = null;
                }
            }
            else
            {
                _frmVista.ArchivoContenido = null;
                _frmVista.Archivo.Image = null;
            }
        }

        private void Archivo_DoubleClick(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Title = "Seleccionar imagen",
                Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos los archivos|*.*",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog(_frmVista) != DialogResult.OK) return;

                // lee bytes y guarda en la propiedad de la vista
                var bytes = File.ReadAllBytes(ofd.FileName);
                _frmVista.ArchivoContenido = bytes;

                // muestra la imagen en el picture box sin bloquear el archivo en disco
                using (var ms = new MemoryStream(bytes))
                using (var img = Image.FromStream(ms))
                {
                    _frmVista.Archivo.Image = new Bitmap(img);
                    _frmVista.Archivo.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
        #endregion

        public void CargarCombox()
        {
            var ProductoCategoria = _Presentador.ObtenerTodosProductoCategoria().Where(s => s.Activo == true).ToList();
            _frmVista.CID_ProductoCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_ProductoCategoria.DisplayMember = "Descripcion";
            _frmVista.CID_ProductoCategoria.ValueMember = "ID_ProductoCategoria";
            _frmVista.CID_ProductoCategoria.DataSource = ProductoCategoria;

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.CID_ProductoCategoria.SelectedIndex = -1;

            _frmVista.CConsultaID_ProductoCategoria.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CConsultaID_ProductoCategoria.DisplayMember = "Descripcion";
            _frmVista.CConsultaID_ProductoCategoria.ValueMember = "ID_ProductoCategoria";
            _frmVista.CConsultaID_ProductoCategoria.DataSource = ProductoCategoria;

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.CConsultaID_ProductoCategoria.SelectedIndex = -1;

            var UnidadMedida = _Presentador.ObtenerTodosUnidadMedida().Where(s => s.Activo == true).ToList();
            _frmVista.CID_UnidadMedida.DropDownStyle = ComboBoxStyle.DropDownList;

            _frmVista.CID_UnidadMedida.DisplayMember = "Descripcion";
            _frmVista.CID_UnidadMedida.ValueMember = "ID_UnidadMedida";
            _frmVista.CID_UnidadMedida.DataSource = UnidadMedida;

            // (Opcional) Dejar sin selección inicial o respetar la que tenga la vista
            _frmVista.CID_UnidadMedida.SelectedIndex = -1;
        }

        public bool ComprobarParaGuardar(out string mensaje)
        {
            string nombre = _frmVista.Nombre?.Trim();
            string descripcion = _frmVista.Descripcion?.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                mensaje = "El nombre es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                mensaje = "La descripcion es obligatoria.";
                return false;
            }

            if (_frmVista.ID_ProductoCategoria <= 0)
            {
                mensaje = "Debe seleccionar una categoria.";
                return false;
            }

            if (_frmVista.ID_UnidadMedida <= 0)
            {
                mensaje = "Debe seleccionar una unidad de medida.";
                return false;
            }

            if (_frmVista.StockMinimo < 0)
            {
                mensaje = "El stock mínimo no puede ser negativo.";
                return false;
            }

            if (_frmVista.PrecioCosto < 0m)
            {
                mensaje = "El precio de costo no puede ser negativo.";
                return false;
            }

            if (_frmVista.PrecioVenta <= 0m)
            {
                mensaje = "El precio de venta no puede ser negativo o vacio.";
                return false;
            }

            if (_frmVista.PrecioVenta < _frmVista.PrecioCosto)
            {
                mensaje = "El precio de venta no puede ser menor que el costo.";
                return false;
            }

            var bytes = _frmVista.ArchivoContenido;
            var tieneImagen = (bytes != null && bytes.Length > 0)
                              || (_frmVista.Archivo != null && _frmVista.Archivo.Image != null);

            if (!tieneImagen)
            {
                mensaje = "Debe seleccionar una imagen para el producto.";
                return false;
            }

            mensaje = null;
            return true;
        }

        private void ConfiguracionGRD()
        {
            var g = _frmVista.GRD; 

            // Config base
            g.SuspendLayout();
            g.AutoGenerateColumns = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.EditMode = DataGridViewEditMode.EditProgrammatically;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.RowHeadersVisible = false;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Columnas
            g.Columns.Clear();

            // ID_Producto (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_Producto",
                HeaderText = "ID_Producto",
                DataPropertyName = "ID_Producto",
                Visible = false
            });

            // ID_ProductoCategoria (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_ProductoCategoria",
                HeaderText = "ID_ProductoCategoria",
                DataPropertyName = "ID_ProductoCategoria",
                Visible = false
            });

            // ID_UnidadMedida (oculta)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colID_UnidadMedida",
                HeaderText = "ID_UnidadMedida",
                DataPropertyName = "ID_UnidadMedida",
                Visible = false
            });

            // Nombre (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                FillWeight = 140
            });

            // Descripcion (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripcion",
                DataPropertyName = "Descripcion",
                FillWeight = 140
            });

            // StockActual (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStockActual",
                HeaderText = "StockActual",
                DataPropertyName = "StockActual",
                FillWeight = 140
            });

            // StockMinimo (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStockMinimo",
                HeaderText = "StockMinimo",
                DataPropertyName = "StockMinimo",
                FillWeight = 140
            });

            // PrecioCosto (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioCosto",
                HeaderText = "PrecioCosto",
                DataPropertyName = "PrecioCosto",
                FillWeight = 140
            });

            // PrecioVenta (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioVenta",
                HeaderText = "PrecioVenta",
                DataPropertyName = "PrecioVenta",
                FillWeight = 140
            });

            // Categoria (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCategoria",
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                FillWeight = 140
            });

            // UnidadMedida (de Producto)
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnidadMedida",
                HeaderText = "Unidad de Medida",
                DataPropertyName = "UnidadMedida",
                FillWeight = 140
            });

            // Activo
            g.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colActivo",
                HeaderText = "Activo",
                DataPropertyName = "Activo",
                Width = 70
            });

            var desc = _frmVista.ConsultaDescripcion;
            var categoria = _frmVista.ConsultaID_ProductoCategoria;

            // Carga de datos desde el presentador (List<Producto>)
            var data = _Presentador.CargarDatosGRD(desc, categoria);
            _frmVista.GRD_DataSourceProducto = data;

            g.ResumeLayout();
        }

        public void CargarDatosGRD()
        {
            var g = _frmVista.GRD;
            var desc = _frmVista.ConsultaDescripcion;
            var categoria = _frmVista.ConsultaID_ProductoCategoria;

            // Carga de datos desde el presentador (List<Producto>)
            var data = _Presentador.CargarDatosGRD(desc, categoria);
            _frmVista.GRD_DataSourceProducto = data;

            g.ResumeLayout();
        }
    }
}
