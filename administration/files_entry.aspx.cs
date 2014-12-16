using System;
using System.IO;
using System.Drawing;
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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
public partial class administration_files_entry : System.Web.UI.Page
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
                //case "15":
                //    obj_table = "periodicals";
                //    break;
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
                    trUpload.Visible = true;
                    label1.Visible = true;
                    set_example_label();
                    if (id != "")
                    {
                        fillGrid();

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
                    trUpload.Visible = false;
                    label1.Visible = false;
                    gvContentFiles.Visible = false;

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
            setvalue = "6";
        if (Request["operation"].ToString() == "unfinished")
            setvalue = "7";
        if (Request["operation"].ToString() == "refused")
            setvalue = "9";
        
        if (Value != "")
        {
            id = Smrt_Srch_object.SelectedValue;
            
            switch (Value)
            {

                case "1":
                    
                    SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
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
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //  dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
                    Smrt_Srch_object.stored = "get_video_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams6;
                    break;
                case "7":
                    
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
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
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
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
           // if (Session["user_type"].ToString() != "6")
           //     Response.Redirect("~/administration/login.aspx");
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
                type_mode.Value = "6";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "6"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
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
                type_mode.Value = "7";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "7"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
                DataTable unfinishedDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count_filtered_unfinushed");
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
            //else if (Request["operation"].ToString() == "processed")
            //{
            //    type_mode.Value = "8";
            //    SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "8") };
            //    DataTable processedDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count");
            //    if (processedDT.Rows.Count > 0)
            //    {
            //        for (int count = 0; count < counter; count++)
            //        {
            //            DataRow[] foundRows;
            //            foundRows = processedDT.Select("ctype = '" + ddlElementType.Items[count].Value + "'");
            //            if (foundRows.Length == 0 && ddlElementType.Items[count].Value != "0")
            //                objectsDT.Rows[count].Delete();
            //        }
            //    }

            //    ddlElementType.DataSource = objectsDT;
            //    ddlElementType.DataBind();
            //    ListItem litem = new ListItem(".. اختر عنصر ..", "0");
            //    litem.Selected = true;
            //    ddlElementType.Items.Insert(0, litem);
            //}
            else if (Request["operation"].ToString() == "refused")
            {
                type_mode.Value = "9";
                chkDone.Text = "تم الإنتهاء من تصحيح الأخطاء";
                SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@file_status", "9"), new SqlParameter("@user_id", Session["user_id"].ToString()) };
                DataTable refusedDT = DatabaseFunctions.SelectData(newSqlParams, "get_files_new_count_filtered_err");
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
           
        }
        else
            Response.Redirect("~/administration/Default.aspx");
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

            case 1: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة شخصية' as title_usage,'' as title1_usage,'' as title2_usage,file_status from characters where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from characters left outer join contents_notes on characters.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where characters.id=" + current_content_id + " and contents_notes.content_type=1 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "characters";
                break;
            case 2: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from events where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from events left outer join contents_notes on events.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where events.id=" + current_content_id + " and contents_notes.content_type=2 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "events";
                break;
            case 3: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from topics where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from topics left outer join contents_notes on topics.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where topics.id=" + current_content_id + " and contents_notes.content_type=3 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "topics";
                break;
            case 4: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة شخصية' as title_usage,'' as title1_usage,'' as title2_usage,file_status from places where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from places left outer join contents_notes on places.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where places.id=" + current_content_id + " and contents_notes.content_type=4 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "places";
                break;
            case 5: DT = General_Helping.GetDataTable("select id,small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'صورة تفصيلية' as title1_usage,'' as title2_usage,file_status from artifacts where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from artifacts left outer join contents_notes on artifacts.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where artifacts.id=" + current_content_id + " and contents_notes.content_type=5 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "artifacts";
                break;
            case 6: DT = General_Helping.GetDataTable("select id,small_image as title,(file_name+extension) as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الفيديو' as title1_usage,'' as title2_usage,file_status from content_media where content_media.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_media left outer join contents_notes on content_media.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_media.id=" + current_content_id + " and contents_notes.content_type=6 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "content_media";
                break;
            case 7: DT = General_Helping.GetDataTable("select id,(file_name+extension) as title,'' as title1,'' as title2,'ملف الصوت' as title_usage,'' as title1_usage,'' as title2_usage,file_status from content_media where content_media.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_media left outer join contents_notes on content_media.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_media.id=" + current_content_id + " and contents_notes.content_type=7 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "content_media";
                
                break;
            case 8: DT = General_Helping.GetDataTable("select id,small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الوثيقة' as title1_usage,'' as title2_usage,file_status from documents  where documents.doc_type=3 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=3 and documents.id=" + current_content_id + " and contents_notes.content_type=8 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "documents";
                break;
            case 9: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف المقالة' as title1_usage,'' as title2_usage,file_status from documents  where documents.doc_type=2 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=2 and documents.id=" + current_content_id + " and contents_notes.content_type=9 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "documents";
                break;
            case 10: DT = General_Helping.GetDataTable("select id, small_image as title,large_image as title1,'' as title2,'صورة صغيرة' as title_usage,'ملف الكتاب' as title1_usage,'' as title2_usage,file_status from documents where documents.doc_type=1 and documents.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from documents left outer join contents_notes on documents.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where documents.doc_type=1 and documents.id=" + current_content_id + " and contents_notes.content_type=10 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "documents";
                break;
            case 12: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة الغلاف' as title_usage,'ملف المخطوطة' as title1_usage,'' as title2_usage,file_status from manuscripts where manuscripts.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from manuscripts left outer join contents_notes on manuscripts.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where  manuscripts.id=" + current_content_id + " and contents_notes.content_type=12 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "manuscripts";
                break;
            case 13: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة الغلاف' as title_usage,'ملف الاطروحة' as title1_usage,'' as title2_usage,file_status from theses where theses.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from theses left outer join contents_notes on theses.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where theses.id=" + current_content_id + " and contents_notes.content_type=13 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "theses";
                break;
            case 14: DT = General_Helping.GetDataTable("select id, image_name as title,file_name as title1,'' as title2,'صورة الغلاف' as title_usage,'ملف البحث' as title1_usage,'' as title2_usage,file_status from conference_proceedings where conference_proceedings.id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from conference_proceedings left outer join contents_notes on conference_proceedings.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where conference_proceedings.id=" + current_content_id + " and contents_notes.content_type=14 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "conference_proceedings";
                break;
            case 11: DT = General_Helping.GetDataTable("select id,small_image as title,normal_image as title1,large_image as title2,'صورة صغيرة' as title_usage,'صورة عادية' as title1_usage,'صورة مفصلة' as title2_usage,file_status from content_images where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from content_images left outer join contents_notes on content_images.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where content_images.id=" + current_content_id + " and contents_notes.content_type=11 and contents_notes.error_status=1 and contents_notes.error_type=2");
                obj_table = "content_images";
                break;
            case 15: DT = General_Helping.GetDataTable("select id,image_name as title,'' as title1,'' as title2,'صورة الموقع' as title_usage,'' as title1_usage,'' as title2_usage,file_status from WebSites_Template where id=" + current_content_id);
                errorDT = General_Helping.GetDataTable("select usage,error_place,observer_note,error_name,contents_notes.id,file_status from WebSites_Template left outer join contents_notes on WebSites_Template.id=contents_notes.content_id join contents_errors on contents_notes.error_id=contents_errors.id join content_files on contents_notes.usage_id=content_files.id where WebSites_Template.id=" + current_content_id + " and contents_notes.content_type=15 and contents_notes.error_status=1 and contents_notes.error_type=2");
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
                gvContentFiles.Visible = false;
            }
        
        
        if (type_mode.Value == "9")
        {
            gvErrors.DataSource = errorDT;
            gvErrors.DataBind();
            trErrors.Visible=true;
        }
        else
        {
            gvErrors.DataSource = "";
            gvErrors.DataBind();
            trErrors.Visible = false;
        }

        lockTr.Visible = true;
        lockChckBox.Enabled = true;
        lockBtn.Enabled = true;
        //lockChckBox.Checked = false;
        string updateLock = "select lock_files from " + obj_table;
        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
        DataTable dt = General_Helping.GetDataTable(updateLock);
        if (dt.Rows.Count > 0)
        {
            if (Convert.ToInt16(dt.Rows[0]["lock_files"].ToString()) > 0)
            {
                lockChckBox.Enabled = false;
                lockChckBox.Checked = true;
                lockBtn.Enabled = false;
            }
            else
                lockChckBox.Checked = false;
        }
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
            //case "15":
            //    obj_table = "periodicals";
            //    break;
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
            lockBtn.Enabled = false;
            btnsave.Visible = true;
            btnSavePage.Visible = true;
            chkDone.Visible = true;
            lockBtn.Enabled = false;
            trUpload.Visible = true;
            label1.Visible = true;
            set_example_label();
            fillGrid();
        }


    }
    protected void ddlElementType_SelectedIndexChanged(object sender, EventArgs e)
    {
        //lblpage.Visible = false;
        ddlTypeChanged();

    }
   
    protected void filldll()
    {
        DataTable DT = General_Helping.GetDataTable("select id,title from content_types");
        Obj_General_Helping.SmartBindDDL(ddlElementType, DT, "id", "title", ".. اختر عنصر ..");
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
                case 1: DT = General_Helping.GetDataTable("select char_id as id,name as title1,'1_'+CAST(char_id as nvarchar(50))+'  '+name as title  from characters_details join characters on characters_details.char_id=characters.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and characters.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 1");
                    break;
                case 2: DT = General_Helping.GetDataTable("select event_id as id,'2_'+CAST(event_id as nvarchar(50))+'  '+title as title from events_details join events on events_details.event_id=events.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and events.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 2");
                    break;
                case 3: DT = General_Helping.GetDataTable("select topic_id as id,'3_'+CAST(topic_id as nvarchar(50))+'  '+title as title from topics_details join topics on topics_details.topic_id=topics.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and topics.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 3");
                    break;
                case 4: DT = General_Helping.GetDataTable("select place_id as id,name as title1,'4_'+CAST(place_id as nvarchar(50))+'  '+name as title  from places_details join places on places_details.place_id=places.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and places.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 4");
                    break;
                case 5: DT = General_Helping.GetDataTable("select artifact_id as id,'5_'+CAST(artifact_id as nvarchar(50))+'  '+title as title from artifacts_details join artifacts on artifacts_details.artifact_id=artifacts.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and artifacts.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 5");
                    break;
                case 6: DT = General_Helping.GetDataTable("select content_media_id as id,'6_'+CAST(content_media_id as nvarchar(50))+'  '+title as title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and content_media.content_media_type=6 and content_media.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 6");
                    break;
                case 7: DT = General_Helping.GetDataTable("select content_media_id as id,'7_'+CAST(content_media_id as nvarchar(50))+'  '+title as title from content_media_details join content_media on content_media_details.content_media_id=content_media.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and content_media.content_media_type=7 and content_media.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 7");
                    break;
                case 8: DT = General_Helping.GetDataTable("select doc_id as id, '8_'+CAST(doc_id as nvarchar(50))+'  '+title as title from documents_details join documents on documents_details.doc_id=documents.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and documents.doc_type=3 and documents.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 8");
                    break;
                case 9: DT = General_Helping.GetDataTable("select doc_id as id, '9_'+CAST(doc_id as nvarchar(50))+'  '+title as title from documents_details join documents on documents_details.doc_id=documents.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and documents.doc_type=2 and documents.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 9");
                    break;
                case 10: DT = General_Helping.GetDataTable("select doc_id as id, '10_'+CAST(doc_id as nvarchar(50))+'  '+title as title from documents_details join documents on documents_details.doc_id=documents.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and documents.doc_type=1 and documents.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 10");
                    break;
                case 12: DT = General_Helping.GetDataTable("select manuscript_id as id, '12_'+CAST(manuscript_id as nvarchar(50))+'  '+title as title from manuscripts_details join manuscripts on manuscripts_details.manuscript_id=manuscripts.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and manuscripts.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 12");
                    break;
                case 13: DT = General_Helping.GetDataTable("select these_id as id, '13_'+CAST(these_id as nvarchar(50))+'  '+title as title from theses_details join theses on theses_details.these_id=theses.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and theses.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 13");
                    break;
                case 14: DT = General_Helping.GetDataTable("select conference_proceeding_id as id, '14_'+CAST(conference_proceeding_id as nvarchar(50))+'  '+title as title from conference_proceedings_details join conference_proceedings on conference_proceedings_details.conference_proceeding_id=conference_proceedings.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and conference_proceedings.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 14");
                    break;
                case 11: DT = General_Helping.GetDataTable("select content_images_details.content_image_id  as id, '11_'+CAST(content_image_id as nvarchar(50))+'  '+ title as title from content_images_details join  content_images on content_images_details.content_image_id=content_images.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ") and content_images.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 11");
                    break;
                case 15: DT = General_Helping.GetDataTable("select website_id as id, '15_'+CAST(website_id as nvarchar(50))+'  '+title as title from WebSites_Template_details join WebSites_Template on WebSites_Template_details.website_id=WebSites_Template.id where (lock_files=0 or lock_files=" + Session["user_id"].ToString() + ")  and WebSites_Template.file_status=" + type_mode.Value);
                    usageDT = General_Helping.GetDataTable("select id,usage as title from content_files where content_type = 15");
                    break;


            }
            //if (DT.Rows.Count > 0)
                MOnMember_Data(ddlElementType.SelectedValue);
                Smrt_Srch_object.SelectedValue = "";
                Smrt_Srch_object.SelectedText = "";
                lockTr.Visible = false;
                gvContentFiles.Visible = false;
         
            if (usageDT.Rows.Count > 0)
                Obj_General_Helping.SmartBindDDL(ddlFileUsage, usageDT, "id", "title", ".. اختر إستخدام ..");
            else
                ddlFileUsage.Items.Clear();

            if (CDataConverter.ConvertToInt(ddlElementType.SelectedValue) > 0)
            { Label23.Text = "_" + ddlElementType.SelectedValue; }
            else { Label23.Visible = false; }

            set_example_label();
            
        }
        else
        {
            
            ddlFileUsage.Items.Clear();
            //DataTable dttemp = new DataTable();
            //gvContentFiles.DataSource = dttemp;
            //gvContentFiles.DataBind();

        }
    }


    public void title_Click(object sender, EventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        LinkButton lnkButton = (LinkButton)sender;
        //HtmlAnchor a1 = (HtmlAnchor)sender;
        switch (current_content_type)
        {
            case 1:

                //Response.Write("<script type='text/javascript'>window.open('~/administration/veiw_images.aspx?path=~/images/sheikhs/'"+lnkButton.Text+"');</script>");
                Response.Redirect("~/administration/veiw_images.aspx?path=~/images/sheikhs/" + lnkButton.Text, true);
                //a1.HRef = "~/administration/veiw_images.aspx?path=~/images/sheikhs/" + a1.InnerText;
                //lnkButton.PostBackUrl = "~/administration/veiw_images.aspx?path=~/images/sheikhs/" + lnkButton.Text;
                break;
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
    public void ImgBtnDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        switch (current_content_type)
        {
            case 1:
                characters_DT characters_obj_to_save = new characters_DT();
                characters_obj_to_save = characters_DB.SelectByID(current_content_id);
                characters_obj_to_save.image_name = "";
                characters_DB.Save(characters_obj_to_save);
                log(35);
                break;
            case 2:
                events_DT events_obj_to_save = new events_DT();
                events_obj_to_save = events_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                events_obj_to_save.large_image = "";
                events_DB.Save(events_obj_to_save);
                log(35);
                break;
            case 3:
                topics_DT topics_obj_to_save = new topics_DT();
                topics_obj_to_save = topics_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                 topics_obj_to_save.large_image = "";
                 topics_DB.Save(topics_obj_to_save);
                log(35);

                break;
            case 4:
                places_DT places_obj_to_save = new places_DT();
                places_obj_to_save = places_DB.SelectByID(current_content_id);
                places_obj_to_save.image_name = "";
                places_DB.Save(places_obj_to_save);
                log(35);
                break;
            case 5:
                artifacts_DT artifacts_obj_to_save = new artifacts_DT();
                artifacts_obj_to_save = artifacts_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    artifacts_obj_to_save.small_image = "";
                else
                    artifacts_obj_to_save.large_image = "";
                
                artifacts_DB.Save(artifacts_obj_to_save);
                log(35);
                break;
            case 6:
                content_media_DT video_obj_to_save = new content_media_DT();
                video_obj_to_save = content_media_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    video_obj_to_save.small_image = "";
                else
                {
                    video_obj_to_save.file_name = "";
                    video_obj_to_save.extension = "";
                }
                
                content_media_DB.Save(video_obj_to_save);
                log(35);

                break;
            case 7:
                content_media_DT audio_obj_to_save = new content_media_DT();
                audio_obj_to_save = content_media_DB.SelectByID(current_content_id);
                audio_obj_to_save.file_name = "";
                audio_obj_to_save.extension = "";
              
                content_media_DB.Save(audio_obj_to_save);
                log(35);
                break;

            case 8:
                documents_DT wase2a_obj_to_save = new documents_DT();
                wase2a_obj_to_save = documents_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    wase2a_obj_to_save.small_image = "";
                else
                    wase2a_obj_to_save.large_image = "";
                
                documents_DB.Save(wase2a_obj_to_save);
                log(35);
                break;
            case 9:
                documents_DT article_obj_to_save = new documents_DT();
                article_obj_to_save = documents_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    article_obj_to_save.small_image = "";
                else
                    article_obj_to_save.large_image = "";
                
                documents_DB.Save(article_obj_to_save);
                log(35);

                break;
            case 10:
                documents_DT book_obj_to_save = new documents_DT();
                book_obj_to_save = documents_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    book_obj_to_save.small_image = "";
                else
                    book_obj_to_save.large_image = "";
             
                documents_DB.Save(book_obj_to_save);
                log(35);
                break;
            case 12:
                manuscripts_DT manuscripts_obj_to_save = new manuscripts_DT();
                manuscripts_obj_to_save = manuscripts_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    manuscripts_obj_to_save.image_name = "";
                else
                    manuscripts_obj_to_save.file_name = "";
              
                manuscripts_DB.Save(manuscripts_obj_to_save);
                log(35);
                break;
            case 13:
                theses_DT theses_obj_to_save = new theses_DT();
                theses_obj_to_save = theses_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    theses_obj_to_save.image_name = "";
                else
                    theses_obj_to_save.file_name = "";
            
                theses_DB.Save(theses_obj_to_save);
                log(35);
                break;
            case 14:
                conference_proceedings_DT conference_proceedings_obj_to_save = new conference_proceedings_DT();
                conference_proceedings_obj_to_save = conference_proceedings_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    conference_proceedings_obj_to_save.image_name = "";
                else
                    conference_proceedings_obj_to_save.file_name = "";
               
                conference_proceedings_DB.Save(conference_proceedings_obj_to_save);
                log(35);
                break;
            case 11:
                content_images_DT images_obj_to_save = new content_images_DT();
                images_obj_to_save = content_images_DB.SelectByID(current_content_id);
                if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 1)
                    images_obj_to_save.small_image = "";
                else if (CDataConverter.ConvertToInt(((ImageButton)sender).CommandName) == 2)
                    images_obj_to_save.normal_image = "";
                else
                    images_obj_to_save.large_image = "";
                
                content_images_DB.Save(images_obj_to_save);
                log(35);

                break;
            case 15:
                WebSites_Template_DT WebSites_Template_obj_to_save = new WebSites_Template_DT();
                WebSites_Template_obj_to_save = WebSites_Template_DB.SelectByID(current_content_id);
                WebSites_Template_obj_to_save.image_name = "";
                WebSites_Template_DB.Save(WebSites_Template_obj_to_save);
                log(35);
                break;
        }

        lblpageMsg.Visible = false;
        fillGrid();
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        if (fileIsValid())
        {

            switch (current_content_type)
            {


                case 1:
                    characters_DT characters_obj_to_save = new characters_DT();
                    characters_obj_to_save = characters_DB.SelectByID(current_content_id);
                    characters_obj_to_save.image_name = fucontentFile.FileName;
                    //characters_obj_to_save.file_status = 7;
                    characters_DB.Save(characters_obj_to_save);
                    log(31);
                    saveFileSystem("\\images\\sheikhs\\");

                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 2:
                    events_DT events_obj_to_save = new events_DT();
                    events_obj_to_save = events_DB.SelectByID(current_content_id);
                    events_obj_to_save.large_image = fucontentFile.FileName;
                    //events_obj_to_save.file_status = 7;
                    events_DB.Save(events_obj_to_save);
                    log(31);
                    saveFileSystem("\\images\\events\\");
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";

                    break;
                case 3:
                    topics_DT topics_obj_to_save = new topics_DT();
                    topics_obj_to_save = topics_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 4)
                    topics_obj_to_save.large_image = fucontentFile.FileName;
                    //topics_obj_to_save.file_status = 7;
                    topics_DB.Save(topics_obj_to_save);
                    log(31);
                    saveFileSystem("\\images\\topics\\");
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 4:
                    places_DT places_obj_to_save = new places_DT();
                    places_obj_to_save = places_DB.SelectByID(current_content_id);
                    places_obj_to_save.image_name = fucontentFile.FileName;
                    //places_obj_to_save.file_status = 7;
                    places_DB.Save(places_obj_to_save);
                    log(31);
                    saveFileSystem("\\upload\\forms\\");

                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 5:
                    artifacts_DT artifacts_obj_to_save = new artifacts_DT();
                    artifacts_obj_to_save = artifacts_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 8)
                    artifacts_obj_to_save.small_image = fucontentFile.FileName;
                    else
                    artifacts_obj_to_save.large_image = fucontentFile.FileName;
                    //artifacts_obj_to_save.file_status = 7;
                    artifacts_DB.Save(artifacts_obj_to_save);
                    log(31);
                    saveFileSystem("\\upload\\forms\\");

                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 6:
                    content_media_DT video_obj_to_save = new content_media_DT();
                    video_obj_to_save = content_media_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 10)
                        video_obj_to_save.small_image = fucontentFile.FileName;
                    else
                    {
                        video_obj_to_save.file_name = fucontentFile.FileName.ToString().Split('.')[0];
                        video_obj_to_save.extension = "."+fucontentFile.FileName.ToString().Split('.')[1];
                    }
                   // video_obj_to_save.file_status = 7;
                    content_media_DB.Save(video_obj_to_save);
                    log(31);
                    saveFileSystem("\\upload\\Videos\\");
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 7:
                    content_media_DT audio_obj_to_save = new content_media_DT();
                    audio_obj_to_save = content_media_DB.SelectByID(current_content_id);
                    audio_obj_to_save.file_name = fucontentFile.FileName.ToString().Split('.')[0];
                    audio_obj_to_save.extension = "." + fucontentFile.FileName.ToString().Split('.')[1];
                    //audio_obj_to_save.file_status = 7;
                    content_media_DB.Save(audio_obj_to_save);
                    log(31);
                    saveFileSystem("\\upload\\audio\\");
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 8:
                    documents_DT wase2a_obj_to_save = new documents_DT();
                    wase2a_obj_to_save = documents_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 13)
                    {
                        wase2a_obj_to_save.small_image = fucontentFile.FileName;
                        Stream imgStream = fucontentFile.PostedFile.InputStream;
                        Bitmap bmThumb = new Bitmap(imgStream);
                        //int new_width = (int)(bmThumb.Width * (170.0 / bmThumb.Height));
                        System.Drawing.Image im = bmThumb.GetThumbnailImage(227, 170, null, IntPtr.Zero);

                        im.Save(Server.MapPath("~").ToString() + "\\images\\esdarat\\" + fucontentFile.FileName.Split('.')[0] + "_small." + fucontentFile.FileName.Split('.')[1]);
                        saveFileSystem("\\images\\esdarat\\");
                    }
                    else
                    { 
                        wase2a_obj_to_save.large_image = fucontentFile.FileName;
                        saveFileSystem("\\images\\esdarat\\");
                        try
                        {
                            string txt_Source = Server.MapPath("~").ToString() + "\\images\\esdarat\\";// string path = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_Destination = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_SoftwareSource = Server.MapPath("~").ToString() + "\\images\\FlipPDF\\pdfflip.exe";

                            //FileUpload1.SaveAs(txt_Source + "\\" + FileUpload1.FileName);

                            string[] files = Directory.GetFiles(txt_Source, fucontentFile.FileName,
                                                SearchOption.AllDirectories);
                            if (files.Length > 0)
                            {

                                foreach (string fullFileName in files)
                                {
                                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullFileName);

                                    System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                                    process1.StartInfo.FileName = txt_SoftwareSource;
                                    process1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                    process1.StartInfo.Arguments = "\"" + fullFileName + "\" \"" + txt_Destination + "\\" + fileNameWithoutExtension + "\"";
                                    process1.Start();
                                    //System.Threading.Thread.Sleep(999999000);
                                    process1.WaitForExit();

                                }

                            }
                            else
                            {

                            }

                        }
                        catch (Exception ex)
                        {
                            lblpageMsg.Text = ex.Message;
                        }
                    }
                    //wase2a_obj_to_save.file_status = 7;
                    documents_DB.Save(wase2a_obj_to_save);
                    log(31);
                    
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 9:
                    documents_DT article_obj_to_save = new documents_DT();
                    article_obj_to_save = documents_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 15)
                    {
                        article_obj_to_save.small_image = fucontentFile.FileName;
                        Stream imgStream = fucontentFile.PostedFile.InputStream;
                        Bitmap bmThumb = new Bitmap(imgStream);
                        //int new_width = (int)(bmThumb.Width * (170.0 / bmThumb.Height));
                        System.Drawing.Image im = bmThumb.GetThumbnailImage(227, 170, null, IntPtr.Zero);

                        im.Save(Server.MapPath("~").ToString() + "\\images\\esdarat\\" + fucontentFile.FileName.Split('.')[0] + "_small." + fucontentFile.FileName.Split('.')[1]);
                        saveFileSystem("\\images\\esdarat\\");
                    }
                    else
                    {
                        article_obj_to_save.large_image = fucontentFile.FileName;
                        saveFileSystem("\\images\\esdarat\\");
                        try
                        {
                            string txt_Source = Server.MapPath("~").ToString() + "\\images\\esdarat\\";// string path = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_Destination = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_SoftwareSource = Server.MapPath("~").ToString() + "\\images\\FlipPDF\\pdfflip.exe";

                            //FileUpload1.SaveAs(txt_Source + "\\" + FileUpload1.FileName);

                            string[] files = Directory.GetFiles(txt_Source, fucontentFile.FileName,
                                                SearchOption.AllDirectories);
                            if (files.Length > 0)
                            {

                                foreach (string fullFileName in files)
                                {
                                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullFileName);

                                    System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                                    process1.StartInfo.FileName = txt_SoftwareSource;
                                    process1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                    process1.StartInfo.Arguments = "\"" + fullFileName + "\" \"" + txt_Destination + "\\" + fileNameWithoutExtension + "\"";
                                    process1.Start();
                                    //System.Threading.Thread.Sleep(999999000);
                                    process1.WaitForExit();

                                }

                            }
                            else
                            {

                            }

                        }
                        catch (Exception ex)
                        {
                            lblpageMsg.Text = ex.Message;
                        }
                    }
                    //article_obj_to_save.file_status = 7;
                    documents_DB.Save(article_obj_to_save);
                    log(31);
                    
                    
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 10:
                    documents_DT book_obj_to_save = new documents_DT();
                    book_obj_to_save = documents_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 17)
                    {
                        book_obj_to_save.small_image = fucontentFile.FileName;
                        Stream imgStream = fucontentFile.PostedFile.InputStream;
                        Bitmap bmThumb = new Bitmap(imgStream);
                        //int new_width = (int)(bmThumb.Width * (170.0 / bmThumb.Height));
                        System.Drawing.Image im = bmThumb.GetThumbnailImage(227, 170, null, IntPtr.Zero);

                        im.Save(Server.MapPath("~").ToString() + "\\images\\esdarat\\" + fucontentFile.FileName.Split('.')[0] + "_small." + fucontentFile.FileName.Split('.')[1]);
                        saveFileSystem("\\images\\esdarat\\");
                    }
                    else
                    {
                        book_obj_to_save.large_image = fucontentFile.FileName;
                        saveFileSystem("\\images\\esdarat\\");
                        //try
                        //{
                        //    string txt_Source = Server.MapPath("~").ToString() + "\\images\\esdarat\\";// string path = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                        //    string txt_Destination = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                        //    string txt_SoftwareSource = Server.MapPath("~").ToString() + "\\images\\FlipPDF\\pdfflip.exe";

                        //    //FileUpload1.SaveAs(txt_Source + "\\" + FileUpload1.FileName);

                        //    string[] files = Directory.GetFiles(txt_Source, fucontentFile.FileName,
                        //                        SearchOption.AllDirectories);
                        //    if (files.Length > 0)
                        //    {

                        //        foreach (string fullFileName in files)
                        //        {
                        //            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullFileName);

                        //            System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                        //            process1.StartInfo.FileName = txt_SoftwareSource;
                        //            process1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        //            process1.StartInfo.Arguments = "\"" + fullFileName + "\" \"" + txt_Destination + "\\" + fileNameWithoutExtension + "\"";
                        //            process1.Start();
                        //            //System.Threading.Thread.Sleep(999999000);
                        //            process1.WaitForExit();

                        //        }

                        //    }
                        //    else
                        //    {

                        //    }

                        //}
                        //catch (Exception ex)
                        //{
                        //    lblpageMsg.Text = ex.Message;
                        //}
                    }
                    //book_obj_to_save.file_status = 7;
                    documents_DB.Save(book_obj_to_save);
                    log(31);
                    
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 12:
                    manuscripts_DT manuscripts_obj_to_save = new manuscripts_DT();
                    manuscripts_obj_to_save = manuscripts_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 22)
                    {
                        manuscripts_obj_to_save.image_name = fucontentFile.FileName;
                        Stream imgStream = fucontentFile.PostedFile.InputStream;
                        Bitmap bmThumb = new Bitmap(imgStream);
                        //int new_width = (int)(bmThumb.Width * (170.0 / bmThumb.Height));
                        System.Drawing.Image im = bmThumb.GetThumbnailImage(227, 170, null, IntPtr.Zero);
                        im.Save(Server.MapPath("~").ToString() + "\\images\\esdarat\\" + fucontentFile.FileName.Split('.')[0] + "_small." + fucontentFile.FileName.Split('.')[1]);
                        saveFileSystem("\\images\\esdarat\\");
                    }
                    else
                    {
                        manuscripts_obj_to_save.file_name = fucontentFile.FileName;
                        saveFileSystem("\\images\\esdarat\\");
                        try
                        {
                            string txt_Source = Server.MapPath("~").ToString() + "\\images\\esdarat\\";// string path = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_Destination = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_SoftwareSource = Server.MapPath("~").ToString() + "\\images\\FlipPDF\\pdfflip.exe";

                            //FileUpload1.SaveAs(txt_Source + "\\" + FileUpload1.FileName);

                            string[] files = Directory.GetFiles(txt_Source, fucontentFile.FileName,
                                                SearchOption.AllDirectories);
                            if (files.Length > 0)
                            {

                                foreach (string fullFileName in files)
                                {
                                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullFileName);

                                    System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                                    process1.StartInfo.FileName = txt_SoftwareSource;
                                    process1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                    process1.StartInfo.Arguments = "\"" + fullFileName + "\" \"" + txt_Destination + "\\" + fileNameWithoutExtension + "\"";
                                    process1.Start();
                                    //System.Threading.Thread.Sleep(999999000);
                                    process1.WaitForExit();

                                }

                            }
                            else
                            {

                            }

                        }
                        catch (Exception ex)
                        {
                            lblpageMsg.Text = ex.Message;
                        }
                    }
                    //manuscripts_obj_to_save.file_status = 7;
                    manuscripts_DB.Save(manuscripts_obj_to_save);
                    log(31);
                   
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 13:
                    theses_DT theses_obj_to_save = new theses_DT();
                    theses_obj_to_save = theses_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 24)
                    {
                        theses_obj_to_save.image_name = fucontentFile.FileName;
                        Stream imgStream = fucontentFile.PostedFile.InputStream;
                        Bitmap bmThumb = new Bitmap(imgStream);
                        //int new_width = (int)(bmThumb.Width * (170.0 / bmThumb.Height));
                        System.Drawing.Image im = bmThumb.GetThumbnailImage(227, 170, null, IntPtr.Zero);

                        im.Save(Server.MapPath("~").ToString() + "\\images\\esdarat\\" + fucontentFile.FileName.Split('.')[0] + "_small." + fucontentFile.FileName.Split('.')[1]);
                        saveFileSystem("\\images\\esdarat\\");
                    }
                    else
                    { 
                        theses_obj_to_save.file_name = fucontentFile.FileName;
                        saveFileSystem("\\images\\esdarat\\");
                        try
                        {
                            string txt_Source = Server.MapPath("~").ToString() + "\\images\\esdarat\\";// string path = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_Destination = Server.MapPath("~").ToString() + "\\images\\esdarat\\";
                            string txt_SoftwareSource = Server.MapPath("~").ToString() + "\\images\\FlipPDF\\pdfflip.exe";

                            //FileUpload1.SaveAs(txt_Source + "\\" + FileUpload1.FileName);

                            string[] files = Directory.GetFiles(txt_Source, fucontentFile.FileName,
                                                SearchOption.AllDirectories);
                            if (files.Length > 0)
                            {

                                foreach (string fullFileName in files)
                                {
                                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fullFileName);

                                    System.Diagnostics.Process process1 = new System.Diagnostics.Process();
                                    process1.StartInfo.FileName = txt_SoftwareSource;
                                    process1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                    process1.StartInfo.Arguments = "\"" + fullFileName + "\" \"" + txt_Destination + "\\" + fileNameWithoutExtension + "\"";
                                    process1.Start();
                                    //System.Threading.Thread.Sleep(999999000);
                                    process1.WaitForExit();

                                }

                            }
                            else
                            {

                            }

                        }
                        catch (Exception ex)
                        {
                            lblpageMsg.Text = ex.Message;
                        }
                    }
                    //theses_obj_to_save.file_status = 7;
                    theses_DB.Save(theses_obj_to_save);
                    log(31);
                    
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 14:
                    conference_proceedings_DT conference_proceedings_obj_to_save = new conference_proceedings_DT();
                    conference_proceedings_obj_to_save = conference_proceedings_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 26)
                        conference_proceedings_obj_to_save.image_name = fucontentFile.FileName;
                    else
                        conference_proceedings_obj_to_save.file_name = fucontentFile.FileName;
                    //conference_proceedings_obj_to_save.file_status = 7;
                    conference_proceedings_DB.Save(conference_proceedings_obj_to_save);
                    log(31);
                    saveFileSystem("\\images\\esdarat\\");
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 11:
                    content_images_DT images_obj_to_save = new content_images_DT();
                    images_obj_to_save = content_images_DB.SelectByID(current_content_id);
                    if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 19)
                        images_obj_to_save.small_image = fucontentFile.FileName;
                    else if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 20)
                        images_obj_to_save.normal_image = fucontentFile.FileName;
                    else if (CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue) == 21)
                        images_obj_to_save.large_image = fucontentFile.FileName;
                    //images_obj_to_save.file_status = 7;
                    content_images_DB.Save(images_obj_to_save);
                    log(31);
                    saveFileSystem("\\images\\uploaded_images\\");
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;
                case 15:
                    WebSites_Template_DT WebSites_Template_obj_to_save = new WebSites_Template_DT();
                    WebSites_Template_obj_to_save = WebSites_Template_DB.SelectByID(current_content_id);
                    WebSites_Template_obj_to_save.image_name = fucontentFile.FileName;
                    //WebSites_Template_obj_to_save.file_status = 7;
                    WebSites_Template_DB.Save(WebSites_Template_obj_to_save);
                    log(31);
                    saveFileSystem("\\images\\esdarat\\");

                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "تم الحفظ ";
                    break;

            }
            
            fillGrid();
        }
        else
        {
            lblpageMsg.Visible = true;
            //lblpageMsg.Text = "إمتداد الصورة غير معروف";
           
            }
    }
    protected void btnsavePage_Click(object sender, EventArgs e)
    {
        
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        if (gvContentFiles.Rows.Count > 0)
        {
            switch (current_content_type)
            {
                case 1:
                    characters_DT characters_obj_to_save = new characters_DT();
                    characters_obj_to_save = characters_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=1");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=1");
                        
                        characters_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        characters_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                        
                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        characters_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        characters_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        characters_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    characters_DB.Save(characters_obj_to_save);
                    //
                    

                    break;
                case 2:
                    events_DT events_obj_to_save = new events_DT();
                    events_obj_to_save = events_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=2");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=2");
                        
                        events_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        events_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        events_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        events_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        events_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    events_DB.Save(events_obj_to_save);

                    
                    break;
                case 3:
                    
                    topics_DT topics_obj_to_save = new topics_DT();
                    topics_obj_to_save = topics_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=3");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=3");
                       
                        topics_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        topics_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        topics_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        topics_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        topics_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    topics_DB.Save(topics_obj_to_save);
                    
                    
                    break;
                case 4:
                    places_DT places_obj_to_save = new places_DT();
                    places_obj_to_save = places_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=4");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=4");

                        places_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        places_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();

                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        places_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        places_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        places_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    places_DB.Save(places_obj_to_save);
                    //


                    break;
                case 5:
                    if (gvContentFiles.Rows.Count == 2)
                    { 
                    artifacts_DT artifacts_obj_to_save = new artifacts_DT();
                    artifacts_obj_to_save = artifacts_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=5");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=5");

                        artifacts_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        artifacts_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();

                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        artifacts_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        artifacts_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        artifacts_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    artifacts_DB.Save(artifacts_obj_to_save);
                    //
                    }
                    else
                    {
                        artifacts_DT artifacts_obj_to_save = new artifacts_DT();
                        artifacts_obj_to_save = artifacts_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            artifacts_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            artifacts_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        artifacts_DB.Save(artifacts_obj_to_save);
                    }
                    break;
                case 6:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        content_media_DT video_obj_to_save = new content_media_DT();
                        video_obj_to_save = content_media_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=6");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=6");
                            video_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            video_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            video_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            video_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            video_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        content_media_DB.Save(video_obj_to_save);
                        
                    }
                    else
                    {
                        content_media_DT video_obj_to_save = new content_media_DT();
                        video_obj_to_save = content_media_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            video_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            video_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        content_media_DB.Save(video_obj_to_save);
                    }

                    break;
                case 7:
                    content_media_DT audio_obj_to_save = new content_media_DT();
                    audio_obj_to_save = content_media_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=7");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=7");
                        audio_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        audio_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        audio_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        audio_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        audio_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    content_media_DB.Save(audio_obj_to_save);
                    

                    break;

                case 8:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        documents_DT wase2a_obj_to_save = new documents_DT();
                        wase2a_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=8");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=8");
                            wase2a_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            wase2a_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            wase2a_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            wase2a_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            wase2a_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        documents_DB.Save(wase2a_obj_to_save);
                        
                    }
                    else
                    {
                        documents_DT wase2a_obj_to_save = new documents_DT();
                        wase2a_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            wase2a_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            wase2a_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        documents_DB.Save(wase2a_obj_to_save);
                    }
                    break;
                case 9:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        documents_DT article_obj_to_save = new documents_DT();
                        article_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=9");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=9");
                            article_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            article_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            article_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            article_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            article_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        documents_DB.Save(article_obj_to_save);
                        
                    }
                    else
                    {
                        documents_DT article_obj_to_save = new documents_DT();
                        article_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            article_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            article_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        documents_DB.Save(article_obj_to_save);
                    }

                    break;
                case 10:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        documents_DT book_obj_to_save = new documents_DT();
                        book_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=10");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=10");
                            book_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            book_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            book_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            book_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            book_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        documents_DB.Save(book_obj_to_save);
                        
                    }
                    else
                    {
                        documents_DT book_obj_to_save = new documents_DT();
                        book_obj_to_save = documents_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            book_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            book_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        documents_DB.Save(book_obj_to_save);
                    }
                    break;
                case 12:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        manuscripts_DT manuscripts_obj_to_save = new manuscripts_DT();
                        manuscripts_obj_to_save = manuscripts_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=12");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=12");
                            manuscripts_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            manuscripts_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            manuscripts_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            manuscripts_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            manuscripts_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        manuscripts_DB.Save(manuscripts_obj_to_save);

                    }
                    else
                    {
                        manuscripts_DT manuscripts_obj_to_save = new manuscripts_DT();
                        manuscripts_obj_to_save = manuscripts_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            manuscripts_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            manuscripts_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        manuscripts_DB.Save(manuscripts_obj_to_save);
                    }
                    break;
                case 13:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        theses_DT theses_obj_to_save = new theses_DT();
                        theses_obj_to_save = theses_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=13");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=13");
                            theses_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            theses_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            theses_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            theses_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            theses_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        theses_DB.Save(theses_obj_to_save);

                    }
                    else
                    {
                        theses_DT theses_obj_to_save = new theses_DT();
                        theses_obj_to_save = theses_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            theses_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            theses_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        theses_DB.Save(theses_obj_to_save);
                    }
                    break;
                case 14:
                    if (gvContentFiles.Rows.Count == 2)
                    {
                        conference_proceedings_DT conference_proceedings_obj_to_save = new conference_proceedings_DT();
                        conference_proceedings_obj_to_save = conference_proceedings_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=14");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=14");
                            conference_proceedings_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            conference_proceedings_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            conference_proceedings_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            conference_proceedings_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            conference_proceedings_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        conference_proceedings_DB.Save(conference_proceedings_obj_to_save);

                    }
                    else
                    {
                        conference_proceedings_DT conference_proceedings_obj_to_save = new conference_proceedings_DT();
                        conference_proceedings_obj_to_save = conference_proceedings_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            conference_proceedings_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            conference_proceedings_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        conference_proceedings_DB.Save(conference_proceedings_obj_to_save);
                    }
                    break;
                case 11:
                    if (gvContentFiles.Rows.Count == 3)
                    {
                        content_images_DT images_obj_to_save = new content_images_DT();
                        images_obj_to_save = content_images_DB.SelectByID(current_content_id);
                        if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=11");
                            General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=11");
                            images_obj_to_save.file_status = 18;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            images_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            gvContentFiles.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                            images_obj_to_save.file_status = 7;
                        else if (type_mode.Value != "9" && chkDone.Checked == true)
                        {
                            images_obj_to_save.file_status = 8;
                            //lblpageMsg.Visible = true;
                            //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                            log(6);
                            images_obj_to_save.lock_files = 0;
                            lockChckBox.Enabled = false;
                            lockBtn.Enabled = false;
                            chkDone.Visible = false;
                            btnSavePage.Visible = false;
                            btnsave.Visible = false;
                            trUpload.Visible = false;
                            trErrors.Visible = false;
                            fill_data();
                            Smrt_Srch_object.Clear_Controls();
                        }
                        content_images_DB.Save(images_obj_to_save);
                        
                    }
                    else
                    {
                        content_images_DT images_obj_to_save = new content_images_DT();
                        images_obj_to_save = content_images_DB.SelectByID(current_content_id);
                        if (type_mode.Value != "9" && chkDone.Checked == true )
                        {
                            images_obj_to_save.file_status = 7;
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        else if (type_mode.Value != "9" && chkDone.Checked == false)
                        {
                            images_obj_to_save.file_status = 7;
                        }
                        else if (type_mode.Value == "9" && chkDone.Checked == true)
                        {
                            
                            Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('هناك ملفات لهذا العنصر لم يتم تحميلها بعد ')</script>");
                        }
                        content_images_DB.Save(images_obj_to_save);
                    }

                    break;
                case 15:
                    WebSites_Template_DT WebSites_Template_obj_to_save = new WebSites_Template_DT();
                    WebSites_Template_obj_to_save = WebSites_Template_DB.SelectByID(current_content_id);
                    if (type_mode.Value == "9" && chkDone.Checked == true)
                    {
                        General_Helping.ExcuteQuery("update contents_notes set error_status=3 where contents_notes.error_status=2 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=15");
                        General_Helping.ExcuteQuery("update contents_notes set error_status=2 where contents_notes.error_status=1 and contents_notes.error_type=2 and contents_notes.content_id=" + current_content_id + " and contents_notes.content_type=15");

                        WebSites_Template_obj_to_save.file_status = 18;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        WebSites_Template_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();

                    }
                    else if (type_mode.Value != "9" && chkDone.Checked == false)
                        WebSites_Template_obj_to_save.file_status = 7;
                    else if (type_mode.Value != "9" && chkDone.Checked == true)
                    {
                        WebSites_Template_obj_to_save.file_status = 8;
                        //lblpageMsg.Visible = true;
                        //lblpageMsg.Text = "تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ";
                        Page.RegisterStartupScript("Sucess", "<script language=javascript>alert('تم إرسال ملفات هذا العنصر إلى مراقب جودة الملفات ')</script>");
                        log(6);
                        WebSites_Template_obj_to_save.lock_files = 0;
                        lockChckBox.Enabled = false;
                        lockBtn.Enabled = false;
                        chkDone.Visible = false;
                        btnSavePage.Visible = false;
                        btnsave.Visible = false;
                        trUpload.Visible = false;
                        gvContentFiles.Visible = false;
                        trErrors.Visible = false;
                        fill_data();
                        Smrt_Srch_object.Clear_Controls();
                    }
                    WebSites_Template_DB.Save(WebSites_Template_obj_to_save);
                    //


                    break;
            }


           
        }
        else
        {
            lblpageMsg.Visible = true;
            lblpageMsg.Text = "هناك ملفات لهذا العنصر لم يتم تحميلها بعد";
            
        }
    }
    protected Boolean fileIsValid()
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
        int current_content_type = CDataConverter.ConvertToInt(ddlElementType.SelectedValue);
        int current_content_usage = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
        if (fucontentFile.HasFile)
        {
            String[] dotFileName = fucontentFile.FileName.Split('.');
            if (dotFileName.Length == 2)
            {
                switch (current_content_type)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 11:
                    case 15:
                        if (dotFileName[1].ToString().ToLower() == "jpeg" || dotFileName[1].ToString().ToLower() == "jpg" ||
                            dotFileName[1].ToString().ToLower() == "gif" || dotFileName[1].ToString().ToLower() == "png" ||
                            dotFileName[1].ToString().ToLower() == "bmp" || dotFileName[1].ToString().ToLower() == "tiff" ||
                            dotFileName[1].ToString().ToLower() == "raw")
                        { }
                        else
                        {
                            lblpageMsg.Visible = true;
                            lblpageMsg.Text = "إمتداد الصورة غير معروف";
                            return false;
                        }
                        break;
                    case 5:
                        if (current_content_usage == 8)
                        {
                            if (dotFileName[1].ToString().ToLower() == "jpeg" || dotFileName[1].ToString().ToLower() == "jpg" ||
                            dotFileName[1].ToString().ToLower() == "gif" || dotFileName[1].ToString().ToLower() == "png" ||
                            dotFileName[1].ToString().ToLower() == "bmp" || dotFileName[1].ToString().ToLower() == "tiff" ||
                            dotFileName[1].ToString().ToLower() == "raw")
                            { }
                            else
                            {
                                lblpageMsg.Visible = true;
                                lblpageMsg.Text = "إمتداد الصورة غير معروف";
                                return false;
                            }
                        }
                        else if (current_content_usage == 9)
                        {
                            
                        }
                        break;
                    case 6:
                        if (current_content_usage == 11)
                        {
                            if (dotFileName[1].ToString().ToLower() != "wmv" && dotFileName[1].ToString().ToLower() != "mp4")
                            {
                                lblpageMsg.Visible = true;
                                lblpageMsg.Text = "إمتداد التسجيل المرئى غير معروف";
                                return false;
                            }
                        }
                        if (current_content_usage == 10)
                        {
                            if (dotFileName[1].ToString().ToLower() == "jpeg" || dotFileName[1].ToString().ToLower() == "jpg" ||
                            dotFileName[1].ToString().ToLower() == "gif" || dotFileName[1].ToString().ToLower() == "png" ||
                            dotFileName[1].ToString().ToLower() == "bmp" || dotFileName[1].ToString().ToLower() == "tiff" ||
                            dotFileName[1].ToString().ToLower() == "raw")
                            { }
                            else
                            {
                                lblpageMsg.Visible = true;
                                lblpageMsg.Text = "إمتداد الصورة غير معروف";
                                return false;
                            }
                        }

                        break;
                    case 7:

                        if (dotFileName[1].ToString().ToLower() != "mp3")
                        {
                            lblpageMsg.Visible = true;
                            lblpageMsg.Text = "إمتداد التسجيل السمعى غير معروف";
                            return false;
                        }

                        break;
                    case 8:
                    case 9:
                    case 10:
                    case 12:
                    case 13:
                    case 14:
                        if (current_content_usage == 14 || current_content_usage == 16 || current_content_usage == 18 || current_content_usage == 23 || current_content_usage == 25 || current_content_usage == 27)
                        {
                            if (dotFileName[1].ToString().ToLower() != "pdf")
                            {
                                lblpageMsg.Visible = true;
                                lblpageMsg.Text = "إمتداد الوثيقة غير معروف";
                                return false;
                            }
                        }
                        if (current_content_usage == 13 || current_content_usage == 15 || current_content_usage == 17 || current_content_usage == 22 || current_content_usage == 24 || current_content_usage == 26)
                        {
                            if (dotFileName[1].ToString().ToLower() == "jpeg" || dotFileName[1].ToString().ToLower() == "jpg" ||
                            dotFileName[1].ToString().ToLower() == "gif" || dotFileName[1].ToString().ToLower() == "png" ||
                            dotFileName[1].ToString().ToLower() == "bmp" || dotFileName[1].ToString().ToLower() == "tiff" ||
                            dotFileName[1].ToString().ToLower() == "raw")
                            { }
                            else
                            {
                                lblpageMsg.Visible = true;
                                lblpageMsg.Text = "إمتداد الصورة غير معروف";
                                return false;
                            }
                        }

                        break;
                   
                   
                    







                }
                String[] _fileName = dotFileName[0].Split('_');
                if (_fileName.Length == 3)
                {
                    if (CDataConverter.ConvertToInt(_fileName[0]) != current_content_type)
                    {
                        lblpageMsg.Visible = true;
                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                        return false;
                    }
                    else if (CDataConverter.ConvertToInt(_fileName[1]) != current_content_id)
                    {
                        lblpageMsg.Visible = true;
                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                        return false;
                    }
                    else
                    {
                        switch (current_content_type)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 15:
                                if (_fileName[2] != "img")
                                {
                                    lblpageMsg.Visible = true;
                                    lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                    return false;
                                }
                                break;
                            case 5:
                                if (current_content_usage == 8)
                                {
                                    if (_fileName[2] != "thum")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                    break;
                                }
                                else if (current_content_usage == 9)
                                {
                                    if (_fileName[2] != "norm")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                    break;
                                }
                                break;
                            case 6:
                                if (current_content_usage == 10)
                                {
                                    if (_fileName[2] != "thum")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                else if (current_content_usage == 11)
                                {
                                    if (_fileName[2] != "video")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                break;
                            case 7:
                                if (_fileName[2] != "sound")
                                {
                                    lblpageMsg.Visible = true;
                                    lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                    return false;
                                }
                                break;

                            case 8:
                            case 9:
                            case 10:
                            case 12:
                            case 13:
                            case 14:
                                if (current_content_usage == 13 || current_content_usage == 15 || current_content_usage == 17 || current_content_usage == 22 || current_content_usage == 24 || current_content_usage == 26)
                                {
                                    if (_fileName[2] != "thum")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                else if (current_content_usage == 14 || current_content_usage == 16 || current_content_usage == 18 || current_content_usage == 23 || current_content_usage == 25 || current_content_usage == 27)
                                {
                                    if (_fileName[2] != "doc")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                break;
                            case 11:
                                if (current_content_usage == 19)
                                {
                                    if (_fileName[2] != "thum")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                else if (current_content_usage == 20)
                                {
                                    if (_fileName[2] != "norm")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                else if (current_content_usage == 21)
                                {
                                    if (_fileName[2] != "larg")
                                    {
                                        lblpageMsg.Visible = true;
                                        lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                                        return false;
                                    }
                                }
                                break;


                        }
                    }

                    return true;

                }
                else
                {
                    lblpageMsg.Visible = true;
                    lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                    return false;
                }


            }
            else
            {
                lblpageMsg.Visible = true;
                lblpageMsg.Text = "اسم الملف ليس بالصيغة الصحيحة";
                return false;
            }


        }
        else
            return false;
    }
    protected void saveFileSystem(string path)
    {
        // Specify the path on the server to
        // save the uploaded file to.
        //String savePath = @"c:\temp\uploads\";
        string savePath = MapPath("~") + path;
        // Before attempting to perform operations
        // on the file, verify that the FileUpload 
        // control contains a file.
        if (fucontentFile.HasFile)
        {
            // Get the name of the file to upload.
            string fileName = fucontentFile.FileName;

            // Append the name of the file to upload to the path.
            savePath += fileName;


            // Call the SaveAs method to save the 
            // uploaded file to the specified path.
            // This example does not perform all
            // the necessary error checking.               
            // If a file with the same name
            // already exists in the specified path,  
            // the uploaded file overwrites it.
            fucontentFile.SaveAs(savePath);
            
            lblpageMsg.Text = "تم حفظ الملف  " + fileName;
            // Notify the user of the name of the file
            // was saved under.

        }
        else
        {
            // Notify the user that a file was not uploaded.
            lblpageMsg.Text = "You did not specify a file to upload.";
        }

    }
   
    protected void ddlFileUsage_SelectedIndexChanged(object sender, EventArgs e)
    {
        set_example_label();
    }
    private void set_example_label()
    {
            string strExt = "";
            string strExt2 = "";
            int current_content_usage = CDataConverter.ConvertToInt(ddlFileUsage.SelectedValue);
            switch (CDataConverter.ConvertToInt(ddlElementType.SelectedValue))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 15:
                    strExt = "img";
                    strExt2 = "jpg";
                    break;
                case 5:
                    if (current_content_usage == 8)
                    {
                        strExt = "thum";
                        strExt2 = "jpg";
                    }
                    else if (current_content_usage == 9)
                    {
                        strExt = "norm";
                        strExt2 = "##";
                    }
                    break;
                case 6:
                    if (current_content_usage == 10)
                    {
                        strExt = "thum";
                        strExt2 = "jpg";
                    }
                    else if (current_content_usage == 11)
                    {
                        strExt = "video";
                        strExt2 = "wmv";
                    }

                    break;

                   
               case 7:
                    strExt = "sound";
                    strExt2 = "mp3";     
                                break;

                case 8:
                case 9:
                case 10:
                case 12:
                case 13:
                case 14:
                    if (current_content_usage == 13 || current_content_usage == 15 || current_content_usage == 17 || current_content_usage == 22 || current_content_usage == 24 || current_content_usage == 26)
                    {
                        strExt = "thum";
                        strExt2 = "jpg";
                    }
                    else if (current_content_usage == 14 || current_content_usage == 16 || current_content_usage == 18 || current_content_usage == 23 || current_content_usage == 25 || current_content_usage == 27)
                    {
                        strExt = "doc";
                        strExt2 = "pdf";
                    }
                    break;
                case 11:
                    if (current_content_usage == 19)
                    {
                        strExt = "thum";
                        strExt2 = "jpg";
                    }
                    else if (current_content_usage == 20)
                    {
                        strExt = "norm";
                        strExt2 = "jpg";
                    }
                    else if (current_content_usage == 21)
                    {
                        strExt = "larg";
                        strExt2 = "jpg";
                    }
                    break;


                        }


            if (CDataConverter.ConvertToInt(ddlElementType.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
            { Label5.Text = ddlElementType.SelectedValue + "_" + Smrt_Srch_object.SelectedValue + "_" + strExt + "." + strExt2; }
            else if (CDataConverter.ConvertToInt(ddlElementType.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) == 0)
             { Label5.Text = ddlElementType.SelectedValue + "_##_" + strExt + "." + strExt2; }
             else { Label5.Visible = false; }
    }
    protected void chkDone_CheckedChanged(object sender, EventArgs e)
    {
        if (chkDone.Checked==true)
            btnSavePage.Enabled = true;
        else
            btnSavePage.Enabled = false;
    }
}
