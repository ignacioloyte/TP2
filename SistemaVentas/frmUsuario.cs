﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentacion.Idioma;
using CapaPresentacion.Modales;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Globalization;
using SistemaVentas;

namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {

        public frmUsuario()
        {
            InitializeComponent();

        }

        private void CargarGrilla()
        {

            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            dgvData.Rows.Clear();

            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] { "", item.IdUsuario, item.NUsuario, item.Documento, item.NombreCompleto, item.Email,
                   "",   item.oRol.IdRol,    item.FechaAlta,    item.FechaBaja,item.oRol.Descripcion, item.Estado,item.Estado ? "Activo" : "No Activo"  // Aquí se hace la conversión
 



            });
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public void CargarIdioma()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CapaPresentacion.Properties.Settings.Default.Idioma);
            lblNombreUsuario.Text = Textos.lblNombreUsuario;
            lblNroDoc.Text = Textos.lblNroDoc;
            lblNombreCliente.Text = Textos.lblNombreCliente;
            lblEmail.Text = Textos.lblEmail;
            lblContraseña.Text = Textos.lblContraseña;
            lblConfContraseña.Text = Textos.lblConfContraseña;
            lblRol.Text = Textos.lblRol;
            lblEstado.Text = Textos.lblEstado;
            btnGuardar.Text = Textos.btnGuardar;
            btnLimpiarForm.Text = Textos.btnLimpiarForm;
            btnEliminar.Text = Textos.btnEliminar;
            lblTituloUsuario.Text = Textos.lblTituloUsuario;
            lblBuscar.Text = Textos.lblBuscar;
            lblUsuarios.Text = Textos.lblUsuarios;

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CargarIdioma();
            //Para darle los valores al ComboBox del estado
            cbEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbEstado.DisplayMember = "Texto";
            cbEstado.ValueMember = "Valor";
            cbEstado.SelectedIndex = 0;


            List<Rol> listaRol = new CN_Rol().Listar();

            foreach (Rol item in listaRol)
            {
                cbRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cbRol.DisplayMember = "Texto";
            cbRol.ValueMember = "Valor";
            cbRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    cbBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBusqueda.DisplayMember = "Texto";
            cbBusqueda.ValueMember = "Valor";
            cbBusqueda.SelectedIndex = 0;

            // Mostrar todos los usuario

            CargarGrilla();
        }

        //Boton de Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaBajaDefault = new DateTime(2100, 1, 1); // Fecha por defecto
            DateTime fechaBaja;

            // Verifica si txtFechaBaja.Text es nulo o vacío, y asigna la fecha por defecto en ese caso
            if (string.IsNullOrEmpty(txtFechaBaja.Text))
            {
                fechaBaja = fechaBajaDefault;
            }
            else
            {
                // Intenta convertir el texto a DateTime, si falla, asigna la fecha por defecto
                if (!DateTime.TryParse(txtFechaBaja.Text, out fechaBaja))
                {
                    fechaBaja = fechaBajaDefault;
                }
            }

            string mensaje = string.Empty;
       

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                NUsuario = txtNUsuario.Text,
                Documento = txtNroDoc.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Email = txtEmail.Text,
                Clave = Encriptado.HashPassword(txtClave.Text),
                FechaAlta = dtInicio.Value,
                FechaBaja = fechaBaja,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                //Nos ejecuta el metodo RE- Muestra en el datagrid los datos
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    // Registro Crear Usuario

                    CN_Log Log = new CN_Log();
                    Log.LogAction(Convert.ToString(Inicio.usuarioActual.IdUsuario), "Se ha creado el usuario",Convert.ToString( idusuariogenerado));

                    CargarGrilla();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
            else
            {
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    // Registro Editar Usuario

                    CN_Log Log = new CN_Log();
                    Log.LogAction(Convert.ToString(Inicio.usuarioActual.IdUsuario), "Se ha editado el usuario", txtId.Text);

                    CargarGrilla();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }




        }

        //Metodo para limpiar los campos
        private void Limpiar()
        {
            txtIndice.Text = "-1";
            txtId.Text = "0";
            txtNUsuario.Text = "";
            txtNroDoc.Text = "";
            txtNombreCompleto.Text = "";
            txtEmail.Text = "";
            txtClave.Text = "";
            txtConfClave.Text = "";
            dtInicio.Value = DateTime.Now;
            txtFechaBaja.Text = "";
            cbRol.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;

            txtNroDoc.Select();

        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;

            }



        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {

                    txtIndice.Text = indice.ToString();
                    txtId.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txtNUsuario.Text = dgvData.Rows[indice].Cells["NombreUsuario"].Value.ToString();
                    txtNroDoc.Text = dgvData.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvData.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtEmail.Text = dgvData.Rows[indice].Cells["Email"].Value.ToString();

                    txtFechaBaja.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    txtClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfClave.Text = dgvData.Rows[indice].Cells["Clave"].Value.ToString();


                    // Obtén el valor de IdRol de la fila seleccionada
                    var idRol = dgvData.Rows[e.RowIndex].Cells["IdRol"].Value.ToString();

                    // Busca este valor en los ítems del cbRol
                    foreach (var item in cbRol.Items)
                    {
                        OpcionCombo opc = item as OpcionCombo;
                        if (opc != null && opc.Valor.ToString() == idRol)
                        {
                            // Si encuentras una coincidencia, selecciona este ítem en el ComboBox
                            cbRol.SelectedItem = item;
                            break;
                        }
                    }
                 

                    foreach (OpcionCombo oc in cbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cbEstado.Items.IndexOf(oc);
                            cbEstado.SelectedIndex = indice_combo;
                            break;

                        }
                    }

                }
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)

                    };
                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        CargarGrilla();
                        // Registro Eliminar Usuario

                        CN_Log Log = new CN_Log();
                        Log.LogAction(Convert.ToString(Inicio.usuarioActual.IdUsuario), "Se ha eliminado el usuario", txtId.Text);

                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }


        //Para realizar busqueda por el combo box
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBusqueda.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else { row.Visible = false; }
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }

        }

        private void btnLimpiarForm_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
