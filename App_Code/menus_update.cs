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
using System.IO;
using System.Data.SqlClient;

/// <summary>
/// Summary description for menus_update
/// </summary>
public class menus_update
{
	public menus_update()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    /// <summary>
    /// This function used to get No. images will be wrote in left menu item (الصور)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related images
    /// </param>
    /// <returns>
    /// No. images
    /// </returns>
    public static string get_images_count(string page_name)
    {
        string no_images = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable images_count_DT = new DataTable();
        images_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_images_count");
        if (images_count_DT.Rows.Count > 0)
        {
            if (images_count_DT.Rows.Count == 1)
                no_images = images_count_DT.Rows[0][0].ToString();
            else if (images_count_DT.Rows.Count > 1)
                no_images = images_count_DT.Rows.Count.ToString();
        }
      

        if (no_images == "" || no_images == "0")
            no_images = "";
        else
            no_images = "(" + no_images + ")";
        return no_images;
    }

    public static int get_current_lang()
    {
        int lang_id = 1;
        if (HttpContext.Current.Session["Lang"] != null && HttpContext.Current.Session["Lang"].ToString() != "")
        {
            if (HttpContext.Current.Session["Lang"].ToString() == "ar" || HttpContext.Current.Session["Lang"].ToString()== "1") 
                lang_id = 1;
            if (HttpContext.Current.Session["Lang"].ToString() == "en" || HttpContext.Current.Session["Lang"].ToString() == "2") 
                lang_id = 2;
            if (HttpContext.Current.Session["Lang"].ToString() == "fr" || HttpContext.Current.Session["Lang"].ToString() == "3") 
                lang_id = 3;
        }
        return lang_id;
    }
    /// <summary>
    /// This function used to get No. docs will be wrote in left menu item 
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related docs
    /// </param>
    /// <returns>
    /// No. docs
    /// </returns>
    /// 
    public static string get_char_count(string page_name)
    {
        string no_chars = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable chars_count_DT = new DataTable();
        chars_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_characters_count");
        if (chars_count_DT.Rows.Count > 0)
        {
            if (chars_count_DT.Rows.Count == 1)
                no_chars = chars_count_DT.Rows[0][0].ToString();
            else if (chars_count_DT.Rows.Count > 1)
                no_chars = chars_count_DT.Rows.Count.ToString();
        }
        if (no_chars == "" || no_chars == "0")
            no_chars = "";
        else
            no_chars = "(" + no_chars + ")";
        return no_chars;
    }

    public static string get_events_count(string page_name)
    {
        string no_event = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable event_count_DT = new DataTable();
        event_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_events_count");
        if (event_count_DT.Rows.Count > 0)
        {
            if (event_count_DT.Rows.Count == 1)
                no_event = event_count_DT.Rows[0][0].ToString();
            else if (event_count_DT.Rows.Count > 1)
                no_event = event_count_DT.Rows.Count.ToString();
        }
        if (no_event == "" || no_event == "0")
            no_event = "";
        else
            no_event = "(" + no_event + ")";
        return no_event;
    }
    public static string get_topics_count(string page_name)
    {
        string no_topic = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable topic_count_DT = new DataTable();
        topic_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_topics_count");
        if (topic_count_DT.Rows.Count > 0)
        {
            if (topic_count_DT.Rows.Count == 1)
                no_topic = topic_count_DT.Rows[0][0].ToString();
            else if (topic_count_DT.Rows.Count > 1)
                no_topic = topic_count_DT.Rows.Count.ToString();
        }
        if (no_topic == "" || no_topic == "0")
            no_topic = "";
        else
            no_topic = "(" + no_topic + ")";
        return no_topic;
    }
     public static string get_places_count(string page_name)
    {
        string no_places = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable places_count_DT = new DataTable();
        places_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_places_count");
        if (places_count_DT.Rows.Count > 0)
        {
            if (places_count_DT.Rows.Count == 1)
                no_places = places_count_DT.Rows[0][0].ToString();
            else if (places_count_DT.Rows.Count > 1)
                no_places = places_count_DT.Rows.Count.ToString();
        }
        if (no_places == "" || no_places == "0")
            no_places = "";
        else
            no_places = "(" + no_places + ")";
        return no_places;
    }
    
    public static string get_docs_count(string page_name)
    {
        string no_docs = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable docs_count_DT = new DataTable();
        docs_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_docs_count");
        if (docs_count_DT.Rows.Count > 0)
        {
            if (docs_count_DT.Rows.Count == 1)
                no_docs = docs_count_DT.Rows[0][0].ToString();
            else if (docs_count_DT.Rows.Count > 1)
                no_docs = docs_count_DT.Rows.Count.ToString();
        }
        if (no_docs == "" || no_docs == "0")
            no_docs = "";
        else
            no_docs = "(" + no_docs + ")";
        return no_docs;
    }

    /// <summary>
    /// This function used to get No. books will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related books
    /// </param>
    /// <returns>
    /// No. books
    /// </returns>
    public static string get_books_count(string page_name)
    {
        string no_books = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable books_count_DT = new DataTable();
        books_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_books_count");
        if (books_count_DT.Rows.Count > 0)
        {
            if (books_count_DT.Rows.Count == 1)
                no_books = books_count_DT.Rows[0][0].ToString();
            else if (books_count_DT.Rows.Count > 1)
                no_books = books_count_DT.Rows.Count.ToString();
        }
        if (no_books == "" || no_books == "0")
            no_books = "";
        else
            no_books = "(" + no_books + ")";
        return no_books;

    }

    /// <summary>
    /// This function used to get No. articles will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related articles
    /// </param>
    /// <returns>
    /// No. articles
    /// </returns>
    public static string get_articles_count(string page_name)
    {
        string no_articles = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable articles_count_DT = new DataTable();
        articles_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_articles_count");
        if (articles_count_DT.Rows.Count > 0)
        {
            if (articles_count_DT.Rows.Count == 1)
                no_articles = articles_count_DT.Rows[0][0].ToString();
            else if (articles_count_DT.Rows.Count > 1)
                no_articles = articles_count_DT.Rows.Count.ToString();
        }
        if (no_articles == "" || no_articles == "0")
            no_articles = "";
        else
            no_articles = "(" + no_articles + ")";
        return no_articles;
    }

    /// <summary>
    /// This function used to get No. videos will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related videos
    /// </param>
    /// <returns>
    /// No. videos
    /// </returns>
    public static string get_videos_count(string page_name)
    {
        string no_videos = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable videos_count_DT = new DataTable();
        videos_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_videos_count");
        if (videos_count_DT.Rows.Count > 0)
        {
            if (videos_count_DT.Rows.Count == 1)
                no_videos = videos_count_DT.Rows[0][0].ToString();
            else if (videos_count_DT.Rows.Count > 1)
                no_videos = videos_count_DT.Rows.Count.ToString();
        }
        if (no_videos == "" || no_videos == "0")
            no_videos = "";
        else
            no_videos = "(" + no_videos + ")";
        return no_videos;
    }

    /// <summary>
    /// This function used to get No. audios will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related audios
    /// </param>
    /// <returns>
    /// No. audios
    /// </returns>
    public static string get_audios_count(string page_name)
    {
        string no_audios = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable audios_count_DT = new DataTable();
        audios_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_audios_count");
        if (audios_count_DT.Rows.Count > 0)
        {
            if (audios_count_DT.Rows.Count == 1)
                no_audios = audios_count_DT.Rows[0][0].ToString();
            else if (audios_count_DT.Rows.Count > 1)
                no_audios = audios_count_DT.Rows.Count.ToString();
        }
        if (no_audios == "" || no_audios == "0")
            no_audios = "";
        else
            no_audios = "(" + no_audios + ")";
        return no_audios;
    }

    /// <summary>
    /// This function used to get No. artifacts will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related artifacts
    /// </param>
    /// <returns>
    /// No. artifacts
    /// </returns>
    public static string get_artifacts_count(string page_name)
    {
        string no_artifacts = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable artifacts_count_DT = new DataTable();
        artifacts_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_artifacts_count");
        if (artifacts_count_DT.Rows.Count > 0)
        {
            if (artifacts_count_DT.Rows.Count == 1)
                no_artifacts = artifacts_count_DT.Rows[0][0].ToString();
            else if (artifacts_count_DT.Rows.Count > 1)
                no_artifacts = artifacts_count_DT.Rows.Count.ToString();
        }
        if (no_artifacts == "" || no_artifacts == "0")
            no_artifacts = "";
        else
            no_artifacts = "(" + no_artifacts + ")";
        return no_artifacts;
    }

    /// <summary>
    /// This function used to get No. manuscripts will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related manuscripts
    /// </param>
    /// <returns>
    /// No. manuscripts
    /// </returns>
    public static string get_manuscripts_count(string page_name)
    {
        string no_manuscripts = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable manuscripts_count_DT = new DataTable();
        manuscripts_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_manuscripts_count");
        if (manuscripts_count_DT.Rows.Count > 0)
        {
            if (manuscripts_count_DT.Rows.Count == 1)
                no_manuscripts = manuscripts_count_DT.Rows[0][0].ToString();
            else if (manuscripts_count_DT.Rows.Count > 1)
                no_manuscripts = manuscripts_count_DT.Rows.Count.ToString();
        }
        if (no_manuscripts == "0" || no_manuscripts == "")
            no_manuscripts = "";
        else
            no_manuscripts = "(" + no_manuscripts + ")";
        return no_manuscripts;
    }




    /// <summary>
    /// This function used to get No. websites will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related websites
    /// </param>
    /// <returns>
    /// No. websites
    /// </returns>
    public static string get_websites_count(string page_name)
    {
        string no_websites = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable websites_count_DT = new DataTable();
        websites_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_websites_count");
        if (websites_count_DT.Rows.Count > 0)
        {
            if (websites_count_DT.Rows.Count == 1)
                no_websites = websites_count_DT.Rows[0][0].ToString();
            else if (websites_count_DT.Rows.Count > 1)
                no_websites = websites_count_DT.Rows.Count.ToString();
        }
        if (no_websites == "" || no_websites == "0")
            no_websites = "";
        else
            no_websites = "(" + no_websites + ")";
        return no_websites;

    }

    /// <summary>
    /// This function used to get No. ConferenceProceedings will be wrote in left menu item (?????)
    /// </summary>
    /// <param name="page_name">
    /// Name of current page, upon this page select related websites
    /// </param>
    /// <returns>
    /// No. ConferenceProceedings
    /// </returns>
    public static string get_ConferenceProceedings_count(string page_name)
    {
        string no_ConferenceProceedings = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable ConferenceProceedings_count_DT = new DataTable();
        ConferenceProceedings_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_conference_proceedings_count");
        if (ConferenceProceedings_count_DT.Rows.Count > 0)
        {
            if (ConferenceProceedings_count_DT.Rows.Count == 1)
                no_ConferenceProceedings = ConferenceProceedings_count_DT.Rows[0][0].ToString();
            else if (ConferenceProceedings_count_DT.Rows.Count > 1)
                no_ConferenceProceedings = ConferenceProceedings_count_DT.Rows.Count.ToString();
        }
        if (no_ConferenceProceedings == "" || no_ConferenceProceedings == "0")
            no_ConferenceProceedings = "";
        else
            no_ConferenceProceedings = "(" + no_ConferenceProceedings + ")";
        return no_ConferenceProceedings;

    }
    public static string get_theses_count(string page_name)
    {
        string no_theses = "0";
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable theses_count_DT = new DataTable();
        theses_count_DT = DatabaseFunctions.SelectData(sqlParams, "get_theses_count");
        if (theses_count_DT.Rows.Count > 0)
        {
            if (theses_count_DT.Rows.Count == 1)
                no_theses = theses_count_DT.Rows[0][0].ToString();
            else if (theses_count_DT.Rows.Count > 1)
                no_theses = theses_count_DT.Rows.Count.ToString();
        }
        if (no_theses == "" || no_theses == "0")
            no_theses = "";
        else
            no_theses = "(" + no_theses + ")";
        return no_theses;
    }

    public static int get_content_type(string page_name)
    {
        int content_type = 0;
        switch (page_name.ToLower())
        {
            case "default.aspx":
                content_type = 0;
                break;
            case "characterdetails.aspx":
                content_type = 1;
                break;
            case "event_details.aspx":
                content_type = 2;
                break;
            case "topic_details.aspx":
                content_type = 3;
                break;
            case "5":
                
                break;
            case "6":
                break;
            case "7":
                break;
            case "8":
                break;
            case "9":
                break;
            default:
                content_type = CDataConverter.ConvertToInt(HttpContext.Current.Session["content_type"].ToString());
                break;

        }
        return content_type;
    }
    public static DataTable get_images_related(string page_name)
    {

        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable images = new DataTable();
        images = DatabaseFunctions.SelectData(sqlParams, "get_related_image");
        if (images.Rows.Count > 0)
        {
            return images;

            //if (books_count_DT.Rows.Count == 1)
            //    no_books = books_count_DT.Rows[0][0].ToString();
            //else if (books_count_DT.Rows.Count > 1)
            //    no_books = books_count_DT.Rows.Count.ToString();
        }
        //if (no_books == "" || no_books == "0")
        //    no_books = "";
        //else
        //    no_books = "(" + no_books + ")";

        return images;

    }
   
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       