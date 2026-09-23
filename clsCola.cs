using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionED
{
    internal class clsCola
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
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Listar(ListBox lstListado)
        {
            clsNodo aux = Primero;

            lstListado.Items.Clear();

            while (aux != null)
            {
                lstListado.Items.Add(aux.Codigo + " " + aux.Nombre + ", " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void ListarEnGrilla(DataGridView dgvListado)
        {
            clsNodo aux = Primero;

            dgvListado.Rows.Clear();

            while (aux != null)
            {
                dgvListado.Rows.Add(
                    aux.Codigo,
                    aux.Nombre,
                    aux.Tramite
                );
                aux = aux.Siguiente;
            }
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;

                if (Primero == null)
                {
                    Ultimo = null;
                }
            }

        }
    }
}
