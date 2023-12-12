using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Idioma;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CapaPresentacion.Properties.Settings.Default.Idioma);
            lblDetalleVenta.Text = Textos.lblDetalleVenta;
            lblNroDoc.Text = Textos.lblNroDoc;
            btnBuscarS.Text = Textos.btnBuscarS;
            btnLimpiarForm.Text = Textos.btnLimpiarForm;
            gbInfo.Text = Textos.gbInfo;
            lblFecha.Text = Textos.lblFecha;
            lblDoc.Text = Textos.lblDoc;
            lblUsuario.Text = Textos.lblUsuario;
            gbInfoProveedor.Text = Textos.gbInfoProveedor;
            lblDoc2.Text = Textos.lblDoc;
            lblNombreCliente.Text = Textos.lblNombreCliente;
            lblMontoTotal.Text = Textos.lblMontoTotal;
            lblMontoPago.Text = Textos.lblMontoPago;
            lblMontoCambio.Text = Textos.lblMontoCambio;
            btnDescargarPdf.Text = Textos.btnDescargarPdf;
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            CargarIdioma();
            txtBusquedaDoc.Select();
        }


        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            Venta oVenta = new CN_Venta().ObtenerVenta(txtBusquedaDoc.Text);

            if (oVenta.IdVenta != 0)
            {
                txtNroDoc.Text = oVenta.NumeroDocumento;
                txtFecha.Text = oVenta.FechaRegistro.ToString();
                txtTipoDocumento.Text = oVenta.TipoDocumento;

                txtNroDocCliente.Text = oVenta.DocumentoCliente;
                lblNombreCliente.Text = oVenta.NombreCliente;


                dgvData.Rows.Clear();

                foreach (DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dgvData.Rows.Add(new object[] { dv.oProducto.Nombre, dv.PrecioVenta, dv.Cantidad, dv.SubTotal });
                }

                txtMontoTotal.Text = oVenta.MontoTotal.ToString("0.00");
                txtMontoPago.Text = oVenta.MontoPago.ToString("0.00");
                txtMontoCambio.Text = oVenta.MontoCambio.ToString("0.00");

            }
        }

        private void btnLimpiarCompra_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTipoDocumento.Text = "";
            txtUsuario.Text = "";
            txtNroDocCliente.Text = "";
            lblNombreCliente.Text = "";

            dgvData.Rows.Clear();
            txtMontoTotal.Text = "0.00";
            txtMontoPago.Text = "0.00";
            txtMontoCambio.Text = "0.00";

        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {

            if (txtTipoDocumento.Text == "")
            {
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            Negocio odatos = new CN_Negocio().ObtenerDatos();

            //Reemplazamos los textos de la plantilla html por las variables que ingresamos del negocio
            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.CUIT);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumento.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtNroDoc.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txtNroDocCliente.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", lblNombreCliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFecha.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuario.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";


            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotal.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtMontoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtMontoCambio.Text);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtNroDoc.Text);
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

