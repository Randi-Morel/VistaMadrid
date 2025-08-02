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
        //Lista para almacenar los paneles en los que estan los botones de Mantenimientos, Procesos y Reportes
        List<Panel> Paneles = new List<Panel>();

        //Lista para almacenar los botones de Manenimientos, Procesos y Reportes
        List<Button> ColorButtons = new List<Button>();
        
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
            pnMantenimientos.Height = 0;
            pnProcesos.Height = 0;
            pnReportes.Height = 0;

            pnMantenimientos.Visible = false;
            pnProcesos.Visible = false;
            pnReportes.Visible = false;

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

        private void OpenInPanel(Button boton, Panel subpanel, int height)
        {
            if (subpanel.Visible)
            {
                hoverButton.MouseOff(boton);
                PanelAnimationHelper.TogglePanel(subpanel, height);
                subpanel.Height = 0;
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
