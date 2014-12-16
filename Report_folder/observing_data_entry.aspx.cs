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


public partial class administration_entry_form : BasePage
{
    List<ReportParameter> parameters = new List<ReportParameter>();
    string reportPath = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.DataSource = DatabaseFunctions.SelectData(null, "Datarev");
            DropDownList1.DataBind();


            ListItem litem = new ListItem("-- اختر مراجع البيانات --", "0");
            litem.Selected = true;
            DropDownList1.Items.Insert(0, litem);
        }

    }



    //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //   parameters.Add(new ReportParameter("userName", DropDownList1.SelectedValue.ToString()));
    //}


    protected void ViewReport_Click(object sender, EventArgs e)
    {
        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        reportPath = "/Azhar_report/observing_data_entry_live";
        ReportViewer1.ServerReport.ReportPath = reportPath;
        parameters.Add(new ReportParameter("user_id", DropDownList1.SelectedValue.ToString()));
        parameters.Add(new ReportParameter("Start_date", TextBox2.Text.ToString()));
        parameters.Add(new ReportParameter("end_date", TextBox3.Text.ToString()));
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        ReportViewer1.ShowParameterPrompts = false;
        ReportViewer1.ShowPromptAreaButton = false;
        ReportViewer1.ServerReport.Refresh();
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        parameters.Add(new ReportParameter("userName", DropDownList1.SelectedValue.ToString()));
        
    }
}


