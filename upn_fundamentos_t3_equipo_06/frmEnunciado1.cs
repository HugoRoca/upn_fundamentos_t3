using System;
using System.Collections.Generic;
using System.Windows.Forms;
using upn_fundamentos_t3_equipo_06.Enunciado_1;

namespace upn_fundamentos_t3_equipo_06
{
    public partial class frmEnunciado1 : Form
    {
        Commons f_commons = new Commons();
        BLVeterinaria f_blveterinaria = new BLVeterinaria();

        public frmEnunciado1()
        {
            InitializeComponent();
        }

        private void frmEnunciado1_Load(object sender, EventArgs e)
        {
            HabilitarDeshabilitarControles(false, 0);
            HabilitarDeshabilitarControles(false, 1);

            cbxDuenio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnNuevoDuenio_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitarControles(btnNuevoDuenio.Text == "Nuevo", 0);
        }

        private void btnNuevoMascota_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitarControles(btnNuevoMascota.Text == "Nuevo", 1);
        }

        private void btnRegistrarDuenio_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatosRegistro(false)) return;

                PersonaModel f_model = new PersonaModel(txtCodigoDuenio.Text,
                    txtNombreDuenio.Text, txtDireccionDuenio.Text, txtTelefonoDuenio.Text);

                f_blveterinaria.RegistrarDuenio(f_model);

                CargarListView(0);

                HabilitarDeshabilitarControles(false, 0);

                MessageBox.Show("Registro Exitoso!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error!", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatosRegistro(true)) return;

                PersonaModel f_duenio = f_blveterinaria.BuscarDuenio(cbxDuenio.Text);

                MascotaModel model = new MascotaModel(txtCodigoMascota.Text,
                    txtNombreMascota.Text, txtEdadMascota.Text, txtRazaMascota.Text, f_duenio);

                f_blveterinaria.RegistrarMascota(model);

                CargarListView(1);

                HabilitarDeshabilitarControles(false, 1);

                MessageBox.Show("Registro Exitoso!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error!", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                MascotaModel f_model = f_blveterinaria.BuscarMascota(txtBuscaMascota.Text);

                if (f_model == null)
                {
                    MessageBox.Show("Nombre de mascota no existe en base de datos!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(String.Format("Mascota encontrada:\n" +
                        "- Nombre: {0}\n" +
                        "- Raza: {1}\n" +
                        "- Dueño: {2}", f_model.Nombre, f_model.Raza, f_model.Duenio.Nombre), "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al buscar!", "¡Oh no!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreDuenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void txtTelefonoDuenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }

        private void txtNombreMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void txtRazaMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void txtEdadMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumerosYLetras(sender, e);
        }

        private void txtBuscaMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void CargarListView(int f_tipo)
        {
            if (f_tipo == 0)
            {
                lvDuenios.Items.Clear();

                List<PersonaModel> f_lista = f_blveterinaria.ObtenerDuenios();

                foreach (PersonaModel model in f_lista)
                {
                    lvDuenios.Items.Add(String.Format("{0} - {1} - {2} - {3}",
                        model.Codigo.ToUpper(), model.Nombre.ToUpper(),
                        model.Telefono.ToUpper(), model.Direccion.ToUpper()));
                }
            }
            else
            {
                lvMascotas.Items.Clear();

                List<MascotaModel> f_lista = f_blveterinaria.ObtenerMascotas();

                foreach (MascotaModel model in f_lista)
                {
                    lvMascotas.Items.Add(String.Format("{0} - {1} - {2} - {3} - Dueño: {4}",
                        model.Codigo.ToUpper(), model.Nombre.ToUpper(),
                        model.Edad.ToUpper(), model.Raza.ToUpper(),
                        model.Duenio.Nombre.ToUpper()));
                }
            }
        }

        private void HabilitarDeshabilitarControles(bool f_value, int f_tipo)
        {
            if (f_tipo == 0)
            {
                txtNombreDuenio.Enabled = f_value;
                txtDireccionDuenio.Enabled = f_value;
                txtTelefonoDuenio.Enabled = f_value;
                btnRegistrarDuenio.Enabled = f_value;
                btnNuevoDuenio.Text = f_value ? "Cancelar" : "Nuevo";

                txtNombreDuenio.Focus();
                txtCodigoDuenio.Clear();
                txtNombreDuenio.Clear();
                txtDireccionDuenio.Clear();
                txtTelefonoDuenio.Clear();

                txtCodigoDuenio.Text = f_value ? f_commons.GenerarCodigoAleatorio() : "";
            }
            else
            {
                txtNombreMascota.Enabled = f_value;
                txtEdadMascota.Enabled = f_value;
                txtRazaMascota.Enabled = f_value;
                cbxDuenio.Enabled = f_value;
                btnRegistrarMascota.Enabled = f_value;
                btnNuevoMascota.Text = f_value ? "Cancelar" : "Nuevo";

                txtNombreMascota.Focus();
                txtCodigoMascota.Clear();
                txtNombreMascota.Clear();
                txtRazaMascota.Clear();
                txtEdadMascota.Clear();
                cbxDuenio.SelectedIndex = -1;

                txtCodigoMascota.Text = f_value ? f_commons.GenerarCodigoAleatorio() : "";


                if (f_value)
                {
                    cbxDuenio.Items.Clear();

                    List<PersonaModel> f_listaDuenios = f_blveterinaria.ObtenerDuenios();

                    cbxDuenio.Items.Add("-- Seleccione --");

                    for (int i = 0; i < f_listaDuenios.Count; i++)
                    {
                        cbxDuenio.Items.Add(f_listaDuenios[i].Nombre);
                    }

                    cbxDuenio.SelectedIndex = 0;
                }
            }
        }

        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (!Char.IsLetter(tecla) && !Char.IsControl(tecla) && tecla != ' ') e.Handled = true;
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (!Char.IsDigit(tecla) && !Char.IsControl(tecla))
            {
                e.Handled = true;
            }
        }

        private void ValidarSoloNumerosYLetras(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (!Char.IsLetterOrDigit(tecla) && !Char.IsControl(tecla) && tecla != ' ')
            {
                e.Handled = true;
            }
        }

        private bool ValidarDatosRegistro(bool f_mascotas)
        {
            bool f_validacion = true;

            if (f_mascotas && (cbxDuenio.SelectedIndex == 0 || txtNombreMascota.Text == "" ||
                txtEdadMascota.Text == "" || txtRazaMascota.Text == ""))
            {
                f_validacion = false;
            }

            if (!f_mascotas && (txtNombreDuenio.Text == "" || txtDireccionDuenio.Text == "" || txtTelefonoDuenio.Text == ""))
            {
                f_validacion = false;
            }

            if (!f_validacion) MessageBox.Show("Faltan completar datos, por favor revisar!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return f_validacion;
        }
    }

}
