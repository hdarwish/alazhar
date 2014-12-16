using System;
using System.Collections;
using System.Configuration;
using System.Data;
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

public partial class Reports_FeaturesHonor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    { 

    }
   
    
    public void CallReport(string ReportPath, ReportParameter parameter)
    {
        ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://asma-pc/ReportServer");
        string reportPath = "";
        reportPath = ReportPath;

        ReportViewer1.ShowCredentialPrompts = false;
        List<ReportParameter> parameters = new List<ReportParameter>();
        ReportViewer1.ServerReport.ReportPath = reportPath;

         parameters.Add(parameter);       
        ReportViewer1.ServerReport.SetParameters(parameters);

        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;

    }






    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReportParameter pam = (new ReportParameter("id", DropDownList1.SelectedValue));

        string Path;
        Path = "/FeaturesHonor/featuresHonor";

        CallReport(Path, pam);

    }
}