using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pryCarrionED
{
    internal class clsNodo
    {
        Int32 codigo;
        private String nombre;
        private String tramite;
        private clsNodo ant;
        private clsNodo sig;

        public clsNodo Siguiente { get => sig; set => sig = value; }
        public clsNodo Anterior { get => ant; set => ant = value; }
        public Int32 Codigo { get => codigo; set => codigo = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public String Tramite { get => tramite; set => tramite = value; }
    }
}
