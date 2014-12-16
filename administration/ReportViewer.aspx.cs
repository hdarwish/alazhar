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
using System.IO;
using System.Xml;
using Microsoft.Reporting;


public partial class administration_entry_form : BasePage
{
    public static string id = "";
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    // static int smartvalue = 0;
    protected override void OnInit(EventArgs e)
    {
        dont_show_button();
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
                case "5":
                    obj_table = "artifacts";
                    break;
                case "6":
                    obj_table = "content_media";
                    break;
                case "7":
                    obj_table = "content_media";
                    break;
                case "8":
                    obj_table = "documents";
                    break;
                case "9":
                    obj_table = "documents";
                    break;
                case "10":
                    obj_table = "documents";
                    break;
                case "11":
                    obj_table = "content_images";
                    break;
                case "12":
                    obj_table = "manuscripts";
                    break;
                case "13":
                    obj_table = "theses";
                    break;
                case "14":
                    obj_table = "conference_proceedings";
                    break;
                case "15":
                    obj_table = "WebSites_Template";
                    break;
                //case "16":
                //    obj_table = "conferences";
                //    break;

                case "16":
                    obj_table = "glossary";
                    break;
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
        if (Value == "0")
        {
            Smrt_Srch_object.Visible = false;
            //ViewReport.Visible = true;
            return;
        }
        else
        {
            Smrt_Srch_object.Visible = true;
            // ViewReport.Visible = false;
        }

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
            dont_show_button();
            fill_data();
            ViewReport.Visible = false;

        }




    }

    public void fill_data()
    {

        DataTable objectsDT = content_types_DB.SelectAll();
        object_type.DataSource = content_types_DB.SelectAll();
        object_type.DataBind();


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
                if (foundRows.Length == 0 && object_type.Items[count].Value != "0")
                    objectsDT.Rows[count].Delete();
            }
        }

        object_type.DataSource = objectsDT;
        object_type.DataBind();
        ListItem litem = new ListItem("-- اختر نوع الاستمارة --", "-1");
        litem.Selected = true;
        object_type.Items.Insert(0, litem);
        ListItem alllistitem = new ListItem("++ عرض كل تقارير الترجمة لــ ++", "0");

        object_type.Items.Insert(1, alllistitem);

        object_type1.DataSource = objectsDT;
        object_type1.DataBind();
        ListItem litem1 = new ListItem("-- اختر نوع الاستمارة --", "-1");
        litem.Selected = true;
        object_type1.Items.Insert(0, litem1);

    }



    ////////////////////////////////////////////////////////////////////////////////////



    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void object_type1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (object_type1.SelectedValue == "-1")
        {

            ViewReport.Visible = false;
            return;
        }
        else
        {
            show_button();
            ViewReport.Visible = true;
            Smrt_Srch_object.Visible = false;
            // ViewReport.Visible = false;





            // MOnMember_Data(object_type.SelectedValue);

        }
        Label3.Visible =
        Label23.Visible = false;
        //if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0)
        //{ Label23.Text = "_" + object_type.SelectedValue; }
        //else { Label23.Visible = false; }
    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (Smrt_Srch_object.SelectedValue != "")
        dont_show_button();
        if (object_type.SelectedValue == "0")
        {
            Smrt_Srch_object.Visible = false;
            object_type1.Visible = true;
            //ViewReport.Visible = true;
            return;
        }
        else
        {
            Smrt_Srch_object.Visible = true;
            // ViewReport.Visible = false;
            object_type1.Visible = false;
            Smrt_Srch_object.Clear_Controls();



            // MOnMember_Data(object_type.SelectedValue);
            Fill_smart(object_type.SelectedValue);
        }


        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0)
        { Label23.Text = "_" + object_type.SelectedValue; }
        else { Label23.Visible = false; }
    }


    protected void ViewReport_Click(object sender, EventArgs e)
    {
        ReportViewer1.ShowCredentialPrompts = false;
        ReportViewer1.ServerReport.ReportServerCredentials = new ReportCredentials("Administrator", "P@ssw0rd", "hhi");
        ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["reportserveruri"].ToString());
        List<ReportParameter> parameters = new List<ReportParameter>();

        string reportPath = "";

        switch (object_type.SelectedValue)
        {
            case "0":
                {
                    switch (object_type1.SelectedValue)
                    {
                        case "1":
                            {
                                //characters
                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT characters_details.char_id, characters_details.name, characters_details.titles, characters_details.other_names, characters_details.char_brief,characters_details.char_details, characters_details.scientific_life, characters_details.mashyakha_azhar, characters_details.birth_details,characters_details.birth_date, characters_details.death_date, characters_details.working_life, characters_details.activities, characters_details.hbirth_date,characters_details.hdeath_date, characters_details.keywords, characters_details.notes, characters_details.written_about, characters_details.lang_id,awsema_details.details AS details1 FROM    characters left  JOIN characters_details ON characters.id = characters_details.char_id left outer JOIN  awsema_details ON characters_details.char_id = awsema_details.char_id WHERE (characters.form_status=12) and (characters_details.lang_id =1) AND (awsema_details.lang_id = 1) and (characters.form_export != 1) AND (characters.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by characters_details.char_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //characters
                                        //Report Path
                                        reportPath = "/Azhar_report/characters_report";

                                        //objectId
                                        parameters.Add(new ReportParameter("id", dt.Rows[i]["char_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\charachters\\1_" + dt.Rows[i]["char_id"].ToString() + ".doc");
                                        element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["char_id"].ToString()));

                                    }
                                }
                                break;
                            }
                        case "2":
                            {
                                //events
                                show_button();

                                DataTable dt = General_Helping.GetDataTable("select events_details.*,events.start_date,events.end_date,events.large_image FROM events INNER JOIN events_details ON events.id = events_details.event_id WHERE (events.form_status=12) and (events_details.lang_id = 1) AND (events.form_export != 1) AND(events.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by events_details.event_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //events
                                        //Report Path
                                        reportPath = "/Azhar_report/Events_Report";
                                        //content Type   

                                        //objectId
                                        parameters.Add(new ReportParameter("event_id", dt.Rows[i]["event_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\events\\2_" + dt.Rows[i]["event_id"].ToString() + ".doc");
                                        element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["event_id"].ToString()));

                                    }
                                }
                                break;
                            }
                        case "3":
                            {
                                //topics
                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT topics_details.*,topics.large_image FROM topics INNER JOIN topics_details ON topics.id = topics_details.topic_id WHERE (topics.form_status=12) and (topics_details.lang_id = 1) AND (form_export != 1) AND (topics.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by topics_details.topic_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //topics
                                        //Report Path
                                        reportPath = "/Azhar_report/Topics";

                                        //objectId
                                        parameters.Add(new ReportParameter("topic_id", dt.Rows[i]["topic_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\topics\\3_" + dt.Rows[i]["topic_id"].ToString() + ".doc");
                                        //form_export  
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["topic_id"].ToString()));
                                        }
                                        catch { };
                                    }


                                }
                                break;
                            }
                        case "4":
                            {
                                //places
                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT places_details.*,name as title FROM  places INNER JOIN places_details ON places.id = places_details.place_id WHERE  (places.form_status=12) and (places_details.lang_id = 1) AND (places.form_export != 1) AND (places.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by places_details.place_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //places
                                        //Report Path
                                        reportPath = "/Azhar_report/places";

                                        //objectId
                                        parameters.Add(new ReportParameter("place_id", dt.Rows[i]["place_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\places\\4_" + dt.Rows[i]["place_id"].ToString() + ".doc");
                                        element_exported(object_type1.SelectedValue,CDataConverter.ConvertToInt(dt.Rows[i]["place_id"].ToString()));
                                    }
                                   
                                }

                                break;
                            }
                        case "5":
                            {
                                //artifacts

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT artifacts_details.* FROM artifacts INNER JOIN artifacts_details ON artifacts.id = artifacts_details.artifact_id WHERE  (artifacts.form_status=12) and  (artifacts_details.lang_id = 1) AND (artifacts.form_export != 1) AND (artifacts.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by artifacts_details.artifact_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //artifacts
                                        //Report Path
                                        reportPath = "/Azhar_report/Artifacts";

                                        //objectId
                                        parameters.Add(new ReportParameter("artifact_id", dt.Rows[i]["artifact_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\artifacts\\5_" + dt.Rows[i]["artifact_id"].ToString() + ".doc");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["artifact_id"].ToString()));
                                        }
                                        catch { };
                                      }
                                   
                                }
                                break;
                            }
                        case "6":
                            {
                                //vedio
                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT  content_media_details.*  FROM content_media INNER JOIN content_media_details ON content_media.id = content_media_details.content_media_id WHERE (content_media_details.lang_id = 1) AND (content_media.form_status=12) AND (content_media.content_media_type = 6) and  (content_media.form_export !=1) and (content_media.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by content_media.id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //vedio
                                        //Report Path
                                        reportPath = "/Azhar_report/vedio_Report";

                                        //content Type   
                                        parameters.Add(new ReportParameter("content_media_type", "6"));
                                        //objectId
                                        parameters.Add(new ReportParameter("video_id", dt.Rows[i]["content_media_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\vedio\\6_" + dt.Rows[i]["content_media_id"].ToString() + ".doc");
                                        element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["content_media_id"].ToString()));
                                    }
                                  

                                }
                                break;
                            }
                        case "7":
                            {
                                //audio
                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT  content_media_details.*  FROM content_media INNER JOIN content_media_details ON content_media.id = content_media_details.content_media_id WHERE (content_media_details.lang_id = 1) AND (content_media.form_status=12) AND (content_media.content_media_type = 7) and form_export != 1 and (content_media.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " and " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by content_media.id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //audio
                                        //Report Path
                                        reportPath = "/Azhar_report/Audio_Report";

                                        //content Type   
                                        parameters.Add(new ReportParameter("content_media_type", "7"));
                                        //objectId
                                        parameters.Add(new ReportParameter("video_id", dt.Rows[i]["content_media_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\audio\\7_" + dt.Rows[i]["content_media_id"].ToString() + ".doc");
                                        element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["content_media_id"].ToString()));
                                    }
                                    
                                }
                                break;
                            }
                        case "8":
                            {
                                //docs
                                //Report Path

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT documents.*,documents_details.doc_id,documents_details.title,documents_details.brief,documents_details.publish_location,documents_details.resource,documents_details.request_id,documents_details.direct_subject,documents_details.lang_id,documents_details.notes,documents_details.docs_type,documents_details.material_type,documents_details.material_shape,documents_details.doc_lang,documents_details.series_no,documents_details.series,documents_details.other_doc_lang,documents_details.keywords,documents_details.organization_save,documents_details.country_name,documents_details.save_no,documents_details.city,documents_details.save_notes,documents_details.docs_other_type,documents_details.docs_sum,documents_details.docs_other_shape,documents_details.save_public_no,documents_details.art_no,documents_details.library_no,documents_details.save_specifics_no,documents_details.title_type_id,documents_details.form_pic_state,documents_details.data_collector_name,documents_details.data_revision_name,documents_details.FromTitle,documents_details.FromHeader,documents_details.FromDocumented FROM   documents INNER JOIN documents_details ON documents.id = documents_details.doc_id WHERE (documents.doc_type=3) and   (documents.form_status=12) and (documents_details.lang_id =1) AND (documents.form_export != 1)  AND (documents.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by documents_details.doc_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //docs
                                        //Report Path
                                        reportPath = "/Azhar_report/Doc_Report";

                                        //objectId
                                        parameters.Add(new ReportParameter("docs_id", dt.Rows[i]["doc_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\document\\8_" + dt.Rows[i]["doc_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["doc_id"].ToString()));
                                        }
                                        catch { };
                                        }

                                  
                                }


                                break;
                            }
                        case "9":
                            {
                                //Article

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT documents.*,documents_details.doc_id,documents_details.title,documents_details.brief,documents_details.publish_location,documents_details.resource,documents_details.request_id,documents_details.direct_subject,documents_details.lang_id,documents_details.notes,documents_details.docs_type,documents_details.material_type,documents_details.material_shape,documents_details.doc_lang,documents_details.series_no,documents_details.series,documents_details.other_doc_lang,documents_details.keywords,documents_details.organization_save,documents_details.country_name,documents_details.save_no,documents_details.city,documents_details.save_notes,documents_details.docs_other_type,documents_details.docs_sum,documents_details.docs_other_shape,documents_details.save_public_no,documents_details.art_no,documents_details.library_no,documents_details.save_specifics_no,documents_details.title_type_id,documents_details.form_pic_state,documents_details.data_collector_name,documents_details.data_revision_name,documents_details.FromTitle,documents_details.FromHeader,documents_details.FromDocumented FROM   documents INNER JOIN documents_details ON documents.id = documents_details.doc_id WHERE (documents.doc_type=2) and  (documents.form_status=12) and (documents_details.lang_id =1)  AND (documents.form_export != 1)  AND (documents.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by documents_details.doc_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //articles
                                        //Report Path
                                        reportPath = "/Azhar_report/Articls";

                                        //objectId
                                        parameters.Add(new ReportParameter("id", dt.Rows[i]["doc_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\articles\\9_" + dt.Rows[i]["doc_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue,CDataConverter.ConvertToInt(dt.Rows[i]["doc_id"].ToString()));
                                        }
                                        catch { };
                                    }

                                }
                                break;
                            }
                        case "10":
                            {
                                //books

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT documents.*,documents_details.doc_id,documents_details.title,documents_details.brief,documents_details.publish_location,documents_details.resource,documents_details.request_id,documents_details.direct_subject,documents_details.lang_id,documents_details.notes,documents_details.docs_type,documents_details.material_type,documents_details.material_shape,documents_details.doc_lang,documents_details.series_no,documents_details.series,documents_details.other_doc_lang,documents_details.keywords,documents_details.organization_save,documents_details.country_name,documents_details.save_no,documents_details.city,documents_details.save_notes,documents_details.docs_other_type,documents_details.docs_sum,documents_details.docs_other_shape,documents_details.save_public_no,documents_details.art_no,documents_details.library_no,documents_details.save_specifics_no,documents_details.title_type_id,documents_details.form_pic_state,documents_details.data_collector_name,documents_details.data_revision_name,documents_details.FromTitle,documents_details.FromHeader,documents_details.FromDocumented FROM         documents INNER JOIN documents_details ON documents.id = documents_details.doc_id WHERE (documents.doc_type=1) and  (documents.form_status=12) and (documents_details.lang_id =1) AND (documents.form_export != 1)  AND (documents.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by documents_details.doc_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //books
                                        //Report Path
                                        reportPath = "/Azhar_report/Book_Report";

                                        //objectId
                                        parameters.Add(new ReportParameter("id", dt.Rows[i]["doc_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\books\\10_" + dt.Rows[i]["doc_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["doc_id"].ToString()));
                                        }
                                        catch { };
                                    }

                                }
                                break;
                            }
                        case "11":
                            {
                                //images

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT	* FROM content_images_details INNER JOIN  content_images on content_images.id=content_images_details.content_image_id WHERE (content_images.form_status=12) and (content_images_details.lang_id =1) and  (content_images.form_export != 1)  AND (content_images_details.content_image_id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by content_images_details.content_image_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //Report Path
                                        reportPath = "/Azhar_report/photo";

                                        //objectId
                                        parameters.Add(new ReportParameter("id", dt.Rows[i]["content_image_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\images\\11_" + dt.Rows[i]["content_image_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["content_image_id"].ToString()));
                                        }
                                        catch { };
                                    }

                                }
                                break;
                            }
                        case "12":
                            {
                                //manuscripts

                                show_button();
                              
                                DataTable dt = General_Helping.GetDataTable("SELECT manuscripts_details.* FROM  manuscripts_details INNER JOIN manuscripts ON manuscripts.id = manuscripts_details.manuscript_id WHERE (manuscripts.form_status=12) and (manuscripts_details.lang_id =1) AND  (manuscripts.form_export != 1) AND (manuscripts.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by manuscripts_details.manuscript_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //manuscripts
                                        //Report Path
                                        reportPath = "/Azhar_report/Manuscripts";

                                        //objectId
                                        parameters.Add(new ReportParameter("manuscript_id", dt.Rows[i]["manuscript_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\manuscript\\12_" + dt.Rows[i]["manuscript_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try {
                                        element_exported(object_type1.SelectedValue,CDataConverter.ConvertToInt(dt.Rows[i]["manuscript_id"].ToString()));
                                    }
                                    catch {};
                                    }

                                }
                                break;
                            }

                        case "13":
                            {
                                //theses

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT theses_details.* FROM theses INNER JOIN theses_details ON theses.id = theses_details.these_id WHERE (theses.form_status=12) and (theses_details.lang_id = 1) AND (WebSites_Template.form_export != 1) AND (theses.id BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by theses_details.these_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //theses
                                        //Report Path
                                        reportPath = "/Azhar_report/Theses_Report";

                                        //objectId
                                        parameters.Add(new ReportParameter("these_id", dt.Rows[i]["these_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\theses\\13_" + dt.Rows[i]["these_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["these_id"].ToString()));
                                        }
                                        catch { };
                                    }

                                }
                                break;
                            }
                        case "14":
                            {
                                //conference

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT conference_proceedings_details.* FROM conference_proceedings INNER JOIN conference_proceedings_details ON conference_proceedings.id = conference_proceedings_details.conference_proceeding_id WHERE   (conference_proceedings.form_status=12) and  (conference_proceedings_details.lang_id = 1) AND (conference_proceedings.form_export != 1)  AND (conference_proceedings.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by conference_proceedings_details.conference_proceeding_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //conference
                                        //Report Path
                                        reportPath = "/Azhar_report/Conference_Report";

                                        //objectId
                                        parameters.Add(new ReportParameter("conf_id", dt.Rows[i]["conference_proceeding_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\confrence proceding\\14_" + dt.Rows[i]["conference_proceeding_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                            element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["conference_proceeding_id"].ToString()));
                                        }
                                        catch { };
                                    }

                                   

                                }
                                break;
                            }
                        case "15":
                            {
                                //website


                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT WebSites_Template_details.* FROM WebSites_Template INNER JOIN WebSites_Template_details ON WebSites_Template.id = WebSites_Template_details.website_id WHERE (WebSites_Template.form_status=12) and (WebSites_Template_details.lang_id = 1) AND (WebSites_Template.form_export != 1) AND (WebSites_Template.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by WebSites_Template_details.website_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //website
                                        //Report Path
                                        reportPath = "/Azhar_report/Book_Report";

                                        //objectId
                                        parameters.Add(new ReportParameter("id", dt.Rows[i]["website_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\websits\\15_" + dt.Rows[i]["website_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                           element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["website_id"].ToString()));
                                        }
                                        catch { };
                                    }
                                   

                                }
                                break;
                            }


                        case "16":
                            {
                                //glossary

                                show_button();
                                DataTable dt = General_Helping.GetDataTable("SELECT glossary_details.* FROM  glossary INNER JOIN glossary_details ON glossary.id = glossary_details.glossary_id WHERE (glossary.form_status=12) and (glossary_details.lang_id =1) AND  (glossary.form_export != 1) AND (glossary.id  BETWEEN " + CDataConverter.ConvertToInt(txtfrom.Text) + " AND " + CDataConverter.ConvertToInt(txtto.Text) + ")" + " order by glossary_details.glossary_id desc");
                                if (dt.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dt.Rows.Count; i++, parameters.Clear())
                                    {
                                        //glossary
                                        //Report Path
                                        reportPath = "/Azhar_report/Glossary";

                                        //objectId
                                        parameters.Add(new ReportParameter("glossary_id", dt.Rows[i]["glossary_id"].ToString()));
                                        //LangID
                                        parameters.Add(new ReportParameter("lang_id", "1"));

                                        ReportViewer1.ServerReport.ReportPath = reportPath;
                                        ReportViewer1.ServerReport.SetParameters(parameters);

                                        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
                                        //ReportViewer1.ProcessingMode = ProcessingMode.Local;


                                        ReportViewer1.ShowParameterPrompts = false;

                                        ReportViewer1.ShowPromptAreaButton = false;
                                        string mimeType = "application/doc";
                                        string encoding = "";

                                        string format = "Word";
                                        string devinfo = "";
                                        Warning[] warnings = null;
                                        string[] result;
                                        byte[] fileByte;
                                        fileByte = ReportViewer1.ServerReport.Render(format, devinfo, out mimeType, out encoding, out format, out result, out warnings);
                                        WriteFile(fileByte, "D:\\azhar\\translation\\glossary\\16_" + dt.Rows[i]["glossary_id"].ToString() + ".doc");    //Server.MapPath("~/path/blahblah/");
                                        try
                                        {
                                          element_exported(object_type1.SelectedValue, CDataConverter.ConvertToInt(dt.Rows[i]["glossary_id"].ToString()));
                                        }
                                        catch { };
                                    }
                                   

                                }
                                break;

                            }
                    }
                    break;
                }

            case "1":
                {
                    //characteristics
                    //Report Path
                    reportPath = "/Azhar_report/characters_report";

                    //objectId
                    parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));

                    break;
                }
            case "2":
                {
                    //events
                    //Report Path
                    reportPath = "/Azhar_report/Events_Report";
                    //content Type   

                    //objectId
                    parameters.Add(new ReportParameter("event_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));

                    break;
                }
            case "3":
                {
                    //topics
                    //Report Path
                    reportPath = "/Azhar_report/Topics";

                    //objectId
                    parameters.Add(new ReportParameter("topic_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));

                    break;
                }
            case "4":
                {
                    //places
                    //Report Path
                    reportPath = "/Azhar_report/places";

                    //objectId
                    parameters.Add(new ReportParameter("place_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "5":
                {
                    //artifacts
                    //Report Path
                    reportPath = "/Azhar_report/Artifacts";

                    //objectId
                    parameters.Add(new ReportParameter("artifact_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "6":
                {
                    //vedio
                    //Report Path
                    reportPath = "/Azhar_report/Audio_Vedio_Report";
                    //content Type   
                    parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
                    //objectId
                    parameters.Add(new ReportParameter("video_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "7":
                {
                    //audio
                    //Report Path
                    reportPath = "/Azhar_report/Audio_Vedio_Report";
                    //content Type   
                    parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
                    //objectId
                    parameters.Add(new ReportParameter("video_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "8":
                {
                    //docs
                    //Report Path
                    reportPath = "/Azhar_report/Doc_Report";

                    //objectId
                    parameters.Add(new ReportParameter("docs_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "9":
                {
                    //articles
                    //Report Path
                    reportPath = "/Azhar_report/Articls";


                    //objectId
                    parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "10":
                {
                    //books
                    //Report Path
                    reportPath = "/Azhar_report/Book_Report";
                    //content Type   
                    // parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
                    //objectId
                    parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "11":
                {
                    //images
                    reportPath = "/Azhar_report/photo";
                    //content Type   
                    // parameters.Add(new ReportParameter("content_media_type", object_type.SelectedValue));
                    //objectId
                    parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "12":
                {
                    //manuscripts
                    //Report Path
                    reportPath = "/Azhar_report/Manuscripts";

                    //objectId
                    parameters.Add(new ReportParameter("manuscript_id", Smrt_Srch_object.SelectedValue));

                    //parameters.Add(new ReportParameter("manuscript_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }

            case "13":
                {
                    //theses
                    //Report Path
                    reportPath = "/Azhar_report/Theses_Report";

                    //objectId
                    parameters.Add(new ReportParameter("these_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "14":
                {
                    //conference

                    //Report Path
                    reportPath = "/Azhar_report/Conference_Report";

                    //objectId
                    parameters.Add(new ReportParameter("conf_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
            case "15":
                {
                    //website
                    //Report Path
                    reportPath = "/Azhar_report/WebSite_Report";

                    //objectId
                    parameters.Add(new ReportParameter("id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }


            case "16":
                {
                    //glossary
                    reportPath = "/Azhar_report/Glossary";

                    //objectId
                    parameters.Add(new ReportParameter("glossary_id", Smrt_Srch_object.SelectedValue));
                    //LangID
                    parameters.Add(new ReportParameter("lang_id", "1"));
                    break;
                }
        }


        ReportViewer1.ServerReport.ReportPath = reportPath;
        ReportViewer1.ServerReport.SetParameters(parameters);
        ReportViewer1.ProcessingMode = ProcessingMode.Remote;
        ReportViewer1.ShowParameterPrompts = false;
        ReportViewer1.ShowPromptAreaButton = false;
        ReportViewer1.ServerReport.Refresh();

    }




    private static void WriteFile(byte[] input, string FileName)
    {
        //Open a file stream and write out the report
        FileStream stream = File.OpenWrite(FileName);
        stream.Write(input, 0, input.Length);
        stream.Close();
    }
    void show_button()
    {
        lblto.Visible = true;
        txtto.Visible = true;
        lblfrom.Visible = true;
        txtfrom.Visible = true;

    }
    void dont_show_button()
    {
        lblto.Visible = false;
        txtto.Visible = false;
        lblfrom.Visible = false;
        txtfrom.Visible = false;

    }

    protected void element_exported(string type, int element_id)
    {
        SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@content_type", type) ,
        new SqlParameter("@id", element_id)};
        int row = DatabaseFunctions.UpdateData(newSqlParams, "Proce_Element_export");
    }
}