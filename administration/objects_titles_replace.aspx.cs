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

public partial class administration_objects_titles_replace : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            get_content_types();
            
        }
    }
    public void get_content_types()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "get_content_types");
        types_list.DataSource = dt;
        types_list.DataBind();
        ListItem litem = new ListItem("-- اختر الإستمارة --", "0");
        litem.Selected = true;
        types_list.Items.Insert(0, litem);
    }
    //protected void objects_grid_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    int id = Convert.ToInt32(e.CommandArgument);
    //    if (e.CommandName == "replace")
    //    {
    //        DataTable dt = new DataTable();

    //        if (id > 0)
    //        {
    //            if (object_name.Text.Trim() != "")
    //            {
    //                SqlParameter[] sqlParams = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", id),
    //                                                        new SqlParameter("@operation", "edit"),
    //                                                        new SqlParameter("@keyfield1", ""),
    //                                                        new SqlParameter("@keyfield2", ""),
    //                                                         new SqlParameter("@lang_id", menus_update.get_current_lang())
    //                                                      };
    //                int reslt = 0;
    //                switch (types_list.SelectedValue)
    //                {
    //                    case "1":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_characters_titles");
    //                        break;
    //                    case "2":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_events_titles");
    //                        break;
    //                    case "3":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_topics_titles");
    //                        break;
    //                    case "4":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_places_titles");
    //                        break;
    //                    case "5":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_artifacts_titles");
    //                        break;
    //                    case "6":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_video_titles");
    //                        break;
    //                    case "7":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_audio_titles");
    //                        break;
    //                    case "8":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_docs_titles");
    //                        break;
    //                    case "9":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_articles_titles");
    //                        break;
    //                    case "10":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_books_titles");
    //                        break;
    //                    case "11":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_images_titles");
    //                        break;
    //                    case "12":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_manuscripts_titles");
    //                        break;
    //                    case "13":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_theses_titles");
    //                        break;
    //                    case "14":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_conference_proceedings_titles");
    //                        break;
    //                    case "15":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_website_titles");
    //                        break;

    //                    case "16":
    //                        reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_glossary_titles");
    //                        break;
    //                }
    //            }
    //            else
    //                Response.Write("<script language='javascript'>alert('من فضلك أدخل اسم العنصر');</script>");
    //        }
    //        //object_name.Text = "";
    //        fill_grid();
    //    }
    //    else if (e.CommandName == "translate")
    //    {
    //        Response.Redirect("objects_translate.aspx?obj_type=" + types_list.SelectedValue + "&obj_id=" + id.ToString());
    //    }
    //}
    //protected void objects_grid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    objects_grid.PageIndex = e.NewPageIndex;
    //    fill_grid();
    //}
    //protected void objects_grid_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        string obj_id = (string)Convert.ToString(DataBinder.Eval(e.Row.DataItem, "id"));
    //        has_translated(obj_id);
    //        if(translate_en.Value != "")
    //        {
    //            Label trans_en = (Label)e.Row.FindControl("translated_EN");
    //            trans_en.Text = "تم";
    //        }
    //        if (translate_fr.Value != "")
    //        {
    //            Label trans_fr = (Label)e.Row.FindControl("translated_FR");
    //            trans_fr.Text = "تم";
    //        }
    //    }
    //}
    //public void has_translated(string obj_id)
    //{
    //    translate_en.Value = "";
    //    translate_fr.Value = "";
    //    DataTable dt2 = new DataTable();
    //    DataTable dt3 = new DataTable();
    //    string english_title = "";
    //    string french_title = "";
    //    switch (types_list.SelectedValue)
    //    {
    //        case "1":
    //            SqlParameter[] sqlParams2 = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams3 = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams2, "characters_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams3, "characters_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["name"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["name"].ToString();
    //            break;
    //        case "2":
    //            SqlParameter[] sqlParams4 = new SqlParameter[] {    new SqlParameter("@event_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams5 = new SqlParameter[] {    new SqlParameter("@event_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams4, "events_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams5, "events_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //                break;
    //        case "3":
    //            SqlParameter[] sqlParams6 = new SqlParameter[] {    new SqlParameter("@topic_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams7 = new SqlParameter[] {    new SqlParameter("@topic_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams6, "topics_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams7, "topics_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "4":
    //            SqlParameter[] sqlParams8 = new SqlParameter[] {    new SqlParameter("@place_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams9 = new SqlParameter[] {    new SqlParameter("@place_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams8, "places_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams9, "places_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "5":
    //            SqlParameter[] sqlParams10 = new SqlParameter[] {    new SqlParameter("@artifact_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams11 = new SqlParameter[] {    new SqlParameter("@artifact_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams10, "artifacts_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams11, "artifacts_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "6":
    //            SqlParameter[] sqlParams12 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2),new SqlParameter("@content_media_type", 6)};
    //            SqlParameter[] sqlParams13 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3),new SqlParameter("@content_media_type", 6),};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams12, "content_media_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams13, "content_media_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "7":
    //            SqlParameter[] sqlParams14 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2),new SqlParameter("@content_media_type", 7)};
    //            SqlParameter[] sqlParams15 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3),new SqlParameter("@content_media_type", 7),};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams14, "content_media_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams15, "content_media_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "8":
    //            SqlParameter[] sqlParams16 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 3)};
    //            SqlParameter[] sqlParams17 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams16, "docs_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams17, "docs_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "9":
    //            SqlParameter[] sqlParams18 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 2)};
    //            SqlParameter[] sqlParams19 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 2)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams18, "docs_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams19, "docs_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "10":
    //            SqlParameter[] sqlParams20 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 1)};
    //            SqlParameter[] sqlParams21 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 1)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams20, "docs_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams21, "docs_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "11":
    //            SqlParameter[] sqlParams22 = new SqlParameter[] {    new SqlParameter("@image_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams23 = new SqlParameter[] {    new SqlParameter("@image_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams22, "images_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams23, "images_details_select3");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "12":
    //            SqlParameter[] sqlParams24 = new SqlParameter[] {    new SqlParameter("@manuscript_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams25 = new SqlParameter[] {    new SqlParameter("@manuscript_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams24, "manuscripts_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams25, "manuscripts_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "13":
    //            SqlParameter[] sqlParams26 = new SqlParameter[] {    new SqlParameter("@these_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams27 = new SqlParameter[] {    new SqlParameter("@these_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams26, "theses_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams27, "theses_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "14":
    //            SqlParameter[] sqlParams28 = new SqlParameter[] {    new SqlParameter("@conference_proceeding_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams29 = new SqlParameter[] {    new SqlParameter("@conference_proceeding_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams28, "conference_proceedings_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams29, "conference_proceedings_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //        case "15":
    //            SqlParameter[] sqlParams30 = new SqlParameter[] {    new SqlParameter("@website_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams31 = new SqlParameter[] {    new SqlParameter("@website_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams30, "website_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams31, "website_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;


    //        case "16":
    //            SqlParameter[] sqlParams32 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 2)};
    //            SqlParameter[] sqlParams33 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(obj_id)),
    //                                                                new SqlParameter("@lang_id", 3)};
    //            dt2 = DatabaseFunctions.SelectData(sqlParams32, "glossary_details_select2");
    //            dt3 = DatabaseFunctions.SelectData(sqlParams33, "glossary_details_select2");
    //            if (dt2.Rows.Count > 0)
    //                english_title = dt2.Rows[0]["title"].ToString();
    //            if (dt3.Rows.Count > 0)
    //                french_title = dt3.Rows[0]["title"].ToString();
    //            break;
    //    }
    //    translate_en.Value = english_title;
    //    translate_fr.Value = french_title;
    //}
    //protected void proceed_Click(object sender, EventArgs e)
    //{
    //    int z;
    //    foreach (GridViewRow row in objects_grid.Rows)
    //    {
    //        // Access the CheckBox
    //        CheckBox cbActiveEn = (CheckBox)row.FindControl("ActivateEn");
    //        HtmlInputHidden sID = (HtmlInputHidden)row.FindControl("user_id");
    //        if (cbActiveEn != null && cbActiveEn.Checked)
    //        {
    //            z = General_Helping.ExcuteQuery("update Users set active=1 where id=" + sID.Value.ToString());
    //        }
    //        else
    //        {
    //            z = General_Helping.ExcuteQuery("update Users set active=0 where id=" + sID.Value.ToString());
    //        }

    //        // Access the CheckBox
    //        CheckBox cbDel = (CheckBox)row.FindControl("DeleteEvent");
    //        if (cbDel != null && cbDel.Checked)
    //        {
    //            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ID", sID.Value.ToString()) };
    //            int rslt = DatabaseFunctions.UpdateData(sqlParams, "User_Delete");
    //        }

    //    }
    //    get_content_types();
    //}
    //protected void add_btn_Click(object sender, EventArgs e)
    //{
    //    DataTable dt = new DataTable();
    //    if (object_name.Text.Trim() != "")
    //    {
    //        SqlParameter[] sqlParams = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", Convert.ToInt16("0")),
    //                                                        new SqlParameter("@operation", "add"),
    //                                                        new SqlParameter("@keyfield1", extra_field1.Text),
    //                                                        new SqlParameter("@keyfield2", extra_field2.Text),
    //                                                        new SqlParameter("@lang_id", menus_update.get_current_lang())
    //                                                      };
    //        SqlParameter[] sqlParams2 = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", Convert.ToInt16("0")),
    //                                                        new SqlParameter("@operation", "add"),
    //                                                        new SqlParameter("@keyfield1", extra_field1.Text),
    //                                                        new SqlParameter("@keyfield2", extra_field2.Text),
    //                                                        new SqlParameter("@lang_id", menus_update.get_current_lang().ToString())
    //                                                        };
    //        int reslt = 0;
    //        string author_id = "";
    //        string operation = "";
    //        if (extra_field1.Text.Trim() != "")
    //        {
    //            author_id = extra_field1.Text.Trim();
    //            operation = "0";
    //        }
    //        else if (Convert.ToInt16(char_lst.SelectedValue) > 0)
    //        {
    //            author_id = char_lst.SelectedValue;
    //            operation = "1";
    //        }
    //        else if (Convert.ToInt16(auth_lst.SelectedValue) > 0)
    //        {
    //            author_id = auth_lst.SelectedValue;
    //            operation = "2";
    //        }
    //        switch (types_list.SelectedValue)
    //        {
    //            case "1":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_characters_titles");
    //                break;
    //            case "2":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_events_titles");
    //                break;
    //            case "3":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_topics_titles");
    //                break;
    //            case "4":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_places_titles");
    //                break;
    //            case "5":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_artifacts_titles");
    //                break;
    //            case "6":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams2, "insert_video_titles");
    //                break;
    //            case "7":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams2, "insert_audio_titles");
    //                break;
    //            case "8":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_docs_titles");
    //                break;
    //            case "9":
    //                sqlParams = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", Convert.ToInt16("0")),
    //                                                        new SqlParameter("@operation", "add"),
    //                                                        new SqlParameter("@keyfield1", author_id),
    //                                                        new SqlParameter("@keyfield2", operation),
    //                                                        new SqlParameter("@lang_id", menus_update.get_current_lang())
    //                                                      };
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_articles_titles");
    //                break;
    //            case "10":
    //                sqlParams = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", Convert.ToInt16("0")),
    //                                                        new SqlParameter("@operation", "add"),
    //                                                        new SqlParameter("@keyfield1", author_id),
    //                                                        new SqlParameter("@keyfield2", operation),
    //                                                        new SqlParameter("@lang_id", menus_update.get_current_lang())
    //                                                      };
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_books_titles");
    //                break;
    //            case "11":

    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_images_titles");
    //                break;
    //            case "12":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_manuscripts_titles");
    //                break;
    //            case "13":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_theses_titles");
    //                break;
    //            case "14":
    //                reslt = DatabaseFunctions.UpdateData(sqlParams, "insert_conference_proceedings_titles");
    //                break;
    //            case "15":
    //                SqlParameter[] sqlParams3 = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", Convert.ToInt16("0")),
    //                                                        new SqlParameter("@operation", "add"),
    //                                                        new SqlParameter("@keyfield1", ""),
    //                                                        new SqlParameter("@keyfield2", ""),
    //                                                        new SqlParameter("@lang_id", menus_update.get_current_lang())
    //                                                      };
    //                reslt = DatabaseFunctions.UpdateData(sqlParams3, "insert_website_titles");
    //                break;



    //            case "16":
    //                SqlParameter[] sqlParams4 = new SqlParameter[] { 
    //                                                        new SqlParameter("@object_name", object_name.Text),
    //                                                        new SqlParameter("@id", Convert.ToInt16("0")),
    //                                                        new SqlParameter("@operation", "add"),
    //                                                        new SqlParameter("@keyfield1", ""),
    //                                                        new SqlParameter("@keyfield2", ""),
    //                                                        new SqlParameter("@lang_id", menus_update.get_current_lang())
    //                                                     };
    //                reslt = DatabaseFunctions.UpdateData(sqlParams4, "insert_glossary_titles");
    //                break;
    //        }
    //    }
    //    //object_name.Text = "";
    //    extra_field1.Text = "";
    //    extra_field2.Text = "";
    //    fill_grid();
    //    ShowAlertMessage("تم إضافة اسم العنصر بنجاح");
    //}
    //public static void ShowAlertMessage(string success)
    //{

    //    Page page = HttpContext.Current.Handler as Page;
    //    if (page != null)
    //    {
    //        success = success.Replace("'", "\'");
    //        ScriptManager.RegisterStartupScript(page, page.GetType(), "success_msg", "alert('" + success + "');", true);
    //    }
    //}
    //
    //public void fill_grid()
    //{
    //    DataTable dt = new DataTable();
    //    switch (types_list.SelectedValue)
    //    {
    //        case "1":
    //            SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams1, "get_characters_titles");
    //            break;
    //        case "2":
    //            SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams2, "get_events_titles");
    //            break;
    //        case "3":
    //            SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams3, "get_topics_titles");
    //            break;
    //        case "4":
    //            SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams4, "get_places_titles");
    //            break;
    //        case "5":
    //            SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams5, "get_artifacts_titles");
    //            break;
    //        case "6":
    //            SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams6, "get_video_titles");
    //            break;
    //        case "7":
    //            SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams7, "get_audio_titles");
    //            break;
    //        case "8":
    //            SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams8, "get_docs_titles");
    //            break;
    //        case "9":
    //            SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams9, "get_articles_titles");
    //            break;
    //        case "10":
    //            SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams10, "get_books_titles");
    //            break;
    //        case "11":
    //            SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()) ,new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams11, "get_images_titles");
    //            break;
    //        case "12":
    //            SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams12, "get_manuscripts_titles");
    //            break;
    //        case "13":
    //            SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", object_name.Text), new SqlParameter("@selview", "2") , 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams13, "get_theses_titles");
    //            break;
    //        case "14":
    //            SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams14, "get_conference_proceedings_titles");
    //            break;
    //        case "15":
    //            SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams15, "get_website_titles");
    //            break;


    //        case "16":
    //            SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@get_glossary_titles", object_name.Text), new SqlParameter("@selview", "2"), 
    //                                                            new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", menus_update.get_current_lang())};
    //            dt = DatabaseFunctions.SelectData(sqlParams16, "get_glossary_titles");
    //            break;
    //    }
    //    dt.DefaultView.Sort = "id DESC";
    //    objects_grid.DataSource = dt;
    //    objects_grid.DataBind();
    //}
    //protected void agree_btn_Click(object sender, EventArgs e)
    //{
    //    fill_grid();
    //}
    protected void types_list_SelectedIndexChanged(object sender, EventArgs e)
    {
        get_over_it();
        
    }
   protected void get_over_it()
    {
        switch (types_list.SelectedValue)
        {
            case "1":
                SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@char_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_characters_titles";
                Smrt_Srch_object_replace_name.stored = "get_characters_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams1;
                Smrt_Srch_object_name.stored_parameters = sqlParams1;
                
                break;
            case "2":
                SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@event_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_events_titles";
                Smrt_Srch_object_replace_name.stored = "get_events_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams2;
                Smrt_Srch_object_name.stored_parameters = sqlParams2; 
                break;
            case "3":
                SqlParameter[] sqlParams3 = new SqlParameter[] { new SqlParameter("@topic_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_topics_titles";
                Smrt_Srch_object_replace_name.stored = "get_topics_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams3;
                Smrt_Srch_object_name.stored_parameters = sqlParams3;
                break;
            case "4":
                SqlParameter[] sqlParams4 = new SqlParameter[] { new SqlParameter("@place_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_places_titles";
                Smrt_Srch_object_replace_name.stored = "get_places_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams4;
                Smrt_Srch_object_name.stored_parameters = sqlParams4;
                break;
            case "5":
                SqlParameter[] sqlParams5 = new SqlParameter[] { new SqlParameter("@artifact_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_artifacts_titles";
                Smrt_Srch_object_replace_name.stored = "get_artifacts_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams5;
                Smrt_Srch_object_name.stored_parameters = sqlParams5;
                break;
            case "6":
                SqlParameter[] sqlParams6 = new SqlParameter[] { new SqlParameter("@video_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_video_titles";
                Smrt_Srch_object_replace_name.stored = "get_video_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams6;
                Smrt_Srch_object_name.stored_parameters = sqlParams6;
                break;
            case "7":
                SqlParameter[] sqlParams7 = new SqlParameter[] { new SqlParameter("@audio_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_audio_titles";
                Smrt_Srch_object_replace_name.stored = "get_audio_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams7;
                Smrt_Srch_object_name.stored_parameters = sqlParams7;
                break;
            case "8":
                SqlParameter[] sqlParams8 = new SqlParameter[] { new SqlParameter("@docs_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_docs_titles";
                Smrt_Srch_object_replace_name.stored = "get_docs_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams8;
                Smrt_Srch_object_name.stored_parameters = sqlParams8;
                break;
            case "9":
                SqlParameter[] sqlParams9 = new SqlParameter[] { new SqlParameter("@articles_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_articles_titles";
                Smrt_Srch_object_replace_name.stored = "get_articles_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams9;
                Smrt_Srch_object_name.stored_parameters = sqlParams9;
                break;
            case "10":
                SqlParameter[] sqlParams10 = new SqlParameter[] { new SqlParameter("@books_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_books_titles";
                Smrt_Srch_object_replace_name.stored = "get_books_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams10;
                Smrt_Srch_object_name.stored_parameters = sqlParams10;
                break;
            case "11":
                SqlParameter[] sqlParams11 = new SqlParameter[] { new SqlParameter("@image_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()) ,new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_images_titles";
                Smrt_Srch_object_replace_name.stored = "get_images_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams11;
                Smrt_Srch_object_name.stored_parameters = sqlParams11;
                break;
            case "12":
                SqlParameter[] sqlParams12 = new SqlParameter[] { new SqlParameter("@manuscript_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_manuscripts_titles";
                Smrt_Srch_object_replace_name.stored = "get_manuscripts_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams12;
                Smrt_Srch_object_name.stored_parameters = sqlParams12;
                break;
            case "13":
                SqlParameter[] sqlParams13 = new SqlParameter[] { new SqlParameter("@these_name", ""), new SqlParameter("@selview", "2") , 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_theses_titles";
                Smrt_Srch_object_replace_name.stored = "get_theses_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams13;
                Smrt_Srch_object_name.stored_parameters = sqlParams13;
                break;
            case "14":
                SqlParameter[] sqlParams14 = new SqlParameter[] { new SqlParameter("@conference_proceeding_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_conference_proceedings_titles";
                Smrt_Srch_object_replace_name.stored = "get_conference_proceedings_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams14;
                Smrt_Srch_object_name.stored_parameters = sqlParams14;
                break;
            case "15":
                SqlParameter[] sqlParams15 = new SqlParameter[] { new SqlParameter("@website_name", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_website_titles";
                Smrt_Srch_object_replace_name.stored = "get_website_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams15;
                Smrt_Srch_object_name.stored_parameters = sqlParams15;
                break;


            case "16":
                SqlParameter[] sqlParams16 = new SqlParameter[] { new SqlParameter("@get_glossary_titles", ""), new SqlParameter("@selview", "2"), 
                                                                new SqlParameter("@user_id", Session["user_id"].ToString()),new SqlParameter("@lang_id", 1)};
                Smrt_Srch_object_name.stored = "get_glossary_titles";
                Smrt_Srch_object_replace_name.stored = "get_glossary_titles";
                Smrt_Srch_object_replace_name.stored_parameters = sqlParams16;
                Smrt_Srch_object_name.stored_parameters = sqlParams16;
                break;
        }
        Smrt_Srch_object_replace_name.Value_Field = "id";
        Smrt_Srch_object_replace_name.Text_Field = "title";
        Smrt_Srch_object_name.Value_Field = "id";
        Smrt_Srch_object_name.Text_Field = "title";
        Smrt_Srch_object_name.DataBind();
        Smrt_Srch_object_replace_name.DataBind();
        Smrt_Srch_object_name.Clear_Selected();
        Smrt_Srch_object_replace_name.Clear_Selected();
   }
    protected DataTable fillDataTable(string id)
    {
        DataTable dt = new DataTable();
        
        return dt;
    }
    protected void cancel_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected override void OnInit(EventArgs e)
    {

        this.Smrt_Srch_object_replace_name.Value_Handler += new Smart_Search.Delegate_Selected_Value(MOnMember_Data);

    }
    private void MOnMember_Data(string Value)
    {

        if (Smrt_Srch_object_name.SelectedValue == Smrt_Srch_object_replace_name.SelectedValue && Smrt_Srch_object_name.SelectedValue!="")
        {
            ShowAlertMessage("المستبدل يجب ان يكون مختلف عن العنصر الرئيسى");
            Smrt_Srch_object_replace_name.SelectedValue = "0";
        }
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
    protected void replace_btn_Click(object sender, EventArgs e)
    {
        if (types_list.SelectedIndex == 0)
        {
            ShowAlertMessage("من فضلك أدخل نوع الإستمارة");
            return;
        }
        if (Smrt_Srch_object_name.SelectedValue != "" && Smrt_Srch_object_replace_name.SelectedValue != "")
        {
            SqlParameter[] sqlParamse2 = new SqlParameter[] { 
                        new SqlParameter("@content_type", types_list.SelectedIndex),
                        new SqlParameter ("@content_id",CDataConverter.ConvertToInt(Smrt_Srch_object_name.SelectedValue)),
                        new SqlParameter ("@content_id_replaced",CDataConverter.ConvertToInt(Smrt_Srch_object_replace_name.SelectedValue))  };
            DatabaseFunctions.UpdateData(sqlParamse2, "replace_titles");
            ShowAlertMessage("تم الإستبدال بنجاح");
            log(41);
            get_over_it();
        }
        else
        {
            ShowAlertMessage("من فضلك أدخل اسم العنصر الرئيسى والمستبدل");
            return;
        }
    }
    public void log(int operation_id)
    {
        int current_content_id = CDataConverter.ConvertToInt(Smrt_Srch_object_name.SelectedValue);
        int current_content_type = types_list.SelectedIndex;
        int current_content_replace_id = CDataConverter.ConvertToInt(Smrt_Srch_object_replace_name.SelectedValue);
        contents_log_DT clog = new contents_log_DT();
        clog.id = 0;
        clog.content_type = current_content_type;
        clog.content_id = current_content_id;
        clog.operation_id = operation_id;
        clog.user_id = Convert.ToInt16(Session["user_id"].ToString());
        clog.note_date = DateTime.Now.ToShortDateString();
        clog.lang_id = current_content_replace_id;
        int rslut = contents_log_DB.Save(clog);
    }
    //function check_value()
    //{
    //    var ctrID = document.getElementById("<%=Smrt_Srch_object_name.ClientID %>").value;
    //    var ctrID2 = document.getElementById("<%=Smrt_Srch_object_replace_name.ClientID %>").value;

    //    if (ctrID != '' && ctrID2 != '') {
    //        if (confirm('سوف يتم الإستبدال بالعنصر الرئيسى ,موافق؟'))
    //            return true;
    //        else
    //            return false;
           
    //    }
    //    else
    //    {
    //        alert('من فضلك أدخل اسم العنصر الرئيسى والمستبدل');
    //        return false;
    //    }
    //}

}
