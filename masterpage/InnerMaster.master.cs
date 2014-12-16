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
using System.Threading;
using System.Globalization;
public partial class masterpage_HomeMaster : System.Web.UI.MasterPage
{
    Get_subpath obj = new Get_subpath();
    public static string srchtxt = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Page.Title = GetGlobalResourceObject("Master", "pgstitle").ToString();
        DataTable charDT = new DataTable();
        DataTable eventsDT = new DataTable();
        DataTable topicsDT = new DataTable();
        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        {
            css_gen.Attributes.Add("href", "../css/CSS.css");
            pagebannerdiv.Style.Add("background-image", "url(../img/banner3.jpg);");
            LinkButton3.Style.Add("font-weight", "bold");
            LinkButton3.Style.Add("color", "#f6f2e2");
            LinkButton3.Style.Add("font-size", "12px");
        }

        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
        {
            css_gen.Attributes.Add("href", "../css/CSS_en.css");
            pagebannerdiv.Style.Add("background-image", "url(../img/banner_en.jpg);");
            LinkButton2.Style.Add("font-weight", "bold");
            LinkButton2.Style.Add("color", "#f6f2e2");
            LinkButton2.Style.Add("font-size", "12px");
        }

        if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            css_gen.Attributes.Add("href", "../css/CSS_fr.css");
            pagebannerdiv.Style.Add("background-image", "url(../img/banner_fr.jpg);");
            LinkButton1.Style.Add("font-weight", "bold");
            LinkButton1.Style.Add("color", "#f6f2e2");
            LinkButton1.Style.Add("font-size", "12px");
        }
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            divtop_menu_right.Style.Add("float", "left");
            divtop_menu_right.Style.Add("margin-left", "0px");

            divtop_menu_left.Style.Add("float", "right");
            divtop_menu_left.Style.Add("margin-right", "24px");
            div_page_body.Style.Add("float", "left");
            divleftUC11.Style.Add("float", "left");
            if (obj.URLIsExist("media/listPhotos.aspx") == false)
            body_left.Attributes["class"] = "_inner_page_body_left_enfr";
           
            body_left_right.Style.Add("float", "left");
            divrightUC11.Style.Add("float", "right");

            //if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            //{
            //    entd.Visible = arensep.Visible = frensep.Visible = false;
            //}
            //if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            //{
            //    frtd.Visible = arensep.Visible = frensep.Visible = false;
            //}

        }
        //if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        //{
        //    artd.Visible = arensep.Visible = frensep.Visible = false;
        //}

        if (master_page_modified(obj))
        {
            leftUC11.Visible = false;
            rightUC11.Visible = false;
            //nav_bar.Visible = false;
            body_left.Attributes.Remove("class");
            body_left_right.Attributes.Remove("class");
            maindiv.Attributes.Add("width", "100%");
        }
        if (Session["content_type"] != null && Session["content_id"] != null)
        {
                
                checksubpaths();
            }

            
    }
    protected bool master_page_modified(Get_subpath obj)
    {
        string[] pages = { "places/placesMoreDetails.aspx", "general/search.aspx", "general/theCo_org.aspx", "general/FAQ.aspx", 
                             "general/contactus.aspx","general/about_website.aspx","general/related_sites.aspx",
                         "general/AddContent.aspx","general/WebsiteMap.aspx","general/Privacy_Policy.aspx","general/Terms_of_use.aspx"};

        for (int i = 0; i < pages.Length; i++)
        {
            if (obj.URLIsExist(pages[i]))
            {
                return true;
            }

        }
        return false;

    }

    protected void checksubpaths()
    {
        
        if (obj.URLIsExist("sheikhs/Default.aspx"))
        {

            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "charactersNav");
            hypSiteMap2.HRef = "~/sheikhs/Default.aspx";
            hypSiteMap2.Visible = true;
        }

        if (obj.URLIsExist("sheikhs/characterdetails.aspx"))
        {
            characters_details_DT chardetailsobj = characters_details_DB.SelectBychar_ID(Convert.ToInt16(Session["content_id"].ToString()), menus_update.get_current_lang());
            if (chardetailsobj == null)
            {
                Response.Redirect("~/sheikhs/Default.aspx");
            }
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "charactersNav");
            hypSiteMap2.HRef = "~/sheikhs/Default.aspx";
            hypSiteMap2.Visible = true;
            if (chardetailsobj.name != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + chardetailsobj.name;
                hypSiteMap3.HRef = "~/sheikhs/characterdetails.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            }
        }
        
        if (obj.URLIsExist("events/Default.aspx"))
        {

            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "eventsNav");
            hypSiteMap2.HRef = "~/events/Default.aspx";
            hypSiteMap2.Visible = true;
        }
        if (obj.URLIsExist("events/eventsDetails.aspx"))
        {
            events_details_DT eventsDetailsObj = events_details_DB.SelectByevent_ID(Convert.ToInt16(Session["content_id"].ToString()), menus_update.get_current_lang());
            if (eventsDetailsObj == null)
            {
                Response.Redirect("~/events/Default.aspx");
            }
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "eventsNav");
            hypSiteMap2.HRef = "~/events/Default.aspx";
            hypSiteMap2.Visible = true;
            if (eventsDetailsObj.title != "")
            {
                hypSiteMap3.InnerHtml = " &raquo; " + eventsDetailsObj.title;
                hypSiteMap3.Visible = true;
                hypSiteMap3.HRef = "~/events/eventsDetails.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            }
        }
        if (obj.URLIsExist("topics/Default.aspx"))
        {

            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "topicsNav");
            hypSiteMap2.HRef = "~/topics/Default.aspx";
            hypSiteMap2.Visible = true;
        }
        if (obj.URLIsExist("topics/topicsDetails.aspx"))
        {
        
            topics_details_DT topicsDetailsObj = topics_details_DB.SelectBytopic_ID(Convert.ToInt16(Session["content_id"].ToString()), menus_update.get_current_lang());
            if (topicsDetailsObj == null)
            {
                Response.Redirect("~/topics/Default.aspx");
            }
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "topicsNav");
            hypSiteMap2.HRef = "~/topics/Default.aspx";
            hypSiteMap2.Visible = true;
            if (topicsDetailsObj.title != "")
            {
                hypSiteMap3.InnerHtml = " &raquo; " + topicsDetailsObj.title;
                hypSiteMap3.Visible = true;
                hypSiteMap3.HRef = "~/topics/topicsDetails.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            }
        }
        if (obj.URLIsExist("places/Default.aspx"))
        {

            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "placeNav");
            hypSiteMap2.HRef = "~/places/Default.aspx";
            hypSiteMap2.Visible = true;
        }
        if (obj.URLIsExist("places/placesDetails.aspx") || obj.URLIsExist("places/placesMoreDetails.aspx"))
        {

            places_details_DT placesDetailsObj = places_details_DB.SelectByID(Convert.ToInt16(Session["content_id"].ToString()), menus_update.get_current_lang());
            if (placesDetailsObj == null)
            {
                Response.Redirect("~/places/Default.aspx");
            }
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "placeNav");
            hypSiteMap2.HRef = "~/places/Default.aspx";
            hypSiteMap2.Visible = true;
            if (placesDetailsObj.name != "")
            {
                hypSiteMap3.InnerHtml = " &raquo; " + placesDetailsObj.name;
                hypSiteMap3.Visible = true;
                hypSiteMap3.HRef = "~/places/placesDetails.aspx?id=" + Convert.ToInt16(Session["content_id"].ToString());
            }
        }
        if (obj.URLIsExist("Esdarat/listArtifacts.aspx"))
        { 
            hypSiteMap2.Visible = true; 
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "artifactsNav"); 
            hypSiteMap2.HRef = "~/Esdarat/listArtifacts.aspx"; 
        }
        if (obj.URLIsExist("Esdarat/artifactsDetails.aspx"))
        {
            artifacts_details_DT artifactsDetailsObj = artifacts_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]));
            if (artifactsDetailsObj == null)
            {
                Response.Redirect("~/Esdarat/listArtifacts.aspx");
            }
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "artifactsNav");
            hypSiteMap2.HRef = "~/Esdarat/listArtifacts.aspx";
            if (artifactsDetailsObj.title != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + artifactsDetailsObj.title;
                hypSiteMap3.HRef = "~/Esdarat/artifactsDetails.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
               
            }
            
            
        }
        if (obj.URLIsExist("media/audio_list.aspx"))

        { 
            hypSiteMap2.Visible = true; 
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "audiosNav");
            hypSiteMap2.HRef = "~/media/audio_list.aspx";
        }

        if (obj.URLIsExist("media/AudioDetails.aspx"))
        {
            
            content_media_details_DT contentMediaDetailsObj = content_media_details_DB.SelectByID(Convert.ToInt16(Request["id"]), menus_update.get_current_lang());
            if (contentMediaDetailsObj == null)
            {
                Response.Redirect("~/media/audio_list.aspx");
            }
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "audiosNav");
            hypSiteMap2.HRef = "~/media/audio_list.aspx";
            if (contentMediaDetailsObj.title != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + contentMediaDetailsObj.title;
                hypSiteMap3.HRef = "~/media/AudioDetails.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
            }
        }

        if (obj.URLIsExist("media/tvAudioList.aspx"))

        {
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "videosNav");
            hypSiteMap2.HRef = "~/media/tvAudioList.aspx"; 
        }


        if (obj.URLIsExist("media/tvaudioDetailss.aspx"))
        {
            
            content_media_details_DT contentMediaDetailsObj = content_media_details_DB.SelectByID(Convert.ToInt16(Request["id"]), menus_update.get_current_lang());
            if (contentMediaDetailsObj == null)
            {
                Response.Redirect("~/media/tvAudioList.aspx");
            }
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "videosNav");
            hypSiteMap2.HRef = "~/media/tvAudioList.aspx";
            if (contentMediaDetailsObj.title != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + contentMediaDetailsObj.title;
                hypSiteMap3.HRef = "~/media/tvaudioDetailss.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
            }
        }
        
        if (obj.URLIsExist("Esdarat/list_document.aspx"))
        {
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "docsNav");
            hypSiteMap2.HRef = "~/Esdarat/list_document.aspx";
        }
        

        if (obj.URLIsExist("Esdarat/document_details.aspx"))
        {

            documents_details_DT documentsDetailsObj = documents_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]), menus_update.get_current_lang());
            if (documentsDetailsObj == null)
            {
                Response.Redirect("~/Esdarat/list_document.aspx");
            }
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "docsNav");
            hypSiteMap2.HRef = "~/Esdarat/list_document.aspx";
            if (documentsDetailsObj.title != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + documentsDetailsObj.title;
                hypSiteMap3.HRef = "~/Esdarat/document_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]); 
            }
        }
        if (obj.URLIsExist("Esdarat/list_articles.aspx"))
        {
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "articlNav");
            hypSiteMap2.HRef = "~/Esdarat/list_articles.aspx";
        }

        if (obj.URLIsExist("Esdarat/article_details.aspx"))
        {

            documents_details_DT documentsDetailsObj = documents_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]), menus_update.get_current_lang());
            if (documentsDetailsObj == null)
            {
                Response.Redirect("~/Esdarat/list_articles.aspx");
            }
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "articlNav");
            hypSiteMap2.HRef = "~/Esdarat/list_articles.aspx";
            if (documentsDetailsObj.title != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + documentsDetailsObj.title;
                hypSiteMap3.HRef = "~/Esdarat/article_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
            }
        }
        if (obj.URLIsExist("Esdarat/list_characters_books.aspx"))

        {
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "bookNav");
            hypSiteMap2.HRef = "~/Esdarat/list_characters_books.aspx";
        }

        if (obj.URLIsExist("Esdarat/books_details.aspx"))
        {

            documents_details_DT documentsDetailsObj = documents_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]), menus_update.get_current_lang());
            if (documentsDetailsObj == null)
            {
                Response.Redirect("~/Esdarat/list_characters_books.aspx");
            }
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "bookNav");
            hypSiteMap2.HRef = "~/Esdarat/list_characters_books.aspx";
            if (documentsDetailsObj.title != "")
            {
                hypSiteMap3.Visible = true;
                hypSiteMap3.InnerHtml = " &raquo; " + documentsDetailsObj.title;
                hypSiteMap3.HRef = "~/Esdarat/books_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
            }
        }

        if (obj.URLIsExist("media/listPhotos.aspx"))
        {
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "imgsNav");
            hypSiteMap2.HRef = "~/media/listPhotos.aspx";
        }
        if (obj.URLIsExist("Esdarat/listManuscript.aspx"))
        {
            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "manuscriptNav");
            hypSiteMap2.HRef = "~/Esdarat/listManuscript.aspx";
        }

        if (obj.URLIsExist("Esdarat/manuscriptDetails.aspx"))
        {
           
            manuscripts_details_DT manu = manuscripts_details_DB.SelectByID(Convert.ToInt32(Request.QueryString["id"]), menus_update.get_current_lang());
            if (manu != null)
            {
                hypSiteMap2.Visible = true;
                hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "manuscriptNav");
                hypSiteMap2.HRef = "~/Esdarat/listManuscript.aspx";
                if (manu.title.ToString() != "")
                {
                    hypSiteMap3.Visible = true;
                    hypSiteMap3.InnerHtml = " &raquo; " + manu.title.ToString();
                    hypSiteMap3.HRef = "~/Esdarat/manuscriptDetails.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
                }
            }
            else
            {
                Response.Redirect("~/Esdarat/listManuscript.aspx");
            }
        }
        if (obj.URLIsExist("Elzakera/List_theses.aspx"))
        {

            hypSiteMap2.Visible = true;
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "theseNav");
            hypSiteMap2.HRef = "~/Elzakera/List_theses.aspx";
        }

        if (obj.URLIsExist("Elzakera/thesesDetails.aspx"))
        {
            theses_details_DT thesesDetailsObj = theses_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]));
            if (thesesDetailsObj != null)
            {
                hypSiteMap2.Visible = true;
                hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "theseNav");
                hypSiteMap2.HRef = "~/Elzakera/List_theses.aspx";
                if (thesesDetailsObj.title != "")
                {
                    hypSiteMap3.Visible = true;
                    hypSiteMap3.InnerHtml = " &raquo; " + thesesDetailsObj.title;
                    hypSiteMap3.HRef = "~/Elzakera/thesesDetails.aspx?id=" + CDataConverter.ConvertToInt(Request.QueryString["id"]);
                }
            }
            else
            {
                Response.Redirect("~/Elzakera/List_theses.aspx");
            }
        }
        if (obj.URLIsExist("Esdarat/listConferencePropceed.aspx"))
        {
            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "confNav");
            hypSiteMap2.HRef = "~/Esdarat/listConferencePropceed.aspx";
            hypSiteMap2.Visible = true;
        }
        if (obj.URLIsExist("Esdarat/ConferenceProceedDetails.aspx"))
        {
           conference_proceedings_details_DT conferenceproceedingsDetailsObj = conference_proceedings_details_DB.SelectByConference_ID(Convert.ToInt16(Request.QueryString["id"]), menus_update.get_current_lang());
           if (conferenceproceedingsDetailsObj != null)
            {
                hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "confNav");
                hypSiteMap2.HRef = "~/Esdarat/listConferencePropceed.aspx";
                hypSiteMap2.Visible = true;
                if (conferenceproceedingsDetailsObj.title != "")
                {
                    hypSiteMap3.Visible = true;
                    hypSiteMap3.InnerHtml = " &raquo; " + conferenceproceedingsDetailsObj.title;
                    hypSiteMap3.HRef = "~/Esdarat/ConferenceProceedDetails.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
                }
            }
            else
            {
                Response.Redirect("~/Esdarat/listConferencePropceed.aspx");
            }
        }
        
        
        
        if (obj.URLIsExist("Esdarat/listWebSites.aspx"))
        {

            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "webNav");
            hypSiteMap2.HRef = "~/Esdarat/listWebSites.aspx";
            hypSiteMap2.Visible = true;

        }
        if (obj.URLIsExist("Esdarat/webSiteDetails.aspx"))
        {
           
            WebSites_Template_details_DT WebSitesDetailsObj = WebSites_Template_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]), menus_update.get_current_lang());
            if (WebSitesDetailsObj != null)
            {
                hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "webNav");
                hypSiteMap2.HRef = "~/Esdarat/listWebSites.aspx";
                hypSiteMap2.Visible = true;
                if (WebSitesDetailsObj.title != "")
                {
                    hypSiteMap3.Visible = true;
                    hypSiteMap3.InnerHtml = " &raquo; " + WebSitesDetailsObj.title;
                    hypSiteMap3.HRef = "~/Esdarat/webSiteDetails.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
                }
            }
            else { Response.Redirect("~/Esdarat/listWebSites.aspx"); }
        }
        if (obj.URLIsExist("glossary/Default.aspx"))
        {

            hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "glossNav");
            hypSiteMap2.HRef = "~/glossary/Default.aspx";
            hypSiteMap2.Visible = true;

        }
        if (obj.URLIsExist("glossary/glossary_details.aspx"))
        {
            glossary_details_DT glossary_detailsObj = glossary_details_DB.SelectByID(Convert.ToInt16(Request.QueryString["id"]), menus_update.get_current_lang());
            if (glossary_detailsObj != null)
            {

                hypSiteMap2.InnerHtml = (String)GetGlobalResourceObject("Master", "glossNav");
                hypSiteMap2.HRef = "~/glossary/Default.aspx";
                hypSiteMap2.Visible = true;
                if (glossary_detailsObj.title != "")
                {
                    hypSiteMap3.Visible = true;
                    hypSiteMap3.InnerHtml = " &raquo; " + glossary_detailsObj.title;
                    hypSiteMap3.HRef = "~/glossary/glossary_details.aspx?id=" + Convert.ToInt16(Request.QueryString["id"]);
                }
            }
            else
            {
                Response.Redirect("~/glossary/Default.aspx");
            }

        }
        if (obj.URLIsExist("general/search.aspx"))
        {

            
            if (Session["k"].ToString() != null)
            {
                if (Request["K"].ToString() != null)
                {
                    srchtxt = Session["k"].ToString();
                    hypSiteMap1.InnerText = "نتائج البحث عن : " ;
                    hypSiteMap2.InnerText =srchtxt;
                }
              
            }
            hypSiteMap1.HRef = "";
            hypSiteMap1.Visible = true;
            hypSiteMap1.Style.Add("color", "#FF6D00");
            hypSiteMap2.HRef = "";
            hypSiteMap2.Visible = true;
            hypSiteMap2.Style.Add("color", "#C66370");
           
        }
       
    }

    protected void ArLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "ar";
        if (Session["Lang"].ToString() == "ar")
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-eg");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ar-eg");
        }
        Response.Redirect(Request.Url.ToString());
    }
    protected void EnLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "en";
        if (Session["Lang"].ToString() == "en")
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-us");

        }
        Response.Redirect(Request.Url.ToString());
    }
    protected void FrLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "fr";
        Response.Redirect(Request.Url.ToString());
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
        Session["k"] = txt_sr2.Text.Trim();
        Response.Redirect("../general/search.aspx?k=?");
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             