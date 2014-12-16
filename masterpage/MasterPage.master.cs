using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.IO;
using System.Data.SqlClient;
public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.Title = "ذاكرة الأزهر";
        DataTable charDT = new DataTable();
        DataTable eventsDT = new DataTable();
        DataTable topicsDT = new DataTable();
        if (Session["content_type"].ToString() == "1" && Session["content_id"].ToString() != "0")
        {
            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16(Session["content_id"].ToString())) ,
            new SqlParameter("@lang_id",Convert.ToInt16(1))};


            charDT = DatabaseFunctions.SelectData(sqlParams, "characters_details_select2");
            // lblSiteMap.Text = "&nbsp;&nbsp;&nbsp;&nbsp;" + "الرئيسية >> الشخصيات >> " + charDT.Rows[0]["name"].ToString();

            hypSiteMap2.InnerText = " >> الشخصيات ";
            hypSiteMap2.HRef = "~/sheikhs/Default.aspx";
            hypSiteMap2.Visible = true;
            hypSiteMap3.InnerText = " >> " + charDT.Rows[0]["name"].ToString();
            hypSiteMap3.Visible = true;
            hypSiteMap3.HRef = "~/sheikhs/characters_details.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            string page_name = Request.FilePath;
            switch (page_name)
            {

                case "/azhar/media/photo_gallery.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> " + " الصور "; hypSiteMap4.HRef = "~/media/photo_gallery.aspx"; break;
                case "/azhar/media/audio_tracks.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> " + " التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx"; break;
                case "/azhar/media/audio_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> " + " التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams10 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playaudioid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt10 = new DataTable();
                    dt10 = DatabaseFunctions.SelectData(sqlparams10, "audio_select");
                    hypSiteMap5.InnerText = " >> " + dt10.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/audio_player.aspx?playaudioid=" + Convert.ToInt16(Request.QueryString["playaudioid"]); break;


                case "/azhar/media/video_tracks.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx"; break;
                case "/azhar/media/video_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams17 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playvideoid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt17 = new DataTable();
                    dt17 = DatabaseFunctions.SelectData(sqlparams17, "videos_select");
                    hypSiteMap5.InnerText = " >> " + dt17.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/video_player.aspx?playvideoid=" + Convert.ToInt16(Request.QueryString["playvideoid"]); break;

                case "/azhar/Esdarat/list_document.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx"; break;
                case "/azhar/Esdarat/document_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt = new DataTable();
                    dt = DatabaseFunctions.SelectData(sqlparams, "documents_docdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt.Rows[0]["doc_title"].ToString(); hypSiteMap5.HRef = "~/Esdarat/document_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;
                case "/azhar/Esdarat/list_characters_books.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx"; break;
                case "/azhar/Esdarat/books_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams1 = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt1 = new DataTable();
                    dt1 = DatabaseFunctions.SelectData(sqlparams1, "documents_booksdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt1.Rows[0]["doc_title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/books_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;



                case "/azhar/Esdarat/list_articles.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx"; break;

                case "/azhar/Esdarat/articles_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams4 = new SqlParameter[]
                {

                   new SqlParameter("@lang_id",Convert.ToInt16(1)),
                   new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                   
                };
                    DataTable dt4 = new DataTable();
                    dt4 = DatabaseFunctions.SelectData(sqlparams4, "documents_articlesdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt4.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/articles_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

            }
        }

        else if (Session["content_type"].ToString() == "2" && Session["content_id"].ToString() != "0")
        {
            SqlParameter[] sqlparams1 = new SqlParameter[]
                {

                   new SqlParameter("@lang_id",Convert.ToInt16(1)),
                   new SqlParameter("@event_id",Convert.ToInt16(Session["content_id"].ToString()))
                   
                };


            eventsDT = DatabaseFunctions.SelectData(sqlparams1, "events_details_select2");
            // lblSiteMap.Text = "&nbsp;&nbsp;&nbsp;&nbsp;" + "الرئيسية >> الشخصيات >> " + charDT.Rows[0]["name"].ToString();

            hypSiteMap2.InnerText = " >> الأحداث والمواقف ";
            hypSiteMap2.HRef = "~/events/Default.aspx";
            hypSiteMap2.Visible = true;
            hypSiteMap3.InnerText = " >> " + eventsDT.Rows[0]["title"].ToString();
            hypSiteMap3.Visible = true;
            hypSiteMap3.HRef = "~/events/event_details.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            string page_name = Request.FilePath;
            switch (page_name)
            {

                case "/azhar/media/photo_gallery.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الصور "; hypSiteMap4.HRef = "~/media/photo_gallery.aspx"; break;
                case "/azhar/media/audio_tracks.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx"; break;
                case "/azhar/media/audio_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams11 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playaudioid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt11 = new DataTable();
                    dt11 = DatabaseFunctions.SelectData(sqlparams11, "audio_select");
                    hypSiteMap5.InnerText = " >> " + dt11.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/audio_player.aspx?playaudioid=" + Convert.ToInt16(Request.QueryString["playaudioid"]); break;


                case "/azhar/media/video_tracks.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx"; break;
                case "/azhar/media/video_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams16 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playvideoid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt16 = new DataTable();
                    dt16 = DatabaseFunctions.SelectData(sqlparams16, "videos_select");
                    hypSiteMap5.InnerText = " >> " + dt16.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/video_player.aspx?playvideoid=" + Convert.ToInt16(Request.QueryString["playvideoid"]); break;

                case "/azhar/Esdarat/list_document.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx"; break;
                case "/azhar/Esdarat/document_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt = new DataTable();
                    dt = DatabaseFunctions.SelectData(sqlparams, "documents_docdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt.Rows[0]["doc_title"].ToString(); hypSiteMap5.HRef = "~/Esdarat/document_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/Esdarat/list_characters_books.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx"; break;
                case "/azhar/Esdarat/books_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams2 = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt2 = new DataTable();
                    dt2 = DatabaseFunctions.SelectData(sqlparams2, "documents_booksdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt2.Rows[0]["doc_title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/books_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/Esdarat/list_articles.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx"; break;
                case "/azhar/Esdarat/articles_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams5 = new SqlParameter[]
                {

                   new SqlParameter("@lang_id",Convert.ToInt16(1)),
                   new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                   
                };
                    DataTable dt5 = new DataTable();
                    dt5 = DatabaseFunctions.SelectData(sqlparams5, "documents_articlesdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt5.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/articles_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;


            }
        }
        else if (Session["content_type"].ToString() == "3" && Session["content_id"].ToString() != "0")
        {
            SqlParameter[] sqlparams2 = new SqlParameter[]
            {
                new SqlParameter("@topic_id",Convert.ToInt16(Session["content_id"].ToString())),
                new SqlParameter("@lang_id",Convert.ToInt16(1))
            };


            topicsDT = DatabaseFunctions.SelectData(sqlparams2, "topics_details_select2");
            // lblSiteMap.Text = "&nbsp;&nbsp;&nbsp;&nbsp;" + "الرئيسية >> الشخصيات >> " + charDT.Rows[0]["name"].ToString();

            hypSiteMap2.InnerText = " >> الموضوعات ";
            hypSiteMap2.HRef = "~/topics/Default.aspx";
            hypSiteMap2.Visible = true;
            hypSiteMap3.InnerText = " >> " + topicsDT.Rows[0]["title"].ToString();
            hypSiteMap3.Visible = true;
            hypSiteMap3.HRef = "~/topics/topic_details.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            string page_name = Request.FilePath;
            switch (page_name)
            {

                case "/azhar/media/photo_gallery.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الصور "; hypSiteMap4.HRef = "~/media/photo_gallery.aspx"; break;
                case "/azhar/media/audio_tracks.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx"; break;
                case "/azhar/media/audio_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams12 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playaudioid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt12 = new DataTable();
                    dt12 = DatabaseFunctions.SelectData(sqlparams12, "audio_select");
                    hypSiteMap5.InnerText = " >> " + dt12.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/audio_player.aspx?playaudioid=" + Convert.ToInt16(Request.QueryString["playaudioid"]); break;

                case "/azhar/media/video_tracks.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx"; break;
                case "/azhar/media/video_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams15 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playvideoid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt15 = new DataTable();
                    dt15 = DatabaseFunctions.SelectData(sqlparams15, "videos_select");
                    hypSiteMap5.InnerText = " >> " + dt15.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/video_player.aspx?playvideoid=" + Convert.ToInt16(Request.QueryString["playvideoid"]); break;

                case "/azhar/Esdarat/list_document.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx"; break;
                case "/azhar/Esdarat/document_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt = new DataTable();
                    dt = DatabaseFunctions.SelectData(sqlparams, "documents_docdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt.Rows[0]["doc_title"].ToString(); hypSiteMap5.HRef = "~/Esdarat/document_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/Esdarat/list_characters_books.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx"; break;
                case "/azhar/Esdarat/books_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams3 = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt3 = new DataTable();
                    dt3 = DatabaseFunctions.SelectData(sqlparams3, "documents_booksdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt3.Rows[0]["doc_title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/books_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/Esdarat/list_articles.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx"; break;
                case "/azhar/Esdarat/articles_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams6 = new SqlParameter[]
                {

                   new SqlParameter("@lang_id",Convert.ToInt16(1)),
                   new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                   
                };
                    DataTable dt6 = new DataTable();
                    dt6 = DatabaseFunctions.SelectData(sqlparams6, "documents_articlesdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt6.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/articles_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

            }
        }
        else
        {

            // general pages after الرئيسية
            string page_name = Request.FilePath;
            switch (page_name)
            {

                case "/azhar/sheikhs/Default.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> الشخصيات "; hypSiteMap2.HRef = "~/sheikhs/Default.aspx"; break;
                case "/azhar/media/photo_gallery.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> الصور "; hypSiteMap2.HRef = "~/media/photo_gallery.aspx"; break;
                case "/azhar/media/audio_tracks.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> التسجيلات الإذاعية "; hypSiteMap2.HRef = "~/media/audio_tracks.aspx"; break;
                case "/azhar/media/audio_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات الإذاعية "; hypSiteMap4.HRef = "~/media/audio_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams13 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playaudioid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt13 = new DataTable();
                    dt13 = DatabaseFunctions.SelectData(sqlparams13, "audio_select");
                    hypSiteMap5.InnerText = " >> " + dt13.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/audio_player.aspx?playaudioid=" + Convert.ToInt16(Request.QueryString["playaudioid"]); break;


                case "/azhar/media/video_tracks.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap2.HRef = "~/media/video_tracks.aspx"; break;
                case "/azhar/media/video_player.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> التسجيلات التلفزيونية "; hypSiteMap4.HRef = "~/media/video_tracks.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams14 = new SqlParameter[] { new SqlParameter("@id", Convert.ToInt16(Request["playvideoid"])) ,
                         new SqlParameter("@content_type", Convert.ToInt16(0))};

                    DataTable dt14 = new DataTable();
                    dt14 = DatabaseFunctions.SelectData(sqlparams14, "videos_select");
                    hypSiteMap5.InnerText = " >> " + dt14.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/media/video_player.aspx?playvideoid=" + Convert.ToInt16(Request.QueryString["playvideoid"]); break;

                case "/azhar/Esdarat/list_document.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> الوثائق "; hypSiteMap2.HRef = "~/Esdarat/list_document.aspx"; break;
                case "/azhar/Esdarat/document_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الوثائق "; hypSiteMap4.HRef = "~/Esdarat/list_document.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams7 = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt7 = new DataTable();
                    dt7 = DatabaseFunctions.SelectData(sqlparams7, "documents_docdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt7.Rows[0]["doc_title"].ToString(); hypSiteMap5.HRef = "~/Esdarat/document_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/Esdarat/list_characters_books.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> الكتب الإلكترونية "; hypSiteMap2.HRef = "~/Esdarat/list_characters_books.aspx"; break;
                case "/azhar/Esdarat/books_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> الكتب الإلكترونية "; hypSiteMap4.HRef = "~/Esdarat/list_characters_books.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams8 = new SqlParameter[]
                    {

                       new SqlParameter("@lang_id",Convert.ToInt16(1)),
                       new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                       
                    };
                    DataTable dt8 = new DataTable();
                    dt8 = DatabaseFunctions.SelectData(sqlparams8, "documents_booksdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt8.Rows[0]["doc_title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/books_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/Esdarat/list_articles.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> المقالات "; hypSiteMap2.HRef = "~/Esdarat/list_articles.aspx"; break;
                case "/azhar/Esdarat/articles_details.aspx": hypSiteMap4.Visible = true; hypSiteMap4.InnerText = " >> المقالات "; hypSiteMap4.HRef = "~/Esdarat/list_articles.aspx";
                    hypSiteMap5.Visible = true;
                    SqlParameter[] sqlparams9 = new SqlParameter[]
                {

                   new SqlParameter("@lang_id",Convert.ToInt16(1)),
                   new SqlParameter("@doc_ID",Convert.ToInt16(Request.QueryString["id"]))
                   
                };
                    DataTable dt9 = new DataTable();
                    dt9 = DatabaseFunctions.SelectData(sqlparams9, "documents_articlesdetails_select");
                    hypSiteMap5.InnerText = " >> " + dt9.Rows[0]["title"].ToString();
                    hypSiteMap5.HRef = "~/Esdarat/articles_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); break;

                case "/azhar/events/Default.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> الأحداث والمواقف "; hypSiteMap2.HRef = "~/events/Default.aspx"; break;
                case "/azhar/topics/Default.aspx": hypSiteMap2.Visible = true; hypSiteMap2.InnerText = " >> الموضوعات "; hypSiteMap2.HRef = "~/topics/Default.aspx"; break;
            }



        }



        //Session["content_id"] = Request["id"];
        //Session["content_type"] = "1";
        //string page_name = Request.FilePath; //Path.GetFileName(Request.Path);

        //switch (page_name)
        //{
        //    case "/azhar/general/Default.aspx": lblSiteMap.Text = "&nbsp;&nbsp;&nbsp;&nbsp;" + "الرئيسية >>"; break;
        //    case "/azhar/sheikhs/Default.aspx": lblSiteMap.Text = "&nbsp;&nbsp;&nbsp;&nbsp;" + "الرئيسية >> الشخصيات >>"; break;

        //}
        //lblSiteMap.Text=
    }
    protected void ArLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "ar";
        Response.Redirect(Request.Url.ToString());
    }
    protected void EnLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "en";
        Response.Redirect(Request.Url.ToString());
    }
    protected void FrLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "fr";
        Response.Redirect(Request.Url.ToString());
    }
}
