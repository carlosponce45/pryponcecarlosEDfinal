using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryponcecarlosED
{
    internal class Clsnodo
    {
        //Propiedades
        private Int32 cod;
        private String nom;
        private String tra;

        private Clsnodo sig;
        private Clsnodo ant;

        public Int32 Codigo
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Tramite
        {
            get { return tra; }
            set { tra = value; }
        }

        public Clsnodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public Clsnodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public Clsnodo Izquierda
        {
            get { return ant; }
            set { ant = value; }
        }

        public Clsnodo Derecha
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}


