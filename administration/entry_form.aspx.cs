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
            if (Request["operation"].ToString() == "wrong")
            {

                fillgrid();

            }

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
            DataTable dt_lock = General_Helping.GetDataTable(sql);
            if (dt_lock.Rows.Count > 0)
            {
                CheckBox1.Enabled = false;
                CheckBox1.Checked = true;
                lockBtn.Enabled = false;
                if (id != "")
                {
                    load_control();
                }

            }
            else
            {

                tr_lock.Visible = true;
                CheckBox1.Enabled = true;
                CheckBox1.Checked = false;
                lockBtn.Enabled = true;
                TabContainer1.Visible = false;
                tr_finish.Visible = false;
            }


        }
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {

        if (Smrt_Srch_object.SelectedValue != "" && Smrt_Srch_object.SelectedValue != "--- البحث بالكود ----")
        {
            SqlParameter[] sqlParams = Smrt_Srch_object.stored_parameters;

            string stored_name = Smrt_Srch_object.stored;
            DataTable Dt = new DataTable();
            if (stored_name != "" && sqlParams.Length > 0)
            {
                Dt = DatabaseFunctions.SelectData(sqlParams, stored_name);
                if (Dt.Rows.Count > 0)
                {
                    for (int count = 0; count < Dt.Rows.Count; count++)
                    {
                        if (Smrt_Srch_object.SelectedValue == Dt.Rows[count]["id"].ToString())
                        {
                            tr_lock.Visible = true;
                            
                            return;
                        }
                    }
                    tr_lock.Visible = true;
                    CheckBox1.Enabled = false;
                    lockBtn.Enabled = false;
                    
                    
                }
            }
        }
    }

    private void Fill_smart(string Value)
    { //public void fill_objects_titles()
        //{
        string setvalue = "";
        DataTable dt = new DataTable();
        if (Request["operation"].ToString() == "new")
            setvalue = "20";
        if (Request["operation"].ToString() == "unfinished")
            setvalue = "21";
        if (Request["operation"].ToString() == "wrong")
            setvalue = "25";
        if (Value != "")
        {
            switch (Value)
            {

                case "1":
                    SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_characters_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams1;
                    break;
                case "2":
                    SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", setvalue), 
                                                                  new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                  new SqlParameter("@lang_id", menus_update.get_current_lang())};

                    Smrt_Srch_object.stored = "get_events_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams2;
                    break;
                case "3":
                    SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                 new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_topics_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams3;
                    break;
                case "4":
                    SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};

                    Smrt_Srch_object.stored = "get_places_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams4;
                    break;
                case "5":
                    SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                               new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_artifacts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams5;
                    break;
                case "6":
                    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                 new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_video_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams6;
                    break;
                case "7":
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                          new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_audio_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams7;
                    break;
                case "8":
                    SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                     new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_docs_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams8;
                    break;
                case "9":
                    SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                     new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_articles_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams9;
                    break;
                case "10":
                    SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                     new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_books_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams10;
                    break;
                case "11":
                    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                     new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_images_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams11;
                    break;
                case "12":
                    SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString())
                    , new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_manuscripts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams12;
                    break;

                case "13":
                    SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString())
                     ,new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_theses_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams13;
                    break;
                case "14":
                    SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_conference_proceedings_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams14;
                    break;
                case "15":

                    SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", ""), new SqlParameter("@selview",setvalue) , 
                        new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                    Smrt_Srch_object.stored = "get_website_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams15;
                    break;


                case "16":

                    SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@glossary_name", ""), new SqlParameter("@selview",setvalue) , 
                        new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                    Smrt_Srch_object.stored = "get_glossary_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams16;
                    break;
            }
        }

        Smrt_Srch_object.Value_Field = "id";
        Smrt_Srch_object.Text_Field = "title";
        Smrt_Srch_object.DataBind();


    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // meeting comment 22-10-2012
        if (chk_status.Checked == true)
        { Save.Enabled = true; }
        else { Save.Enabled = false; }
        // // 
        if (!IsPostBack)
        {

            fill_data();
            TabContainer1.Visible = false;
            tr_finish.Visible = false;

            if (Request["operation"] != null && Request["operation"] == "wrong")
            {
                if (CheckBox1.Checked == true)
                {
                    TabPanel7.Enabled = true;
                }
            }
            else { TabPanel7.Enabled = false; }




        }
        else
        {

            if (Smrt_Srch_object.SelectedValue != "")
            {
                id = Smrt_Srch_object.SelectedValue;

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
                    sql = "select form_lock_en from " + obj_table + " where form_lock_en= " + Session["user_id"].ToString();
                    sql += " and id=" + Smrt_Srch_object.SelectedValue;
                }
                if (menus_update.get_current_lang() == 3)
                {
                    sql = "select form_lock_fr from " + obj_table + " where form_lock_fr= " + Session["user_id"].ToString();
                    sql += " and id=" + Smrt_Srch_object.SelectedValue;
                }
                DataTable dt_lock = General_Helping.GetDataTable(sql);
                if (dt_lock.Rows.Count > 0)
                {
                    CheckBox1.Enabled = false;
                    CheckBox1.Checked = true;
                    lockBtn.Enabled = false;
                    if (id != "")
                    {

                        load_control();
                    }

                }
                else
                {
                    //tr_lock.Visible = true;
                    //CheckBox1.Enabled = true;
                    // lockBtn.Enabled = true;
                    TabPanel1.Enabled = false;
                    TabPanel2.Enabled = false;
                    TabPanel3.Enabled = false;
                    TabPanel4.Enabled = false;
                    TabPanel5.Enabled = false;
                    TabPanel6.Enabled = false;
                    TabPanel7.Enabled = false;
                    TabPanel8.Enabled = false;
                    TabPanel9.Enabled = false;

                }
            }
        }
    }

    public void fill_data()
    {

        if (Request["operation"] != null)
        {

            DataTable objectsDT = content_types_DB.SelectAll();
            object_type.DataSource = content_types_DB.SelectAll();
            object_type.DataBind();

            int counter = objectsDT.Rows.Count;
            if (Request["operation"].ToString() == "new")
            {
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "1"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang().ToString()) };
                DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_final_entryform_count");
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
                ListItem litem = new ListItem("-- اختر نوع الاستمارة --", "0");
                litem.Selected = true;
                object_type.Items.Insert(0, litem);
            }
            else if (Request["operation"].ToString() == "unfinished")
            {
                SqlParameter[] processedSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "2"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang().ToString()) };
                DataTable processedDT = DatabaseFunctions.SelectData(processedSqlParams, "get_final_entryform_count_filtered_unfinushed");
                if (processedDT.Rows.Count > 0)
                {
                    for (int count = 0; count < counter; count++)
                    {
                        DataRow[] foundRows;
                        foundRows = processedDT.Select("ctype = '" + object_type.Items[count].Value + "'");
                        if (foundRows.Length == 0 && object_type.Items[count].Value != "0")
                            objectsDT.Rows[count].Delete();
                    }
                }

                object_type.DataSource = objectsDT;
                object_type.DataBind();
                ListItem litem = new ListItem("-- اختر نوع الاستمارة --", "0");
                litem.Selected = true;
                object_type.Items.Insert(0, litem);
            }
            else if (Request["operation"].ToString() == "wrong")
            {
                SqlParameter[] refusedSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "5"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang().ToString()) };
                DataTable refusedDT = DatabaseFunctions.SelectData(refusedSqlParams, "get_final_entryform_count_filtered_err");
                if (refusedDT.Rows.Count > 0)
                {
                    for (int count = 0; count < counter; count++)
                    {
                        DataRow[] foundRows;
                        foundRows = refusedDT.Select("ctype = '" + object_type.Items[count].Value + "'");
                        if (foundRows.Length == 0 && object_type.Items[count].Value != "0")
                            objectsDT.Rows[count].Delete();
                    }
                }

                object_type.DataSource = objectsDT;
                object_type.DataBind();
                ListItem litem = new ListItem("-- اختر نوع الاستمارة --", "0");
                litem.Selected = true;
                object_type.Items.Insert(0, litem);
            }
        }
    }



    ////////////////////////////////////////////////////////////////////////////////////

    public void load_control()
    {

        if (Convert.ToInt16(object_type.SelectedValue) > 0)
        {
            if (CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
            {
                string control_name = "";
                switch (object_type.SelectedValue)
                {
                    case "1":
                        control_name = "~/user_controls/add_characters.ascx";
                        break;
                    case "2":
                        control_name = "~/user_controls/events_form.ascx";
                        break;
                    case "3":
                        control_name = "~/user_controls/topics.ascx";
                        break;
                    case "4":
                        control_name = "~/user_controls/places_form.ascx";
                        break;
                    case "5":
                        control_name = "~/user_controls/artifacts.ascx";

                        break;
                    case "6":
                        control_name = "~/user_controls/video_form.ascx";
                        break;
                    case "7":
                        control_name = "~/user_controls/audio_form.ascx";
                        break;
                    case "8":
                        control_name = "~/user_controls/add_documents.ascx";
                        break;
                    case "9":
                        control_name = "~/user_controls/add_articles.ascx";
                        break;
                    case "10":
                        control_name = "~/user_controls/add_books.ascx";
                        break;
                    case "11":
                        control_name = "~/user_controls/photo_form.ascx";
                        break;
                    case "12":
                        control_name = "~/user_controls/manuscripts_form.ascx";
                        break;
                    case "13":
                        control_name = "~/user_controls/theses.ascx";
                        break;
                    case "14":
                        control_name = "~/user_controls/conference_proceed.ascx";
                        break;
                    case "15":
                        control_name = "~/user_controls/website_template.ascx";
                        break;
                    case "16":
                        control_name = "~/user_controls/add_glossary.ascx";
                        break;

                }
                tr_lock.Visible = true;
                if (CheckBox1.Checked == true)
                {
                    // control_panel.Visible = true;
                    //TabContainer1.Visible  = true;
                    //tr_finish.Visible = true;

                    if (menus_update.get_current_lang() == 1)
                    {
                        TabContainer1.Visible = true;
                        tr_finish.Visible = true;
                        TabPanel1.Enabled = true;
                        TabPanel2.Enabled = true;
                        TabPanel3.Enabled = true;
                        TabPanel4.Enabled = false;
                        TabPanel5.Enabled = true;
                        TabPanel6.Enabled = true;
                        //TabPanel8.Enabled = true;
                        //TabPanel9.Enabled = true;

                    }
                    if (Request["operation"] != null && Request["operation"] == "wrong")

                    { if (fillgrid()) { TabPanel7.Enabled = true; } else { TabPanel7.Enabled = false; } }
                    else { TabPanel7.Enabled = false; }
                    control_panel.Controls.Clear();
                    Control user_ctrl = (Control)LoadControl(control_name);
                    HiddenField Hfield_content_type = (HiddenField)user_ctrl.FindControl("content_type");
                    Hfield_content_type.Value = object_type.SelectedValue;
                    HiddenField Hfield_content_id = (HiddenField)user_ctrl.FindControl("content_id");
                    Hfield_content_id.Value = Smrt_Srch_object.SelectedValue;
                    control_panel.Controls.Add(user_ctrl);


                    // Main element hidden values

                    HiddenField Hfield_content_type1 = (HiddenField)main_elements.FindControl("content_type");
                    Hfield_content_type1.Value = object_type.SelectedValue;
                    HiddenField Hfield_content_id1 = (HiddenField)main_elements.FindControl("content_id");
                    Hfield_content_id1.Value = Smrt_Srch_object.SelectedValue;
                    main_elements.fillGrid();
                    //main_elements.fillMainTypeDDL();
                    //Smart_Search smrt = (Smart_Search)main_elements.FindControl("Smrt_Srch_MainElementName");
                    //smrt.Clear_Selected();
                    //if (CDataConverter.ConvertToInt(smrt.SelectedValue) > 0)
                    //{
                    //   HiddenField hf = (HiddenField)main_elements.FindControl("HiddenField1");
                    //smrt.Clear_Selected();

                    //main_elements.ddlNameChanged();



                    // }
                    if (Smrt_Srch_object.SelectedValue != "")
                    {
                        if (Session["user_type"] != null)
                        {
                            main_elements.Enabled();
                        }
                    }
                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) < 5)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel3.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)support_elements.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)support_elements.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            //support_elements.SupportddlNameChanged();
                            support_elements.fillGrid();
                            //support_elements.fillSupportedTypeDDL();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    support_elements.Enabled();
                                }
                            }
                        }
                    }
                    else TabPanel3.Enabled = false;

                    ///////// references
                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) < 6 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 12 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 16)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel5.Enabled = true;
                            HiddenField Hfield_ref = (HiddenField)add_reference1.FindControl("content_type");
                            Hfield_ref.Value = object_type.SelectedValue;
                            HiddenField Hfield_ref_content_id = (HiddenField)add_reference1.FindControl("content_id");
                            Hfield_ref_content_id.Value = Smrt_Srch_object.SelectedValue;
                            add_reference1.fillGrid();

                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    add_reference1.Enabled();
                                }
                            }
                        }
                        else TabPanel5.Enabled = false;


                    }
                    else TabPanel5.Enabled = false;

                    ////// timeline

                    HiddenField Hfield_timeline_type = (HiddenField)timeline.FindControl("content_type");
                    Hfield_timeline_type.Value = object_type.SelectedValue;
                    HiddenField Hfield_timeline_id = (HiddenField)timeline.FindControl("content_id");
                    Hfield_timeline_id.Value = Smrt_Srch_object.SelectedValue;
                    timeline.fillGrid();

                    if (Smrt_Srch_object.SelectedValue != "")
                    {
                        if (Session["user_type"] != null)
                        {
                            timeline.Enabled();
                        }
                    }

                    //////// charachters moalfat
                    if (object_type.SelectedValue == "1")
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel4.Enabled = true;
                            HiddenField Hfield_moalfat_type = (HiddenField)char_moalfat.FindControl("content_type");
                            Hfield_moalfat_type.Value = object_type.SelectedValue;

                            HiddenField Hfield_content_id3 = (HiddenField)char_moalfat.FindControl("content_id");
                            Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                            char_moalfat.fillGrid();
                        }

                        if (Smrt_Srch_object.SelectedValue != "")
                        { char_moalfat.Enabled(); }
                    }

                    else TabPanel4.Enabled = false;

                    //////////////////// Add doc authors 

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 10 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 9 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 14)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel8.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)docs_authors.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)docs_authors.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            //HtmlTableRow findtr = (HtmlTableRow)docs_authors.FindControl("tr_author_type");
                            //if (object_type.SelectedValue == "10")
                            //{

                            //    if (menus_update.get_current_lang() == 1)
                            //    {
                            //        //docs_authors.filldrop_author_type();

                            //        if (findtr != null)
                            //            findtr.Visible = true;
                            //    }
                            //}
                            //else { findtr.Visible = false; }
                            docs_authors.FillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    docs_authors.Enabled();
                                }
                            }
                        }
                    }
                    else { TabPanel8.Enabled = false; }
                    ////////////////////////// Add glossary 

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 16)
                    {

                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel5.Enabled = true;
                            //TabPanel1.Enabled = false;
                            TabPanel2.Enabled = false;
                            TabPanel3.Enabled = false;
                            TabPanel4.Enabled = false;
                            TabPanel7.Enabled = false;
                            TabPanel6.Enabled = false;
                            TabPanel8.Enabled = false;
                            TabPanel9.Enabled = false;
                            TabPanel10.Enabled = false;
                        }
                    }

                    ///////////////////////// Add  places translation 

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 4)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel9.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)places_translation.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)places_translation.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            places_translation.fillGridVeiws();

                            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                            {
                                places_translation.Enabled();

                            }
                        }
                    }
                    else { TabPanel9.Enabled = false; }

                    ///////////////////////// Add  manuscript_tab 

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 12)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel10.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)manuscript_tab1.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)manuscript_tab1.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            manuscript_tab1.getData();

                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {

                                }
                            }
                        }
                    }
                    else { TabPanel10.Enabled = false; }

                    control_loaded.Value = Smrt_Srch_object.SelectedValue;



                    if (menus_update.get_current_lang() == 2 || menus_update.get_current_lang() == 3)
                    {
                        TabContainer1.Visible = true;
                        tr_finish.Visible = true;
                        TabPanel1.Enabled = true;
                        TabPanel2.Enabled = false;
                        TabPanel3.Enabled = false;
                        TabPanel4.Enabled = false;
                        TabPanel5.Enabled = false;
                        TabPanel6.Enabled = true;
                        TabPanel8.Enabled = false;
                        TabPanel9.Enabled = false;
                        TabPanel10.Enabled = false;
                        if (Request["operation"] != null && Request["operation"] == "wrong")

                        { if (fillgrid()) { TabPanel7.Enabled = true; } else { TabPanel7.Enabled = false; } }
                        else { TabPanel7.Enabled = false; }
                        control_panel.Controls.Clear();
                        Control user_ctrlen = (Control)LoadControl(control_name);
                        HiddenField Hfield_content_typeen = (HiddenField)user_ctrlen.FindControl("content_type");
                        Hfield_content_typeen.Value = object_type.SelectedValue;
                        HiddenField Hfield_content_iden = (HiddenField)user_ctrlen.FindControl("content_id");
                        Hfield_content_iden.Value = Smrt_Srch_object.SelectedValue;
                        control_panel.Controls.Add(user_ctrl);

                        control_loaded.Value = Smrt_Srch_object.SelectedValue;
                        HiddenField Hfield_timeline_typeen = (HiddenField)timeline.FindControl("content_type");
                        Hfield_timeline_typeen.Value = object_type.SelectedValue;
                        HiddenField Hfield_timeline_iden = (HiddenField)timeline.FindControl("content_id");
                        Hfield_timeline_iden.Value = Smrt_Srch_object.SelectedValue;
                        timeline.fillGrid();

                        if (object_type.SelectedValue == "1")
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel4.Enabled = true;
                                HiddenField Hfield_moalfat_type = (HiddenField)char_moalfat.FindControl("content_type");
                                Hfield_moalfat_type.Value = object_type.SelectedValue;

                                HiddenField Hfield_content_id3 = (HiddenField)char_moalfat.FindControl("content_id");
                                Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                                char_moalfat.fillGrid();
                            }

                            if (Smrt_Srch_object.SelectedValue != "")
                            { char_moalfat.Enabled(); }
                        }
                        else TabPanel4.Enabled = false;

                        ///////////////////////// Add doc authors 

                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 10 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 9 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 14)
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel8.Enabled = true;
                                HiddenField Hfield_content_type2 = (HiddenField)docs_authors.FindControl("content_type");
                                Hfield_content_type2.Value = object_type.SelectedValue;
                                HiddenField Hfield_content_id2 = (HiddenField)docs_authors.FindControl("content_id");
                                Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                                docs_authors.FillGrid();
                                if (Smrt_Srch_object.SelectedValue != "")
                                {
                                    if (Session["user_type"] != null)
                                    {
                                        docs_authors.Enabled();
                                    }
                                }
                            }
                        }
                        ///////////////////////// Add  places translation 

                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 4)
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel9.Enabled = true;
                                HiddenField Hfield_content_type2 = (HiddenField)places_translation.FindControl("content_type");
                                Hfield_content_type2.Value = object_type.SelectedValue;
                                HiddenField Hfield_content_id2 = (HiddenField)places_translation.FindControl("content_id");
                                Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                                places_translation.fillGridVeiws();
                                if (Smrt_Srch_object.SelectedValue != "")
                                {
                                    if (Session["user_type"] != null)
                                    {
                                        // places_translation.Enabled();
                                    }
                                }
                            }
                        }
                        else { TabPanel9.Enabled = false; }
                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 16)
                        {
                            TabPanel6.Enabled = false;

                        }

                        ///////////////////////// Add  manuscript_tab 

                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 12)
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel10.Enabled = true;
                                HiddenField Hfield_content_type2 = (HiddenField)manuscript_tab1.FindControl("content_type");
                                Hfield_content_type2.Value = object_type.SelectedValue;
                                HiddenField Hfield_content_id2 = (HiddenField)manuscript_tab1.FindControl("content_id");
                                Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                                manuscript_tab1.getData();

                                if (Smrt_Srch_object.SelectedValue != "")
                                {
                                    if (Session["user_type"] != null)
                                    {

                                    }
                                }
                            }
                        }
                        else { TabPanel10.Enabled = false; }

                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            if (Session["user_type"] != null)
                            {
                                timeline.Enabled();
                            }
                        }

                    }
                }
                else
                {
                    TabPanel1.Enabled = false;
                    TabPanel2.Enabled = false;
                    TabPanel3.Enabled = false;
                    TabPanel4.Enabled = false;
                    TabPanel5.Enabled = false;
                    TabPanel6.Enabled = false;
                    TabPanel7.Enabled = false;
                    TabPanel8.Enabled = false;
                    TabPanel9.Enabled = false;
                    TabPanel10.Enabled = false;

                }
            }
        }
    }

    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {
        //load_control();
        ////tr_lock.Visible = false;
        //if (Request["operation"].ToString() == "wrong")
        //{
        //    tr_observer.Visible = true;
        //    Div6.Style.Add("display", "block");
        //    fillgrid();
        //    //tr_lock.Visible = false;

        //}
        //if (Smrt_Srch_object.SelectedValue != "0")
        //{
        //    main_elements1.fillGrid();
        //    support_elements1.fillGrid();
        //    timeline.fillGrid();
        //    char_moalfat.fillGrid();
        //    add_reference1.fillGrid();
        //}
        //tr_lock.Visible = true;

    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if (Smrt_Srch_object.SelectedValue != "")

        Smrt_Srch_object.Clear_Controls();
        control_panel.Controls.Clear();

        TabPanel1.Enabled =
        TabPanel2.Enabled =
        TabPanel3.Enabled =
        TabPanel4.Enabled =
        TabPanel5.Enabled =
        TabPanel6.Enabled =
        TabPanel7.Enabled = false;
        TabPanel8.Enabled = false;
        TabPanel9.Enabled = false;
        // MOnMember_Data(object_type.SelectedValue);
        Fill_smart(object_type.SelectedValue);

        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0)
        { Label23.Text = "_" + object_type.SelectedValue; }
        else { Label23.Visible = false; }
    }

    public void Log(int operation_id)
    {
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = Convert.ToInt16(object_type.SelectedValue);
        clog.content_id = Convert.ToInt16(Smrt_Srch_object.SelectedValue);
        clog.operation_id = operation_id;
        clog.lang_id = menus_update.get_current_lang();
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.note_date = DateTime.Now.ToShortDateString();
        int rslut = contents_log_DB.Save(clog);
    }
    public bool GetLog()
    {
        bool flag = false;

        if (object_type.SelectedValue != "" && Smrt_Srch_object.SelectedValue != "")
        {
            if (object_type.SelectedValue != "16")
            {
                int content_type = Convert.ToInt32(object_type.SelectedValue);
                int content_id = Convert.ToInt32(Smrt_Srch_object.SelectedValue);
                int mainElementsgrid_count = main_elements.gridCount;
                int timelinegrid_count = timeline.gridCount;
                int reference = add_reference1.rowsofgrid;
                DataTable tab1 = contents_log_DB.SelectByOperationID(2, content_id, content_type, menus_update.get_current_lang());
                //DataTable tab2 = contents_log_DB.SelectByOperationID(10, content_id, content_type);
                //DataTable tab6 = contents_log_DB.SelectByOperationID(14, content_id, content_type);
                if (tab1.Rows.Count > 0)
                {

                    if (mainElementsgrid_count > 0 || menus_update.get_current_lang() != 1)
                    {
                        if (content_type == 1 || content_type == 2 || content_type == 3 || content_type == 4 || content_type == 5 || content_type == 12)
                        {
                            if (reference > 0)
                            {
                               flag = true;
                            }
                            else if (menus_update.get_current_lang() == 1)
                            {
                                 flag = false; TabContainer1.ActiveTabIndex = 7;ShowAlertMessage("يجب ادخال المراجع"); return flag;
                            }
                        }
                   

                        if (object_type.SelectedValue == "1")
                        {
                            if (timelinegrid_count > 0)
                            {
                                flag = true;
                            }
                            else { flag = false; TabContainer1.ActiveTabIndex = 8; ShowAlertMessage("يجب ادخال الخط الزمني"); return flag; }
                        }
                        else { flag = true; }
                    }
                    else { flag = false; TabContainer1.ActiveTabIndex = 1; ShowAlertMessage("يجب ادخال العناصر الأساسية"); return flag; }
                    

                }
                else { flag = false; TabContainer1.ActiveTabIndex = 0; ShowAlertMessage("يجب ادخال جميع  بيانات تفاصيل الاستمارة"); }

            }
            else
            {
                int content_type = Convert.ToInt32(object_type.SelectedValue);
                int content_id = Convert.ToInt32(Smrt_Srch_object.SelectedValue);
                //int mainElementsgrid_count = main_elements.gridCount;
                int timelinegrid_count = timeline.gridCount;
                DataTable tab1 = contents_log_DB.SelectByOperationID(2, content_id, content_type, menus_update.get_current_lang());
                //DataTable tab2 = contents_log_DB.SelectByOperationID(10, content_id, content_type);
                //DataTable tab6 = contents_log_DB.SelectByOperationID(14, content_id, content_type);
                if (tab1.Rows.Count > 0)
                {
                    flag = true;
                }

                else { flag = false; TabContainer1.ActiveTabIndex = 0; ShowAlertMessage("يجب ادخال جميع  بيانات تفاصيل الاستمارة"); }
            }
        }
        return flag;

    }
    public bool fillgrid()
    {
        bool f = false;
        TabPanel7.Enabled = true;
        DataTable dt = contents_notes_DB.SelectByErrorID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue), CDataConverter.ConvertToInt(object_type.SelectedValue), 1, 1, menus_update.get_current_lang());
        if (dt.Rows.Count > 0)
        {
            gvnotes.DataSource = dt;
            gvnotes.DataBind();
            if (menus_update.get_current_lang() == 1)
            {
                gvnotes.Columns[0].Visible = true;
                gvnotes.Columns[1].Visible = false;
                gvnotes.Columns[2].Visible = false;
            }
            else if (menus_update.get_current_lang() == 2)
            {
                gvnotes.Columns[0].Visible = false;
                gvnotes.Columns[1].Visible = true;
                gvnotes.Columns[2].Visible = false;
            }
            else
            {
                gvnotes.Columns[0].Visible = false;
                gvnotes.Columns[1].Visible = false;
                gvnotes.Columns[2].Visible = true;
            }
            f = true;
        }
        return f;

    }

    public static void ShowAlertMessage(string error)
    {

        Page page = HttpContext.Current.Handler as Page;
        if (page != null)
        {
            error = error.Replace("'", "\'");
            ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", "alert('" + error + "');", true);
        }
    }
    protected void Save_Click(object sender, EventArgs e)
    {
        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
        {
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
                case "16":
                    obj_table = "glossary";
                    break;
            }
            //if (timelineform1.rowsofgrid < 0)
            //{ ShowAlertMessage("يجب إدخال الخط الزمني"); }

            string updateLock = "";
            if (Request["operation"].ToString() == "new")
            {
                if (chk_status.Checked == true)
                {
                    if (GetLog())
                    {

                        if (menus_update.get_current_lang() == 1)
                        {
                            updateLock = "update " + obj_table + " set form_status= 3 , form_lock =0";
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        if (menus_update.get_current_lang() == 2)
                        {
                            updateLock = "update " + obj_table + " set form_status_en= 3 , form_lock_en =0";
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        if (menus_update.get_current_lang() == 3)
                        {
                            updateLock = "update " + obj_table + " set form_status_fr= 3 , form_lock_fr =0";
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        int reslt = General_Helping.ExcuteQuery(updateLock);
                        Session["sendto"] = "quality";
                        Log(5);
                        Response.Redirect("~/administration/Default.aspx");

                    }
                }
                else
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status= 2 , form_lock = " + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en= 2 , form_lock_en = " + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr= 2 , form_lock_fr = " + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    int reslt = General_Helping.ExcuteQuery(updateLock);
                    Log(2);
                    Response.Redirect("~/administration/Default.aspx");
                }

            }

            else if (Request["operation"].ToString() == "unfinished")
            {
                if (chk_status.Checked == true)
                {


                    if (GetLog())
                    {
                        if (menus_update.get_current_lang() == 1)
                        {
                            updateLock = "update " + obj_table + " set form_status= 3, form_lock =0";
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        if (menus_update.get_current_lang() == 2)
                        {
                            updateLock = "update " + obj_table + " set form_status_en= 3, form_lock_en =0";
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        if (menus_update.get_current_lang() == 3)
                        {
                            updateLock = "update " + obj_table + " set form_status_fr= 3, form_lock_fr =0";
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }

                        int reslt2 = General_Helping.ExcuteQuery(updateLock);
                        Session["sendto"] = "quality";
                        Log(5);
                        SqlParameter[] sqlParamse2 = new SqlParameter[] { new SqlParameter("@content_id", Smrt_Srch_object.SelectedValue),
                        new SqlParameter ("@content_type", object_type.SelectedValue),
                        new SqlParameter ("@error_status",2) , 
                        new SqlParameter ("@error_setnew_status",3),
                        new SqlParameter ("@lang_id",menus_update.get_current_lang())};
                        DatabaseFunctions.UpdateData(sqlParamse2, "contents_notes_update");

                        SqlParameter[] sqlParamse = new SqlParameter[] { new SqlParameter("@content_id", Smrt_Srch_object.SelectedValue),
                        new SqlParameter ("@content_type", object_type.SelectedValue),
                        new SqlParameter ("@error_status",1) , 
                        new SqlParameter ("@error_setnew_status",2),
                        new SqlParameter ("@lang_id",menus_update.get_current_lang())};
                        int res = DatabaseFunctions.UpdateData(sqlParamse, "contents_notes_update");
                        Response.Redirect("~/administration/Default.aspx");
                    }
                }

                else
                {
                    string sql = "";
                    if (menus_update.get_current_lang() == 1)
                    {
                        sql = "select form_lock from " + obj_table + " where form_lock = " + Session["user_id"].ToString();
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
                    DataTable dt = General_Helping.GetDataTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        if (menus_update.get_current_lang() == 1)
                        {
                            updateLock = "update " + obj_table + " set form_status= 2 , form_lock = " + dt.Rows[0]["form_lock"].ToString();
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        if (menus_update.get_current_lang() == 2)
                        {
                            updateLock = "update " + obj_table + " set form_status_en= 2 , form_lock_en = " + dt.Rows[0]["form_lock_en"].ToString();
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        if (menus_update.get_current_lang() == 3)
                        {
                            updateLock = "update " + obj_table + " set form_status_fr= 2 , form_lock_fr = " + dt.Rows[0]["form_lock_fr"].ToString();
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        }
                        int reslt = General_Helping.ExcuteQuery(updateLock);
                        Log(2);
                        Response.Redirect("~/administration/Default.aspx");
                    }

                }
            }

            else if (Request["operation"].ToString() == "wrong")
            {
                //string updateLock = "";
                if (chk_status.Checked == true)
                {
                    if (menus_update.get_current_lang() == 1)
                    {

                        updateLock = "update " + obj_table + " set form_status= 4 , form_lock =0";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {

                        updateLock = "update " + obj_table + " set form_status_en= 4 , form_lock_en =0";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {

                        updateLock = "update " + obj_table + " set form_status_fr= 4 , form_lock_fr =0";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }

                    int reslt = General_Helping.ExcuteQuery(updateLock);
                    Session["sendto"] = "quality";
                    Log(5);
                    SqlParameter[] sqlParamse2 = new SqlParameter[] { new SqlParameter("@content_id", Smrt_Srch_object.SelectedValue),
                    new SqlParameter ("@content_type", object_type.SelectedValue),
                    new SqlParameter ("@error_status",2) , 
                    new SqlParameter ("@error_setnew_status",3),
                    new SqlParameter ("@lang_id",menus_update.get_current_lang())};
                    DatabaseFunctions.UpdateData(sqlParamse2, "contents_notes_update");

                    SqlParameter[] sqlParamse = new SqlParameter[] { new SqlParameter("@content_id", Smrt_Srch_object.SelectedValue),
                    new SqlParameter ("@content_type", object_type.SelectedValue),
                    new SqlParameter ("@error_status",1) , 
                    new SqlParameter ("@error_setnew_status",2),
                    new SqlParameter ("@lang_id",menus_update.get_current_lang())};
                    int res = DatabaseFunctions.UpdateData(sqlParamse, "contents_notes_update");
                    Response.Redirect("~/administration/Default.aspx");
                }
                else
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status= 5 , form_lock = " + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en= 5 , form_lock_en = " + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr= 5 , form_lock_fr = " + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    int reslt = General_Helping.ExcuteQuery(updateLock);
                    Log(2);
                    Response.Redirect("~/administration/Default.aspx");

                }
            }


            //string updateLock1 = "update " + obj_table + " set form_lock =0";
            //updateLock1 += " where id=" + Smrt_Srch_object.SelectedValue;
            //int reslt2 = General_Helping.ExcuteQuery(updateLock1);
            if (chk_status.Checked == true)
            {
                // Log(5);             
            }
            else
            {
                //Log(2);
            }


        }
    }


    public void lockFun()
    {
        string obj_table = "";
        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
        {
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
                case "16":
                    obj_table = "glossary";
                    break;
            }
            if (CheckBox1.Checked == true)
            {

                if (obj_table != "")
                {
                    string sql = "";
                    string updateLock = "";
                    if (menus_update.get_current_lang() == 1)
                    {
                        sql = "select form_lock from " + obj_table + " where id= " + Smrt_Srch_object.SelectedValue;
                        DataTable locked = General_Helping.GetDataTable(sql);
                        if (locked.Rows[0]["form_lock"].ToString() != "0" && locked.Rows[0]["form_lock"].ToString() != null)
                        {
                            if (locked.Rows[0]["form_lock"].ToString() != Session["user_id"].ToString())
                            {
                                //ShowAlertMessage("عفواً تم الاستحواذ علي الاستمارة من مدخل أخر");
                                Session["sendto"] = "entrylocked";
                                Response.Redirect("~/administration/Default.aspx");
                            }
                        }
                        else
                        {
                            updateLock = "update " + obj_table + " set form_lock=" + Session["user_id"].ToString();
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                            if (Request["operation"].ToString() == "new")
                            {
                                string status = "update " + obj_table + " set form_lock=" + Session["user_id"].ToString() + " , form_status=" + 2;
                                status += " where id=" + Smrt_Srch_object.SelectedValue;
                                General_Helping.ExcuteQuery(status);
                            }
                        }
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        sql = "select form_lock_en from " + obj_table + " where id= " + Smrt_Srch_object.SelectedValue;
                        DataTable locked = General_Helping.GetDataTable(sql);
                        if (locked.Rows[0]["form_lock_en"].ToString() != "0" && locked.Rows[0]["form_lock_en"].ToString() != null)
                        {
                            if (locked.Rows[0]["form_lock_en"].ToString() != Session["user_id"].ToString())
                            {
                                //ShowAlertMessage("عفواً تم الاستحواذ علي الاستمارة من مدخل أخر");
                                Session["sendto"] = "entrylocked";
                                Response.Redirect("~/administration/Default.aspx");
                            }
                        }
                        else
                        {
                            updateLock = "update " + obj_table + " set form_lock_en= " + Session["user_id"].ToString();
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;


                            if (Request["operation"].ToString() == "new")
                            {
                                string status = "update " + obj_table + " set form_lock_en=" + Session["user_id"].ToString() + " , form_status_en=" + 2;
                                status += " where id=" + Smrt_Srch_object.SelectedValue;
                                General_Helping.ExcuteQuery(status);
                            }
                        }
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        sql = "select form_lock_fr from " + obj_table + " where id= " + Smrt_Srch_object.SelectedValue;
                        DataTable locked = General_Helping.GetDataTable(sql);
                        if (locked.Rows[0]["form_lock_fr"].ToString() != "0" && locked.Rows[0]["form_lock_fr"].ToString() != null)
                        {
                            if (locked.Rows[0]["form_lock_fr"].ToString() != Session["user_id"].ToString())
                            {
                                //ShowAlertMessage("عفواً تم الاستحواذ علي الاستمارة من مدخل أخر");
                                Session["sendto"] = "entrylocked";
                                Response.Redirect("~/administration/Default.aspx");
                            }
                        }
                        else
                        {
                            
                            updateLock = "update " + obj_table + " set form_lock_fr= " + Session["user_id"].ToString();
                            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                            if (Request["operation"].ToString() == "new")
                            {
                                string status = "update " + obj_table + " set form_lock_fr=" + Session["user_id"].ToString() + " , form_status_fr=" + 2;
                                status += " where id=" + Smrt_Srch_object.SelectedValue;
                                General_Helping.ExcuteQuery(status);
                            }
                          
                        }
                    }

                    if (updateLock != "")
                    {
                       
                       
                        int reslt = General_Helping.ExcuteQuery(updateLock);
                        if (reslt != -1)
                        {
                            Fill_smart(object_type.SelectedValue);
                        }

                      
                        CheckBox1.Enabled = false;
                        lockBtn.Enabled = false;
                        load_control();
                        Log(15);


                    }
                }




            }

        }
        else { ShowAlertMessage("يجب اختيار نوع الاستمارة واسم العنصر أولاً"); }
    }
    protected void lockBtn_Click(object sender, EventArgs e)
    {
        lockFun();
    }
}