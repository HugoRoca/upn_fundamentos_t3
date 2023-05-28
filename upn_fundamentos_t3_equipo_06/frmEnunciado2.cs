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
                if (txtNumeroIngresar.Text == "")
                {
                    MessageBox.Show("Debe ingredar un número", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumeroIngresar.Focus();
                    return;
                }

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

                CargarListView(lista);
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

                CargarListView(lista);
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
                if (lvLista.SelectedItems.Count < 0)
                {
                    MessageBox.Show("Debe ingresar un número", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ListViewItem selectedItem = lvLista.SelectedItems[0];
                string numero = selectedItem.Text;
                bool esEliminado = _blEnunciado2.EliminarNumero(double.Parse(numero));

                if (esEliminado) MessageBox.Show("Número eliminado!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("No se encontró el número!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void CargarListView(List<double> f_listaNumeros = null)
        {
            lvLista.Items.Clear();

            List<double> lista = f_listaNumeros ?? _blEnunciado2.ObtenerListaNumeros();

            foreach (var f_item in lista)
            {
                lvLista.Items.Add(f_item.ToString());
            }
        }
    }
}
