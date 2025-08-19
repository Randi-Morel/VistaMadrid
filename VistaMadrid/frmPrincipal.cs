using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaMadrid.Vista.Mantenimientos.Categoria;
using VistaMadrid.Vista.Mantenimientos.Cliente;
using VistaMadrid.Vista.Mantenimientos.Condicion_de_Pago;
using VistaMadrid.Vista.Mantenimientos.Empleados;
using VistaMadrid.Vista.Mantenimientos.Mesa;
using VistaMadrid.Vista.Mantenimientos.Metodo_de_Pago;
using VistaMadrid.Vista.Mantenimientos.Permiso;
using VistaMadrid.Vista.Mantenimientos.Producto;
using VistaMadrid.Vista.Mantenimientos.Proveedor;
using VistaMadrid.Vista.Mantenimientos.Rol;
using VistaMadrid.Vista.Mantenimientos.Sala;
using VistaMadrid.Vista.Mantenimientos.Tipo_de_Movimiento;
using VistaMadrid.Vista.Mantenimientos.Unidad_de_Medida;

namespace VistaMadrid
{
    public partial class frmPrincipal : Form
    {
        //Lista para almacenar los paneles en los que estan los botones de Mantenimientos, Procesos y Reportes
        List<Panel> Paneles = new List<Panel>();

        //Lista para almacenar los botones de Manenimientos, Procesos y Reportes
        List<Button> ColorButtons = new List<Button>();
        
        HoverButton hoverButton = new HoverButton();

        int[] alturas = new int[8];
        bool abierto = false;
        
        private bool SplitterMoved = false;

        private readonly Dictionary<Type, TabPage> _tabsPorTipo = new Dictionary<Type, TabPage>();

        public frmPrincipal()
        {
            InitializeComponent();

            //Guarda la altura desplegada de los subpaneles
            AddHeight();

            //Se entran los botones en listas y sus imagenes
            AddInList();

            btnMesas.Click += (s, e) => AbrirTabForm<frmMesa>("Mesas");
            btnCategorias.Click += (s, e) => AbrirTabForm<frmCategoria>("Categorias");
            btnClientes.Click += (s, e) => AbrirTabForm<frmCliente>("Clientes");
            btnCondicionesPago.Click += (s, e) => AbrirTabForm<frmCondicionPago>("Condicion de Pago");
            btnEmpleados.Click += (s, e) => AbrirTabForm<frmEmpleado>("Empleados");
            btnMetodosPago.Click += (s, e) => AbrirTabForm<frmMetodoPago>("Metodo de Pago");
            //btnPermisos.Click += (s, e) => AbrirTabForm<frmPermiso>("Permisos");
            btnProductos.Click += (s, e) => AbrirTabForm<frmProducto>("Productos");
            btnProveedores.Click += (s, e) => AbrirTabForm<frmProveedor>("Proveedores");
            //btnRol.Click += (s, e) => AbrirTabForm<frmRol>("Roles");
            //btnSalas.Click += (s, e) => AbrirTabForm<frmSala>("Salas");
            btnTiposMovimiento.Click += (s, e) => AbrirTabForm<frmTipoMovimiento>("Tipos de Movimientos");
            btnUnidadesMedida.Click += (s, e) => AbrirTabForm<frmUnidadMedida>("Unidades de Medidas");


            //Asigna la altura a 0, para hacer la animacion
            pnMantenimientos.Height = 0;
            pnProcesos.Height = 0;
            pnReportes.Height = 0;

            pnMantenimientos.Visible = false;
            pnProcesos.Visible = false;
            pnReportes.Visible = false;

            pnLateral.Size = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.10), 0);
            pnLateral.MinimumSize = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.12), 0);
            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height-34);

            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.Padding = new Point(18, 4); // deja espacio para la X
            tabControl.DrawItem += tabControlMain_DrawItem;
            tabControl.MouseDown += tabControlMain_MouseDown;
        }

        /// Abre un Form embebido como TabPage. Si ya existe, solo enfoca la pestaña.
        public void AbrirTabForm<TForm>(string titulo = null, Func<TForm> factory = null)
        where TForm : Form, new()
        {
            var tipo = typeof(TForm);
            if (_tabsPorTipo.TryGetValue(tipo, out var existente))
            {
                if (existente == null || existente.IsDisposed || !tabControl.TabPages.Contains(existente))
                    _tabsPorTipo.Remove(tipo);
                else
                {
                    tabControl.SelectedTab = existente;
                    return;
                }
            }

            // Crear el formulario (vía factory si necesitas pasar parámetros)
            var frm = (factory != null) ? factory() : new TForm();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Crear la pestaña
            var textoTab = titulo ?? QuitarPrefijoFrm(tipo.Name);
            var tab = new TabPage(textoTab);

            // Cuando el form se cierre (si decides cerrarlo por código), quita la pestaña del diccionario
            frm.FormClosed += (s, e) =>
            {
                if (_tabsPorTipo.ContainsKey(tipo))
                    _tabsPorTipo.Remove(tipo);
                if (!tab.IsDisposed) tab.Dispose();
            };

            tab.Controls.Add(frm);
            tabControl.TabPages.Add(tab);
            _tabsPorTipo[tipo] = tab;

            frm.Show();
            tabControl.SelectedTab = tab;
        }

        private static string QuitarPrefijoFrm(string name)
        => name.StartsWith("frm", StringComparison.OrdinalIgnoreCase) ? name.Substring(3) : name;
   
        /// Cierra la pestaña actual (y dispone el Form embebido).
        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tab = tabControl.TabPages[e.Index];
            var rect = tabControl.GetTabRect(e.Index);

            // texto
            TextRenderer.DrawText(
                e.Graphics,
                tab.Text,
                e.Font,
                new Rectangle(rect.X + 6, rect.Y + 5, rect.Width - 22, rect.Height - 5),
                tab.Enabled ? SystemColors.ControlText : SystemColors.GrayText,
                TextFormatFlags.EndEllipsis
            );

            // rectángulo de la X (14x14, pegado a la derecha)
            var close = GetCloseRect(rect);
            // dibuja la X simple
            using (var pen = new Pen(Color.DimGray, 1.6f))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawLine(pen, close.Left, close.Top, close.Right, close.Bottom);
                e.Graphics.DrawLine(pen, close.Right, close.Top, close.Left, close.Bottom);
            }

            e.DrawFocusRectangle();
        }

        private Rectangle GetCloseRect(Rectangle tabRect)
        {
            const int s = 14; // tamaño del botón X
            int x = tabRect.Right - s - 6;
            int y = tabRect.Top + (tabRect.Height - s) / 2;
            return new Rectangle(x, y, s, s);
        }

        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                var rect = tabControl.GetTabRect(i);
                var close = GetCloseRect(rect);

                bool clickX = e.Button == MouseButtons.Left && close.Contains(e.Location);
                bool clickMM = e.Button == MouseButtons.Middle && rect.Contains(e.Location); // rueda media cierra

                if (clickX || clickMM)
                {
                    var page = tabControl.TabPages[i];

                    // Si guardas índice por tipo en un diccionario:
                    if (page.Tag is Type t) _tabsPorTipo.Remove(t);

                    // 1) Quitar del TabControl
                    tabControl.TabPages.Remove(page);
                    // 2) Disponer la página (libera también sus controles/form embebido)
                    page.Dispose();

                    break;
                }
            }
        }

        ////////////////////////

        private void frmPrincipal2_Resize(object sender, EventArgs e)
        {
            if (!SplitterMoved) {
                pnLateral.Width = Convert.ToInt32(pnSuperior.Width * 0.15);
            }
            pnLateral.MaximumSize = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.35), 0);
            pnSubBotones.MaximumSize = new System.Drawing.Size(0, pnSeparadorLateral.Height - 269);
            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height - 34);

            //pnSubBotones.Height = pnLateral.Height - 242;
        }

        private void spLateral_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplitterMoved = true;
            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height - 34);
        }


        //Muestra los paneles que contienen categorias, ejemplo: Mantenimientos, Procesos,etc
        private void btnMantenimientos_Click(object sender, EventArgs e)
        {
            
            OpenInPanel(btnMantenimientos, pnMantenimientos, alturas[0]);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            OpenInPanel(btnProcesos, pnProcesos, alturas[1]);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            OpenInPanel(btnReportes, pnReportes, alturas[2]);
        }


        private void OpenInPanel(Button boton, Panel subpanel, int height)
        {
            if (subpanel.Visible)
            {
                hoverButton.MouseOff(boton);
                PanelAnimationHelper.TogglePanel(subpanel, height);
                //subpanel.Height = 0;
                subpanel.Visible = false;
                abierto = false;
                
            }
            else
            {
                //Valida si hay algun otro panel abierto, y lo cierra
                if (abierto)
                {
                    foreach (Panel pan in Paneles)
                    {
                        if (pan.Visible)
                        {
                            PanelAnimationHelper.TogglePanel(pan, height);
                            pan.Height = 0;
                            pan.Visible = false;
                        }
                    }
                    foreach (Button btn in ColorButtons)
                    {
                        hoverButton.MouseOff(btn);
                    }
                }
                
                foreach (Control ctrl in subpanel.Controls)
                {
                    ctrl.Visible = true;
                }
                
                hoverButton.MouseOn(boton);
                subpanel.Visible=true;
                PanelAnimationHelper.TogglePanel(subpanel, height);

                abierto = true;
            }
        }

        private void AddInList()
        {

            //Se cargan 
            ColorButtons.Add(btnMantenimientos);
            ColorButtons.Add(btnProcesos);
            ColorButtons.Add(btnReportes);

            //Se almacenan los paneles que contienen botones, sirve para ocultarlos en caso de que se abra otro
            Paneles.Add(pnMantenimientos);
            Paneles.Add(pnProcesos);
            Paneles.Add(pnReportes);
        }

        private void AddHeight()
        {
            this.alturas[0] = pnMantenimientos.Height;
            this.alturas[1] = pnProcesos.Height;
            this.alturas[2] = pnReportes.Height;
        }

    }
}
