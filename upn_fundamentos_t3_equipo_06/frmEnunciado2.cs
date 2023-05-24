using System;
using System.Collections.Generic;
using System.Windows.Forms;
using upn_fundamentos_t3_equipo_06.Enunciado_2;

namespace upn_fundamentos_t3_equipo_06
{
    public partial class frmEnunciado2 : Form
    {
        BLEnunciadoDos _blEnunciado2 = new BLEnunciadoDos();

        public frmEnunciado2()
        {
            InitializeComponent();
        }

        private void frmEnunciado2_Load(object sender, EventArgs e)
        {
            txtNumeroIngresar.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _blEnunciado2.AgregarNumero(double.Parse(txtNumeroIngresar.Text));
                txtNumeroIngresar.Clear();
                txtNumeroIngresar.Focus();

                CargarListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error!", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenarAsc_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> lista = _blEnunciado2.OrdenarAscendenteDescendente(true);

                lvLista.Items.Clear();

                foreach (var item in lista)
                {
                    lvLista.Items.Add(item.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error!", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenarDesc_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> lista = _blEnunciado2.OrdenarAscendenteDescendente(false);

                lvLista.Items.Clear();

                foreach (var item in lista)
                {
                    lvLista.Items.Add(item.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error!", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esEliminado = _blEnunciado2.EliminarNumero(double.Parse(txtNumeroEliminar.Text));

                if (esEliminado) MessageBox.Show("Número eliminado!");
                else
                {
                    MessageBox.Show("No se encontró el número!");
                }

                txtNumeroEliminar.Clear();
                txtNumeroEliminar.Focus();

                CargarListView();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error!", "¡Oh no!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumeroIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerosDecimales(sender, e);
        }

        private void txtNumeroEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarNumerosDecimales(sender, e);
        }

        private void validarNumerosDecimales(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if (((e.KeyChar == '.') || (e.KeyChar == ',') || (e.KeyChar == '-')) && 
                ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CargarListView()
        {
            lvLista.Items.Clear();

            List<double> lista = _blEnunciado2.ObtenerListaNumeros();

            foreach (var item in lista)
            {
                lvLista.Items.Add(item.ToString());
            }
        }
    }
}
