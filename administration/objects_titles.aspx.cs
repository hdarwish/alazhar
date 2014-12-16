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

public partial class administration_objects_titles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            get_content_types();
            DataTable charsDT = characters_details_DB.SelectBylang_ID(menus_update.get_current_lang());
            DataTable authorsDT = authors_details_DB.SelectAll();
            char_lst.DataSource = charsDT;
            char_lst.DataBind();
            auth_lst.DataSource = authorsDT;
            auth_lst.DataBind();
            ListItem litem = new ListItem("-- اختر الشخصية --", "0");
            litem.Selected = true;
            char_lst.Items.Insert(0, litem);
            ListItem litem2 = new ListItem("-- اختر المؤلف --", "0");
            litem2.Selected = true;
            auth_lst.Items.Insert(0, litem2);
        }
    }
    public void get_content_types()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "get_content_types");
        types_list.DataSource = dt;
        types_list.DataBind();
    }
    protected void objects_grid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "replace")
            {
                DataTable dt = new DataTable();

                if (id > 0)
                {
                    if (object_name.Text.Trim() != "")
                    {
                        SqlParameter[] sqlParams = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", id),
                                                            new SqlParameter("@operation", "edit"),
                                                            new SqlParameter("@keyfield1", ""),
                                                            new SqlParameter("@keyfield2", ""),
                                                             new SqlParameter("@lang_id", menus_update.get_current_lang())
                                                          };
                        int reslt = 0;
                        switch (types_list.SelectedValue)
                        {
                            case "1":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_characters_titles");
                                break;
                            case "2":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_events_titles");
                                break;
                            case "3":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_topics_titles");
                                break;
                            case "4":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_places_titles");
                                break;
                            case "5":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_artifacts_titles");
                                break;
                            case "6":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_video_titles");
                                break;
                            case "7":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_audio_titles");
                                break;
                            case "8":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_docs_titles");
                                break;
                            case "9":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_articles_titles");
                                break;
                            case "10":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_books_titles");
                                break;
                            case "11":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_images_titles");
                                break;
                            case "12":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_manuscripts_titles");
                                break;
                            case "13":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_theses_titles");
                                break;
                            case "14":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_conference_proceedings_titles");
                                break;
                            case "15":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_website_titles");
                                break;

                            case "16":
                                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_glossary_titles");
                                break;
                        }
                    }
                    else
                        Response.Write("<script language='javascript'>alert('من فضلك أدخل اسم العنصر');</script>");
                }
                //object_name.Text = "";
                fill_grid();
            }
            else if (e.CommandName == "translate")
            {
                Response.Redirect("objects_translate.aspx?obj_type=" + types_list.SelectedValue + "&obj_id=" + id.ToString());
            }
        
    }
    protected void objects_grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        objects_grid.PageIndex = e.NewPageIndex;
        fill_grid();
    }
    protected void objects_grid_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            string obj_id = (string)Convert.ToString(DataBinder.Eval(e.Row.DataItem, "id"));
            has_translated(obj_id);
            if(translate_en.Value != "")
            {
                Label trans_en = (Label)e.Row.FindControl("translated_EN");
                trans_en.Text = "تم";
            }
            if (translate_fr.Value != "")
            {
                Label trans_fr = (Label)e.Row.FindControl("translated_FR");
                trans_fr.Text = "تم";
            }
        }
    }

    public void has_translated(string obj_id)
    {
        translate_en.Value = "";
        translate_fr.Value = "";
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        string english_title = "";
        string french_title = "";
        switch (types_list.SelectedValue)
        {
            case "1":
                SqlParameter[] sqlParams2 = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams3 = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams2, "characters_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams3, "characters_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["name"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["name"].ToString();
                break;
            case "2":
                SqlParameter[] sqlParams4 = new SqlParameter[] {    new SqlParameter("@event_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams5 = new SqlParameter[] {    new SqlParameter("@event_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams4, "events_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams5, "events_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                    break;
            case "3":
                SqlParameter[] sqlParams6 = new SqlParameter[] {    new SqlParameter("@topic_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams7 = new SqlParameter[] {    new SqlParameter("@topic_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams6, "topics_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams7, "topics_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "4":
                SqlParameter[] sqlParams8 = new SqlParameter[] {    new SqlParameter("@place_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams9 = new SqlParameter[] {    new SqlParameter("@place_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams8, "places_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams9, "places_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "5":
                SqlParameter[] sqlParams10 = new SqlParameter[] {    new SqlParameter("@artifact_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams11 = new SqlParameter[] {    new SqlParameter("@artifact_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams10, "artifacts_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams11, "artifacts_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "6":
                SqlParameter[] sqlParams12 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@content_media_type", 6)};
                SqlParameter[] sqlParams13 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@content_media_type", 6),};
                dt2 = DatabaseFunctions.SelectData(sqlParams12, "content_media_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams13, "content_media_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "7":
                SqlParameter[] sqlParams14 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@content_media_type", 7)};
                SqlParameter[] sqlParams15 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@content_media_type", 7),};
                dt2 = DatabaseFunctions.SelectData(sqlParams14, "content_media_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams15, "content_media_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "8":
                SqlParameter[] sqlParams16 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 3)};
                SqlParameter[] sqlParams17 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams16, "docs_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams17, "docs_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "9":
                SqlParameter[] sqlParams18 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 2)};
                SqlParameter[] sqlParams19 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 2)};
                dt2 = DatabaseFunctions.SelectData(sqlParams18, "docs_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams19, "docs_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "10":
                SqlParameter[] sqlParams20 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 1)};
                SqlParameter[] sqlParams21 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 1)};
                dt2 = DatabaseFunctions.SelectData(sqlParams20, "docs_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams21, "docs_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "11":
                SqlParameter[] sqlParams22 = new SqlParameter[] {    new SqlParameter("@image_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams23 = new SqlParameter[] {    new SqlParameter("@image_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams22, "images_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams23, "images_details_select3");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "12":
                SqlParameter[] sqlParams24 = new SqlParameter[] {    new SqlParameter("@manuscript_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams25 = new SqlParameter[] {    new SqlParameter("@manuscript_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams24, "manuscripts_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams25, "manuscripts_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "13":
                SqlParameter[] sqlParams26 = new SqlParameter[] {    new SqlParameter("@these_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams27 = new SqlParameter[] {    new SqlParameter("@these_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams26, "theses_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams27, "theses_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "14":
                SqlParameter[] sqlParams28 = new SqlParameter[] {    new SqlParameter("@conference_proceeding_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams29 = new SqlParameter[] {    new SqlParameter("@conference_proceeding_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams28, "conference_proceedings_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams29, "conference_proceedings_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "15":
                SqlParameter[] sqlParams30 = new SqlParameter[] {    new SqlParameter("@website_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams31 = new SqlParameter[] {    new SqlParameter("@website_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams30, "website_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams31, "website_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;


            case "16":
                SqlParameter[] sqlParams32 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams33 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(obj_id)),
                                                                    new SqlParameter("@lang_id", 3)};
                dt2 = DatabaseFunctions.SelectData(sqlParams32, "glossary_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams33, "glossary_details_select2");
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
        }
        translate_en.Value = english_title;
        translate_fr.Value = french_title;
    }


    protected void proceed_Click(object sender, EventArgs e)
    {
        int z;
        foreach (GridViewRow row in objects_grid.Rows)
        {
            // Access the CheckBox
            CheckBox cbActiveEn = (CheckBox)row.FindControl("ActivateEn");
            HtmlInputHidden sID = (HtmlInputHidden)row.FindControl("user_id");
            if (cbActiveEn != null && cbActiveEn.Checked)
            {
                z = General_Helping.ExcuteQuery("update Users set active=1 where id=" + sID.Value.ToString());
            }
            else
            {
                z = General_Helping.ExcuteQuery("update Users set active=0 where id=" + sID.Value.ToString());
            }

            // Access the CheckBox
            CheckBox cbDel = (CheckBox)row.FindControl("DeleteEvent");
            if (cbDel != null && cbDel.Checked)
            {
                SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ID", sID.Value.ToString()) };
                int rslt = DatabaseFunctions.UpdateData(sqlParams, "User_Delete");
            }

        }
        get_content_types();
    }
     
    
    
    protected void add_btn_Click(object sender, EventArgs e)
    {
       
        DataTable dt = new DataTable();
        if (object_name.Text.Trim() != "")
        {
            SqlParameter[] sqlParams = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", Convert.ToInt16("0")),
                                                            new SqlParameter("@operation", "add"),
                                                            new SqlParameter("@keyfield1", extra_field1.Text),
                                                            new SqlParameter("@keyfield2", extra_field2.Text),
                                                            new SqlParameter("@lang_id", menus_update.get_current_lang())
                                                          };
            SqlParameter[] sqlParams2 = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", Convert.ToInt16("0")),
                                                            new SqlParameter("@operation", "add"),
                                                            new SqlParameter("@keyfield1", extra_field1.Text),
                                                            new SqlParameter("@keyfield2", extra_field2.Text),
                                                            new SqlParameter("@lang_id", menus_update.get_current_lang().ToString())
                                                            };
            int reslt = 0;
            string author_id = "";
            string operation = "";
            if (extra_field1.Text.Trim() != "")
            {
                author_id = extra_field1.Text.Trim();
                operation = "0";
            }
            else if (Convert.ToInt16(char_lst.SelectedValue) > 0)
            {
                author_id = char_lst.SelectedValue;
                operation = "1";
            }
            else if (Convert.ToInt16(auth_lst.SelectedValue) > 0)
            {
                author_id = auth_lst.SelectedValue;
                operation = "2";
            }
            switch (types_list.SelectedValue)
            {
                case "1":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_characters_titles");
                    break;
                case "2":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_events_titles");
                    break;
                case "3":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_topics_titles");
                    break;
                case "4":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_places_titles");
                    break;
                case "5":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_artifacts_titles");
                    break;
                case "6":
                    reslt = DatabaseFunctions.UpdateData(sqlParams2, "insert_video_titles");
                    break;
                case "7":
                    reslt = DatabaseFunctions.UpdateData(sqlParams2, "insert_audio_titles");
                    break;
                case "8":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_docs_titles");
                    break;
                case "9":
                    sqlParams = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", Convert.ToInt16("0")),
                                                            new SqlParameter("@operation", "add"),
                                                            new SqlParameter("@keyfield1", author_id),
                                                            new SqlParameter("@keyfield2", operation),
                                                            new SqlParameter("@lang_id", menus_update.get_current_lang())
                                                          };
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_articles_titles");
                    break;
                case "10":
                    sqlParams = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", Convert.ToInt16("0")),
                                                            new SqlParameter("@operation", "add"),
                                                            new SqlParameter("@keyfield1", author_id),
                                                            new SqlParameter("@keyfield2", operation),
                                                            new SqlParameter("@lang_id", menus_update.get_current_lang())
                                                          };
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_books_titles");
                    break;
                case "11":

                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_images_titles");
                    break;
                case "12":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_manuscripts_titles");
                    break;
                case "13":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_theses_titles");
                    break;
                case "14":
                    reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_conference_proceedings_titles");
                    break;
                case "15":
                    SqlParameter[] sqlParams3 = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", Convert.ToInt16("0")),
                                                            new SqlParameter("@operation", "add"),
                                                            new SqlParameter("@keyfield1", ""),
                                                            new SqlParameter("@keyfield2", ""),
                                                            new SqlParameter("@lang_id", menus_update.get_current_lang())
                                                          };
                    reslt = DatabaseFunctions.UpdateData(sqlParams3, "insert_website_titles");
                    break;



                case "16":
                    SqlParameter[] sqlParams4 = new SqlParameter[] { 
                                                            new SqlParameter("@object_name", object_name.Text.Trim()),
                                                            new SqlParameter("@id", Convert.ToInt16("0")),
                                                            new SqlParameter("@operation", "add"),
                                                            new SqlParameter("@keyfield1", ""),
                                                            new SqlParameter("@keyfield2", ""),
                                                            new SqlParameter("@lang_id", menus_update.get_current_lang())
                                                         };
                    reslt = DatabaseFunctions.UpdateData(sqlParams4, "insert_glossary_titles");
                    break;
            }
        }
        //object_name.Text = "";
        extra_field1.Text = "";
        extra_field2.Text = "";
        fill_grid();
        ShowAlertMessage("تم إضافة اسم العنصر بنجاح");
        
    }
    public static void ShowAlertMessage(string success)
    {

        Page page = HttpContext.Current.Handler as Page;
        if (page != null)
        {
            success = success.Replace("'", "\'");
            ScriptManager.RegisterStartupScript(page, page.GetType(), "success_msg", "alert('" + success + "');", true);
        }
    }
    protected void cancel_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    private string getNormalizedName(string str)
    {
        System.Text.StringBuilder normalizedSTR = new System.Text.StringBuilder(); ;
        char[] normalizedSTRarr = str.ToCharArray();
        foreach (char ch in normalizedSTRarr)
        {
            if (ch == 'أ' || ch == 'إ' || ch == 'ا' || ch == 'أ' || ch == 'آ')
            { normalizedSTR.Append('ا'); }
            else if (ch == 'ه' || ch == 'ة')
            { normalizedSTR.Append('ه'); }
            else if (ch == 'ي' || ch == 'ى' || ch == 'ئ')
            { normalizedSTR.Append('ى'); }
            else if (ch == 'ؤ' || ch == 'و')
            { normalizedSTR.Append('و'); }
            else
            { normalizedSTR.Append(ch); }
        }
        return normalizedSTR.ToString();
    }
    public void fill_grid()
    {

        DataTable dt = new DataTable();
        
       // ArrayList Arr =  Utils.StringUtils.GetPermutations(object_name.Text);
        // string Txt_Query = "";
        //if (Arr.Count == 0)
        //{
        //objects_grid.Columns[2].Visible = objects_grid.Columns[3].Visible = false;
        
            switch (types_list.SelectedValue)
            {
                case "1":
                    SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams1, "get_characters_titles");
                    
                    break;
                case "2":
                    SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams2, "get_events_titles");
                    
                    break;
                case "3":
                    SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams3, "get_topics_titles");
                    
                    break;
                case "4":
                    SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams4, "get_places_titles");
                    
                    break;
                case "5":
                    SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams5, "get_artifacts_titles");
                    
                    break;
                case "6":
                    SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
                   
                    break;
                case "7":
                    SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams7, "get_audio_titles");
                    
                    break;
                case "8":
                    SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams8, "get_docs_titles");
                   
                    break;
                case "9":
                    SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams9, "get_articles_titles");

                    objects_grid.Columns[2].Visible = objects_grid.Columns[3].Visible = true;
                    
                    break;
                case "10":
                    SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams10, "get_books_titles");


                    objects_grid.Columns[2].Visible = objects_grid.Columns[3].Visible = true;
                    break;
                case "11":
                    SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams11, "get_images_titles");
                    
                    break;
                case "12":
                    SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams12, "get_manuscripts_titles");
                    
                    break;
                case "13":
                    SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams13, "get_theses_titles");
                    
                    break;
                case "14":
                    SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
                    
                    break;
                case "15":
                    SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams15, "get_website_titles");
                    
                    break;


                case "16":
                    SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@glossary_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
                    dt = DatabaseFunctions.SelectData(sqlParams16, "get_glossary_titles");
                    
                    break;
            }

            DataTable final_dt = dt.Clone();
            string temp = getNormalizedName(object_name.Text.Trim());

            if (object_Id.Text.Trim() != "")
            {
                DataRow[] dtar = dt.Select("id = " + object_Id.Text);
                foreach (DataRow dr in dtar)
                {
                    final_dt.ImportRow(dr);
                    final_dt.AcceptChanges();
                }
            }    
            else if (temp != "")
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (getNormalizedName(dr["title"].ToString()).Contains(temp))
                    {

                        final_dt.ImportRow(dr);
                        final_dt.AcceptChanges();
                    }
                }
            }
            else {
                final_dt = dt.Copy(); 
            }
        
       
        dt.DefaultView.Sort = "id DESC";
        objects_grid.DataSource = final_dt;
        objects_grid.DataBind();
    }
    protected void agree_btn_Click(object sender, EventArgs e)
    {
        fill_grid();
    }
    protected void types_list_SelectedIndexChanged(object sender, EventArgs e)
    {
        extra_field1_tr.Visible = false;
        extra_field2_tr.Visible = false;
        moalef1_tr.Visible = false;
        moalef2_tr.Visible = false;
        int obj_id = Convert.ToInt16(types_list.SelectedValue);
        if (obj_id >= 5 && obj_id <= 14)
        {
            extra_field1_tr.Visible = true;
            switch (types_list.SelectedValue)
            {
                case "5":
                    key_field1.Text = "جهة الحفظ";
                    extra_field2_tr.Visible = true;
                    key_field2.Text = "رقمه في جهة الحفظ";
                    break;
                case "6":
                    key_field1.Text = "تاريخ الاذاعة أو التسجيل";
                    break;
                case "7":
                    key_field1.Text = "تاريخ الاذاعة أو التسجيل";
                    break;
                case "8":
                    key_field1.Text = "رقم الحفظ";
                    break;
                case "9":
                    key_field1.Text = "المؤلف";
                    extra_field2_tr.Visible = true;
                    key_field2.Text = "تاريخ النشر";
                    moalef1_tr.Visible = true;
                    moalef2_tr.Visible = true;
                    break;
                case "10":
                    key_field1.Text = "المؤلف";
                    moalef1_tr.Visible = true;
                    moalef2_tr.Visible = true;
                    break;
                case "11":
                    key_field1.Text = "رقم المسلسل";
                    break;
                case "12":
                    key_field1.Text = "المؤلف";
                    break;
                case "13":
                    key_field1.Text = "بيان المسئولية (المؤلف)";
                    break;
                case "14":
                    key_field1.Text = "بيان المسئولية (المؤلف)";
                    break;
            }
        }
        fill_grid();
    }
}
