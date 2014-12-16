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
        if (!IsPostBack)
        {
            DropDownList1.DataSource = DatabaseFunctions.SelectData(null, "DataEntery");
            DropDownList1.DataBind();


            ListItem litem = new ListItem("-- اختر مدخل البيانات --", "0");
            litem.Selected = true;
            DropDownList1.Items.Insert(0, litem);
        }
    }
    public void CallReport(string ReportPath)
    {
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
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
        Path = "/Azhar_report/TotalFrequencyOFerrorsData";
        CallReport(Path);

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ReportParameter pam1 = (new ReportParameter("id", DropDownList1.SelectedValue));// user id
        parameters.Add(pam1);

    }
}