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
            case "2":
                SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", setvalue), 
                                                                  new SqlParameter("@user_id", "1"),
                                                                  new SqlParameter("@lang_id","1")};

                Smrt_Srch_object.stored = "get_events_titles";
                Smrt_Srch_object.stored_parameters = sqlParams2;
                break;
            case "3":
                SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id","1"),
                                                                 new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_topics_titles";
                Smrt_Srch_object.stored_parameters = sqlParams3;
                break;
            case "4":
                SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", "1"),
                                                                new SqlParameter("@lang_id", "1")};

                Smrt_Srch_object.stored = "get_places_titles";
                Smrt_Srch_object.stored_parameters = sqlParams4;
                break;
            case "5":
                SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", "1"),
                                                               new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_artifacts_titles";
                Smrt_Srch_object.stored_parameters = sqlParams5;
                break;
            case "6":
                SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id","1"),
                                                                 new SqlParameter("@lang_id","1")};
                Smrt_Srch_object.stored = "get_video_titles";
                Smrt_Srch_object.stored_parameters = sqlParams6;
                break;
            case "7":
                SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id","1"),
                                                          new SqlParameter("@lang_id","1")};
                Smrt_Srch_object.stored = "get_audio_titles";
                Smrt_Srch_object.stored_parameters = sqlParams7;
                break;
            case "8":
                SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id","1"),
                     new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_docs_titles";
                Smrt_Srch_object.stored_parameters = sqlParams8;
                break;
            case "9":
                SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", "1"),
                     new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_articles_titles";
                Smrt_Srch_object.stored_parameters = sqlParams9;
                break;
            case "10":
                SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", "1"),
                     new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_books_titles";
                Smrt_Srch_object.stored_parameters = sqlParams10;
                break;
            case "11":
                SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", "1"),
                     new SqlParameter("@lang_id","1")};
                Smrt_Srch_object.stored = "get_images_titles";
                Smrt_Srch_object.stored_parameters = sqlParams11;
                break;
            case "12":
                SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", "1")
                    , new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_manuscripts_titles";
                Smrt_Srch_object.stored_parameters = sqlParams12;
                break;

            case "13":
                SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", "1")
                     ,new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_theses_titles";
                Smrt_Srch_object.stored_parameters = sqlParams13;
                break;
            case "14":
                SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", "1"),
                                                                new SqlParameter("@lang_id", "1")};
                Smrt_Srch_object.stored = "get_conference_proceedings_titles";
                Smrt_Srch_object.stored_parameters = sqlParams14;
                break;
            case "15":

                SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", ""), new SqlParameter("@selview",setvalue) , 
                        new SqlParameter("@user_id", "1"),
                                                                new SqlParameter("@lang_id", "1")};
                //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                Smrt_Srch_object.stored = "get_website_titles";
                Smrt_Srch_object.stored_parameters = sqlParams15;
                break;


            case "16":

                SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@glossary_name", ""), new SqlParameter("@selview",setvalue) , 
                        new SqlParameter("@user_id", "1"),
                                                                new SqlParameter("@lang_id","1")};
                //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                Smrt_Srch_object.stored = "get_glossary_titles";
                Smrt_Srch_object.stored_parameters = sqlParams16;
                break;
        }

        Smrt_Srch_object.Value_Field = "id";
        Smrt_Srch_object.Text_Field = "title";
        Smrt_Srch_object.DataBind();


    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // meeting comment 22-10-2012

        if (!IsPostBack)
        {

            Smrt_Srch_object.Clear_Controls();



            // MOnMember_Data(object_type.SelectedValue);
            Fill_smart("1");

            
            //ViewReport.Visible = false;

        }




    }

    

    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    

    protected void ViewReport_Click(object sender, EventArgs e)
    {
        //   ReportViewer1.ShowCredentialPrompts = false;

        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "";

       
                    reportPath = "/Azhar_report/important_activities_live";
                    ReportViewer1.ServerReport.ReportPath = reportPath;
                    string selectedVal = Smrt_Srch_object.SelectedValue;
                    if (selectedVal.Trim() == "" || Convert.ToInt32(selectedVal) <= 0)
                    { selectedVal = "0"; }
                    ReportParameter param = (new ReportParameter("id", selectedVal));
                    parameters.Add(param);
                    ReportViewer1.ServerReport.SetParameters(parameters);
                    ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                    //ReportViewer1.ProcessingMode = ProcessingMode.Local;
                    ReportViewer1.ShowParameterPrompts = false;
                    ReportViewer1.ShowPromptAreaButton = false;
                    ReportViewer1.ServerReport.Refresh();
                  
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        //ReportViewer1.ProcessingMode = ProcessingMode.Local;
        ReportViewer1.ShowParameterPrompts = false;
        ReportViewer1.ShowPromptAreaButton = false;
        ReportViewer1.ServerReport.Refresh();
    }    


}