using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class Reports_report : System.Web.UI.Page
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

            obj_table = "characters";

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

            ViewReport.Visible = true;


        }
    }


    private void Fill_smart(string Value)
    { //public void fill_objects_titles()
        //{
        string setvalue = "50";
        DataTable dt = new DataTable();

        switch (Value)
        {

            case "1":
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id","1"),
                                                                new SqlParameter("@lang_id","1")};
                Smrt_Srch_object.stored = "get_characters_titles";
                Smrt_Srch_object.stored_parameters = sqlParams1;
                break;
           
        }

        Smrt_Srch_object.Value_Field = "id";
        Smrt_Srch_object.Text_Field = "title";
        Smrt_Srch_object.DataBind();


    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Smrt_Srch_object.Clear_Controls();



            // MOnMember_Data(object_type.SelectedValue);
            Fill_smart("1");


            //ViewReport.Visible = false;

        }


    }
    
    
    protected void txt_Name_TextChanged(object sender, EventArgs e)
    {

      
        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "/Azhar_report/Report_WorkLife";
        if (Smrt_Srch_object.SelectedValue == "")
            Smrt_Srch_object.SelectedValue = "0";
        parameters.Add(new ReportParameter("id",  Smrt_Srch_object.SelectedValue));

        ReportViewer1.ServerReport.ReportPath = reportPath;
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;

        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;
        
    }

    protected void ViewReport_Click(object sender, EventArgs e)
    {
        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "/Azhar_report/Report_WorkLife";
        if (Smrt_Srch_object.SelectedValue == "")
            Smrt_Srch_object.SelectedValue = "0";
        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));

        ReportViewer1.ServerReport.ReportPath = reportPath;
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;

        ReportViewer1.ServerReport.Refresh();
        ReportViewer1.ShowParameterPrompts = false;
    }   
}