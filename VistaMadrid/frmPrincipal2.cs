using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid
{
    public partial class frmPrincipal2 : Form
    {
        List<List<Button>> TodasLasListas = new List<List<Button>>();

        //Grupo de botones de restaurante
        List<Button> MantenimientosRestaurante = new List<Button>();
        List<Button> ProcesosRestaurante = new List<Button>();

        //Grupo de botones de inventario
        List<Button> MantemimientosInventario = new List<Button>();
        List<Button> ProcesosInventario = new List<Button>();
        List<Button> ReportesInventario = new List<Button>();

        //Grupo de botones de CxC
        List<Button> MantenimientosCxC = new List<Button>();
        List<Button> ProcesosCxC = new List<Button>();
        List<Button> ReportesCxC = new List<Button>();

        

        private bool SplitterMoved = false;
        public frmPrincipal2()
        {
            InitializeComponent();
            pnLateral.Size = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.15), 0);
            pnLateral.MinimumSize = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.10), 0);
            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height-34);

            //Almacena todas las listas de botones
            TodasLasListas.Add(MantenimientosRestaurante);
            TodasLasListas.Add(ProcesosRestaurante);
            TodasLasListas.Add(MantemimientosInventario);
            TodasLasListas.Add (ProcesosInventario);
            TodasLasListas.Add(ReportesInventario);
            TodasLasListas.Add(MantenimientosCxC);
            TodasLasListas.Add(ProcesosCxC);
            TodasLasListas.Add(ReportesCxC);

            //Grupo de botones de restaurante
            MantenimientosRestaurante.Add(btnMesas);
            MantenimientosRestaurante.Add(btnEmpleados);
            ProcesosRestaurante.Add(btnFacturacion);

            //Grupo de botones de inventario
            MantemimientosInventario.Add(btnProductos);
            MantemimientosInventario.Add(btnCategorias);
            MantemimientosInventario.Add(btnUnidadesMedida);
            MantemimientosInventario.Add(btnProveedores);
            MantemimientosInventario.Add(btnTiposMovimiento);
            ProcesosInventario.Add(btnMovimiento);
            ReportesInventario.Add(btnStockActual);
            ReportesInventario.Add(btnEntradasYSalidas);

            //Grupo de botones de CxC
            MantenimientosCxC.Add(btnClientes);
            MantenimientosCxC.Add(btnCondicionesPago);
            MantenimientosCxC.Add(btnMetodosPago);
            ProcesosCxC.Add(btnRegistroPago);
            ReportesCxC.Add(btnCuentasPorCobrar);
            ReportesCxC.Add(btnEstadoCuenta);
            ReportesCxC.Add(btnCuentasVencidas);
            ReportesCxC.Add(btnDeudaCliente);
        }

        private void frmPrincipal2_Resize(object sender, EventArgs e)
        {
            if (!SplitterMoved) {
                pnLateral.Width = Convert.ToInt32(pnSuperior.Width * 0.15);
            }
            pnLateral.MaximumSize = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.35), 0);

            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height - 34);
        }

        private void spLateral_SplitterMoved(object sender, SplitterEventArgs e)
        {
            SplitterMoved = true;
            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height - 34);
        }

        private void OcultarTodosLosBotones()
        {
            foreach (var grupo in TodasLasListas)
            {
                foreach (var boton in grupo)
                {
                    boton.Visible = false;
                }
            }
        }

        private void btnMantemimientosRestaurante_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in MantenimientosRestaurante)
                btn.Visible = true;
        }

        private void btnProcesosRestaurante_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in ProcesosRestaurante)
                btn.Visible = true;
        }

        private void btnMantenimientosInventario_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in MantemimientosInventario)
                btn.Visible = true;
        }

        private void btnProcesosInventario_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in ProcesosInventario)
                btn.Visible = true;
        }

        private void btnReportesInventario_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in ReportesInventario)
                btn.Visible = true;
        }

        private void btnMantenimientosCxC_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in MantenimientosCxC)
                btn.Visible = true;
        }

        private void btnProcesosCxC_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in ProcesosCxC)
                btn.Visible = true;
        }

        private void btnReportesCxC_Click(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();
            foreach (var btn in ReportesCxC)
                btn.Visible = true;
        }

    }
}
