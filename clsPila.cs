using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionED
{
    internal class clsPila
    {
        private clsNodo primero;
        private clsNodo ultimo;

        internal clsNodo Primero { get => primero; set => primero = value; }
        internal clsNodo Ultimo { get => ultimo; set => ultimo = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }

        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
                MessageBox.Show("Se ha eliminado el primer nodo de la pila", "Eliminar Nodo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                Primero = null;
                MessageBox.Show("No hay nodos para eliminar", "Eliminar Nodo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Recorrer(ListBox lbListado)
        {
            clsNodo aux = Primero;

            lbListado.Items.Clear();

            while (aux != null)
            {
                lbListado.Items.Add(aux.Codigo.ToString() + " | " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void RecorrerDgv(DataGridView dgvListado)
        {
            clsNodo aux = Primero;

            dgvListado.Rows.Clear();

            while (aux != null)
            {
                dgvListado.Rows.Add(
                    aux.Codigo.ToString(),
                    aux.Nombre,
                    aux.Tramite
                    );

                aux = aux.Siguiente;
            }
        }
    }
}
