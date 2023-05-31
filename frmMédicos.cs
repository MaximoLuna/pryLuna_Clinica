using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace pryLuna_Clinica
{
    public partial class frmMédicos : Form
    {
        public frmMédicos()
        {
            InitializeComponent();
        }

        private void frmMédicos_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsEspecialidades objEspecialidad = new clsEspecialidades();
            objEspecialidad.CargarEspecialidades(cmbEspecialidadM, cmbEspecialidadC);
            clsMedicos objMedico = new clsMedicos();
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            clsMedicos objMedico = new clsMedicos();
            objMedico.Grabar(txtMatricula, txtNombreM, cmbEspecialidadM, cmbEspecialidadC);
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }

        private void cmbEspecialidadC_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsMedicos objMedico = new clsMedicos();
            objMedico.ListarMedicos(dgvConsultas, cmbEspecialidadC);
        }

    }
}
