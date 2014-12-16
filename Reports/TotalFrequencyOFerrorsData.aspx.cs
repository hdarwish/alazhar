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

public partial class Reports_TotalFrequencyOFerrors : System.Web.UI.Page
{
    List<ReportParameter> parameters = new List<ReportParameter>();
   // ReportParameter pam1 = new ReportParameter();
  //ReportParameter pam2 = new ReportParameter();
  // ReportParameter pam3 = new ReportParameter();
    string Path;



    protected void Page_Load(object sender, EventArgs e)
    {
            
        

    }
    public void CallReport(string ReportPath)
    {
        ReportViewer1.ServerReport.ReportServerUrl = new Uri("http://asma-pc/ReportServer");
        string reportPath = "";
        reportPath = ReportPath;

        ReportViewer1.ShowCredentialPrompts = false;
       // List<ReportParameter> parameters = new List<ReportParameter>();
        ReportViewer1.ServerReport.ReportPath = reportPath;

       // parameters.Add(parameter1);
      // parameters.Add(parameter2);
      //parameters.Add(parameter3);

        ReportViewer1.ServerReport.SetParameters(parameters);

        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;

    }
    protected void View_Click(object sender, EventArgs e)
    {
        ReportParameter pam2 = (new ReportParameter("Start_date", TxtFrom.Text.ToString()));
        parameters.Add(pam2);
        ReportParameter pam3 = (new ReportParameter("end_date", TxtTO.Text.ToString()));
        parameters.Add(pam3);
        Path = "/TotalFrequencyOFerrorsData/TotalFrequencyOFerrorsData";
        CallReport(Path);

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReportParameter pam1 = (new ReportParameter("id", DropDownList1.SelectedValue));// user id
        parameters.Add(pam1);

    }
}