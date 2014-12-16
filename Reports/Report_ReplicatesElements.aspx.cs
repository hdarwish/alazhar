using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

public partial class Reports_Report_ReplicatesElements : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {

        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://amrafifi-pc/ReportServer");
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "/Reports_Ashzr/Report_ReplicatesElements";

        parameters.Add(new ReportParameter("id", object_type.SelectedValue));

        ReportViewer1.ServerReport.ReportPath = reportPath;
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;

        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;
    }
}