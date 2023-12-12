using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Office2013.Drawing.Chart;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.tool.xml.parser;
using AngleSharp.Html.Parser;
using CapaPresentacion.Idioma;

namespace CapaPresentacion
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CapaPresentacion.Properties.Settings.Default.Idioma);
            lblDetalleCompra.Text = Textos.lblDetalleCompra;
            lblNroDoc.Text = Textos.lblNroDoc;
            btnBuscarS.Text = Textos.btnBuscarS;
            btnLimpiarForm.Text = Textos.btnLimpiarForm;
            gboInfoCompra.Text = Textos.gboInfoCompra;
            lblFecha.Text = Textos.lblFecha;
            lblDoc.Text = Textos.lblDoc;
            lblUsuario.Text = Textos.lblUsuario;
            gbInfoProveedor.Text = Textos.gbInfoProveedor;
            lblDoc2.Text = Textos.lblDoc;
            lblRazonSocial.Text = Textos.lblRazonSocial;
            lblMontoTotal.Text = Textos.lblMontoTotal;
            btnDescargarPdf.Text = Textos.btnDescargarPdf;
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            CargarIdioma();
        }

        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            Compra oCompra = new CN_Compra().ObtenerCompra(txtBusquedaDoc.Text);

            if (oCompra.IdCompra != 0)
            {
                txtNroDoc.Text = oCompra.NumeroDocumento;
                txtFecha.Text = oCompra.FechaCreacion.ToString();
                txtTipoDocumento.Text = oCompra.TipoDocumento;
                txtUsuario.Text = oCompra.oUsuario.NombreCompleto;
                txtNroDocProveedor.Text = oCompra.oProveedor.Documento;
                txtNombreProveedor.Text = oCompra.oProveedor.RazonSocial;

                dgvData.Rows.Clear();

                foreach (DetalleCompra dc in oCompra.oDetalleCompra)
                {
                    dgvData.Rows.Add(new object[] { dc.oProducto.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal });
                }

                txtMontoTotal.Text = oCompra.MontoTotal.ToString("0.00");

            }


        }



        private void btnLimpiarCompra_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            txtNroDocProveedor.Text = "";
            txtNombreProveedor.Text = "";
            dgvData.Rows.Clear();
            txtMontoTotal.Text = "0.00";

        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            if (txtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Texto_Html = Properties.Resources.PlantillaCompra.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            //Reemplazamos los textos de la plantilla html por las variables que ingresamos del negocio
            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.CUIT);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNroDoc.Text);

            Texto_Html = Texto_Html.Replace("@docproveedor", txtNroDocProveedor.Text);
            Texto_Html = Texto_Html.Replace("@nombreproveedor", txtNombreProveedor.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";


            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Compra_{0}.pdf", txtNroDoc.Text);
            savefile.Filter = "Pdf Files | *.pdf";

            //Validar si elegimos una ruta correcta
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);

                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        //Prblema
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);

                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


    }
}
