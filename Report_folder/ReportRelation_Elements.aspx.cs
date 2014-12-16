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

public partial class Reports_ReportRelation_Elements : System.Web.UI.Page
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
            switch (object_type.SelectedValue)
            {
                case "1":
                    obj_table = "characters";
                    break;
                case "2":
                    obj_table = "events";
                    break;
                case "3":
                    obj_table = "topics";
                    break;
                case "4":
                    obj_table = "places";
                    break;
                //case "5":
                //    obj_table = "artifacts";
                //    break;
                //case "6":
                //    obj_table = "content_media";
                //    break;
                //case "7":
                //    obj_table = "content_media";
                //    break;
                //case "8":
                //    obj_table = "documents";
                //    break;
                //case "9":
                //    obj_table = "documents";
                //    break;
                //case "10":
                //    obj_table = "documents";
                //    break;
                //case "11":
                //    obj_table = "content_images";
                //    break;
                //case "12":
                //    obj_table = "manuscripts";
                //    break;
                //case "13":
                //    obj_table = "theses";
                //    break;
                //case "14":
                //    obj_table = "conference_proceedings";
                //    break;
                //case "15":
                //    obj_table = "WebSites_Template";
                //    break;
                //case "16":
                //    obj_table = "conferences";
                //    break;

                //case "16":
                //    obj_table = "glossary";
                //    break;
            }
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
            //case "5":
            //    SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", setvalue), 
            //                                                    new SqlParameter("@user_id", "1"),
            //                                                   new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_artifacts_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams5;
            //    break;
            //case "6":
            //    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", setvalue), 
            //                                                    new SqlParameter("@user_id","1"),
            //                                                     new SqlParameter("@lang_id","1")};
            //    Smrt_Srch_object.stored = "get_video_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams6;
            //    break;
            //case "7":
            //    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
            //                                                    new SqlParameter("@user_id","1"),
            //                                              new SqlParameter("@lang_id","1")};
            //    Smrt_Srch_object.stored = "get_audio_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams7;
            //    break;
            //case "8":
            //    SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", setvalue) , 
            //                                                    new SqlParameter("@user_id","1"),
            //         new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_docs_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams8;
            //    break;
            //case "9":
            //    SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", setvalue) , 
            //                                                    new SqlParameter("@user_id", "1"),
            //         new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_articles_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams9;
            //    break;
            //case "10":
            //    SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", setvalue) , 
            //                                                    new SqlParameter("@user_id", "1"),
            //         new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_books_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams10;
            //    break;
            //case "11":
            //    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview",setvalue) , 
            //                                                    new SqlParameter("@user_id", "1"),
            //         new SqlParameter("@lang_id","1")};
            //    Smrt_Srch_object.stored = "get_images_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams11;
            //    break;
            //case "12":
            //    SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview",setvalue) , 
            //                                                    new SqlParameter("@user_id", "1")
            //        , new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_manuscripts_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams12;
            //    break;

            //case "13":
            //    SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview",setvalue) , 
            //                                                    new SqlParameter("@user_id", "1")
            //         ,new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_theses_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams13;
            //    break;
            //case "14":
            //    SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview",setvalue) , 
            //                                                    new SqlParameter("@user_id", "1"),
            //                                                    new SqlParameter("@lang_id", "1")};
            //    Smrt_Srch_object.stored = "get_conference_proceedings_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams14;
            //    break;
            //case "15":

            //    SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", ""), new SqlParameter("@selview",setvalue) , 
            //            new SqlParameter("@user_id", "1"),
            //                                                    new SqlParameter("@lang_id", "1")};
            //    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
            //    Smrt_Srch_object.stored = "get_website_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams15;
            //    break;


            //case "16":

            //    SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@glossary_name", ""), new SqlParameter("@selview",setvalue) , 
            //            new SqlParameter("@user_id", "1"),
            //                                                    new SqlParameter("@lang_id","1")};
            //    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
            //    Smrt_Srch_object.stored = "get_glossary_titles";
            //    Smrt_Srch_object.stored_parameters = sqlParams16;
            //    break;
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

            fill_data();
            ViewReport.Visible = false;

        }

    }

    public void fill_data()
    {

        DataTable objectsDT = content_types_DB.SelectAll();
        object_type2.DataSource = content_types_DB.SelectAll();
        object_type2.DataBind();

        int counter = objectsDT.Rows.Count;

        SqlParameter[] newSqlParams = new SqlParameter[] { };
        DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_final_entryform_report");
        int counterS = newDT.Rows.Count;
        if (newDT.Rows.Count > 0)
        {
            for (int count = 0; count < counter; count++)
            {
                DataRow[] foundRows;
                foundRows = newDT.Select("ctype = '" + object_type.Items[count].Value + "'");
                if (foundRows.Length == 0 && object_type2.Items[count].Value != "0")
                    objectsDT.Rows[count].Delete();
            }
        }

        //object_type.DataSource = objectsDT;
        //object_type.DataBind();
        ListItem litem = new ListItem("-- اختر العنصر الرئيسي --", "0");
        litem.Selected = true;
        object_type.Items.Insert(0, litem);


    }



    ////////////////////////////////////////////////////////////////////////////////////



    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {

        Smrt_Srch_object.Clear_Controls();
        Fill_smart(object_type.SelectedValue);

        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0)
        { Label23.Text = "_" + object_type.SelectedValue; }
        else { Label23.Visible = false; }
    }


    protected void ViewReport_Click(object sender, EventArgs e)
    {
        //   ReportViewer1.ShowCredentialPrompts = false;

        //   ReportViewer1.ServerReport.ReportServerCredentials = new ReportCredentials("Administrator", "P@ssw0rd", "hhi");

        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
       
        List<ReportParameter> parameters = new List<ReportParameter>();
        string reportPath = "";

        // switch (object_type.SelectedValue)
        //{
        //case "1":
        // {
        //characteristics
        //Report Path
        // reportPath = "/type_personality/type_personality";
        //objectId
        //   parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
        //            //LangID
        //  parameters.Add(new ReportParameter("lang_id", "1"));
        //  reportPath = "/important_achievement/important_achievement";

        if (object_type2.SelectedValue != "0")
        {
            reportPath = "/Azhar_report/ReportRelation_Elements";
            ReportViewer1.ServerReport.ReportPath = reportPath;
            string selectedVal = Smrt_Srch_object.SelectedValue;
            if (selectedVal.Trim() == "" || Convert.ToInt32(selectedVal) <= 0)
            { selectedVal = "0"; }

            parameters.Add(new ReportParameter("content_type_id1", object_type.SelectedValue));
            
            parameters.Add(new ReportParameter("content_type_id2", object_type2.SelectedValue));
            parameters.Add(new ReportParameter("element_id", Smrt_Srch_object.SelectedValue));

            ReportViewer1.ServerReport.SetParameters(parameters);
            ReportViewer1.ProcessingMode = ProcessingMode.Remote;
            //ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.ShowParameterPrompts = false;
            ReportViewer1.ShowPromptAreaButton = false;
            ReportViewer1.ServerReport.Refresh();
        }
        // break;
        //}
        //case "2":
        //    {
        //        //events
        //        //Report Path
        //        reportPath = "/AzharReport/Events_Report";
        //        //content Type   

        //        //objectId
        //        parameters.Add(new ReportParameter("event_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));

        //        break;
        //    }
        //case "3":
        //    {
        //        //topics
        //        //Report Path
        //        reportPath = "/AzharReport/Topic";

        //        //objectId
        //        parameters.Add(new ReportParameter("topic_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));

        //        break;
        //    }
        //case "4":
        //    {
        //        //places
        //        //Report Path
        //        reportPath = "/AzharReport/places";

        //        //objectId
        //        parameters.Add(new ReportParameter("place_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "5":
        //    {
        //        //artifacts
        //        //Report Path
        //        reportPath = "/AzharReport/Artifacts";

        //        //objectId
        //        parameters.Add(new ReportParameter("artifact_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "6":
        //    {
        //        //vedio
        //        //Report Path
        //        reportPath = "/AzharReport/Audio_Vedio_Report";
        //        //content Type   
        //        parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
        //        //objectId
        //        parameters.Add(new ReportParameter("video_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "7":
        //    {
        //        //audio
        //        //Report Path
        //        reportPath = "/AzharReport/Audio_Vedio_Report";
        //        //content Type   
        //        parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
        //        //objectId
        //        parameters.Add(new ReportParameter("video_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "8":
        //    {
        //        //docs
        //        //Report Path
        //        reportPath = "/AzharReport/Doc_Report";

        //        //objectId
        //        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "9":
        //    {
        //        //articles
        //        //Report Path
        //        reportPath = "/AzharReport/Articls";


        //        //objectId
        //        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "10":
        //    {
        //        //books
        //        //Report Path
        //        reportPath = "/AzharReport/Book_Report";
        //        //content Type   
        //        // parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));

        //        //objectId
        //        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "11":
        //    {
        //        //images
        //        reportPath = "/AzharReport/photo";
        //        //content Type   
        //        // parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
        //        //objectId
        //        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "12":
        //    {
        //        //manuscripts
        //        //Report Path
        //        reportPath = "/AzharReport/Manuscripts";

        //        //objectId
        //        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));

        //        parameters.Add(new ReportParameter("manuscript_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }

        //case "13":
        //    {
        //        //theses
        //        //Report Path
        //        reportPath = "/AzharReport/Theses_Report";

        //        //objectId
        //        parameters.Add(new ReportParameter("these_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "14":
        //    {
        //        //conference

        //        //Report Path
        //        reportPath = "/AzharReport/Conference_Report";

        //        //objectId
        //        parameters.Add(new ReportParameter("conf_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }
        //case "15":
        //    {
        //        //website
        //        //Report Path
        //        reportPath = "/AzharReport/WebSite_Report";

        //        //objectId
        //        parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }


        //case "16":
        //    {
        //        //glossary
        //        reportPath = "/AzharReport/Glossary";

        //        //objectId
        //        parameters.Add(new ReportParameter("glossary_id", Smrt_Srch_object.SelectedValue));
        //        //LangID
        //        parameters.Add(new ReportParameter("lang_id", "1"));
        //        break;
        //    }



        ReportViewer1.ServerReport.ReportPath = reportPath;
        // ReportViewer1.ServerReport.SetParameters(parameters);

        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        //ReportViewer1.ProcessingMode = ProcessingMode.Local;

        ReportViewer1.ShowParameterPrompts = false;

        ReportViewer1.ShowPromptAreaButton = false;

        ReportViewer1.ServerReport.Refresh();
    }
}
