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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple objListaSimple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            objListaSimple.Agregar(Persona);

            txtCodigo.Clear();
            txtNombre.Clear();  
            txtTramite.Clear();
            cboCodigo.SelectedIndex = -1;

            objListaSimple.Listar(lstListado);
            objListaSimple.ListarEnGrilla(dgvListado);
            objListaSimple.ListarEnCombo(cboCodigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedItem != null)
            {
                 objListaSimple.Eliminar(Convert.ToInt32(cboCodigo.SelectedItem));
                 MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún valor a eliminar");
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            cboCodigo.SelectedIndex = -1;

            objListaSimple.Listar(lstListado);
            objListaSimple.ListarEnGrilla(dgvListado);
            objListaSimple.ListarEnCombo(cboCodigo);
        }
    }
}
