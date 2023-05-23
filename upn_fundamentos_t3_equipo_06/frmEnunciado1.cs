using System;
using System.Collections.Generic;
using System.Windows.Forms;
using upn_fundamentos_t3_equipo_06.Enunciado_1;

namespace upn_fundamentos_t3_equipo_06
{
    public partial class frmEnunciado1 : Form
    {
        Commons _commons = new Commons();
        BLVeterinaria _blveterinaria = new BLVeterinaria();

        public frmEnunciado1()
        {
            InitializeComponent();
        }

        private void frmEnunciado1_Load(object sender, EventArgs e)
        {
            HabilitarDeshabilitarControles(false, 0);
            HabilitarDeshabilitarControles(false, 1);
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
                PersonaModel model = new PersonaModel(txtCodigoDuenio.Text,
                    txtNombreDuenio.Text, txtDireccionDuenio.Text, txtTelefonoDuenio.Text);

                _blveterinaria.RegistrarDuenio(model);

                CargarListView(0);

                HabilitarDeshabilitarControles(false, 0);

                MessageBox.Show("Registro Exitoso!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al registrar!", "¡Oh no!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaModel duenio = _blveterinaria.BuscarDuenio(cbxDuenio.Text);

                MascotaModel model = new MascotaModel(txtCodigoMascota.Text,
                    txtNombreMascota.Text, txtEdadMascota.Text, txtRazaMascota.Text, duenio);

                _blveterinaria.RegistrarMascota(model);

                CargarListView(1);

                HabilitarDeshabilitarControles(false, 1);

                MessageBox.Show("Registro Exitoso!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al registrar!", "¡Oh no!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                MascotaModel model = _blveterinaria.BuscarMascota(txtBuscaMascota.Text);

                if (model == null)
                {
                    MessageBox.Show("Nombre de mascota no existe en base de datos!", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(String.Format("Mascota encontrada:\n" +
                        "- Nombre: {0}\n" +
                        "- Raza: {1}\n" +
                        "- Dueño: {2}", model.Nombre, model.Raza, model.Duenio.Nombre), "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al buscar!", "¡Oh no!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarListView(int tipo)
        {
            if (tipo == 0)
            {
                lvDuenios.Items.Clear();

                List<PersonaModel> lista = _blveterinaria.ObtenerDuenios();

                foreach (PersonaModel model in lista)
                {
                    lvDuenios.Items.Add(String.Format("{0} - {1} - {2} - {3}",
                        model.Codigo.ToUpper(), model.Nombre.ToUpper(),
                        model.Telefono.ToUpper(), model.Direccion.ToUpper()));
                }
            }
            else
            {
                lvMascotas.Items.Clear();

                List<MascotaModel> lista = _blveterinaria.ObtenerMascotas();

                foreach (MascotaModel model in lista)
                {
                    lvMascotas.Items.Add(String.Format("{0} - {1} - {2} - {3} - Dueño: {4}",
                        model.Codigo.ToUpper(), model.Nombre.ToUpper(),
                        model.Edad.ToUpper(), model.Raza.ToUpper(), 
                        model.Duenio.Nombre.ToUpper()));
                }
            }
        }

        void HabilitarDeshabilitarControles(bool value, int tipo)
        {
            if (tipo == 0)
            {
                txtNombreDuenio.Enabled = value;
                txtDireccionDuenio.Enabled = value;
                txtTelefonoDuenio.Enabled = value;
                btnRegistrarDuenio.Enabled = value;
                btnNuevoDuenio.Text = value ? "Cancelar" : "Nuevo";

                txtNombreDuenio.Focus();
                txtCodigoDuenio.Clear();
                txtNombreDuenio.Clear();
                txtDireccionDuenio.Clear();
                txtTelefonoDuenio.Clear();

                txtCodigoDuenio.Text = value ? _commons.GenerarCodigoAleatorio() : "";
            }
            else
            {
                txtNombreMascota.Enabled = value;
                txtEdadMascota.Enabled = value;
                txtRazaMascota.Enabled = value;
                cbxDuenio.Enabled = value;
                btnRegistrarMascota.Enabled = value;
                btnNuevoMascota.Text = value ? "Cancelar" : "Nuevo";

                txtNombreMascota.Focus();
                txtCodigoMascota.Clear();
                txtNombreMascota.Clear();
                txtRazaMascota.Clear();
                txtEdadMascota.Clear();
                cbxDuenio.SelectedIndex = -1;

                txtCodigoMascota.Text = value ? _commons.GenerarCodigoAleatorio() : "";


                if (value)
                {
                    cbxDuenio.Items.Clear();

                    List<PersonaModel> listaDuenios = _blveterinaria.ObtenerDuenios();

                    cbxDuenio.Items.Add("-- Seleccione --");

                    for (int i = 0; i < listaDuenios.Count; i++)
                    {
                        cbxDuenio.Items.Add(listaDuenios[i].Nombre);
                    }

                    cbxDuenio.SelectedIndex = 0;
                }
            }
        }
    }
}
