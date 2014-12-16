using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;
using System.Collections.Generic;

public partial class Reports_StaticalyReportDataEntry : System.Web.UI.Page
{

    List<ReportParameter> parameters = new List<ReportParameter>();
    string Path;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReportParameter pam1 = (new ReportParameter("nameUser", DropDownList1.SelectedValue.ToString()));// user id
        parameters.Add(pam1);
    }
    protected void View_Click(object sender, EventArgs e)
    {
        ReportParameter pam2 = (new ReportParameter("Date_from", TxtFrom.Text.ToString()));
        parameters.Add(pam2);
        ReportParameter pam3 = (new ReportParameter("Date_to", TxtTO.Text.ToString()));
        parameters.Add(pam3);
        Path = "/Statistical_report_for_data_entry/StatisticalReportforDataEntry";
        CallReport(Path);
    }
    public void CallReport(string ReportPath)
    {
        ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://asma-pc/ReportServer");
        string reportPath = "";
        reportPath = ReportPath;

        ReportViewer1.ShowCredentialPrompts = false;

        ReportViewer1.ServerReport.ReportPath = reportPath;


        ReportViewer1.ServerReport.SetParameters(parameters);

        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;

    }
}