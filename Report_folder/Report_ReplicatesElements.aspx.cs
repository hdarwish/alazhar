using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.Configuration;

public partial class Reports_Report_ReplicatesElements : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable objectsDT = content_types_DB.SelectAll();
            object_type.DataSource = content_types_DB.SelectAll();
            object_type.DataBind();


            ListItem litem = new ListItem("-- اختر نوع الاستمارة --", "0");
            litem.Selected = true;
            object_type.Items.Insert(0, litem);
        }
    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {

        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "/Azhar_report/Report_ReplicatesElements";

        parameters.Add(new ReportParameter("id", object_type.SelectedValue));

        ReportViewer1.ServerReport.ReportPath = reportPath;
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;

        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;
    }
}