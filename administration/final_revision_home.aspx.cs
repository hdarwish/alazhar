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

public partial class administration_final_revision_home : BasePage
{
 public static string id = "";
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    protected override void OnInit(EventArgs e)
    {
        this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);

    }
    private void MOnMember_Data(string Value)
    {
        //Smrt_Srch_object.Clear_Controls();

       id = Smrt_Srch_object.SelectedValue;
        if (Smrt_Srch_object.SelectedValue != "")
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
            lockTr.Visible = true;
            lockChckBox.Enabled = true;
            lockBtn.Enabled = true;
            //lockChckBox.Checked = false;
            string updateLock = "";
            if (menus_update.get_current_lang() == 1)
            {
                updateLock = "select form_lock,lock_files from " + obj_table;
                updateLock += " where form_lock= " + Session["user_id"].ToString()+" and id=" + Smrt_Srch_object.SelectedValue;
            }
            if (menus_update.get_current_lang() == 2)
            {
                updateLock = "select form_lock_en from " + obj_table;
                updateLock += " where  form_lock_en= " + Session["user_id"].ToString() + " and id=" + Smrt_Srch_object.SelectedValue;
            }
            if (menus_update.get_current_lang() == 3)
            {
                updateLock = "select form_lock_fr from " + obj_table;
                updateLock += " where  form_lock_fr= " + Session["user_id"].ToString() + " and id=" + Smrt_Srch_object.SelectedValue;
            }
            DataTable dt = General_Helping.GetDataTable(updateLock);
            if (dt.Rows.Count > 0)
            {
                if (menus_update.get_current_lang() == 1)
                {
                    if (CDataConverter.ConvertToInt(dt.Rows[0]["form_lock"].ToString()) > 0 || CDataConverter.ConvertToInt(dt.Rows[0]["lock_files"].ToString()) > 0)
                    {
                        lockChckBox.Enabled = false;
                        lockChckBox.Checked = true;
                        lockBtn.Enabled = false;
                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
                        {
                            load_control();
                        }
                    }
                }
                if (menus_update.get_current_lang() == 2)
                {
                    if (CDataConverter.ConvertToInt(dt.Rows[0]["form_lock_en"].ToString()) > 0)
                    {
                        lockChckBox.Enabled = false;
                        lockChckBox.Checked = true;
                        lockBtn.Enabled = false;
                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
                        {
                            load_control();
                        }
                    }
                }
                if (menus_update.get_current_lang() == 3)
                {
                    if (CDataConverter.ConvertToInt(dt.Rows[0]["form_lock_fr"].ToString()) > 0)
                    {
                        lockChckBox.Enabled = false;
                        lockChckBox.Checked = true;
                        lockBtn.Enabled = false;
                        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
                        {
                            load_control();
                        }
                    }
                }



            }
            else
            {
                lockChckBox.Enabled = true;
                lockChckBox.Checked = false;
                lockBtn.Enabled = true;
                TabContainer1.Visible = false;
                tr_file.Visible = false;
                btn_save_all.Visible = false;
                
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
                            lockTr.Visible = true;

                            return;
                        }
                    }
                  

                }
                lockTr.Visible = true;
                lockChckBox.Enabled = false;
                lockBtn.Enabled = false;

            }
        }
    }
    private void Fill_smart(string Value)
    {
        string obj_tatus = "";
        if (Request["operation"].ToString() == "new")
            obj_tatus = "11";
        if (Request["operation"].ToString() == "processed")
            obj_tatus = "12";
        if (Request["operation"].ToString() == "refused")
            obj_tatus = "13";
        if (Value != "0")
        {
            switch (Value)
            {
                case "1":
                    SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang()))};
                    Smrt_Srch_object.stored = "get_characters_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams1;
                    break;
                case "2":
                    SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_events_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams2;
                    break;
                case "3":
                    SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_topics_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams3;
                    break;
                case "4":
                    SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_places_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams4;
                    break;
                case "5":
                    SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_artifacts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams5;
                    break;
                case "6":
                    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_video_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams6;
                    break;
                case "7":
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_audio_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams7;
                    break;
                case "8":
                    SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_docs_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams8;
                    break;
                case "9":
                    SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_articles_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams9;
                    break;
                case "10":
                    SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_books_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams10;
                    break;
                case "11":
                    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_images_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams11;
                    break;
                case "12":
                    SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview", obj_tatus), new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_manuscripts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams12;
                    break;
                case "13":
                    SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview", obj_tatus), 
                                                                    new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                    new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_theses_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams13;
                    break;
                case "14":
                    SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview", obj_tatus), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    Smrt_Srch_object.stored = "get_conference_proceedings_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams14;
                    break;
                case "15":

                    SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", ""), new SqlParameter("@selview",obj_tatus) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                    Smrt_Srch_object.stored = "get_website_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams15;
                    break;

                case "16":

                    SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@glossary_name", ""), new SqlParameter("@selview",obj_tatus) , 
                        new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                    Smrt_Srch_object.stored = "get_glossary_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams16;
                    break;
            }
            Smrt_Srch_object.Value_Field = "id";
            Smrt_Srch_object.Text_Field = "title";
            Smrt_Srch_object.DataBind();
        }
        else
        {
            Smrt_Srch_object.Clear_Controls();
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fill_data();
            TabContainer1.Visible = false;
            TabPanel1.Enabled =
       TabPanel2.Enabled =
       TabPanel3.Enabled =
       TabPanel4.Enabled =
       TabPanel5.Enabled =
       TabPanel6.Enabled =
       TabPanel8.Enabled =
        TabPanel9.Enabled =
         TabPanel10.Enabled =
         TabPanel11.Enabled =
         TabPanel12.Enabled = 
       TabPanel7.Enabled = false;
             tr_file.Visible = false;
             btn_save_all.Visible = false;
        }
        ////else
        ////{

        ////    if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
        ////    {
        ////        load_control();
        ////    }
        ////    else
        ////    {
        ////        TabPanel1.Enabled =
        ////            TabPanel2.Enabled =
        ////            TabPanel3.Enabled =
        ////            TabPanel4.Enabled =
        ////            TabPanel5.Enabled =
        ////            TabPanel6.Enabled =
        ////            TabPanel8.Enabled =
        ////            TabPanel9.Enabled =
        ////            TabPanel10.Enabled =
        ////            TabPanel11.Enabled =
        ////            TabPanel12.Enabled =
        ////            TabPanel7.Enabled = false;
        ////    }
        ////}
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
                    lockChckBox.Enabled = false;
                    lockChckBox.Checked = true;
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
                    TabPanel1.Enabled =
                   TabPanel2.Enabled =
                   TabPanel3.Enabled =
                    TabPanel4.Enabled =
                    TabPanel5.Enabled =
                  TabPanel6.Enabled =
                    TabPanel8.Enabled =
                   TabPanel9.Enabled =
                  TabPanel10.Enabled =
                  TabPanel11.Enabled =
                    TabPanel12.Enabled =
                   TabPanel7.Enabled = false;

                }
            }
        }
        if (menus_update.get_current_lang() == 1)
        {
            
            radlist.Items[0].Enabled = true;
            radlist.Items[1].Enabled = true;

        }
        if (menus_update.get_current_lang() == 2)
        {
            radlist.Items[0].Enabled = false;
            radlist.Items[1].Enabled = true;
        }
        if (menus_update.get_current_lang() == 3)
        {
            radlist.Items[0].Enabled = false;
            radlist.Items[1].Enabled = true;
        }
        
    }
    public void fill_data()
    {
        DataTable objectsDT = content_types_DB.SelectAll();
        object_type.DataSource = content_types_DB.SelectAll();
        object_type.DataBind();

        int counter = objectsDT.Rows.Count;
        if (Request["operation"].ToString() == "new")
        {
            SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "11"), new SqlParameter("@file_status", "11"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()), new  SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang()))   };
            DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_final_new_count");
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
        else if (Request["operation"].ToString() == "processed")
        {
            SqlParameter[] processedSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "12"), new SqlParameter("@file_status", "12"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) , new  SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang())) };
            DataTable processedDT = DatabaseFunctions.SelectData(processedSqlParams, "get_final_new_count");
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
        else if (Request["operation"].ToString() == "refused")
        {
            SqlParameter[] refusedSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "13"), new SqlParameter("@file_status", "13"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) , new  SqlParameter("@lang_id",CDataConverter.ConvertToInt(menus_update.get_current_lang())) };
            DataTable refusedDT = DatabaseFunctions.SelectData(refusedSqlParams, "get_final_new_count");
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
    public void load_control()
    {
        string s1 = object_type.SelectedValue;
        string s2 = Smrt_Srch_object.SelectedValue;
        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
        {
            tr_file.Visible = true;
            DataTable file_info = new DataTable();
            string control_name = "";
            string field1 = "";
            string field2 = "";
            string field3 = "";

            string value1 = "";
            string value2 = "";
            string value3 = "";
            string obj_table = "";
            switch (object_type.SelectedValue)
            {
                case "1":
                    control_name = "~/user_controls/add_characters.ascx";
                    characters_DT cdt = characters_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (cdt.image_name != null)
                        value1 = cdt.image_name.ToString();
                    field1 = "image_name";
                    obj_table = "characters";
                    break;
                case "2":
                    control_name = "~/user_controls/events_form.ascx";
                    events_DT edt = events_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (edt.small_image != null)
                        value1 = edt.small_image.ToString();
                    if (edt.large_image != null)
                        value2 = edt.large_image.ToString();

                    field1 = "small_image";
                    field2 = "large_image";
                    obj_table = "events";

                    break;
                case "3":
                    control_name = "~/user_controls/topics.ascx";
                    topics_DT tdt = topics_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (tdt.small_image != null)
                        value1 = tdt.small_image.ToString();
                    if (tdt.large_image != null)
                        value2 = tdt.large_image.ToString();
                    field1 = "small_image";
                    field2 = "large_image";
                    obj_table = "topics";
                    break;
                case "4":
                    obj_table = "places";
                    control_name = "~/user_controls/places_form.ascx";
                    places_DT pldt = places_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (pldt.image_name != null)
                        value1 = pldt.image_name.ToString();
                    field1 = "image_name";
                    break;
                case "5":
                    obj_table = "artifacts";
                    control_name = "~/user_controls/artifacts.ascx";
                    artifacts_DT artdt = artifacts_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (artdt.small_image != null)
                        value1 = artdt.small_image.ToString();
                    if (artdt.large_image != null)
                        value2 = artdt.large_image.ToString();

                    field1 = "small_image";
                    field2 = "large_image";
                    break;
                case "6":
                    control_name = "~/user_controls/video_form.ascx";
                    content_media_DT vdt = content_media_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (vdt.small_image != null)
                        value1 = vdt.small_image.ToString();
                    if (vdt.file_name != null)
                        value2 = vdt.file_name.ToString() + vdt.extension.ToString();

                    field1 = "small_image";
                    field2 = "file_name";
                    obj_table = "content_media";

                    break;
                case "7":
                    control_name = "~/user_controls/audio_form.ascx";
                    content_media_DT adt = content_media_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (adt.file_name != null)
                        value1 = adt.file_name.ToString() + adt.extension.ToString();

                    field2 = "file_name";
                    obj_table = "content_media";

                    break;
                case "8":
                    control_name = "~/user_controls/add_documents.ascx";
                    documents_DT ddt = documents_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (ddt.small_image != null)
                        value1 = ddt.small_image.ToString();
                    if (ddt.large_image != null)
                        value2 = ddt.large_image.ToString();

                    field1 = "small_image";
                    field2 = "large_image";
                    obj_table = "documents";

                    break;
                case "9":
                    control_name = "~/user_controls/add_articles.ascx";
                    documents_DT ardt = documents_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (ardt.small_image != null)
                        value1 = ardt.small_image.ToString();
                    if (ardt.large_image != null)
                        value2 = ardt.large_image.ToString();

                    field1 = "small_image";
                    field2 = "large_image";
                    obj_table = "documents";

                    break;
                case "10":
                    control_name = "~/user_controls/add_books.ascx";
                    documents_DT bdt = documents_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (bdt.small_image != null)
                        value1 = bdt.small_image.ToString();
                    if (bdt.large_image != null)
                        value2 = bdt.large_image.ToString();

                    field1 = "small_image";
                    field2 = "large_image";
                    obj_table = "documents";

                    break;
                case "11":
                    control_name = "~/user_controls/photo_form.ascx";
                    content_images_DT pdt = content_images_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (pdt.small_image != null)
                        value1 = pdt.small_image.ToString();
                    if (pdt.large_image != null)
                        value2 = pdt.large_image.ToString();
                    if (pdt.normal_image != null)
                        value3 = pdt.normal_image.ToString();

                    field1 = "small_image";
                    field2 = "large_image";
                    field3 = "normal_image";
                    obj_table = "content_images";
                    break;
                case "12":
                    manuscripts_DT mandt = manuscripts_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    control_name = "~/user_controls/manuscripts_form.ascx";
                    obj_table = "manuscripts";
                    if (mandt.image_name != null)
                        value1 = mandt.image_name.ToString();
                    if (mandt.file_name != null)
                        value2 = mandt.file_name.ToString();
                    field1 = "image_name";
                    field2 = "file_name";
                    break;
                case "13":
                    obj_table = "theses";
                    theses_DT thesdt = theses_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    control_name = "~/user_controls/theses.ascx";
                    if (thesdt.image_name != null)
                        value1 = thesdt.image_name.ToString();
                    if (thesdt.file_name != null)
                        value2 = thesdt.file_name.ToString();
                    field1 = "image_name";
                    field2 = "file_name";
                    break;

                case "14":
                    obj_table = "conference_proceedings";
                    conference_proceedings_DT confdt = conference_proceedings_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    control_name = "~/user_controls/conference_proceed.ascx";
                    if (confdt.image_name != null)
                        value1 = confdt.image_name.ToString();
                    if (confdt.file_name != null)
                        value2 = confdt.file_name.ToString();
                    field1 = "image_name";
                    field2 = "file_name";
                    break;
                case "15":
                    control_name = "~/user_controls/website_template.ascx";
                    WebSites_Template_DT wsdt = WebSites_Template_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    if (wsdt.image_name != null)
                        value1 = wsdt.image_name.ToString();
                    field1 = "image_name";
                    obj_table = "WebSites_Template";
                    break;
                case "16":
                    control_name = "~/user_controls/add_glossary.ascx";
                    glossary_DT glosdt = glossary_DB.SelectByID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue));
                    obj_table = "glossary";
                    break;


            }

            lockTr.Visible = true;
            tr_file.Visible = true;
            
            btn_save_all.Visible = true;
            if (lockChckBox.Checked == true)
            {
                DataTable dtcomm = General_Helping.GetDataTable("select * from quality_comments_file where content_id=" + CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) + " and content_type=" + CDataConverter.ConvertToInt(object_type.SelectedValue));
                if (dtcomm.Rows.Count > 0)
                {
                    TabPanel12.Enabled = true;
                    gvContentFiles.DataSource = dtcomm;
                    gvContentFiles.DataBind();

                    txt31.Text = dtcomm.Rows[0]["notes"].ToString();
                }
                else
                {
                    TabPanel12.Enabled = false;
                }

                if (menus_update.get_current_lang() == 1)
                {
                    control_panel.Visible = true;
                    control_panel.Controls.Clear();
                    TabContainer1.Visible = true;
                    TabPanel1.Enabled =
                    TabPanel2.Enabled =
                    TabPanel3.Enabled =
                    TabPanel4.Enabled =
                    TabPanel5.Enabled =
                    TabPanel6.Enabled =
                    TabPanel8.Enabled =
                    TabPanel9.Enabled =
                    TabPanel7.Enabled = true;
                    // tr_e3tmad.Visible = true;
                    Control user_ctrl = (Control)LoadControl(control_name);
                    HiddenField Hfield_content_type = (HiddenField)user_ctrl.FindControl("content_type");
                    Hfield_content_type.Value = object_type.SelectedValue;
                    HiddenField Hfield_content_id = (HiddenField)user_ctrl.FindControl("content_id");
                    Hfield_content_id.Value = Smrt_Srch_object.SelectedValue;
                    control_panel.Controls.Add(user_ctrl);

                    control_loaded.Value = object_type.SelectedValue;

                    // Main element hidden values

                    HiddenField Hfield_content_type1 = (HiddenField)main_elements1.FindControl("content_type");
                    Hfield_content_type1.Value = object_type.SelectedValue;
                    HiddenField Hfield_content_id1 = (HiddenField)main_elements1.FindControl("content_id");
                    Hfield_content_id1.Value = Smrt_Srch_object.SelectedValue;
                    main_elements1.fillGrid();
                    if (Smrt_Srch_object.SelectedValue != "")
                    {
                        if (Session["user_type"] != null)
                        {
                            main_elements1.Enabled();
                        }
                    }
                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) < 5)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel3.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)support_elements2.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)support_elements2.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            support_elements2.fillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    support_elements2.Enabled();
                                }
                            }
                        }
                    }
                    else TabPanel3.Enabled = false;
                    //TabPanel10

                    // Fill errors list
                    if (object_type.SelectedValue == "6" || object_type.SelectedValue == "7")
                        Panel1.Visible = true;
                    if (object_type.SelectedValue == "8" || object_type.SelectedValue == "9" || object_type.SelectedValue == "10")
                        Panel2.Visible = true;
                    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@content_type", CDataConverter.ConvertToInt(object_type.SelectedValue)), new SqlParameter("@form_file", "2") };
                    DataTable errorsDT = DatabaseFunctions.SelectData(sqlParams11, "get_contents_errors");
                    error_type.DataSource = errorsDT;
                    error_type.DataBind();

                    // Fill object files grid
                  SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@content_type", CDataConverter.ConvertToInt(object_type.SelectedValue)) };
                  DataTable filesDT = DatabaseFunctions.SelectData(sqlParams12, "get_content_files");
                  for (int t = 0; t < filesDT.Rows.Count; t++)
                  {
                      if (filesDT.Rows[t]["field_name"].ToString() == field1)
                      {
                          //filesDT.Rows[t]["valid_extension"] = "~/images/" + value1;
                          filesDT.Rows[t]["field_name"] = value1;
                      }
                      if (filesDT.Rows[t]["field_name"].ToString() == field2)
                      {
                          //filesDT.Rows[t]["valid_extension"] = "~/images/" + value2;
                          filesDT.Rows[t]["field_name"] = value2;
                      }
                      if (filesDT.Rows[t]["field_name"].ToString() == field3)
                      {
                          //filesDT.Rows[t]["valid_extension"] = "~/images/" + value3;
                          filesDT.Rows[t]["field_name"] = value3;
                      }



                  }
                  //GridView1.DataSource = filesDT;
                  //GridView1.DataBind();
                  usage_id.DataSource = filesDT;
                  usage_id.DataBind();
                    

    
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
        DataTable DT = new DataTable();
        DataTable errorDT = new DataTable();
        string obj_table2 = "";
        switch (current_content_type)
        {

            case 1: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة شخصية' as title_usage,'' as title1_usage,'' as title2_usage,file_status from characters where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from characters left outer join contents_notes on characters.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where characters.id=" + current_content_id + " and contents_notes.content_type=1 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "characters";
                break;
            case 2: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from events where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from events left outer join contents_notes on events.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where events.id=" + current_content_id + " and contents_notes.content_type=2 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "events";
                break;
            case 3: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from topics where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from topics left outer join contents_notes on topics.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where topics.id=" + current_content_id + " and contents_notes.content_type=3 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "topics";
                break;
            case 4: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة شخصية' as title_usage,'' as title1_usage,'' as title2_usage,file_status from places where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from places left outer join contents_notes on places.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where places.id=" + current_content_id + " and contents_notes.content_type=4 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "places";
                break;
            case 5: DT = General_Helping.GetDataTable("select id,small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from artifacts where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from artifacts left outer join contents_notes on artifacts.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where artifacts.id=" + current_content_id + " and contents_notes.content_type=5 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "artifacts";
                break;
            case 6: DT = General_Helping.GetDataTable("select id,small_image as title,(file_name+extension) as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الفيديو' as title1_usage,'' as title2_usage,file_status from content_media where content_media.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_media left outer join contents_notes on content_media.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_media.id=" + current_content_id + " and contents_notes.content_type=6 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "content_media";
                break;
            case 7: DT = General_Helping.GetDataTable("select id,(file_name+extension) as title,'' as title1,'' as title2,'ملف الصوت' as title_usage,'' as title1_usage,'' as title2_usage,file_status from content_media where content_media.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_media left outer join contents_notes on content_media.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_media.id=" + current_content_id + " and contents_notes.content_type=7 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "content_media";
                
                break;
            case 8: DT = General_Helping.GetDataTable("select id,small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الوثيقة' as title1_usage,'' as title2_usage,file_status from documents  where documents.doc_type=3 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=3 and documents.id=" + current_content_id + " and contents_notes.content_type=8 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "documents";
                break;
            case 9: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف المقالة' as title1_usage,'' as title2_usage,file_status from documents  where documents.doc_type=2 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=2 and documents.id=" + current_content_id + " and contents_notes.content_type=9 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "documents";
                break;
            case 10: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الكتاب' as title1_usage,'' as title2_usage,file_status from documents where documents.doc_type=1 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=1 and documents.id=" + current_content_id + " and contents_notes.content_type=10 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "documents";
                break;
            case 12: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة الغلاف' as title_usage,'ملف المخطوطة' as title1_usage,'' as title2_usage,file_status from manuscripts where manuscripts.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from manuscripts left outer join contents_notes on manuscripts.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where  manuscripts.id=" + current_content_id + " and contents_notes.content_type=12 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "manuscripts";
                break;
            case 13: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة الغلاف' as title_usage,'ملف الاطروحة' as title1_usage,'' as title2_usage,file_status from theses where theses.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from theses left outer join contents_notes on theses.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where theses.id=" + current_content_id + " and contents_notes.content_type=13 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "theses";
                break;
            case 14: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة الغلاف' as title_usage,'ملف البحث' as title1_usage,'' as title2_usage,file_status from conference_proceedings where conference_proceedings.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from conference_proceedings left outer join contents_notes on conference_proceedings.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where conference_proceedings.id=" + current_content_id + " and contents_notes.content_type=14 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "conference_proceedings";
                break;
            case 11: DT = General_Helping.GetDataTable("select id,small_image as title,normal_image as title1,large_image as title2,'صورة صغيرة' as title_usage,'صورة عادية' as title1_usage,'صورة مفصلة' as title2_usage,file_status from content_images where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_images left outer join contents_notes on content_images.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_images.id=" + current_content_id + " and contents_notes.content_type=11 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "content_images";
                break;
            case 15: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة الموقع' as title_usage,'' as title1_usage,'' as title2_usage,file_status from WebSites_Template where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from WebSites_Template left outer join contents_notes on WebSites_Template.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where WebSites_Template.id=" + current_content_id + " and contents_notes.content_type=15 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table2 = "WebSites_Template";
                break;

        }

        DataTable DT1;
        DT1 = MakeNamesTable();

        // Once a table has been created, use the 
        // NewRow to create a DataRow.
        DataRow row;
        row = DT1.NewRow();

        // Then add the new row to the collection.


        if (DT.Rows.Count > 0)
        {
            if (DT.Rows[0]["title"] != null && DT.Rows[0]["title"].ToString() != "")
            {
                row["id"] = DT.Rows[0]["id"].ToString();
                row["title"] = DT.Rows[0]["title"].ToString();
                row["usage"] = DT.Rows[0]["title_usage"].ToString();
                DT1.Rows.Add(row);
            }
            DataRow row1;
            row1 = DT1.NewRow();

            if (DT.Rows[0]["title1"] != null && DT.Rows[0]["title1"].ToString() != "")
            {
                row1["id"] = DT.Rows[0]["id"].ToString();
                row1["title"] = DT.Rows[0]["title1"].ToString();
                row1["usage"] = DT.Rows[0]["title1_usage"].ToString();
                DT1.Rows.Add(row1);
            }
            DataRow row2;
            row2 = DT1.NewRow();
            if (DT.Rows[0]["title2"] != null && DT.Rows[0]["title2"].ToString() != "")
            {
                row2["id"] = DT.Rows[0]["id"].ToString();
                row2["title"] = DT.Rows[0]["title2"].ToString();
                row2["usage"] = DT.Rows[0]["title2_usage"].ToString();
                DT1.Rows.Add(row2);
            }
            if (DT1.Rows.Count > 0)
            {
                GridView1.DataSource = DT1;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            else
            {
                GridView1.DataSource = "";
                //GridView1.DataBind();
                GridView1.Visible = false;
            }
        
        }
        

       
    
////////////// Fill errors grid
                    fill_errors_grid();

                    //else
                    //    lockChckBox.Checked = false;

                    ///////// references
                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) < 6 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 12)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel7.Enabled = true;
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
                        else TabPanel7.Enabled = false;


                    }
                    else TabPanel7.Enabled = false;
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

                    ////////  moalfat
                    if (object_type.SelectedValue == "1")
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            HiddenField Hfield_moalfat_type = (HiddenField)char_moalfat.FindControl("content_type");
                            Hfield_moalfat_type.Value = object_type.SelectedValue;

                            HiddenField Hfield_content_id3 = (HiddenField)char_moalfat.FindControl("content_id");
                            Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                            char_moalfat.fillGrid();
                        }
                    }

                    else { TabPanel6.Enabled = false; }
                    ////////////////// docs authors

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 10 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 9 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 14)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel9.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)docs_authors.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)docs_authors.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            docs_authors.FillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    // docs_authors.Enabled();
                                }
                            }
                        }
                    }
                    else { TabPanel9.Enabled = false; }

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 4)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel10.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)places_translation.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)places_translation.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;

                            places_translation.fillGridVeiws();
                            places_translation.fillDDLsRBts();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    // docs_authors.Enabled();
                                }
                            }
                        }
                    }
                    else { TabPanel10.Enabled = false; }

                    ///////////////////////// Add  manuscript_tab 

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 12)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel11.Enabled = true;
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
                    else { TabPanel11.Enabled = false; }

                }
                else if (menus_update.get_current_lang() == 2 || menus_update.get_current_lang() == 3)
                {
                    //tr_e3tmad.Visible = false;
                    control_panel.Visible = true;
                    control_panel.Controls.Clear();
                    TabContainer1.Visible = true;
                    TabPanel1.Enabled = true;
                    TabPanel2.Enabled =
                    TabPanel3.Enabled =
                    TabPanel4.Enabled =
                    TabPanel5.Enabled =
                    TabPanel6.Enabled =
                    TabPanel7.Enabled = false;
                    TabPanel8.Enabled = true;
                    Control user_ctrl = (Control)LoadControl(control_name);
                    HiddenField Hfield_content_type = (HiddenField)user_ctrl.FindControl("content_type");
                    Hfield_content_type.Value = object_type.SelectedValue;
                    HiddenField Hfield_content_id = (HiddenField)user_ctrl.FindControl("content_id");
                    Hfield_content_id.Value = Smrt_Srch_object.SelectedValue;
                    control_panel.Controls.Add(user_ctrl);

                    control_loaded.Value = object_type.SelectedValue;
                    HiddenField Hfield_timeline_type = (HiddenField)timeline.FindControl("content_type");
                    Hfield_timeline_type.Value = object_type.SelectedValue;
                    HiddenField Hfield_timeline_id = (HiddenField)timeline.FindControl("content_id");
                    Hfield_timeline_id.Value = Smrt_Srch_object.SelectedValue;
                    timeline.fillGrid();

                    if (Smrt_Srch_object.SelectedValue != "")
                    {
                        TabPanel8.Enabled = true;
                        if (Session["user_type"] != null)
                        {
                            timeline.Enabled();
                        }
                    }
                    else { TabPanel8.Enabled = false; }

                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 4)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel10.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)places_translation.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)places_translation.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;

                            places_translation.fillGridVeiws();
                            places_translation.fillDDLsRBts();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    // docs_authors.Enabled();
                                }
                            }
                        }
                    }
                    else { TabPanel10.Enabled = false; }
                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 12)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel11.Enabled = true;
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
                    else { TabPanel11.Enabled = false; }
                    if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 10 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 9 || CDataConverter.ConvertToInt(object_type.SelectedValue) == 14)
                    {
                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            TabPanel9.Enabled = true;
                            HiddenField Hfield_content_type2 = (HiddenField)docs_authors.FindControl("content_type");
                            Hfield_content_type2.Value = object_type.SelectedValue;
                            HiddenField Hfield_content_id2 = (HiddenField)docs_authors.FindControl("content_id");
                            Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                            docs_authors.FillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)
                                {
                                    // docs_authors.Enabled();
                                }
                            }
                        }
                        else { TabPanel9.Enabled = false; }
                    }
                    else { TabPanel9.Enabled = false; }
                }
            }

            else
            {
                TabPanel1.Enabled =
                    TabPanel2.Enabled =
                    TabPanel3.Enabled =
                    TabPanel4.Enabled =
                    TabPanel5.Enabled =
                    TabPanel6.Enabled =
                    TabPanel8.Enabled =
                    TabPanel9.Enabled =
                    TabPanel7.Enabled = false;
            }
        }
    }
    protected void GridView1_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {

        string current_content_type = object_type.SelectedValue;
        if ((e.Row.RowType == DataControlRowType.DataRow))
        {
            //assuming that the required value column is the second column in gridview  e.Row.Cells[1].Text 
            LinkButton lb = (LinkButton)e.Row.FindControl("title");

            ((LinkButton)e.Row.FindControl("title")).Attributes.Add("onclick", "javascript:Openfile('" + lb.Text + "','" + current_content_type + "')");
        }
    }
    public void fill_errors_grid()
    {
        SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@content_id", CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue)),new SqlParameter("@content_type", CDataConverter.ConvertToInt(object_type.SelectedValue)),
                                                                
                                                                new SqlParameter("@id", CDataConverter.ConvertToInt("0")),
            };
        DataTable errorsGridDT = DatabaseFunctions.SelectData(sqlParams13, "get_contents_notes_Select_final");

        GridView2.DataSource = errorsGridDT;
        GridView2.DataBind();
    }
    protected void Smrt_Srch_object_SelectedIndexChanged(object sender, EventArgs e)
    {
        //load_control();
    }
    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Smrt_Srch_object.SelectedValue != "")
            Smrt_Srch_object.Clear_Selected();
        control_panel.Controls.Clear();
        TabContainer1.Visible = false;
        lockTr.Visible = false;
        tr_file.Visible = false;
        radlist.Items[0].Selected = false;
        radlist.Items[1].Selected = false;
        btn_save_all.Visible = false;
        Fill_smart(object_type.SelectedValue);
    }
    protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "RemoveItem")
        {
            int i = contents_notes_DB.Delete(CDataConverter.ConvertToInt(e.CommandArgument.ToString()));
            fill_errors_grid();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void btn_save_errors_Click(object sender, EventArgs e)
    {

        contents_notes_DT nDt = new contents_notes_DT();
        nDt.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        nDt.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
        nDt.error_id = CDataConverter.ConvertToInt(error_type.SelectedValue);
        nDt.error_status = 4;
        nDt.error_type = 2;
        string errorPlace = "";
        if (Panel1.Visible == true)
        {
            errorPlace = second.Text + "#" + minute.Text + "#" + hours.Text;
            nDt.error_place = errorPlace;
        }
        else
        {
            errorPlace = page_no.Text;
            nDt.error_place = errorPlace;
        }
        nDt.usage_id = CDataConverter.ConvertToInt(usage_id.SelectedValue);
        nDt.revision_note = notes.Text;
        nDt.revision_note_date = DateTime.Now.ToShortDateString();
        int result = contents_notes_DB.Save(nDt);

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
        string updatesql = "update " + obj_table + " set file_status=10";
        updatesql += " where id=" + Smrt_Srch_object.SelectedValue;
        int z = General_Helping.ExcuteQuery(updatesql);

        // Recording log action
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
        clog.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        clog.operation_id = 6;
        clog.user_id = CDataConverter.ConvertToInt(Session["user_id"].ToString());
	clog.lang_id = menus_update.get_current_lang();
        clog.note_date = DateTime.Now.ToShortDateString();
        int rslut = contents_log_DB.Save(clog);

        fill_errors_grid();
    }
    protected void btn_save_all_Click(object sender, EventArgs e)
    {

        if (CDataConverter.ConvertToInt(object_type.SelectedValue) == 0 || CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) == 0)
            return;
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
            sql = "select lock_files,form_lock from " + obj_table + " where lock_files= " + Session["user_id"].ToString();
            sql += " and form_lock = " + Session["user_id"].ToString();
            sql += " and id=" + Smrt_Srch_object.SelectedValue;
        }
        if (menus_update.get_current_lang() == 2)
        {
            sql = "select form_lock_en from " + obj_table + " where ";
            sql += " form_lock_en = " + Session["user_id"].ToString();
            sql += " and id=" + Smrt_Srch_object.SelectedValue;
        }
        if (menus_update.get_current_lang() == 3)
        {
            sql = "select form_lock_fr from " + obj_table + " where ";
            sql += " form_lock_fr = " + Session["user_id"].ToString();
            sql += " and id=" + Smrt_Srch_object.SelectedValue;
        }
        DataTable dt_lock = General_Helping.GetDataTable(sql);
        if (dt_lock.Rows.Count == 0)
        { return; }
        //// ??????????????????  ////
        string updateLock = "";
        if (menus_update.get_current_lang() == 1)
        {
            updateLock = "update " + obj_table + " set form_lock=0,lock_files=0 ";
            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
        }
        if (menus_update.get_current_lang() == 2)
        {
            updateLock = "update " + obj_table + " set form_lock_en=0 ";
            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
        }
        if (menus_update.get_current_lang() == 3)
        {
            updateLock = "update " + obj_table + " set form_lock_fr=0";
            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
        }

        int reslt = General_Helping.ExcuteQuery(updateLock);

        string updatesql2 = "";
        int z = 0;

        if (radlist.Items[0].Selected == true)
        {
            if (menus_update.get_current_lang() == 1)
            {
                updatesql2 = "update " + obj_table + " set file_status=6,form_status=1 ";
                updatesql2 += " where id=" + Smrt_Srch_object.SelectedValue;


            }
            else if (menus_update.get_current_lang() == 2)
            {
                updatesql2 = "update " + obj_table + " set form_status_en=1 ";
                updatesql2 += " where id=" + Smrt_Srch_object.SelectedValue;



            }
            else if (menus_update.get_current_lang() == 3)
            {
                updatesql2 = "update " + obj_table + " set form_status_fr=1 ";
                updatesql2 += " where id=" + Smrt_Srch_object.SelectedValue;

            }
            z = General_Helping.ExcuteQuery(updatesql2);
            //Session["sendto"] = "entry";
            // Recording log action
            contents_log_DT clog = new contents_log_DT();
            clog.id = 0;
            clog.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
            clog.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
            clog.operation_id = 8;
            clog.lang_id = menus_update.get_current_lang();
            clog.user_id = CDataConverter.ConvertToInt(Session["user_id"].ToString());
            clog.note_date = DateTime.Now.ToShortDateString();
            int rslut = contents_log_DB.Save(clog);
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال العنصر إلى مرحلة الإدخال ')</script>");
            TabContainer1.Visible = false;
            lockTr.Visible = false;
            tr_file.Visible = false;
            radlist.Items[0].Selected = false;
            radlist.Items[1].Selected = false;
            btn_save_all.Visible = false;
            if (Smrt_Srch_object.SelectedValue != "")
                Smrt_Srch_object.Clear_Selected();
            control_panel.Controls.Clear();
            Fill_smart(object_type.SelectedValue);
            
        }
    
        else if (radlist.Items[1].Selected == true)
        {
            if (menus_update.get_current_lang() == 1)
            {
                string selectsql = "select form_status from " + obj_table;
                selectsql += " where id=" + Smrt_Srch_object.SelectedValue;
                DataTable infoDT = General_Helping.GetDataTable(selectsql);
                if (infoDT.Rows.Count > 0)
                {
                    string hh = infoDT.Rows[0]["form_status"].ToString();
                    if (infoDT.Rows[0]["form_status"].ToString() == "11")
                    {
                        string updatesql = "update " + obj_table + " set file_status=12,form_status=12 ";
                        updatesql += " where id=" + Smrt_Srch_object.SelectedValue;
                        z = General_Helping.ExcuteQuery(updatesql);
                        //Session["sendto"] = "frontend";
                        // Recording log action
                        contents_log_DT clog = new contents_log_DT();
                        clog.id = 0;
                        clog.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
                        clog.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
                        clog.operation_id = 16;
			clog.lang_id = menus_update.get_current_lang();
                        clog.user_id = CDataConverter.ConvertToInt(Session["user_id"].ToString());
                        clog.note_date = DateTime.Now.ToShortDateString();
                        int rslut = contents_log_DB.Save(clog);


                    }
                }
            }
            if (menus_update.get_current_lang() == 2)
            {
                string selectsql = "select form_status_en from " + obj_table;
                selectsql += " where id=" + Smrt_Srch_object.SelectedValue;
                DataTable infoDT = General_Helping.GetDataTable(selectsql);
                if (infoDT.Rows.Count > 0)
                {
                    string hh = infoDT.Rows[0]["form_status_en"].ToString();
                    if (infoDT.Rows[0]["form_status_en"].ToString() == "11")
                    {
                        string updatesql = "update " + obj_table + " set form_status_en=12 ";
                        updatesql += " where id=" + Smrt_Srch_object.SelectedValue;
                        z = General_Helping.ExcuteQuery(updatesql);
                        //Session["sendto"] = "frontend";
                        // Recording log action
                        contents_log_DT clog = new contents_log_DT();
                        clog.id = 0;
                        clog.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
                        clog.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
                        clog.operation_id = 16;
			clog.lang_id = menus_update.get_current_lang();
                        clog.user_id = CDataConverter.ConvertToInt(Session["user_id"].ToString());
                        clog.note_date = DateTime.Now.ToShortDateString();
                        int rslut = contents_log_DB.Save(clog);
                    }
                }
            }
            if (menus_update.get_current_lang() == 3)
            {
                string selectsql = "select form_status_fr from " + obj_table;
                selectsql += " where id=" + Smrt_Srch_object.SelectedValue;
                DataTable infoDT = General_Helping.GetDataTable(selectsql);
                if (infoDT.Rows.Count > 0)
                {
                    string hh = infoDT.Rows[0]["form_status_fr"].ToString();
                    if (infoDT.Rows[0]["form_status_fr"].ToString() == "11")
                    {
                        string updatesql = "update " + obj_table + " set form_status_fr=12 ";
                        updatesql += " where id=" + Smrt_Srch_object.SelectedValue;
                        z = General_Helping.ExcuteQuery(updatesql);
                        //Session["sendto"] = "frontend";
                        // Recording log action//

                        contents_log_DT clog = new contents_log_DT();
                        clog.id = 0;
                        clog.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
                        clog.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
                        clog.operation_id = 16;
			clog.lang_id = menus_update.get_current_lang();
                        clog.user_id = CDataConverter.ConvertToInt(Session["user_id"].ToString());
                        clog.note_date = DateTime.Now.ToShortDateString();
                        int rslut = contents_log_DB.Save(clog);

                    }
                }
            }
            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم الانتهاء من المراجعة النهائية للعنصر ')</script>");
            TabContainer1.Visible = false;
            lockTr.Visible = false;
            tr_file.Visible = false;
            radlist.Items[0].Selected = false;
            radlist.Items[1].Selected = false;
            btn_save_all.Visible = false;
            if (Smrt_Srch_object.SelectedValue != "")
                Smrt_Srch_object.Clear_Selected();
            control_panel.Controls.Clear();
            Fill_smart(object_type.SelectedValue);
           
        }
        
    }
   
    protected void lockBtn_Click(object sender, EventArgs e)
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
        if (lockChckBox.Checked == true)
        {
            string updateLock = "";
            if (menus_update.get_current_lang() == 1)
            {
                updateLock = "update " + obj_table + " set form_lock=" + Session["user_id"].ToString() + ",lock_files=" + Session["user_id"].ToString();
                updateLock += " where id=" + Smrt_Srch_object.SelectedValue;

            }
            if (menus_update.get_current_lang() == 2)
            {
                updateLock = "update " + obj_table + " set form_lock_en=" + Session["user_id"].ToString();
                updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                //int reslt = General_Helping.ExcuteQuery(updateLock);
                //lockChckBox.Enabled = false;
                //lockBtn.Enabled = false;
            }
            if (menus_update.get_current_lang() == 3)
            {
                updateLock = "update " + obj_table + " set form_lock_fr=" + Session["user_id"].ToString();
                updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                //int reslt = General_Helping.ExcuteQuery(updateLock);
                //lockChckBox.Enabled = false;
                //lockBtn.Enabled = false;
            }
            int result = General_Helping.ExcuteQuery(updateLock);
            lockChckBox.Enabled = false;
            lockBtn.Enabled = false;
            // Recording log action // 
            contents_log_DT clog = new contents_log_DT();
            clog.id = 0;
            clog.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
            clog.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
            clog.operation_id = 15;
            clog.lang_id = menus_update.get_current_lang();
            clog.user_id = CDataConverter.ConvertToInt(Session["user_id"].ToString());
            clog.note_date = DateTime.Now.ToShortDateString();
            int rslut = contents_log_DB.Save(clog);
            load_control();
        }
    }
private DataTable MakeNamesTable()
    {
        // Create a new DataTable titled 'Names.'
        DataTable namesTable = new DataTable("Names");

        // Add three column objects to the table.
        DataColumn idColumn = new DataColumn();
        idColumn.DataType = System.Type.GetType("System.Int32");
        idColumn.ColumnName = "id";
        idColumn.DefaultValue = 0;
        namesTable.Columns.Add(idColumn);

        DataColumn fColumn = new DataColumn();
        fColumn.DataType = System.Type.GetType("System.String");
        fColumn.ColumnName = "title";
        fColumn.DefaultValue = "title";
        namesTable.Columns.Add(fColumn);

        DataColumn usage_Column = new DataColumn();
        usage_Column.DataType = System.Type.GetType("System.String");
        usage_Column.ColumnName = "usage";
        usage_Column.DefaultValue = "usage";
        namesTable.Columns.Add(usage_Column);


        // Create an array for DataColumn objects.
        DataColumn[] keys = new DataColumn[2];
        //keys[0] = idColumn;
        //namesTable.PrimaryKey = keys;

        // Return the new DataTable.
        return namesTable;
    }
    protected void gvContentFiles_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {


        if ((e.Row.RowType == DataControlRowType.DataRow))
        {
            //assuming that the required value column is the second column in gridview  e.Row.Cells[1].Text 
            LinkButton lb = (LinkButton)e.Row.FindControl("title");

            ((LinkButton)e.Row.FindControl("title")).Attributes.Add("onclick", "javascript:Openfile('" + lb.Text + "','" + 17 + "')");
        }
    }


    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //bool rslt = security_issues.check_date(TextBox1.Text);
    }
}