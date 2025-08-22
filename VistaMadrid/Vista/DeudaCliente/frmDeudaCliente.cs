using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaMadrid.Vista.DeudaCliente
{
    public partial class frmDeudaCliente : Form
    {
        public frmDeudaCliente()
        {
            InitializeComponent();
            btnGenerarReporte.Click += btnGenerarReporte_Click;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Seleccionar dónde guardar
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"ReporteDeudaCliente-{DateTime.Now.ToString("dd-MM-yyyy")}.pdf"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportarDataGridViewAPdf(GRD, saveFile.FileName);
                    MessageBox.Show("PDF generado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message);
                }
            }
        }

        private void ExportarDataGridViewAPdf(DataGridView dgv, string filePath)
        {
            // Crear documento
            Document doc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Título
            Paragraph titulo = new Paragraph("Reporte - Stock Actual\n\n",
                FontFactory.GetFont("Microsoft YaHei UI", "16", Font.Bold));
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);

            // Crear tabla con tantas columnas como el DataGridView
            PdfPTable tabla = new PdfPTable(dgv.Columns.Count);
            tabla.WidthPercentage = 100;

            // Encabezados
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                PdfPCell celda = new PdfPCell(new Phrase(col.HeaderText,
                    FontFactory.GetFont("Microsoft YaHei UI", "10", Font.Bold)))
                {
                    BackgroundColor = new BaseColor(240, 240, 240),
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
                tabla.AddCell(celda);
            }

            // Filas
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow) // ignorar la fila vacía
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        tabla.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                    }
                }
            }

            // Agregar tabla al documento
            doc.Add(tabla);
            doc.Close();
        }
    }
}
