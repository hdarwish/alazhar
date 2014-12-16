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

public partial class administration_objects_translate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            get_content_types();
            fill_data();
        }
    }
    public void get_content_types()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { };
        DataTable dt = DatabaseFunctions.SelectData(sqlParams, "get_content_types");
        types_list.DataSource = dt;
        types_list.DataBind();
        types_list.SelectedValue = Request["obj_type"].ToString();
    }
    protected void add_btn_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        SqlParameter[] sqlParams = new SqlParameter[] { 
                                                        new SqlParameter("@object_name", ""),
                                                        new SqlParameter("@id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                        new SqlParameter("@operation", "translate"),
                                                        new SqlParameter("@keyfield1", english_name.Text),
                                                        new SqlParameter("@keyfield2", french_name.Text),
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
        lbl_result.Visible = true;
    }
    protected void cancel_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("objects_titles.aspx");
    }
    public void fill_data()
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        string english_title = "";
        string french_title = "";
        string arabic_title = "";
        switch (types_list.SelectedValue)
        {
            case "1":
                SqlParameter[] sqlParams = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams2 = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams3 = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParams, "characters_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams2, "characters_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams3, "characters_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["name"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["name"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["name"].ToString();
                break;
            case "2":
                SqlParameter[] sqlParamsn = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams4 = new SqlParameter[] {    new SqlParameter("@event_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams5 = new SqlParameter[] {    new SqlParameter("@event_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsn, "events_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams4, "events_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams5, "events_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "3":
                SqlParameter[] sqlParamsa = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams6 = new SqlParameter[] {    new SqlParameter("@topic_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams7 = new SqlParameter[] {    new SqlParameter("@topic_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsa, "topics_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams6, "topics_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams7, "topics_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "4":
                SqlParameter[] sqlParamsb = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams8 = new SqlParameter[] {    new SqlParameter("@place_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams9 = new SqlParameter[] {    new SqlParameter("@place_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsb, "places_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams8, "places_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams9, "places_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "5":
                SqlParameter[] sqlParamsc = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams10 = new SqlParameter[] {    new SqlParameter("@artifact_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams11 = new SqlParameter[] {    new SqlParameter("@artifact_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsc, "artifacts_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams10, "artifacts_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams11, "artifacts_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "6":
                SqlParameter[] sqlParamsd = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1),new SqlParameter("@content_media_type", 6)};
                SqlParameter[] sqlParams12 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@content_media_type", 6)};
                SqlParameter[] sqlParams13 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@content_media_type", 6),};
                dt = DatabaseFunctions.SelectData(sqlParamsd, "content_media_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams12, "content_media_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams13, "content_media_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "7":
                SqlParameter[] sqlParamse = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1),new SqlParameter("@content_media_type", 7)};
                SqlParameter[] sqlParams14 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@content_media_type", 7)};
                SqlParameter[] sqlParams15 = new SqlParameter[] {    new SqlParameter("@video_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@content_media_type", 7),};
                dt = DatabaseFunctions.SelectData(sqlParamse, "content_media_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams14, "content_media_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams15, "content_media_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "8":
                SqlParameter[] sqlParamsf = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1),new SqlParameter("@docs_type", 3)};
                SqlParameter[] sqlParams16 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 3)};
                SqlParameter[] sqlParams17 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsf, "docs_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams16, "docs_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams17, "docs_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "9":
                SqlParameter[] sqlParamsg = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1),new SqlParameter("@docs_type", 2)};
                SqlParameter[] sqlParams18 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 2)};
                SqlParameter[] sqlParams19 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 2)};
                dt = DatabaseFunctions.SelectData(sqlParamsg, "docs_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams18, "docs_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams19, "docs_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "10":
                SqlParameter[] sqlParamsh = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1),new SqlParameter("@docs_type", 1)};
                SqlParameter[] sqlParams20 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2),new SqlParameter("@docs_type", 1)};
                SqlParameter[] sqlParams21 = new SqlParameter[] {    new SqlParameter("@doc_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3),new SqlParameter("@docs_type", 1)};
                dt = DatabaseFunctions.SelectData(sqlParamsh, "docs_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams20, "docs_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams21, "docs_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "11":
                SqlParameter[] sqlParamsi = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams22 = new SqlParameter[] {    new SqlParameter("@image_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams23 = new SqlParameter[] {    new SqlParameter("@image_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsi, "images_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams22, "images_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams23, "images_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "12":
                SqlParameter[] sqlParamsj = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams24 = new SqlParameter[] {    new SqlParameter("@manuscript_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams25 = new SqlParameter[] {    new SqlParameter("@manuscript_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsj, "manuscripts_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams24, "manuscripts_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams25, "manuscripts_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "13":
                SqlParameter[] sqlParamsk = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams26 = new SqlParameter[] {    new SqlParameter("@these_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams27 = new SqlParameter[] {    new SqlParameter("@these_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsk, "theses_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams26, "theses_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams27, "theses_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "14":
                SqlParameter[] sqlParamsl = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams28 = new SqlParameter[] {    new SqlParameter("@conference_proceeding_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams29 = new SqlParameter[] {    new SqlParameter("@conference_proceeding_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsl, "conference_proceedings_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams28, "conference_proceedings_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams29, "conference_proceedings_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "15":
                SqlParameter[] sqlParamsm = new SqlParameter[] {    new SqlParameter("@char_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams30 = new SqlParameter[] {    new SqlParameter("@website_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams31 = new SqlParameter[] {    new SqlParameter("@website_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParamsm, "website_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams30, "website_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams31, "website_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
            case "16":
                SqlParameter[] sqlParams32 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 1)};
                SqlParameter[] sqlParams33 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 2)};
                SqlParameter[] sqlParams34 = new SqlParameter[] {    new SqlParameter("@glossary_id", Convert.ToInt16(Request["obj_id"].ToString())),
                                                                    new SqlParameter("@lang_id", 3)};
                dt = DatabaseFunctions.SelectData(sqlParams32, "glossary_details_select2");
                dt2 = DatabaseFunctions.SelectData(sqlParams33, "glossary_details_select2");
                dt3 = DatabaseFunctions.SelectData(sqlParams34, "glossary_details_select2");
                if (dt.Rows.Count > 0)
                    arabic_title = dt.Rows[0]["title"].ToString();
                if (dt2.Rows.Count > 0)
                    english_title = dt2.Rows[0]["title"].ToString();
                if (dt3.Rows.Count > 0)
                    french_title = dt3.Rows[0]["title"].ToString();
                break;
        }
        arabic_name.Text = arabic_title;
        english_name.Text = english_title;
        french_name.Text = french_title;
    }

}
