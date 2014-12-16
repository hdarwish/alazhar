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
    public static string id = "";
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    // static int smartvalue = 0;
    protected override void OnInit(EventArgs e)
    {

        this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);

    }

    private void MOnMember_Data(string Value)
    {
        id = Smrt_Srch_object.SelectedValue;
        if (Smrt_Srch_object.SelectedValue != "")
        {
            //id = Smrt_Srch_object.SelectedValue;


            //tr_lock.Visible = false;
            //if (Request["operation"].ToString() == "wrong")
            //{

            //    fillgrid();

            //}

            string obj_table = "";

            string sql = "";
            if (menus_update.get_current_lang() == 1)
            {
                sql = "select form_lock from " + obj_table + " where form_lock= " + Session["user_id"].ToString();
                sql += " and id=" + Smrt_Srch_object.SelectedValue;
            }
            if (menus_update.get_current_lang() == 2)
            {
                sql = "select form_lock_en from " + obj_table + " where form_lock_en = " + Session["user_id"].ToString();
                sql += " and id=" + Smrt_Srch_object.SelectedValue;
            }
            if (menus_update.get_current_lang() == 3)
            {
                sql = "select form_lock_fr from " + obj_table + " where form_lock_fr = " + Session["user_id"].ToString();
                sql += " and id=" + Smrt_Srch_object.SelectedValue;
            }




        }
    }


    private void Fill_smart(string Value)
    {
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), 
                new SqlParameter("@selview", "50"), 

                                                                new SqlParameter("@user_id","1"),
                                                                new SqlParameter("@lang_id","1")};
            Smrt_Srch_object.stored = "get_characters_titles";
            Smrt_Srch_object.stored_parameters = sqlParams1;
            Smrt_Srch_object.Value_Field = "id";
            Smrt_Srch_object.Text_Field = "title";
            Smrt_Srch_object.DataBind();
        }
    }
    public void CallReport(string ReportPath, ReportParameter parameter)
    {
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
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
    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Smrt_Srch_object.SelectedValue == "")
            Smrt_Srch_object.SelectedValue = "0";
        ReportParameter pam = (new ReportParameter("id", Smrt_Srch_object.SelectedValue));

        string Path;
        Path = "/Azhar_report/featuresHonor";

        CallReport(Path, pam);

    }
}