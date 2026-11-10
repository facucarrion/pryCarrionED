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
    public partial class frmConsultasSQL : Form
    {
        public frmConsultasSQL()
        {
            InitializeComponent();
        }

        clsBaseDeDatos objDB = new clsBaseDeDatos();

        private void btnListar_Click(object sender, EventArgs e)
        {

            if (lbConsultas.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una tabla");
                return;
            }

            objDB.Listar(dgvConsultas, lbConsultas.Text);

        }

        private void frmConsultasSQL_Load(object sender, EventArgs e)
        {
            lbConsultas.Items.Clear();
            lbConsultas.Items.AddRange(new object[] { "Autor", "Idioma", "Libro", "Pais" });
            AplicarEstiloGrilla();
        }

        private void AplicarEstiloGrilla()
        {
            dgvConsultas.ReadOnly = true;
            dgvConsultas.AllowUserToAddRows = false;
            dgvConsultas.AllowUserToDeleteRows = false;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }    }
}
