using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLuna_Clinica
{
    public partial class frmEspecialidades : Form
    {
        public frmEspecialidades()
        {
            InitializeComponent();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            clsEspecialidades objEspecialidad = new clsEspecialidades();
            objEspecialidad.Grabar(txtNumeroE.Text, txtNombreE.Text);
        }
    }
}
