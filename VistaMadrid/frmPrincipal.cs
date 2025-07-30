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
    public partial class frmPrincipal : Form
    {
        ImageList botones = new ImageList();

        //Lista para almacenar los paneles en los que estan los botones de Mantenimientos, Procesos y Reportes
        List<Panel> Paneles = new List<Panel>();
        
        HoverButton hoverButton = new HoverButton();

        int[] alturas = new int[8];
        bool abierto = false;
        
        private bool SplitterMoved = false;
        public frmPrincipal()
        {
            InitializeComponent();

            //Guarda la altura desplegada de los subpaneles
            AddHeight();

            //Se entran los botones en listas y sus imagenes
            AddInList();

            //Asigna la altura a 0, para hacer la animacion
            pnMantenimientosRestaurante.Height = 0;
            pnProcesosRestaurante.Height = 0;

            pnMantenimientosInventario.Height = 0;
            pnProcesosInventario.Height = 0;
            pnReportesInventario.Height = 0;

            pnMantenimientosCxC.Height = 0;
            pnProcesosCxC.Height = 0;
            pnReportesCxC.Height = 0;

            pnRestaurante.Visible = false;
            pnInventario.Visible = false;
            pnCxC.Visible = false;

            pnLateral.Size = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.15), 0);
            pnLateral.MinimumSize = new System.Drawing.Size(Convert.ToInt32(pnSuperior.Width * 0.10), 0);
            pnContenedorLateral.Size = new System.Drawing.Size(pnLateral.Width - 18, pnLateral.Height-34);
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


        //Muestra los sub-botones
        private void btnMantenimientosRestaurante_Click(object sender, EventArgs e)
        {
            
            OpenInSubPanel(btnMantenimientosRestaurante, pnMantenimientosRestaurante, alturas[0]);
        }

        private void btnProcesosRestaurante_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnProcesosRestaurante, pnProcesosRestaurante, alturas[1]);
        }

        private void btnMantenimientosInventario_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnMantenimientosInventario, pnMantenimientosInventario, alturas[2]);
        }

        private void btnProcesosInventario_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnProcesosInventario, pnProcesosInventario, alturas[3]);
        }

        private void btnReportesInventario_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnReportesInventario, pnReportesInventario, alturas[4]);
        }

        private void btnMantenimientosCxC_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnMantenimientosCxC, pnMantenimientosCxC, alturas[5]);
        }

        private void btnProcesosCxC_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnProcesosCxC, pnProcesosCxC, alturas[6]);
        }

        private void btnReportesCxC_Click(object sender, EventArgs e)
        {
            OpenInSubPanel(btnReportesCxC, pnReportesCxC, alturas[7]);
        }
        //Muestra los sub-botones


        //Muestra los paneles que contienen categorias, ejemplo: Mantenimientos, Procesos,etc
        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            OpenInPanel(btnRestaurante,pnRestaurante);
            
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenInPanel(btnInventario,pnInventario);
        }

        private void btnCxC_Click(object sender, EventArgs e)
        {
            OpenInPanel(btnCxC,pnCxC);
        }

        private void OpenInSubPanel(Button boton, Panel subpanel, int height)
        {
            
            if (subpanel.Height != 0)
            {
                boton.ImageIndex = 0;
                PanelAnimationHelper.TogglePanel(subpanel, height);
            }
            else {
                foreach (Control ctrl in subpanel.Controls)
                {
                    ctrl.Visible = true;
                }
                boton.ImageIndex = 1;
                PanelAnimationHelper.TogglePanel(subpanel, height);
            }

        }

        private void OpenInPanel(Button boton, Panel subpanel)
        {
            if (subpanel.Visible)
            {
                hoverButton.MouseOff(boton);
                subpanel.Visible = false;
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
                            pan.Visible = false;
                        }
                    }
                }
                hoverButton.MouseOn(boton);
                subpanel.Visible=true;
               
                abierto = true;
            }
        }

        private void AddInList()
        {
            botones.ImageSize = new Size(20, 20);
            //Imagelist con flechas
            botones.Images.Add(Properties.Resources.DownArrrow);
            botones.Images.Add(Properties.Resources.UpArrow);

            //Se cargan las imagenes del imageList al boton
            btnMantenimientosRestaurante.ImageList = botones;
            btnProcesosRestaurante.ImageList = botones;
           
            btnMantenimientosInventario.ImageList= botones;
            btnProcesosInventario.ImageList = botones;
            btnReportesInventario.ImageList = botones;

            btnMantenimientosCxC.ImageList = botones;
            btnProcesosCxC.ImageList = botones;
            btnReportesCxC.ImageList = botones;

            //Se le añade la primera imagen
            btnMantenimientosRestaurante.ImageIndex = 0;
            btnProcesosRestaurante.ImageIndex = 0;

            btnMantenimientosInventario.ImageIndex = 0;
            btnProcesosInventario.ImageIndex = 0;
            btnReportesInventario.ImageIndex = 0;

            btnMantenimientosCxC.ImageIndex = 0;
            btnProcesosCxC.ImageIndex = 0;
            btnReportesCxC.ImageIndex = 0;

            //Se almacenan los paneles que contienen botones, sirve para ocultarlos en caso de que se abra otro
            Paneles.Add(pnRestaurante);
            Paneles.Add(pnInventario);
            Paneles.Add(pnCxC);
        }

        private void AddHeight()
        {
            //Del 0 al 1 Restaurante
            this.alturas[0] = pnMantenimientosRestaurante.Height;
            this.alturas[1] = pnProcesosRestaurante.Height;

            //Del 2 al 4 Inventario
            this.alturas[2] = pnMantenimientosInventario.Height;
            this.alturas[3] = pnProcesosInventario.Height;
            this.alturas[4] = pnReportesInventario.Height;

            //Del 5 al 7 Reportes
            this.alturas[5] = pnMantenimientosCxC.Height;
            this.alturas[6] = pnProcesosCxC.Height;
            this.alturas[7] = pnReportesCxC.Height;

            
        }

    }
}
