using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryponcecarlosED
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {

         Frmpila vPila = new Frmpila();
         vPila.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmlistasimple vListaSimple = new Frmlistasimple();
            vListaSimple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmlistadoble vListaDoble = new Frmlistadoble();
            vListaDoble.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola vCola = new  FrmCola();
            vCola.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmarbolbinario vArbol = new Frmarbolbinario();
            vArbol.ShowDialog();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operacionesConTablasDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBASEDEDATOS vBaseDatos = new FrmBASEDEDATOS();
            vBaseDatos.ShowDialog();
        }

        private void consultaEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmconsultabasededatos vConsultaBaseDatos = new Frmconsultabasededatos();
            vConsultaBaseDatos.ShowDialog();
        }
    }
}
