using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryponcecarlosED
{
    internal class Clslistasimple
    {
        // Datos indexados
        internal class clsListaSimple
        {
            private Clsnodo pri;

            public Clsnodo Primero
            {
                get { return pri; }
                set { pri = value; }
            }

            public void Agregar(Clsnodo Nuevo)
            {
                if (Primero == null)
                {
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo <= Primero.Codigo)
                    {
                        Nuevo.Siguiente = Primero;
                        Primero = Nuevo;
                    }
                    else
                    {
                        Clsnodo aux = Primero;
                        Clsnodo ant = Primero;
                        while (Nuevo.Codigo > aux.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                            if (aux == null)
                            {
                                break;
                            }
                        }
                        ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = aux;
                    }
                }
            }

            public void Eliminar(Int32 Codigo)
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                }
                else
                {
                    Clsnodo aux1 = Primero;
                    Clsnodo aux2 = Primero;
                    if (aux1.Codigo != Codigo)
                    {
                        aux2 = aux1;
                        aux1 = aux1.Siguiente;
                    }
                    aux2.Siguiente = aux1.Siguiente;
                }
            }

            public void Recorrer(DataGridView Grilla)
            {
                Clsnodo aux = Primero;
                Grilla.Rows.Clear();
                while (aux != null)
                {
                    Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                    aux = aux.Siguiente;
                }
            }
            public void Recorrer(ListBox Lista)
            {
                Clsnodo aux = Primero;
                Lista.Items.Clear();
                while (aux != null)
                {
                    Lista.Items.Add(aux.Codigo);
                    aux = aux.Siguiente;
                }
            }
            public void Recorrer(ComboBox Combo)
            {
                Clsnodo aux = Primero;
                Combo.Items.Clear();
                while (aux != null)
                {
                    Combo.Items.Add(aux.Codigo);
                    aux = aux.Siguiente;
                }
            }
            public void Recorrer()
            {
                Clsnodo aux = Primero;
                StreamWriter AD = new StreamWriter(" listasimple.csv", false);
                AD.WriteLine("LISTA DE ESPERA/n");
                AD.WriteLine("Codigo;Nombre;Tramite");
                while (aux != null)
                {
                    AD.Write(aux.Codigo);
                    AD.Write(";");
                    AD.Write(aux.Nombre);
                    AD.Write("");
                    AD.WriteLine(aux.Tramite);
                    aux = aux.Siguiente;
                }
                AD.Close();
            }
        }
    }
}
