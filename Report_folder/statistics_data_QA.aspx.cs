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
    public static string id = "";
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    // static int smartvalue = 0;
    protected override void OnInit(EventArgs e)
    {

        //this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);

    }

    private void MOnMember_Data(string Value)
    {
    }


    private void Fill_smart(string Value)
    {

    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            name_DropDownList.DataSource = DatabaseFunctions.SelectData(null, "Datarev");
            name_DropDownList.DataBind();


            ListItem litem = new ListItem("-- اختر مراجع البيانات --", "0");
            litem.Selected = true;
            name_DropDownList.Items.Insert(0, litem);
            fill_data();
            ViewReport.Visible = true;
            

        }

    }

    public void fill_data()
    {
    
    }
    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {
    }


    protected void ViewReport_Click(object sender, EventArgs e)
    {

        ReportViewer1.ShowCredentialPrompts = false;

        //ReportViewer1.ServerReport.ReportServerCredentials = new ReportCredentials("Administrator", "P@ssw0rd", "hhi");

        
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "";

        reportPath = "/Azhar_report/Report3_statistics_data_QA";

        parameters.Add(new ReportParameter("Name", name_DropDownList.Text));
        parameters.Add(new ReportParameter("StartingDate", Date_From.Text));
        parameters.Add(new ReportParameter("EndDate", Date_To.Text));

        ReportViewer1.ServerReport.ReportPath = reportPath;

        ReportViewer1.ServerReport.SetParameters(parameters);

        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        //ReportViewer1.ProcessingMode = ProcessingMode.Local;

        ReportViewer1.ShowParameterPrompts = false;

        ReportViewer1.ShowPromptAreaButton = false;

        ReportViewer1.ServerReport.Refresh();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}