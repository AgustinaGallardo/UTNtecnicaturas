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

namespace UTNtecnicaturas.Presentacion.Reporte10
{
    public partial class frmReporte10 : Form
    {
        public frmReporte10()
        {
            InitializeComponent();
        }

        private void Reporte10_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@promedio", Convert.ToInt32(txtPromedio.Text)));
            DataTable dt = Helper.ObtenerInstancia().CargarConsulta("sp_extranjeros_programacion", lst);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet10", dt));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
