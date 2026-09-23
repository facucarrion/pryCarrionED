using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionED
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola objCola = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            objNodo.Siguiente = null;

            objCola.Agregar(objNodo);
            objCola.Listar(lstListado);
            objCola.ListarEnGrilla(dgvListado);

            txtCodigo.Clear();
            txtTramite.Clear();
            txtNombre.Clear();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objCola.Primero != null)
            {
                lblMuestraCodigo.Text = objCola.Primero.Codigo.ToString();
                lblMuestraNombre.Text = objCola.Primero.Nombre;
                lblMuestraTramite.Text = objCola.Primero.Tramite;

                objCola.Eliminar();

                objCola.Listar(lstListado);
                objCola.ListarEnGrilla(dgvListado);
            }
            else
            {
                MessageBox.Show("La cola está vacía");
            }
        }
    }
}
