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
        HoverButton hoverButton = new HoverButton();

        public frmPrincipal()
        {
            InitializeComponent();

           
            
            btnRestaurante.MouseHover += (s, e) =>{
                hoverButton.MouseOn(btnRestaurante);
            };
            btnRestaurante.MouseLeave += (s, e) =>
            {
                if (!pnSubRestaurante.Visible)
                {
                    hoverButton.MouseOff(btnRestaurante);
                }
            };

            btnInventario.MouseHover += (s, e) => {
                hoverButton.MouseOn(btnInventario);
            };
            btnInventario.MouseLeave += (s, e) => {
                if (!pnSubInventario.Visible)
                {
                    hoverButton.MouseOff(btnInventario);
                }
            };

            btnCxC.MouseHover += (s, e) => {
                hoverButton.MouseOn(btnCxC);
            };
            btnCxC.MouseLeave += (s, e) => {
                if (!pnSubCxC.Visible)
                {
                    hoverButton.MouseOff(btnCxC);
                }
                
            };
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            //Hace que el panel lateral se ajuste al tamaño del formulario
            pnLatBotones.Width = pnLateral.Width - 18;
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            if (pnSubRestaurante.Visible)
            {
                pnSubRestaurante.Visible = false;
                hoverButton.MouseOff(btnRestaurante);
            }
            else { 
                
                pnSubRestaurante.Visible=true;
                hoverButton.MouseOn(btnRestaurante);
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (pnSubInventario.Visible)
            {
                pnSubInventario.Visible = false;
                hoverButton.MouseOff(btnInventario);
            }
            else
            {
                pnSubInventario.Visible = true;
                hoverButton.MouseOn(btnInventario);
            }

        }

        private void btnCxC_Click(object sender, EventArgs e)
        {
            if (pnSubCxC.Visible)
            {
                pnSubCxC.Visible = false;
                hoverButton.MouseOff(btnCxC);
            }
            else
            {
                pnSubCxC.Visible = true;
                hoverButton.MouseOn(btnCxC);
            }
        }
    }
    
}
