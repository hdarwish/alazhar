using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Configuration;

public partial class Reports_Report_Report_Statistical_no__Elements : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        //List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "/Azhar_report/Report_Statistical_no_ Elements";

      //  parameters.Add(new ReportParameter("id_content_type", object_type.SelectedValue));

        ReportViewer1.ServerReport.ReportPath = reportPath;
        //ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;

        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;
    }
}