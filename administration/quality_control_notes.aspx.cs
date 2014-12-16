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

public partial class administration_quality_notes : BasePage
{
    public static string id = "";
    public static int row_id = 0;
    private string sql_Connection = Database.ConnectionString;
    General_Helping Obj_General_Helping = new General_Helping();
    protected override void OnInit(EventArgs e)
    {
        this.Smrt_Srch_object.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);
    }

    private void MOnMember_Data(string Value)
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
                    fillddropdown();
                    fillgrid();
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
                   

                }
                tr_lock.Visible = true;
                CheckBox1.Enabled = false;
                lockBtn.Enabled = false;

            }
        }
    }
    private void Fill_smart(string Value)
    {
        string setvalue = "";
        DataTable dt = new DataTable();
        if (Request["operation"].ToString() == "new")
            setvalue = "22";
        if (Request["operation"].ToString() == "processed")
            setvalue = "23";
        if (Request["operation"].ToString() == "unfinished")
            setvalue = "24";
        if (Value != "")
        {
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
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                                new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //dt = DatabaseFunctions.SelectData(sqlParams5, "get_artifacts_titles");
                    Smrt_Srch_object.stored = "get_artifacts_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams5;
                    break;
                case "6":
                    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
                                                          new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    //  dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
                    Smrt_Srch_object.stored = "get_video_titles";
                    Smrt_Srch_object.stored_parameters = sqlParams6;
                    break;
                case "7":
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),
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
        if (chk_status.Checked == true)
        { Button1.Enabled = true; }
        else { Button1.Enabled = false; }
        if (!IsPostBack)
        {
            fill_data();
            TabContainer1.Visible = false;
            tr_finish.Visible = false;
            //fillddropdown();
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
            TabPanel11.Enabled = false;
        }
        else
        {

            if (id != "")
            {
                load_control();



            }
            else
            {
                //fill_data();
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
                TabPanel11.Enabled = false;
            }
        }



    }
    public void fillddropdown()
    {
        DataTable fdt = contents_fields_DB.SelectByCont_type(CDataConverter.ConvertToInt(object_type.SelectedValue));
        drop_fields.DataSource = fdt;
        
        if (menus_update.get_current_lang() == 1)
        {
            drop_fields.DataTextField = "field_name";

        }
        if (menus_update.get_current_lang() == 2)
        { drop_fields.DataTextField = "field_name_en"; }
        if (menus_update.get_current_lang() == 3)
        { drop_fields.DataTextField = "field_name_fr"; }
        drop_fields.DataValueField = "id";
        drop_fields.DataBind();
        ListItem litem = new ListItem("-- اختر نوع الحقل --", "0");
        litem.Selected = true;
        drop_fields.Items.Insert(0, litem);
        //------------------------------------------//
        DataTable erdt = contents_errors_DB.SelectByForm_File();
        drop_type_wrong.DataSource = erdt;
        drop_type_wrong.DataBind();
        ListItem item = new ListItem("-- اختر نوع الخطأ --", "0");
        item.Selected = true;
        drop_type_wrong.Items.Insert(0, item);

    }
    public void fillgrid()
    {
        if (Request.QueryString["operation"].ToString() == "new" || Request.QueryString["operation"].ToString() == "unfinished")
        {

            //TabPanel7.Enabled = true;
            DataTable dt = contents_notes_DB.SelectByErrorID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue), CDataConverter.ConvertToInt(object_type.SelectedValue), 1, 1, menus_update.get_current_lang());
            gvnotes.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
		gvnotes.Visible = true;
                gvnotes.DataBind();
                if (menus_update.get_current_lang() == 1)
                {
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
                //Label1.Text = dt.Rows[0]["error_type"].ToString();
            }
            else
            { gvnotes.Visible = false; }

        }
        else if (Request.QueryString["operation"].ToString() == "processed")
        {
            //TabPanel7.Enabled = true;
            DataTable dt = contents_notes_DB.SelectByErrorID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue), CDataConverter.ConvertToInt(object_type.SelectedValue), 2, 1, menus_update.get_current_lang());
            gvnotes.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
		gvnotes.Visible = true;
                gvnotes.DataBind();
                if (menus_update.get_current_lang() == 1)
                {
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
            }
            else
            { gvnotes.Visible = false; }


        }
        DataTable dtcomm = General_Helping.GetDataTable("select * from quality_comments_file where content_id=" + CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) + " and content_type=" + CDataConverter.ConvertToInt(object_type.SelectedValue));

        gvContentFiles.DataSource = dtcomm;
        gvContentFiles.DataBind();
        if (dtcomm.Rows.Count > 0)
        { txt31.Text = dtcomm.Rows[0]["notes"].ToString(); }
        else { txt31.Text = ""; }	

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (object_type.SelectedValue != "" && Smrt_Srch_object.SelectedValue != "")
        {
            if (CDataConverter.ConvertToInt(drop_fields.SelectedValue) == 0 || CDataConverter.ConvertToInt(drop_type_wrong.SelectedValue) == 0)
            {
                ShowAlertMessage("يجب اختيار نوع الحقل ونوع الخطأ");
                return;
            }
            contents_notes_DT notedt = new contents_notes_DT();

            notedt.id = CDataConverter.ConvertToInt(row_id);
            notedt.field_id = CDataConverter.ConvertToInt(drop_fields.SelectedValue);
            notedt.error_id = CDataConverter.ConvertToInt(drop_type_wrong.SelectedValue);
            notedt.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
            notedt.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
            notedt.error_status = 1;
            notedt.error_type = 1;
            notedt.observer_note = txt_notes.Text;

            notedt.observer_note_date = DateTime.Now.ToShortDateString();
            notedt.lang_id = menus_update.get_current_lang();
            int res = contents_notes_DB.Save(notedt);
            if (res > 0)
            {
                fillgrid();
                log(4);
                ShowAlertMessage("لقد تم الحفظ");
                drop_fields.SelectedIndex = 0;
                drop_type_wrong.SelectedIndex = 0;
                txt_notes.Text = "";
            }
            row_id = 0;
        }

        else { ShowAlertMessage("يجب اختيار نوع الاستمارة والاسم أولاً"); }

    }
    public void fillcontroll()
    {
        contents_notes_DT fileddt = contents_notes_DB.SelectByID(row_id);

        if (fileddt.field_id != 0)
        {
            drop_fields.SelectedValue = fileddt.field_id.ToString();
        }
        if (fileddt.error_id != 0)
        { drop_type_wrong.SelectedValue = fileddt.error_id.ToString(); }
        txt_notes.Text = fileddt.observer_note;



    }
    protected void gvnotes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "EditItem")
        {
            row_id = CDataConverter.ConvertToInt(e.CommandArgument.ToString());
            //edit_id.Value = id;
            //fillcontroll(Convert.ToInt32(id));
            fillcontroll();
        }
        if (e.CommandName == "DeleteItem")
        {
            contents_notes_DB.Delete(Convert.ToInt32(e.CommandArgument));
            fillgrid();

        }

    }
    public void fill_data()
    {
        if (Request["operation"] != null)
        {
            if (Session["user_id"].ToString() != null)
            {
                DataTable objectsDT = content_types_DB.SelectAll();
                object_type.DataSource = content_types_DB.SelectAll();
                object_type.DataBind();

                int counter = objectsDT.Rows.Count;
                if (Request["operation"].ToString() == "new")
                {
                    SqlParameter[] newSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "3"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang()) };
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

                else if (Request["operation"].ToString() == "processed")
                {
                    SqlParameter[] processedSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "4"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang()) };
                    DataTable processedDT = DatabaseFunctions.SelectData(processedSqlParams, "get_final_entryform_count");
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
                else if (Request["operation"].ToString() == "unfinished")
                {
                    SqlParameter[] refusedSqlParams = new SqlParameter[] { new SqlParameter("@form_status", "19"), new SqlParameter("@user_id", Session["user_id"].ToString()), new SqlParameter("@lang_id", menus_update.get_current_lang()) };
                    DataTable refusedDT = DatabaseFunctions.SelectData(refusedSqlParams, "get_final_entryform_count");
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
    }

    //public void fill_objects_titles()
    //{
    //    string setvalue = "";
    //    DataTable dt = new DataTable();
    //    if (Request["operation"].ToString() == "new")
    //        setvalue = "22";

    //    if (Request["operation"].ToString() == "processed")
    //        setvalue = "23";

    //    if (Request["operation"].ToString() == "unfinished")
    //        setvalue = "24";
    //    switch (object_type.SelectedValue)
    //    {
    //        case "1":
    //            SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //            dt = DatabaseFunctions.SelectData(sqlParams1, "get_characters_titles");
    //            break;
    //        case "2":
    //            SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams2, "get_events_titles");
    //            break;
    //        case "3":
    //            SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams3, "get_topics_titles");
    //            break;
    //        case "4":
    //            SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", ""), new SqlParameter("@selview",setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //           dt = DatabaseFunctions.SelectData(sqlParams4, "get_places_titles");
    //        break;
    //        case "5":
    //            SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams5, "get_artifacts_titles");
    //            break;
    //        case "6":
    //            SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
    //            break;
    //        case "7":
    //            SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams7, "get_audio_titles");
    //            break;
    //        case "8":
    //            SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams8, "get_docs_titles");
    //            break;
    //        case "9":
    //            SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //            dt = DatabaseFunctions.SelectData(sqlParams9, "get_articles_titles");
    //            break;
    //        case "10":
    //            SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", setvalue), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) };
    //            dt = DatabaseFunctions.SelectData(sqlParams10, "get_books_titles");
    //            break;
    //        case "11":
    //            SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview", setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //            dt = DatabaseFunctions.SelectData(sqlParams11, "get_images_titles");
    //            break;
    //        case "12":
    //            SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview",setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //            dt = DatabaseFunctions.SelectData(sqlParams12, "get_manuscripts_titles");
    //            break;
    //        case "13":
    //            SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview",setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //            dt = DatabaseFunctions.SelectData(sqlParams13, "get_theses_titles");
    //            break;
    //        case "14":
    //            SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview",setvalue) , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString())};
    //            dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
    //            break;
    //    }
    //    //Smrt_Srch_object.DataSource = dt;
    //     Smrt_Srch_object.DataBind();
    //    //ListItem litem = new ListItem("-- اختر العنصر --", "0");
    //   // litem.Selected = true;
    //    //Smrt_Srch_object.Items.Insert(0, litem);
    //}

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
                    TabPanel11.Enabled = true;
                    if (menus_update.get_current_lang() == 1)
                    {
                        TabContainer1.Visible = true;
                        tr_finish.Visible = true;
                        TabPanel1.Enabled = true;
                        TabPanel2.Enabled = true;
                        TabPanel3.Enabled = true;
                        TabPanel4.Enabled = true;
                        TabPanel5.Enabled = true;
                        TabPanel6.Enabled = true;
                        TabPanel7.Enabled = true;
                        //TabPanel8.Enabled = true;
                        //fillddropdown();
                        //fillgrid();
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
                                support_elements.fillGrid();
                                if (Smrt_Srch_object.SelectedValue != "")
                                {
                                    if (Session["user_type"] != null)
                                    {
                                        support_elements.Enabled();
                                    }
                                }
                            }
                        }
                        else
                        {
                            TabPanel3.Enabled = false;

                        }
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
                        }
                        else { TabPanel5.Enabled = false; }
                        ////// timeline

                        HiddenField Hfield_timeline_type = (HiddenField)timelineform.FindControl("content_type");
                        Hfield_timeline_type.Value = object_type.SelectedValue;
                        HiddenField Hfield_timeline_id = (HiddenField)timelineform.FindControl("content_id");
                        Hfield_timeline_id.Value = Smrt_Srch_object.SelectedValue;
                        timelineform.fillGrid();

                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            if (Session["user_type"] != null)
                            {
                                timelineform.Enabled();
                            }
                        }

                        ////////  moalfat
                        if (object_type.SelectedValue == "1")
                        {
                            TabPanel4.Enabled = true;
                            HiddenField Hfield_moalfat_type = (HiddenField)char_moalfat.FindControl("content_type");
                            Hfield_moalfat_type.Value = object_type.SelectedValue;

                            HiddenField Hfield_content_id3 = (HiddenField)char_moalfat.FindControl("content_id");
                            Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                            char_moalfat.fillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)

                                { char_moalfat.Enabled(); }
                            }
                        }

                        else { TabPanel4.Enabled = false; }

                        ////////  docs authors
                        if (object_type.SelectedValue == "9" || object_type.SelectedValue == "10" || object_type.SelectedValue == "14")
                        {
                            TabPanel8.Enabled = true;
                            HiddenField Hfield_moalfat_type = (HiddenField)docs_authors.FindControl("content_type");
                            Hfield_moalfat_type.Value = object_type.SelectedValue;

                            HiddenField Hfield_content_id3 = (HiddenField)docs_authors.FindControl("content_id");
                            Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                            docs_authors.FillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                //if (Session["user_type"] != null)

                                //{ docs_authors.Enabled(); }
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
                                TabPanel7.Enabled = true;
                                TabPanel6.Enabled = false;
                                TabPanel8.Enabled = false;
                                TabPanel9.Enabled = false;
                                TabPanel10.Enabled = false;
                            }
                        }
                        ///////////////////////// Add  places translation 
                        if (object_type.SelectedValue == "4")
                        {
                            TabPanel9.Enabled = true;
                            HiddenField Hfield_moalfat_type = (HiddenField)places_translation.FindControl("content_type");
                            Hfield_moalfat_type.Value = object_type.SelectedValue;

                            HiddenField Hfield_content_id3 = (HiddenField)places_translation.FindControl("content_id");
                            Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                            places_translation.fillGridVeiws();
                            places_translation.fillDDLsRBts();

                            if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                            {

                                places_translation.Dimmed();
                                places_translation.Enabled();
                            }
                            if (Session["user_type"].ToString() == "5")
                            {

                                places_translation.unvisible();
                            }
                        }

                        else { TabPanel9.Enabled = false; }

                        if (object_type.SelectedValue == "12")
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel10.Enabled = true;
                                HiddenField Hfield_content_type2 = (HiddenField)manuscript_tab1.FindControl("content_type");
                                Hfield_content_type2.Value = object_type.SelectedValue;

                                HiddenField Hfield_content_id2 = (HiddenField)manuscript_tab1.FindControl("content_id");
                                Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                                manuscript_tab1.getData();

                                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                                {

                                    manuscript_tab1.dimmed();
                                    manuscript_tab1.Enabled();
                                }
                                if (Session["user_type"].ToString() == "5")
                                {

                                    manuscript_tab1.unvisable_all();
                                }
                            }

                        }

                        else { TabPanel10.Enabled = false; }
                        control_loaded.Value = Smrt_Srch_object.SelectedValue;
                        //lockFun();
                    }

                    if (menus_update.get_current_lang() == 2 || menus_update.get_current_lang() == 3)
                    {
                        TabContainer1.Visible = true;
                        tr_finish.Visible = true;
                        TabPanel1.Enabled = true;
                        //TabPanel2.Enabled = true;
                        //TabPanel3.Enabled = true;
                        //TabPanel4.Enabled = true;
                        //TabPanel5.Enabled = true;
                        TabPanel6.Enabled = true;
                        TabPanel7.Enabled = true;
                        TabPanel8.Enabled = true;
                        //fillddropdown();
                        //fillgrid();
                        control_panel.Controls.Clear();
                        Control user_ctrl = (Control)LoadControl(control_name);
                        HiddenField Hfield_content_type = (HiddenField)user_ctrl.FindControl("content_type");
                        Hfield_content_type.Value = object_type.SelectedValue;
                        HiddenField Hfield_content_id = (HiddenField)user_ctrl.FindControl("content_id");
                        Hfield_content_id.Value = Smrt_Srch_object.SelectedValue;
                        control_panel.Controls.Add(user_ctrl);


                        control_loaded.Value = Smrt_Srch_object.SelectedValue;
                        HiddenField Hfield_timeline_type = (HiddenField)timelineform.FindControl("content_type");
                        Hfield_timeline_type.Value = object_type.SelectedValue;
                        HiddenField Hfield_timeline_id = (HiddenField)timelineform.FindControl("content_id");
                        Hfield_timeline_id.Value = Smrt_Srch_object.SelectedValue;
                        timelineform.fillGrid();

                        if (Smrt_Srch_object.SelectedValue != "")
                        {
                            if (Session["user_type"] != null)
                            {
                                timelineform.Enabled();
                            }
                        }

                        ////////  moalfat
                        if (object_type.SelectedValue == "1")
                        {
                            TabPanel4.Enabled = true;
                            HiddenField Hfield_moalfat_type = (HiddenField)char_moalfat.FindControl("content_type");
                            Hfield_moalfat_type.Value = object_type.SelectedValue;

                            HiddenField Hfield_content_id3 = (HiddenField)char_moalfat.FindControl("content_id");
                            Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                            char_moalfat.fillGrid();
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                if (Session["user_type"] != null)

                                { char_moalfat.Enabled(); }
                            }
                        }

                        else { TabPanel4.Enabled = false; }

                        if (object_type.SelectedValue == "9" || object_type.SelectedValue == "10" || object_type.SelectedValue == "14")
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel8.Enabled = true;
                                HiddenField Hfield_moalfat_type = (HiddenField)docs_authors.FindControl("content_type");
                                Hfield_moalfat_type.Value = object_type.SelectedValue;

                                HiddenField Hfield_content_id3 = (HiddenField)docs_authors.FindControl("content_id");
                                Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                                docs_authors.FillGrid();
                                if (Smrt_Srch_object.SelectedValue != "")
                                {
                                    //if (Session["user_type"] != null)

                                    //{ docs_authors.Enabled(); }
                                }
                            }
                            else { TabPanel8.Enabled = false; }
                        }

                        else { TabPanel8.Enabled = false; }

                        if (object_type.SelectedValue == "4")
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel9.Enabled = true;
                                HiddenField Hfield_moalfat_type = (HiddenField)places_translation.FindControl("content_type");
                                Hfield_moalfat_type.Value = object_type.SelectedValue;

                                HiddenField Hfield_content_id3 = (HiddenField)places_translation.FindControl("content_id");
                                Hfield_content_id3.Value = Smrt_Srch_object.SelectedValue;
                                places_translation.fillGridVeiws();
                                places_translation.fillDDLsRBts();

                                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                                {

                                    places_translation.Dimmed();
                                    places_translation.Enabled();
                                }
                                if (Session["user_type"].ToString() == "5")
                                {

                                    places_translation.unvisible();
                                }
                            }
                            else { TabPanel9.Enabled = false; }
                        }

                        else { TabPanel9.Enabled = false; }

                        if (object_type.SelectedValue == "12")
                        {
                            if (Smrt_Srch_object.SelectedValue != "")
                            {
                                TabPanel10.Enabled = true;
                                HiddenField Hfield_content_type2 = (HiddenField)manuscript_tab1.FindControl("content_type");
                                Hfield_content_type2.Value = object_type.SelectedValue;

                                HiddenField Hfield_content_id2 = (HiddenField)manuscript_tab1.FindControl("content_id");
                                Hfield_content_id2.Value = Smrt_Srch_object.SelectedValue;
                                manuscript_tab1.getData();

                                if (Session["user_type"].ToString() == "4" && Request.QueryString["operation"].ToString() == "wrong")
                                {

                                    manuscript_tab1.dimmed();
                                    manuscript_tab1.Enabled();
                                }
                                if (Session["user_type"].ToString() == "5")
                                {

                                    manuscript_tab1.unvisable_all();
                                }
                            }

                        }

                        else { TabPanel10.Enabled = false; }


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


    protected void object_type_SelectedIndexChanged(object sender, EventArgs e)
    {
        //fillddropdown();
        Smrt_Srch_object.Clear_Controls();
        control_panel.Controls.Clear();
        Fill_smart(object_type.SelectedValue);
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
        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0)
        { Label23.Text = "_" + object_type.SelectedValue; }
        else Label23.Visible = false;


    }

    protected void drop_type_wrong_SelectedIndexChanged(object sender, EventArgs e)
    {
        //fillgrid();
    }
    protected void gvnotes_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string error_status = (string)Convert.ToString(DataBinder.Eval(e.Row.DataItem, "error_status"));
            //Label VocStat = (Label)e.Row.FindControl("VocStatus");
            if (error_status == "1")
            {
                e.Row.Cells[6].Visible =
                e.Row.Cells[7].Visible = true;
            }

            else if (error_status == "2")
            {

                e.Row.Cells[6].Visible =
                e.Row.Cells[7].Visible = false;
            }


        }
    }



    protected void Button1_Click(object sender, EventArgs e)
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
            DataTable dt = contents_notes_DB.SelectByErrorID(CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue), CDataConverter.ConvertToInt(object_type.SelectedValue), 1, 1, menus_update.get_current_lang());
            string updateLock = "";

            if (chk_status.Checked == true)
            {
                if (dt.Rows.Count > 0)
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status= 5 , form_lock =0 ";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en = 5 , form_lock_en =0 ";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr = 5 , form_lock_fr =0 ";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }

                    int reslt = General_Helping.ExcuteQuery(updateLock);
                    Session["sendto"] = "entry";
                }
                else
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status= 11 , form_lock =0 ";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en= 11 , form_lock_en =0 ";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr= 11 , form_lock_fr =0 ";
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }

                    int reslt = General_Helping.ExcuteQuery(updateLock);
                    Session["sendto"] = "final";
                }
            }
            else
            {
                if (Request["operation"].ToString() == "new")
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status= 19 , form_lock =" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en= 19 , form_lock_en =" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr= 19 , form_lock_fr =" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    int reslt = General_Helping.ExcuteQuery(updateLock);

                }

                if (Request["operation"].ToString() == "unfinished")
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status= 19 , form_lock =" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en= 19 , form_lock_en =" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr= 19 , form_lock_fr =" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }

                    int reslt2 = General_Helping.ExcuteQuery(updateLock);
                }


                if (Request["operation"].ToString() == "processed")
                {
                    if (menus_update.get_current_lang() == 1)
                    {
                        updateLock = "update " + obj_table + " set form_status=4 , form_lock=" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        updateLock = "update " + obj_table + " set form_status_en= 4 , form_lock_en=" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        updateLock = "update " + obj_table + " set form_status_fr= 4 , form_lock_fr=" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                    }
                    int reslt2 = General_Helping.ExcuteQuery(updateLock);
                }
            }
            if (chk_status.Checked == true)
            { //7	تمرير للمراجعة//
                if (dt.Rows.Count > 0)
                { log(8); }
                else { log(7); }
            }
            else
            {

                log(2);

            }
            Response.Redirect("~/administration/Default.aspx");
        }

        else { ShowAlertMessage("يجب اختيار نوع الاستمارة واسم العنصر أولاً"); }
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

    protected void lockBtn_Click(object sender, EventArgs e)
    {
        lockFun();
        //load_control();

    }

    public void log(int operation_id)
    {
        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
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
        //else { ShowAlertMessage("يجب اختيار نوع الاستمتارة واسم العنصر أولاً"); }
    }
    public void lockFun()
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
        if (CheckBox1.Checked == true)
        {
            string sql = "";
             string updateLock = "";
            if (obj_table != "")
            {
                if (menus_update.get_current_lang() == 1)
                {
                    sql = "select form_lock from " + obj_table + " where id= " + Smrt_Srch_object.SelectedValue;
                    DataTable locked = General_Helping.GetDataTable(sql);
                    if (locked.Rows[0]["form_lock"].ToString() != "0" && locked.Rows[0]["form_lock"].ToString() != null)
                    {
                        if (locked.Rows[0]["form_lock"].ToString() != Session["user_id"].ToString())
                        {
                            {
                                //ShowAlertMessage("عفواً تم الاستحواذ علي الاستمارة من مدخل أخر");
                                //System.Threading.Thread.Sleep(5000);
                                Session["sendto"] = "qualitylocked";
                                Response.Redirect("~/administration/Default.aspx");
                            }

                        }
                    }
                    else{
                   
                        updateLock = "update " + obj_table + " set form_lock=" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;

                        if (Request["operation"].ToString() == "new")
                        {
                            string status = "update " + obj_table + " set form_lock=" + Session["user_id"].ToString() + " , form_status=" + 3;
                            status += " where id=" + Smrt_Srch_object.SelectedValue;
                            General_Helping.ExcuteQuery(status);
                        }
                   
                    }
                    
                }
                else if (menus_update.get_current_lang() == 2)
                {
                    sql = "select form_lock_en from " + obj_table + " where id= " + Smrt_Srch_object.SelectedValue;
                    DataTable locked = General_Helping.GetDataTable(sql);
                    if (locked.Rows[0]["form_lock_en"].ToString() != "0" && locked.Rows[0]["form_lock_en"].ToString() != null)
                    {
                        if (locked.Rows[0]["form_lock_en"].ToString() != Session["user_id"].ToString())
                        {
                            { //ShowAlertMessage("عفواً تم الاستحواذ علي الاستمارة من مدخل أخر");
                                //System.Threading.Thread.Sleep(5000);
                                Session["sendto"] = "qualitylocked";
                                Response.Redirect("~/administration/Default.aspx");
                            }

                        }
                    }
                    else
                    {
                          updateLock = "update " + obj_table + " set form_lock_en=" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;

                        if (Request["operation"].ToString() == "new")
                        {
                            string status = "update " + obj_table + " set form_lock_en=" + Session["user_id"].ToString() + " , form_status_en=" + 3;
                            status += " where id=" + Smrt_Srch_object.SelectedValue;
                            General_Helping.ExcuteQuery(status);
                        }
                    }
                   
                }
               else if (menus_update.get_current_lang() == 3)
                {
                    sql = "select form_lock_fr from " + obj_table + " where id= " + Smrt_Srch_object.SelectedValue;
                    DataTable locked = General_Helping.GetDataTable(sql);
                    if (locked.Rows[0]["form_lock_fr"].ToString() != "0" && locked.Rows[0]["form_lock_fr"].ToString() != null)
                    {
                        if (locked.Rows[0]["form_lock_fr"].ToString() != Session["user_id"].ToString())
                        {
                            { //ShowAlertMessage("عفواً تم الاستحواذ علي الاستمارة من مدخل أخر");
                                //System.Threading.Thread.Sleep(5000);
                                Session["sendto"] = "qualitylocked";
                                Response.Redirect("~/administration/Default.aspx");
                            }

                        }
                    }
                    else
                    {
                       updateLock = "update " + obj_table + " set form_lock_fr=" + Session["user_id"].ToString();
                        updateLock += " where id=" + Smrt_Srch_object.SelectedValue;
                        if (Request["operation"].ToString() == "new")
                        {
                            string status = "update " + obj_table + " set form_lock_fr=" + Session["user_id"].ToString() + " , form_status_fr=" + 3;
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
                    fillddropdown();
                    fillgrid();

                    log(15);
                }


                
            }

        }
    }
    public void btnsavefilecomm_Click(object sender, EventArgs e)
    {
        if (CDataConverter.ConvertToInt(object_type.SelectedValue) > 0 && CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) > 0)
        {
            if (fucom.HasFile == true)
            {
                int found = 0;
                DataTable dt = General_Helping.GetDataTable("select * from quality_comments_file where content_id=" + CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) + " and content_type=" + CDataConverter.ConvertToInt(object_type.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    found = CDataConverter.ConvertToInt(dt.Rows[0]["id"].ToString());
                }
                quality_comments_file_DT quality_comments_file_obj = new quality_comments_file_DT();
                quality_comments_file_obj.id = found;
                quality_comments_file_obj.content_id = CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue);
                quality_comments_file_obj.content_type = CDataConverter.ConvertToInt(object_type.SelectedValue);
                quality_comments_file_obj.file_name = fucom.FileName;
                quality_comments_file_obj.notes = txt31.Text;
                int result = quality_comments_file_DB.Save(quality_comments_file_obj);
                if (result > 0)
                {
                    string savePath = MapPath("~") + "\\upload\\forms\\";
                    string fileName = fucom.FileName;
                    if (System.IO.File.Exists(savePath))
                    {

                        string tempfileName = fileName + "_comments";
                        fileName = tempfileName;
                    }

                    savePath += fileName;
                    fucom.SaveAs(savePath);
                    ShowAlertMessage("لقد تم الحفظ بنجاح");
                    fillgrid();
                }
            }
        }
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

    public void ImgBtnDelete_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {

        DataTable dt = General_Helping.GetDataTable("select * from quality_comments_file where content_id=" + CDataConverter.ConvertToInt(Smrt_Srch_object.SelectedValue) + " and content_type=" + CDataConverter.ConvertToInt(object_type.SelectedValue));
        if (dt.Rows.Count > 0)
        {
            quality_comments_file_DB.Delete(CDataConverter.ConvertToInt(dt.Rows[0]["id"].ToString()));
            fillgrid();
        }

    }

}