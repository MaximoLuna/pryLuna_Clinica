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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            frmEspecialidades frmEspecialidades = new frmEspecialidades();
            frmEspecialidades.ShowDialog();
        }

        private void btnMedicos_Click(object sender, EventArgs e)
        {
            frmMédicos frmMedicos = new frmMédicos();
            frmMedicos.ShowDialog();
        }
    }
}
