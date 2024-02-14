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
    public partial class Frmconsultabasededatos : Form
    {
        public Frmconsultabasededatos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Clsbasededatos objBaseDatos = new Clsbasededatos();
            objBaseDatos.Listar(dgvConsulta, txtInstruccion.Text);
        }
    }
}
