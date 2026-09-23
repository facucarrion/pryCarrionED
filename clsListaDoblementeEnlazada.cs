using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionED
{
    internal class clsListaDoblementeEnlazada
    {
        private clsNodo primero;
        private clsNodo ultimo;

        public clsNodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public clsNodo Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Nuevo.Siguiente = null;
                Nuevo.Anterior = null;
                Primero = Nuevo;
                Ultimo = Nuevo;
                return;
            }

            if (Nuevo.Codigo < Primero.Codigo)
            {
                Nuevo.Siguiente = Primero;
                Nuevo.Anterior = null;
                Primero.Anterior = Nuevo;
                Primero = Nuevo;
                return;
            }

            clsNodo aux = Primero;

            while (aux != null && aux.Codigo < Nuevo.Codigo)
            {
                aux = aux.Siguiente;
            }

            if (aux == null)
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Anterior = Ultimo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }

            else
            {
                clsNodo prev = aux.Anterior;
                prev.Siguiente = Nuevo;
                Nuevo.Anterior = prev;
                Nuevo.Siguiente = aux;
                aux.Anterior = Nuevo;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero == null)
            {
                MessageBox.Show("La lista está vacía. No se puede eliminar ningún nodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Primero == Ultimo && Primero.Codigo == Codigo)
            {
                Primero = null;
                Ultimo = null;
                return;
            }

            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.Siguiente;
                if (Primero != null)
                {
                    Primero.Anterior = null;
                }
                else
                {
                    Ultimo = null;
                }
                return;
            }

            clsNodo aux = Primero.Siguiente;

            while (aux != null && aux.Codigo != Codigo)
            {
                aux = aux.Siguiente;
            }

            if (aux == null)
            {
                return;
            }

            if (aux == Ultimo)
            {
                aux.Anterior.Siguiente = null;
                Ultimo = aux.Anterior;
            }
            else
            {
                aux.Anterior.Siguiente = aux.Siguiente;
                aux.Siguiente.Anterior = aux.Anterior;
            }
        }

        public void ListarEnGrilla(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void Listar(ListBox lstListado)
        {
            clsNodo aux = Primero;
            lstListado.Items.Clear();
            while (aux != null)
            {
                lstListado.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }

        public void ListarEnCombo(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
