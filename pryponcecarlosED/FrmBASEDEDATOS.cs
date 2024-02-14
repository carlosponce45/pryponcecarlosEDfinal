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
    public partial class FrmBASEDEDATOS : Form
    {
        String varSQL;
        Clsbasededatos objBaseDeDatos = new Clsbasededatos();
        public FrmBASEDEDATOS()
        {
            InitializeComponent();
        }
       
        private void btnSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT TITULO FROM LIBRO ORDER BY 1 DESC";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT ID,TITULO," + "FROM LIBRO" + "ORDER BY 1 DESC";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO" + "WHERE CANTIDAD >= 1";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSeleccionMulti_Click(object sender, EventArgs e)
        {

        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO" + "WHERE IDAUTOR = 2"
          + "UNION" + "SELECT * FROM LIBRO" + "WHERE IDAUTOR = 5"
          + "UNION" + "SELECT * FROM LIBRO" + "WHERE IDAUTOR = 3";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            varSQL = "SELECT * FROM LIBRO" + "WHERE IDIDIOMA"
         + "NOT IN" + "(SELECT DISTINC IDIDIOMA FROM LIBRO)" + "WHERE IDIOMA < 5";
            objBaseDeDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
