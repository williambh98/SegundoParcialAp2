using BLL;
using Entidades;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SegundoParcialAp2.UI.Consultas
{
    public partial class ConsultasTrasacciones : System.Web.UI.Page
    {
        static List<Trasacciones> lista = new List<Trasacciones>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenaReport();
            }
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Trasacciones, bool>> filtro = x => true;
            RepositorioBase<Trasacciones> repositorio = new RepositorioBase<Trasacciones>();     
            
            int id;
            switch (BuscarPorDropDownList.SelectedIndex)
            {
                case 0://Todo
                    filtro = x => true;
                    break;
                case 1://ID
                    id = Utilitarios.Utils.ToInt(FiltroTextBox.Text);
                    filtro = c => c.TrasaccionID == id;
                    break;
                case 2:// Nombre
                    filtro = c => c.Tipo.Contains(FiltroTextBox.Text);
                    break;
            }
            DateTime desdeTextBox = Utilitarios.Utils.ToFecha(DesdeTextBox.Text);
            DateTime FechaHasta = Utilitarios.Utils.ToFecha(HastaTextBox.Text);
            if (fechaCheckBox.Checked)
                lista = repositorio.GetList(filtro).Where(c => c.Fecha >= desdeTextBox && c.Fecha <= FechaHasta).ToList();
            else
                lista = repositorio.GetList(filtro);
            this.BindGrid(lista);
        }
        private void BindGrid(List<Trasacciones> lista)
        {
            DatosGridView.DataSource = lista;
            DatosGridView.DataBind();
        }

        protected void FechaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fechaCheckBox.Checked)
            {
                fechaCheckBox.Visible = true;
                fechaCheckBox.Visible = true;
            }
            else
            {
                fechaCheckBox.Visible = false;
                fechaCheckBox.Visible = false;
            }
        }
        public void LlenaReport()
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "Popup", $"ShowReporte('');", true);
            MyEstudiantesReportViewer.ProcessingMode = ProcessingMode.Local;
            MyEstudiantesReportViewer.Reset();
            MyEstudiantesReportViewer.LocalReport.ReportPath = Server.MapPath(@"\Reportes\ReportesTrasacciones.rdlc");
            MyEstudiantesReportViewer.LocalReport.DataSources.Clear();
            MyEstudiantesReportViewer.LocalReport.DataSources.Add(new ReportDataSource("Trasacciones", Metodo.segTrasacciones()));
            MyEstudiantesReportViewer.LocalReport.Refresh();
        }

    }
}
