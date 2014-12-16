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

public partial class administration_files_revision : System.Web.UI.Page
{
    public static string id = "";
    General_Helping Obj_General_Helping = new General_Helping();
    private string sql_Connection = Database.ConnectionString;
    protected override void OnInit(EventArgs e)
    {
        this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);
        this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data_index_changed);
        base.OnInit(e);
    }
    private void MOnMember_Data_index_changed(string Value)
    {
        if (Value != "")
        {
            string obj_table = "";
            switch (ddlElementType.SelectedValue)
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
                    obj_table = "conferences";
                    break;
            }
            if (ddlElementType.SelectedValue != "0")
            {
                string sql = "select lock_files from " + obj_table + " where lock_files= " + Session["user_id"].ToString();
                sql += " and id=" + Smrt_Srch_object.SelectedValue;
                DataTable dt_lock = General_Helping.GetDataTable(sql);
            
            if (dt_lock.Rows.Count > 0)
            {
                lockChckBox.Enabled = false;
                lockChckBox.Checked = true;
                lockBtn.Enabled = false;
                btnsave.Visible = true;
                btnSavePage.Visible = true;
                chkDone.Visible = true;
                gvContentFiles.Visible = false;
                gvErrors.Visible = false;
                if (id != "")
                {
                    fillGrid();
                    fillerrorDlls();
                }

            }
            else
            {
                lockTr.Visible = true;
                lockChckBox.Enabled = true;
                lockChckBox.Checked = false;
                lockBtn.Enabled = true;
                btnsave.Visible = false;
                btnSavePage.Visible = false;
                chkDone.Visible = false;
                gvContentFiles.Visible = false;
                gvErrors.Visible = false;
                trErrorType.Visible = false;
                trErrorNotes.Visible = false;
                trDocErrors.Visible = false;
                trfileUsage.Visible = false;
            }
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
    private void MOnMember_Data(string Value)
    { //public void fill_objects_titles()
        //{
        string setvalue = "";
        DataTable dt = new DataTable();
        if (Request["operation"].ToString() == "new")
            setvalue = "8";
        if (Request["operation"].ToString() == "unfinished")
            setvalue = "26";
        if (Request["operation"].ToString() == "refused")
            setvalue = "10";
        if (Request["operation"].ToString() == "corrected")
            setvalue = "18";
        if (Value != "")
        {
            id = Smrt_Srch_object.SelectedValue;
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
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
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
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams5, "get_artifacts_titles");
                    Smrt_Srch_object.stored = "get_artifacts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams5;
                    break;
                case "6":
                    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang().ToString())};
                    //  dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
                    Smrt_Srch_object.stored = "get_video_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams6;
                    break;
                case "7":
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang().ToString())};
                    //dt = DatabaseFunctions.SelectData(sqlParams7, "get_audio_titles");
                    Smrt_Srch_object.stored = "get_audio_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams7;
                    break;
                case "8":
                    SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams8, "get_docs_titles");
                    Smrt_Srch_object.stored = "get_docs_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams8;
                    break;
                case "9":
                    SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams9, "get_articles_titles");
                    Smrt_Srch_object.stored = "get_articles_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams9;
                    break;
                case "10":
                    SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams10, "get_books_titles");
                    Smrt_Srch_object.stored = "get_books_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams10;
                    break;
                case "11":
                    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang().ToString())};
                    //dt = DatabaseFunctions.SelectData(sqlParams11, "get_images_titles");
                    Smrt_Srch_object.stored = "get_images_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams11;
                    break;
                case "12":
                    SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams12, "get_manuscripts_titles");
                    Smrt_Srch_object.stored = "get_manuscripts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams12;
                    break;

                case "13":
                    SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams13, "get_theses_titles");
                    Smrt_Srch_object.stored = "get_theses_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams13;
                    break;
                case "14":
                    SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview",setvalue) , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
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
            }
        }

        Smrt_Srch_object.Value_Field = "id";
        Smrt_Srch_object.Text_Field = "title";
        Smrt_Srch_object.DataBind();
        MOnMember_Data_index_changed(Smrt_Srch_object.SelectedValue);



    }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["user_type"].ToString() != "7")
                Response.Redirect("~/administration/login.aspx");
            //filldll();
            fill_data();
        }
    }
    public void log(int operation_id)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = current_content_type;
        clog.content_id = current_content_id;
        clog.operation_id = operation_id;
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.note_date = DateTime.Now.ToShortDateString();
        int rslut = contents_log_DB.Save(clog);
    }
    public void fill_data()
    {
        if (Request["operation"] != null)
        {
            DataTable objectsDT = content_types_DB.SelectAll();
            ddlElementType.DataSource = content_types_DB.SelectAll();
            ddlElementType.DataBind();

            int counter = objectsDT.Rows.Count;
            if (Request["operation"].ToString() == "new")
            {
                type_mode.Value = "8";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "8"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
                DataTable newDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
                if (newDT.Rows.Count > 0)
                {
                    for (int count = 0; count < counter; count++)
                    {
                        DataRow[] foundRows;
                        foundRows = newDT.Select("ctype = '" + ddlElementType.Items[count].Value + "'");
                        if (foundRows.Length == 0 && ddlElementType.Items[count].Value != "0")
                            objectsDT.Rows[count].Delete();
                    }
                }

                ddlElementType.DataSource = objectsDT;
                ddlElementType.DataBind();
                ListItem litem = new ListItem(".. اختر عنصر ..", "0");
                litem.Selected = true;
                ddlElementType.Items.Insert(0, litem);
            }
            else if (Request["operation"].ToString() == "unfinished")
            {
                type_mode.Value = "26";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "26"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
                DataTable unfinishedDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
                if (unfinishedDT.Rows.Count > 0)
                {
                    for (int count = 0; count < counter; count++)
                    {
                        DataRow[] foundRows;
                        foundRows = unfinishedDT.Select("ctype = '" + ddlElementType.Items[count].Value + "'");
                        if (foundRows.Length == 0 && ddlElementType.Items[count].Value != "0")
                            objectsDT.Rows[count].Delete();
                    }
                }

                ddlElementType.DataSource = objectsDT;
                ddlElementType.DataBind();
                ListItem litem = new ListItem(".. اختر عنصر ..", "0");
                litem.Selected = true;
                ddlElementType.Items.Insert(0, litem);
            }
           
            else if (Request["operation"].ToString() == "refused")
            {
                type_mode.Value = "10";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "10"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
                DataTable refusedDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
                if (refusedDT.Rows.Count > 0)
                {
                    for (int count = 0; count < counter; count++)
                    {
                        DataRow[] foundRows;
                        foundRows = refusedDT.Select("ctype = '" + ddlElementType.Items[count].Value + "'");
                        if (foundRows.Length == 0 && ddlElementType.Items[count].Value != "0")
                            objectsDT.Rows[count].Delete();
                    }
                }

                ddlElementType.DataSource = objectsDT;
                ddlElementType.DataBind();
                ListItem litem = new ListItem(".. اختر عنصر ..", "0");
                litem.Selected = true;
                ddlElementType.Items.Insert(0, litem);
            }
            else if (Request["operation"].ToString() == "corrected")
            {
                type_mode.Value = "18";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "18"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
                DataTable correctedDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
                if (correctedDT.Rows.Count > 0)
                {
                    for (int count = 0; count < counter; count++)
                    {
                        DataRow[] foundRows;
                        foundRows = correctedDT.Select("ctype = '" + ddlElementType.Items[count].Value + "'");
                        if (foundRows.Length == 0 && ddlElementType.Items[count].Value != "0")
                            objectsDT.Rows[count].Delete();
                    }
                }

                ddlElementType.DataSource = objectsDT;
                ddlElementType.DataBind();
                ListItem litem = new ListItem(".. اختر عنصر ..", "0");
                litem.Selected = true;
                ddlElementType.Items.Insert(0, litem);
            }
           
        }
    }
    private void fillGrid()
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        DataTable DT = new DataTable();
        DataTable errorDT = new DataTable();
        string obj_table = "";
        switch (current_content_type)
        {

            case 1:
                DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة شخصية' as title_usage,'' as title1_usage,'' as title2_usage,file_status from characters where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from characters left outer join contents_notes on characters.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where characters.id=" + current_content_id + " and contents_notes.content_type=1 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "characters";
                break;
            case 2: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from events where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from events left outer join contents_notes on events.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where events.id=" + current_content_id + " and contents_notes.content_type=2 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "events";
                break;
            case 3: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from topics where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from topics left outer join contents_notes on topics.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where topics.id=" + current_content_id + " and contents_notes.content_type=3 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "topics";
                break;
            case 4:
                DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة شخصية' as title_usage,'' as title1_usage,'' as title2_usage,file_status from places where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from places left outer join contents_notes on places.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where places.id=" + current_content_id + " and contents_notes.content_type=4 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "places";
                break;
            case 5: DT = General_Helping.GetDataTable("select id,small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from artifacts where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from artifacts left outer join contents_notes on artifacts.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where artifacts.id=" + current_content_id + " and contents_notes.content_type=5 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "artifacts";
                break;
            case 6: DT = General_Helping.GetDataTable("select id,small_image as title,(file_name+extension) as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الفيديو' as title1_usage,'' as title2_usage,file_status from content_media where content_media.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_media left outer join contents_notes on content_media.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_media.id=" + current_content_id + " and contents_notes.content_type=6 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "content_media";
                break;
            case 7: DT = General_Helping.GetDataTable("select id,(file_name+extension) as title,'' as title1,'' as title2,'ملف الصوت' as title_usage,'' as title1_usage,'' as title2_usage,file_status from content_media where content_media.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_media left outer join contents_notes on content_media.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_media.id=" + current_content_id + " and contents_notes.content_type=7 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "content_media";
                break;
            case 8: DT = General_Helping.GetDataTable("select id,small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الوثيقة' as title1_usage,'' as title2_usage,file_status from documents  where documents.doc_type=3 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=3 and documents.id=" + current_content_id + " and contents_notes.content_type=8 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "documents";
                break;
            case 9: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف المقالة' as title1_usage,'' as title2_usage,file_status from documents  where documents.doc_type=2 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=2 and documents.id=" + current_content_id + " and contents_notes.content_type=9 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "documents";
                break;
            case 10: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الكتاب' as title1_usage,'' as title2_usage,file_status from documents where documents.doc_type=1 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=1 and documents.id=" + current_content_id + " and contents_notes.content_type=10 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "documents";
                break;
            case 12: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف المخطوطة' as title1_usage,'' as title2_usage,file_status from manuscripts where manuscripts.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from manuscripts left outer join contents_notes on manuscripts.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where  manuscripts.id=" + current_content_id + " and contents_notes.content_type=12 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "manuscripts";
                break;
            case 13: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الاطروحة' as title1_usage,'' as title2_usage,file_status from theses where theses.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from theses left outer join contents_notes on theses.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where theses.id=" + current_content_id + " and contents_notes.content_type=13 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "theses";
                break;
            case 14: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف البحث' as title1_usage,'' as title2_usage,file_status from conference_proceedings where conference_proceedings.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from conference_proceedings left outer join contents_notes on conference_proceedings.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where conference_proceedings.id=" + current_content_id + " and contents_notes.content_type=14 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by  error_status,contents_notes.id desc");
                obj_table = "conference_proceedings";
                break;
            case 11: DT = General_Helping.GetDataTable("select id,small_image as title,normal_image as title1,large_image as title2,'صورة صغيرة' as title_usage,'صورة عادية' as title1_usage,'صورة مفصلة' as title2_usage,file_status from content_images where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_images left outer join contents_notes on content_images.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_images.id=" + current_content_id + " and contents_notes.content_type=11 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by error_status,contents_notes.id desc");
                obj_table = "content_images";
                break;
            case 15: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة الموقع' as title_usage,'' as title1_usage,'' as title2_usage,file_status from WebSites_Template where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select error_status,usage,error_place,observer_note,error_name,contents_notes.id,file_status from WebSites_Template left outer join contents_notes on WebSites_Template.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where WebSites_Template.id=" + current_content_id + " and contents_notes.content_type=15 and contents_notes.error_status in (1,2,4) and contents_notes.error_type=2 order by error_status,contents_notes.id desc");
                obj_table = "WebSites_Template";
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
            gvContentFiles.DataSource = DT1;
            gvContentFiles.DataBind();
            gvContentFiles.Visible = true;
            
        }
        else
        {
            gvContentFiles.DataSource = "";
            gvContentFiles.DataBind();
            gvContentFiles.Visible = true;
            
        }
        //lblpageMsg.Visible = false;
        gvErrors.DataSource = errorDT;
        gvErrors.DataBind();
        gvErrors.Visible = true;
        if (type_mode.Value != "11")
        {
            trErrorType.Visible = true;
            trErrorNotes.Visible = true;
            trfileUsage.Visible = true;
        }
        if (current_content_type == 6 || current_content_type==7)
            trAudVidErrors.Visible = true;
        else
            trAudVidErrors.Visible = false;
        if (current_content_type == 8 || current_content_type == 9 || current_content_type == 10)
            trDocErrors.Visible = true;
        else
            trDocErrors.Visible = false;

        lockTr.Visible = true;
        lockChckBox.Enabled = true;
        lockBtn.Enabled = true;
        //lockChckBox.Checked = false;
        string updateLock = "select lock_files from " + obj_table;
        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
        DataTable dt = General_Helping.GetDataTable(updateLock);
        if (dt.Rows.Count > 0)
            if (Convert.ToInt16(dt.Rows[0]["lock_files"].ToString()) > 0)
            {
                lockChckBox.Enabled = false;
                lockChckBox.Checked = true;
                lockBtn.Enabled = false;
            }
            else
                lockChckBox.Checked = false;
        }
        else
        {
            gvContentFiles.DataSource = "";
            gvContentFiles.DataBind();
            gvContentFiles.Visible = true;
            
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
    protected void lockBtn_Click(object sender, EventArgs e)
    {
        string obj_table = "";
        switch (ddlElementType.SelectedValue)
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
                obj_table = "conferences";
                break;
        }
        if (lockChckBox.Checked == true)
        {
            string updateLock = "update " + obj_table + " set lock_files=" + Session["user_id"].ToString();
            updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
            int reslt = General_Helping.ExcuteQuery(updateLock);
            log(15);
            lockChckBox.Enabled = false;
            lockChckBox.Checked = true;
            btnsave.Visible = true;
            btnSavePage.Visible = true;
            chkDone.Visible = true;
            lockBtn.Enabled = false;
            fillGrid();
            fillerrorDlls();
        }
    }
    protected void ddlElementType_SelectedIndexChanged(object sender, EventArgs e)
    {
        //lblpage.Visible = false;
        ddlTypeChanged();

    }
    //protected void ddlElementName_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (ddlElementName.SelectedIndex != 0)
    //    {
    //        fillGrid();
    //        int current_content_id = CDataConverter.ConvertToInt(ddlElementName.SelectedValue);
    //        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
    //        General_Helping.ExcuteQuery("update contents_notes set error_status=1 where contents_notes.error_status=4 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=" + current_content_type);
    //        fillerrorDlls();
    //    }
    //}
    protected void ddlErrorType_SelectedIndexChanged(object sender, EventArgs e)
    {
        //lblpage.Visible = false;
        ddlErrorTypeChanged();

    }
    protected void ddlErrorTypeChanged()
    {
        if (ddlErrorType.SelectedIndex != 0)
        {

            switch (CDataConverter.ConvertToInt(ddlErrorType.SelectedValue))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 8:
                case 14:
                case 10:
                case 15:
                    trDocErrors.Visible = false;
                    trAudVidErrors.Visible = false;
                    break;
                case 12:
                case 6:
                case 7:
                    trDocErrors.Visible = false;
                    trAudVidErrors.Visible = true;
                    break;
                case 9:
                case 11:
                case 13:
                    trDocErrors.Visible = true;
                    trAudVidErrors.Visible = false;
                    break;

            }
           
        }
    }
    protected void filldll()
    {
        DataTable DT = General_Helping.GetDataTable("select id,title from content_types");
        Obj_General_Helping.SmartBindDDL(ddlElementType, DT, "id", "title", ".. اختر عنصر ..");
    }
    protected void fillerrorDlls()
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        DataTable DT = General_Helping.GetDataTable("select id,error_name as title from contents_errors where form_file=2 and content_type=" + current_content_type);
        Obj_General_Helping.SmartBindDDL(ddlErrorType, DT, "id", "title", ".. اختر نوع الخطأ ..");
        DataTable usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type=" + current_content_type);
        Obj_General_Helping.SmartBindDDL(ddlFileUsage, usageDT, "id", "title", ".. اختر إستخدام ..");
    }
    protected void ddlTypeChanged()
    {
        //lblpage.Visible = false;
        if (ddlElementType.SelectedIndex != 0)
        {
            DataTable DT = new DataTable();
            DataTable usageDT = new DataTable();
            switch (CDataConverter.ConvertToInt(ddlElementType.SelectedValue))
            {
                case 1: DT = General_Helping.GetDataTable("select char_id as id,name as title1,'1_'+CAST(char_id as nvarchar(50))+'  '+name as title from characters_details join characters on characters_details.char_id=characters.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and characters.file_status=" + type_mode.Value);
                    
                    break;
                case 2: DT = General_Helping.GetDataTable("select event_id as id,'2_'+CAST(event_id as nvarchar(50))+'  '+title as title from events_details join events on events_details.event_id=events.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and events.file_status=" + type_mode.Value);
                    
                    break;
                case 3: DT = General_Helping.GetDataTable("select topic_id as id,'3_'+CAST(topic_id as nvarchar(50))+'  '+title as title from topics_details join topics on topics_details.topic_id=topics.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and topics.file_status=" + type_mode.Value);
                    
                    break;
                case 4: DT = General_Helping.GetDataTable("select place_id as id,name as title1,'4_'+CAST(place_id as nvarchar(50))+'  '+name as title from places_details join places on places_details.place_id=places.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and places.file_status=" + type_mode.Value);

                    break;
                case 5: DT = General_Helping.GetDataTable("select artifact_id as id,'5_'+CAST(artifact_id as nvarchar(50))+'  '+title as title from artifacts_details join artifacts on artifacts_details.artifact_id=artifacts.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and artifacts.file_status=" + type_mode.Value);
                    
                    break;
                case 6: DT = General_Helping.GetDataTable("select content_media_id as id,'6_'+CAST(content_media_id as nvarchar(50))+'  '+title as title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and content_media.content_media_type=6 and content_media.file_status=" + type_mode.Value);
                    
                    break;
                case 7: DT = General_Helping.GetDataTable("select content_media_id as id,'7_'+CAST(content_media_id as nvarchar(50))+'  '+title as title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and content_media.content_media_type=7 and content_media.file_status=" + type_mode.Value);
                    
                    break;
                case 8: DT = General_Helping.GetDataTable("select doc_id as id,  '8_'+CAST(doc_id as nvarchar(50))+'  '+title as title from documents_details join documents on documents_details.doc_id=documents.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and documents.doc_type=3 and documents.file_status=" + type_mode.Value);
                    
                    break;
                case 9: DT = General_Helping.GetDataTable("select doc_id as id,  '9_'+CAST(doc_id as nvarchar(50))+'  '+title as title from documents_details join documents on documents_details.doc_id=documents.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and documents.doc_type=2 and documents.file_status=" + type_mode.Value);
                    
                    break;
                case 10: DT = General_Helping.GetDataTable("select doc_id as id,  '10_'+CAST(doc_id as nvarchar(50))+'  '+title as title from documents_details join documents on documents_details.doc_id=documents.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and documents.doc_type=1 and documents.file_status=" + type_mode.Value);
                    
                    break;
                case 12: DT = General_Helping.GetDataTable("select manuscript_id as id, '12_'+CAST(manuscript_id as nvarchar(50))+'  '+title as title from manuscripts_details join manuscripts on manuscripts_details.manuscript_id=manuscripts.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and manuscripts.file_status=" + type_mode.Value);
                    
                    break;
                case 13: DT = General_Helping.GetDataTable("select these_id as id, '13_'+CAST(these_id as nvarchar(50))+'  '+title as title from theses_details join theses on theses_details.these_id=theses.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and theses.file_status=" + type_mode.Value);
                    
                    break;
                case 14: DT = General_Helping.GetDataTable("select conference_proceeding_id as id, '14_'+CAST(conference_proceeding_id as nvarchar(50))+'  '+title as title from conference_proceedings_details join conference_proceedings on conference_proceedings_details.conference_proceeding_id=conference_proceedings.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and conference_proceedings.file_status=" + type_mode.Value);
                    
                    break;
                case 11: 
                         DT = General_Helping.GetDataTable("select content_images_details.content_image_id  as id, '11_'+CAST(content_image_id as nvarchar(50))+'  '+ title as title from content_images_details join  content_images on content_images_details.content_image_id=content_images.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and content_images.file_status=" + type_mode.Value);
                    
                    break;
                case 15: DT = General_Helping.GetDataTable("select website_id as id, '15_'+CAST(website_id as nvarchar(50))+'  '+title as title from WebSites_Template_details join WebSites_Template on WebSites_Template_details.website_id=WebSites_Template.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and WebSites_Template.file_status=" + type_mode.Value);

                    break;


            }
            MOnMember_Data(ddlElementType.SelectedValue);

            Smrt_Srch_object.SelectedValue = "";
            Smrt_Srch_object.SelectedText = "";
            lockTr.Visible = false;
        }
        else
        {
            
            //DataTable dttemp = new DataTable();
            //gvContentFiles.DataSource = dttemp;
            //gvContentFiles.DataBind();

        }
    }

    protected void gvContentFiles_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {

        string current_content_type = ddlElementType.SelectedValue;
        if ((e.Row.RowType == DataControlRowType.DataRow))
        {
            //assuming that the required value column is the second column in gridview  e.Row.Cells[1].Text 
            LinkButton lb = (LinkButton)e.Row.FindControl("title");

            ((LinkButton)e.Row.FindControl("title")).Attributes.Add("onclick", "javascript:Openfile('" + lb.Text + "','" + current_content_type + "')");
        }
    }
    protected void gvErrors_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {
        
        //string current_content_type = ddlElementType.SelectedValue;
         if ((e.Row.RowType == DataControlRowType.DataRow))
        {
            //assuming that the required value column is the second column in gridview  e.Row.Cells[1].Text 
            TextBox fs = (TextBox)e.Row.FindControl("txtfileStatus");
            if (fs.Text == "1")
            {
                e.Row.Cells[5].Visible = true;
                e.Row.Cells[6].Visible = true;
                newErrorCount.Value = "1";
            }
            else if (fs.Text == "4")
            {

                e.Row.Cells[5].Visible = false;
                e.Row.Cells[6].Visible = false;
                e.Row.BackColor = System.Drawing.Color.Snow;
                newErrorCount.Value = "1";
            }
             else {
                e.Row.Cells[5].Visible = false;
                e.Row.Cells[6].Visible = false;
            }

            //((LinkButton)e.Row.FindControl("title")).Attributes.Add("onclick", "javascript:Openfile('" + lb.Text + "','" + current_content_type + "')");
        }
        
    }
    public void ImgBtnEdit_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        errorID.Value = ((ImageButton)sender).CommandArgument;
        switch (current_content_type)
        {
            case 1:
                contents_notes_DT char_error_obj_to_veiw = new contents_notes_DT();
                char_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = char_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = char_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = char_error_obj_to_veiw.usage_id.ToString();
                break;
            case 2:
                contents_notes_DT event_error_obj_to_veiw = new contents_notes_DT();
                event_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = event_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = event_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = event_error_obj_to_veiw.usage_id.ToString();
                break;
            case 3:
                contents_notes_DT topics_error_obj_to_veiw = new contents_notes_DT();
                topics_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = topics_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = topics_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = topics_error_obj_to_veiw.usage_id.ToString();

                break;
            case 4:
                contents_notes_DT place_error_obj_to_veiw = new contents_notes_DT();
                place_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = place_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = place_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = place_error_obj_to_veiw.usage_id.ToString();
                break;
            case 5:
                contents_notes_DT artifacts_error_obj_to_veiw = new contents_notes_DT();
                artifacts_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = artifacts_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = artifacts_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = artifacts_error_obj_to_veiw.usage_id.ToString();
                break;
            case 6:
                contents_notes_DT vid_error_obj_to_veiw = new contents_notes_DT();
                vid_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = vid_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = vid_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = vid_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "11")
                {
                    txtHours.Text = vid_error_obj_to_veiw.error_place.ToString().Split(':')[0];
                    ddlMin.SelectedValue = vid_error_obj_to_veiw.error_place.ToString().Split(':')[1];
                    ddlSec.SelectedValue = vid_error_obj_to_veiw.error_place.ToString().Split(':')[2];
                }
                break;
            case 7:
                contents_notes_DT aud_error_obj_to_veiw = new contents_notes_DT();
                aud_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = aud_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = aud_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = aud_error_obj_to_veiw.usage_id.ToString();
                txtHours.Text = aud_error_obj_to_veiw.error_place.ToString().Split(':')[0];
                ddlMin.SelectedValue = aud_error_obj_to_veiw.error_place.ToString().Split(':')[1];
                ddlSec.SelectedValue = aud_error_obj_to_veiw.error_place.ToString().Split(':')[2];
               
                break;

            case 8:
                contents_notes_DT doc_error_obj_to_veiw = new contents_notes_DT();
                doc_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = doc_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = doc_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = doc_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "14")
                txterrorPage.Text = doc_error_obj_to_veiw.error_place.ToString();
               
                break;
            case 9:
                contents_notes_DT artic_error_obj_to_veiw = new contents_notes_DT();
                artic_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = artic_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = artic_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = artic_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "16")
                    txterrorPage.Text = artic_error_obj_to_veiw.error_place.ToString();
               
                break;
            case 10:
                contents_notes_DT book_error_obj_to_veiw = new contents_notes_DT();
                book_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = book_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = book_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = book_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "18")
                    txterrorPage.Text = book_error_obj_to_veiw.error_place.ToString();

                break;
            case 12:
                contents_notes_DT manuscripts_error_obj_to_veiw = new contents_notes_DT();
                manuscripts_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = manuscripts_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = manuscripts_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = manuscripts_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "23")
                    txterrorPage.Text = manuscripts_error_obj_to_veiw.error_place.ToString();

                break;
            case 13:
                contents_notes_DT theses_error_obj_to_veiw = new contents_notes_DT();
                theses_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = theses_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = theses_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = theses_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "25")
                    txterrorPage.Text = theses_error_obj_to_veiw.error_place.ToString();

                break;
            case 14:
                contents_notes_DT conference_proceedings_error_obj_to_veiw = new contents_notes_DT();
                conference_proceedings_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = conference_proceedings_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = conference_proceedings_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = conference_proceedings_error_obj_to_veiw.usage_id.ToString();
                if (ddlFileUsage.SelectedValue == "27")
                    txterrorPage.Text = conference_proceedings_error_obj_to_veiw.error_place.ToString();

                break;
            case 11:
                contents_notes_DT images_error_obj_to_veiw = new contents_notes_DT();
                images_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = images_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = images_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = images_error_obj_to_veiw.usage_id.ToString();
                


                break;
            case 15:
                contents_notes_DT website_error_obj_to_veiw = new contents_notes_DT();
                website_error_obj_to_veiw = contents_notes_DB.SelectByID(CDataConverter.ConvertToInt(errorID.Value));
                ddlErrorType.SelectedValue = website_error_obj_to_veiw.error_id.ToString();
                txtErrorNote.Text = website_error_obj_to_veiw.observer_note;
                ddlFileUsage.SelectedValue = website_error_obj_to_veiw.usage_id.ToString();
                break;
        }
    }
    public void ImgBtnDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        //control_relation_id.Value = ((ImageButton)sender).CommandArgument;
        contents_notes_DB.Delete(CDataConverter.ConvertToInt(((ImageButton)sender).CommandArgument));
        log(35);
        lblpageMsg.Visible = false;
        fillGrid();
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        int current_error_type = CDataConverter.ConvertToInt(ddlErrorType.SelectedValue);
        int current_content_usage = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
       
        if (fileIsValid())
        {

            switch (current_content_type)
            {


                case 1:
                    contents_notes_DT character_contents_notes_obj_to_save = new contents_notes_DT();
                    character_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    character_contents_notes_obj_to_save.content_id = current_content_id;
                    character_contents_notes_obj_to_save.content_type = current_content_type;
                    character_contents_notes_obj_to_save.error_id = current_error_type;
                    character_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    character_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    character_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    character_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    character_contents_notes_obj_to_save.error_type = 2;
                    character_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(character_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 2:
                    contents_notes_DT events_contents_notes_obj_to_save = new contents_notes_DT();
                    events_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    events_contents_notes_obj_to_save.content_id = current_content_id;
                    events_contents_notes_obj_to_save.content_type = current_content_type;
                    events_contents_notes_obj_to_save.error_id = current_error_type;
                    events_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    events_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    events_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    events_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    events_contents_notes_obj_to_save.error_type = 2;
                    events_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(events_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 3:
                    contents_notes_DT topics_contents_notes_obj_to_save = new contents_notes_DT();
                    topics_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    topics_contents_notes_obj_to_save.content_id = current_content_id;
                    topics_contents_notes_obj_to_save.content_type = current_content_type;
                    topics_contents_notes_obj_to_save.error_id = current_error_type;
                    topics_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    topics_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    topics_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    topics_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    topics_contents_notes_obj_to_save.error_type = 2;
                    topics_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(topics_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 4:
                    contents_notes_DT places_contents_notes_obj_to_save = new contents_notes_DT();
                    places_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    places_contents_notes_obj_to_save.content_id = current_content_id;
                    places_contents_notes_obj_to_save.content_type = current_content_type;
                    places_contents_notes_obj_to_save.error_id = current_error_type;
                    places_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    places_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    places_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    places_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    places_contents_notes_obj_to_save.error_type = 2;
                    places_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(places_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 5:
                    contents_notes_DT artifacts_contents_notes_obj_to_save = new contents_notes_DT();
                    artifacts_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    artifacts_contents_notes_obj_to_save.content_id = current_content_id;
                    artifacts_contents_notes_obj_to_save.content_type = current_content_type;
                    artifacts_contents_notes_obj_to_save.error_id = current_error_type;
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 8)
                    artifacts_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 9)
                        artifacts_contents_notes_obj_to_save.error_place = "الصورة المجسمة بالكامل";
                    artifacts_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    artifacts_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    artifacts_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    artifacts_contents_notes_obj_to_save.error_type = 2;
                    artifacts_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(artifacts_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 6:
                    contents_notes_DT vid_contents_notes_obj_to_save = new contents_notes_DT();
                    vid_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    vid_contents_notes_obj_to_save.content_id = current_content_id;
                    vid_contents_notes_obj_to_save.content_type = current_content_type;
                    vid_contents_notes_obj_to_save.error_id = current_error_type;
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue)==10)
                        vid_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    else if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue)==11)
                        vid_contents_notes_obj_to_save.error_place = CDataConverter.ConvertToInt(txtHours.Text).ToString() + ":" + ddlMin.SelectedValue + ":" + ddlSec.SelectedValue;
                    vid_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    vid_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    vid_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    vid_contents_notes_obj_to_save.error_type = 2;
                    vid_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(vid_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 7:
                    contents_notes_DT aud_contents_notes_obj_to_save = new contents_notes_DT();
                    aud_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    aud_contents_notes_obj_to_save.content_id = current_content_id;
                    aud_contents_notes_obj_to_save.content_type = current_content_type;
                    aud_contents_notes_obj_to_save.error_id = current_error_type;
                    aud_contents_notes_obj_to_save.error_place = txtHours.Text + ":" + ddlMin.SelectedValue + ":" + ddlSec.SelectedValue;
                    aud_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    aud_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    aud_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    aud_contents_notes_obj_to_save.error_type = 2;
                    aud_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(aud_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 8:
                    contents_notes_DT doc_contents_notes_obj_to_save = new contents_notes_DT();
                    doc_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    doc_contents_notes_obj_to_save.content_id = current_content_id;
                    doc_contents_notes_obj_to_save.content_type = current_content_type;
                    doc_contents_notes_obj_to_save.error_id = current_error_type;
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 13)
                        doc_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    else if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 14)
                        doc_contents_notes_obj_to_save.error_place = "فى الصفحة رقم :  " + txterrorPage.Text;
                    doc_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    doc_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    doc_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    doc_contents_notes_obj_to_save.error_type = 2;
                    doc_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(doc_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 9:

                    contents_notes_DT artic_contents_notes_obj_to_save = new contents_notes_DT();
                    artic_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    artic_contents_notes_obj_to_save.content_id = current_content_id;
                    artic_contents_notes_obj_to_save.content_type = current_content_type;
                    artic_contents_notes_obj_to_save.error_id = current_error_type;
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 15)
                        artic_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    else if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 16)
                        artic_contents_notes_obj_to_save.error_place = "فى الصفحة رقم :  " + txterrorPage.Text;
                    artic_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    artic_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    artic_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    artic_contents_notes_obj_to_save.error_type = 2;
                    artic_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(artic_contents_notes_obj_to_save);
                    log(4);
                   
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 10:
                case 12:
                case 13:
                case 14:
                    contents_notes_DT book_contents_notes_obj_to_save = new contents_notes_DT();
                    book_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    book_contents_notes_obj_to_save.content_id = current_content_id;
                    book_contents_notes_obj_to_save.content_type = current_content_type;
                    book_contents_notes_obj_to_save.error_id = current_error_type;
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 17 || CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 22 || CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 24 || CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 26)
                        book_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    else if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 18 || CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 23 || CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 25 || CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 27)
                        book_contents_notes_obj_to_save.error_place = "فى الصفحة رقم :  " + txterrorPage.Text;
                    book_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    book_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    book_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    book_contents_notes_obj_to_save.error_type = 2;
                    book_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(book_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 11:
                    contents_notes_DT images_contents_notes_obj_to_save = new contents_notes_DT();
                    images_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    images_contents_notes_obj_to_save.content_id = current_content_id;
                    images_contents_notes_obj_to_save.content_type = current_content_type;
                    images_contents_notes_obj_to_save.error_id = current_error_type;
                    images_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    images_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    images_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    images_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    images_contents_notes_obj_to_save.error_type = 2;
                    images_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(images_contents_notes_obj_to_save);
                    log(4);
                   
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
                case 15:
                    contents_notes_DT website_contents_notes_obj_to_save = new contents_notes_DT();
                    website_contents_notes_obj_to_save.id = CDataConverter.ConvertToInt(errorID.Value);//contents_notes_DB.SelectByID_Type_ErrorID(current_content_id, current_content_type, current_error_type, current_content_usage);
                    website_contents_notes_obj_to_save.content_id = current_content_id;
                    website_contents_notes_obj_to_save.content_type = current_content_type;
                    website_contents_notes_obj_to_save.error_id = current_error_type;
                    website_contents_notes_obj_to_save.error_place = "الصورة بالكامل";
                    website_contents_notes_obj_to_save.observer_note = txtErrorNote.Text;
                    website_contents_notes_obj_to_save.usage_id = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
                    website_contents_notes_obj_to_save.observer_note_date = System.DateTime.Now.ToShortDateString();
                    website_contents_notes_obj_to_save.error_type = 2;
                    website_contents_notes_obj_to_save.error_status = 1;
                    contents_notes_DB.Save(website_contents_notes_obj_to_save);
                    log(4);
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم حفظ الخطأ";
                    fillGrid();
                    break;
            }
            
           
        }
    }
    protected void btnsavePage_Click(object sender, EventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
       
            switch (current_content_type)
            {
                case 1:
                 
                    characters_DT characters_obj_to_save = new characters_DT();
                    characters_obj_to_save = characters_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value!= "0" && chkDone.Checked == true)
                    {
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        characters_obj_to_save.file_status = 9;
                        characters_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        characters_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        characters_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        characters_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    characters_DB.Save(characters_obj_to_save);


                   
                    break;
                case 2:
                   
                        events_DT events_obj_to_save = new events_DT();
                        events_obj_to_save = events_DB.SelectByID(current_content_id);
                        if (newErrorCount.Value != "0" && chkDone.Checked == true)
                        {

                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                            log(9);
                            events_obj_to_save.file_status = 9;
                            events_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();

                        }
                        else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                            events_obj_to_save.file_status = 26;
                        else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                        {
                            events_obj_to_save.file_status = 11;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                            log(7);
                            events_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls(); ;
                        }
                        events_DB.Save(events_obj_to_save);
                       
                    
                    break;
                case 3:
                    
                        topics_DT topics_obj_to_save = new topics_DT();
                        topics_obj_to_save = topics_DB.SelectByID(current_content_id);
                        if (newErrorCount.Value != "0" && chkDone.Checked == true)
                        {

                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                            log(9);
                            topics_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();
                            topics_obj_to_save.file_status = 9;

                        }
                        else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                            topics_obj_to_save.file_status = 26;
                        else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                        {
                            topics_obj_to_save.file_status = 11;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                            log(7);
                            topics_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();
                        }
                        topics_DB.Save(topics_obj_to_save);
                        
                   
                    break;
                case 4:

                    places_DT places_obj_to_save = new places_DT();
                    places_obj_to_save = places_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        places_obj_to_save.file_status = 9;
                        places_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        places_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        places_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        places_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    places_DB.Save(places_obj_to_save);



                    break;
                case 5:

                    artifacts_DT artifacts_obj_to_save = new artifacts_DT();
                    artifacts_obj_to_save = artifacts_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        artifacts_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        artifacts_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        artifacts_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        artifacts_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        artifacts_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    artifacts_DB.Save(artifacts_obj_to_save);




                    break;
                case 6:
                  
                        content_media_DT video_obj_to_save = new content_media_DT();
                        video_obj_to_save = content_media_DB.SelectByID(current_content_id);
                        if (newErrorCount.Value != "0" && chkDone.Checked == true)
                        {

                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                            log(9);
                            video_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();
                            video_obj_to_save.file_status = 9;

                        }
                        else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                            video_obj_to_save.file_status = 26;
                        else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                        {
                            video_obj_to_save.file_status = 11;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                            log(7);
                            video_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();
                        }
                        content_media_DB.Save(video_obj_to_save);
                       
                   
                  

                    break;
                case 7:
                    content_media_DT audio_obj_to_save = new content_media_DT();
                    audio_obj_to_save = content_media_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        audio_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        audio_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        audio_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        audio_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        audio_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    content_media_DB.Save(audio_obj_to_save);
                   

                    break;

                case 8:
                    
                        documents_DT wase2a_obj_to_save = new documents_DT();
                        wase2a_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (newErrorCount.Value != "0" && chkDone.Checked == true)
                        {

                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                            log(9);
                            wase2a_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();
                            wase2a_obj_to_save.file_status = 9;

                        }
                        else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                            wase2a_obj_to_save.file_status = 26;
                        else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                        {
                            wase2a_obj_to_save.file_status = 11;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                            log(7);
                            wase2a_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            btnsave.Visible = false;
                            btnSavePage.Visible = false;
                            chkDone.Visible = false;
                            gvErrors.Visible = false;
                            trErrorType.Visible = false;
                            trErrorNotes.Visible = false;trDocErrors.Visible = false;
                            trfileUsage.Visible = false;
                            fill_data();
                            gvContentFiles.Visible = false;
                            Smrt_Srch_object.Clear_Controls();
                        }
                        documents_DB.Save(wase2a_obj_to_save);
                       
                    
                   
                    break;
                case 9:
                   
                    documents_DT article_obj_to_save = new documents_DT();
                    article_obj_to_save = documents_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        article_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        article_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        article_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        article_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        article_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    documents_DB.Save(article_obj_to_save);

                    break;
                case 10:

                    documents_DT book_obj_to_save = new documents_DT();
                    book_obj_to_save = documents_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        book_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        book_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        book_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        book_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        book_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    documents_DB.Save(book_obj_to_save);
                    break;
                case 12:

                    manuscripts_DT manuscripts_obj_to_save = new manuscripts_DT();
                    manuscripts_obj_to_save = manuscripts_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        manuscripts_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        manuscripts_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        manuscripts_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        manuscripts_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        manuscripts_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    manuscripts_DB.Save(manuscripts_obj_to_save);
                    break;
                case 13:

                    theses_DT theses_obj_to_save = new theses_DT();
                    theses_obj_to_save = theses_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        theses_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        theses_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        theses_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        theses_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        theses_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    theses_DB.Save(theses_obj_to_save);
                    break;
                case 14:

                    conference_proceedings_DT conference_proceedings_obj_to_save = new conference_proceedings_DT();
                    conference_proceedings_obj_to_save = conference_proceedings_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        conference_proceedings_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        conference_proceedings_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        conference_proceedings_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        conference_proceedings_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        conference_proceedings_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    conference_proceedings_DB.Save(conference_proceedings_obj_to_save);
                    break;
                case 11:
                    
                    content_images_DT images_obj_to_save = new content_images_DT();
                    images_obj_to_save = content_images_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {

                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        images_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                        images_obj_to_save.file_status = 9;

                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        images_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        images_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        images_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    content_images_DB.Save(images_obj_to_save);
                    break;
                case 15:

                    WebSites_Template_DT WebSites_Template_obj_to_save = new WebSites_Template_DT();
                    WebSites_Template_obj_to_save = WebSites_Template_DB.SelectByID(current_content_id);
                    if (newErrorCount.Value != "0" && chkDone.Checked == true)
                    {
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى معالج الملفات')</script>");
                        log(9);
                        WebSites_Template_obj_to_save.file_status = 9;
                        WebSites_Template_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    else if (newErrorCount.Value != "0" && chkDone.Checked == false)
                        WebSites_Template_obj_to_save.file_status = 26;
                    else if (newErrorCount.Value == "0" && chkDone.Checked == true)
                    {
                        WebSites_Template_obj_to_save.file_status = 11;
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى المراقبة النهائية')</script>");
                        log(7);
                        WebSites_Template_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        btnsave.Visible = false;
                        btnSavePage.Visible = false;
                        chkDone.Visible = false;
                        gvErrors.Visible = false;
                        trErrorType.Visible = false;
                        trErrorNotes.Visible = false;trDocErrors.Visible = false;
                        trfileUsage.Visible = false;
                        fill_data();
                        gvContentFiles.Visible = false;
                        Smrt_Srch_object.Clear_Controls();
                    }
                    WebSites_Template_DB.Save(WebSites_Template_obj_to_save);



                    break;
            }
       
       
    }
    protected Boolean fileIsValid()
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        int current_content_error_type = CDataConverter.ConvertToInt(ddlErrorType.SelectedValue);
        
       
            return true;
    }
    

}
