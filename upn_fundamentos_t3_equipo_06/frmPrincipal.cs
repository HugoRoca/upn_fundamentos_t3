using System;
using System.Windows.Forms;

namespace upn_fundamentos_t3_equipo_06
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEnunciadoUno_Click(object sender, EventArgs e)
        {
            var frm = new frmEnunciado1();
            frm.Show();
        }

        private void btnEnunciadoDos_Click(object sender, EventArgs e)
        {
            var frm = new frmEnunciado2();
            frm.Show();
        }
    }
}
