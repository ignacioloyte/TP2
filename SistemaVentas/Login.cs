using SistemaVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using CapaPresentacion.Idioma;
using CapaEntidad;
using CapaPresentacion.Modales;
using System.Threading;
using CapaPresentacion.Properties;


namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);
            lblUsuario.Text = Textos.lblUsuario;
            lblContraseña.Text = Textos.lblContraseña;
            lbltitulo.Text = Textos.lbltitulo;
            lbltitulo2.Text = Textos.lbltitulo2;
            btnIngresar.Text = Textos.btnIngresar;
            btnCancelar.Text = Textos.btnCancelar;
            btnSeleccionarIdioma.Text = Textos.btnSeleccionarIdioma;
            lblIdioma.Text = Textos.lblIdioma;


        }
        public void LlenarIdiomaComboBox()
        {
            cbIdioma.DataSource = Idiomas.ObtenerIdiomas();
            cbIdioma.DisplayMember = "NombrePais";
            cbIdioma.ValueMember = "CultureInfo";

        }

        private void Login_Load(object sender, EventArgs e)
        {
            CargarIdioma();
            LlenarIdiomaComboBox();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> TEST = new CN_Usuario().Listar();
            /* Llamamos el metodo listar. Utilizamos expresiones landas para poder retornar 
             * la busqueda de un usuario en nuestra lista
            */
            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.NUsuario == txtUsuario.Text &&
                u.Clave == txtClave.Text).FirstOrDefault();

            /* Aca realizamos el check para validar si existe el usuario, si existe en la bd sigue,
             * de lo contrario lanza un mensaje
             * */
            if (ousuario != null)
            {

                // Le pasamos el usuario que usamos en la consulta de la linea 35
                Inicio form = new Inicio(ousuario);




                // Registro Login OK en Bitacora
                CN_Log Log = new CN_Log();
                Log.LogAction(Convert.ToString(ousuario.IdUsuario), "Login", "Autentificado correctamente");


                form.Show();
                this.Hide();

                form.FormClosing += form_closing;
            }

            else
            {
                MessageBox.Show("No se encontro el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Registro Login Fallido en Bitacora
                CN_Log Log = new CN_Log();
                Log.LogAction(txtUsuario.Text, "Login Fallido", "No se ha podido autentificar");


            }
        }
        //Evento para que al cerrarse el form de inicio se abra el login
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            //Realizamos el blanqueo de los campos para que al regresar
            //no puedan ser copiados.

            txtUsuario.Text = "";
            txtClave.Text = "";
            this.Show();
        }

        private void btnSeleccionarIdioma_Click(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cbIdioma.SelectedValue.ToString();
            CargarIdioma();
          
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}
