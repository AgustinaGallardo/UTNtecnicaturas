using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTNtecnicaturas.Datos;

namespace UTNtecnicaturas.Presentacion.RerporteAlumno
{
    public partial class FormAlumnoMat : Form
    {
        public FormAlumnoMat()
        {
            InitializeComponent();
        }

        private void FormAlumnoMat_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
          
        }
        private void Consultar_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@legajo", Convert.ToInt32(txtLegajo.Text)));
            DataTable dt = Helper.ObtenerInstancia().CargarConsulta("Sp_Alumno_materias_informacion", lst);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataAlumno", dt));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
