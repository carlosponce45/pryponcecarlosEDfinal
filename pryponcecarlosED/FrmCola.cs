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
    public partial class FrmCola : Form
    {
        public FrmCola()
        {
            InitializeComponent();
        }
        ClsCola FilaDePersona = new  ClsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clsnodo ObjNodo = new Clsnodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.Recorrer(dgvCola);
            FilaDePersona.Recorrer(lstCola);
            FilaDePersona.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersona.Primero != null)
            {
                lblCodigoEliminar.Text = FilaDePersona.Primero.Codigo.ToString();
                lblNombreEliminar.Text = FilaDePersona.Primero.Nombre;
                lblTramiteEliminar.Text = FilaDePersona.Primero.Tramite;
                FilaDePersona.Eliminar();
                FilaDePersona.Recorrer(dgvCola);
                FilaDePersona.Recorrer(lstCola);
                FilaDePersona.Recorrer();
            }
            else
            {
                lblCodigoEliminar.Text = "";
                lblNombreEliminar.Text = "";
                lblTramiteEliminar.Text = "";
            }
        }
    }
    }

