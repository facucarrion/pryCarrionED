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
    public partial class frmListaDoblementeEnlazada : Form
    {
        public frmListaDoblementeEnlazada()
        {
            InitializeComponent();
        }

        clsListaDoblementeEnlazada objListaDoblementeEnlazada = new clsListaDoblementeEnlazada();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            objListaDoblementeEnlazada.Agregar(Persona);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
            cboCodigo.SelectedIndex = -1;

            objListaDoblementeEnlazada.Listar(lstListado);
            objListaDoblementeEnlazada.ListarEnGrilla(dgvListado);
            objListaDoblementeEnlazada.ListarEnCombo(cboCodigo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cboCodigo.SelectedItem != null)
            {
                objListaDoblementeEnlazada.Eliminar(Convert.ToInt32(cboCodigo.SelectedItem));
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

            objListaDoblementeEnlazada.Listar(lstListado);
            objListaDoblementeEnlazada.ListarEnGrilla(dgvListado);
            objListaDoblementeEnlazada.ListarEnCombo(cboCodigo);
        }
    }
}
