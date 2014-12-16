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

public partial class masterpage_topMenu : System.Web.UI.UserControl
{
    Get_subpath obj = new Get_subpath();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                lt1.Style.Add("float", "left"); lt2.Style.Add("float", "left");
                lt3.Style.Add("float", "left"); lt3.Style.Add("width", "107px"); Literal2.Style.Add("width", "107px");
                    lt4.Style.Add("float", "left");
                lt5.Style.Add("float", "left"); lt6.Style.Add("float", "left");
                lt7.Style.Add("float", "left"); lt7.Style.Add("width", "125px"); Literal4.Style.Add("width", "125px");
                lt7_1.Style.Add("float", "left"); Literal5.Style.Add("float", "left");
                 Literal5.Style.Add("padding-right", "0px");   Literal5.Style.Add("padding-left", "3px");
                 Literal9.Style.Add("float", "left");
                 Literal9.Style.Add("padding-right", "0px"); Literal9.Style.Add("padding-left", "3px");
                 Literal6.Style.Add("float", "left"); Literal6.Style.Add("padding-right", "0px"); Literal6.Style.Add("padding-left", "3px");
                 Literal7.Style.Add("float", "left"); Literal7.Style.Add("padding-right", "0px"); Literal7.Style.Add("padding-left", "3px");
                 lt7_2.Style.Add("float", "left"); lt7_3.Style.Add("float", "left"); lt7_4.Style.Add("float", "left");
                 lt8.Style.Add("float", "left");
                 lt9.Style.Add("float", "left"); lt9.Style.Add("width", "113px");
                 
                    lt10.Style.Add("float", "left");
                    lt11.Style.Add("float", "left"); lt11.Style.Add("width", "101px"); a_lib.Style.Add("width", "101px");
                    lt11_1.Style.Add("float", "left");
                lt11_2.Style.Add("float", "left"); lt11_3.Style.Add("float", "left");
                lt11_4.Style.Add("float", "left"); lt11_5.Style.Add("float", "left");
                lt11_6.Style.Add("float", "left"); lt11_7.Style.Add("float", "left"); lt11_8.Style.Add("float", "left");
                lt12.Style.Add("float", "left");
                lt13.Style.Add("float", "left"); lt14.Style.Add("float", "left");
                lt15.Style.Add("float", "left"); lt15.Style.Add("width", "105px"); Literal8.Style.Add("width", "105px");
                lt15_1.Style.Add("float", "left"); lt15_1.Style.Add("width", "105px");
                lt15_2.Style.Add("float", "left"); lt15_2.Style.Add("width", "105px");
                lt15_3.Style.Add("float", "left"); lt15_3.Style.Add("width", "105px");
                if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    lt3.Style.Add("width", "122px"); Literal2.Style.Add("width", "122px");
                    lt7.Style.Add("width", "115px"); Literal4.Style.Add("width", "115px");
                    lt9.Style.Add("width", "88px");
                    lt11.Style.Add("width", "111px"); a_lib.Style.Add("width", "111px");
                    lt13.Style.Add("width", "114px"); a_timeline.Style.Add("width", "114px");
                }
                A3.Style.Add("width", "100px"); A4.Style.Add("width", "100px"); A5.Style.Add("width", "100px"); A6.Style.Add("width", "100px");
                l6.Style.Add("width", "60px"); l6.Style.Add("padding-right", "0px"); l6.Style.Add("padding-left", "3px");
                l7.Style.Add("width", "60px"); l7.Style.Add("padding-right", "0px"); l7.Style.Add("padding-left", "3px");
                l8.Style.Add("width", "60px"); l8.Style.Add("padding-right", "0px"); l8.Style.Add("padding-left", "3px");
                lbl5.Style.Add("width", "150px"); lbl5.Style.Add("padding-right", "0px"); lbl5.Style.Add("padding-left", "3px");
                lbl1.Style.Add("width", "150px"); lbl1.Style.Add("padding-right", "0px"); lbl1.Style.Add("padding-left", "3px");
                lbl2.Style.Add("width", "150px"); lbl2.Style.Add("padding-right", "0px"); lbl2.Style.Add("padding-left", "3px");
                lbl3.Style.Add("width", "150px"); lbl3.Style.Add("padding-right", "0px"); lbl3.Style.Add("padding-left", "3px");
                lbl4.Style.Add("width", "150px"); lbl4.Style.Add("padding-right", "0px"); lbl4.Style.Add("padding-left", "3px");
                lbl66.Style.Add("width", "150px"); lbl66.Style.Add("padding-right", "0px"); lbl66.Style.Add("padding-left", "3px");
                lbl77.Style.Add("width", "150px"); lbl77.Style.Add("padding-right", "0px"); lbl77.Style.Add("padding-left", "3px");
                lbl88.Style.Add("width", "150px"); lbl88.Style.Add("padding-right", "0px"); lbl88.Style.Add("padding-left", "3px");
                img_event.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                img_topic.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                img_char.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                img_place.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                img_library.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                img_timeline.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
               
            }
            if (obj != null)
            {
                if (master_page_modified(obj))
                {
                    a_main.Attributes["class"] = "isActive";

                    img_main.Attributes["class"] = "menuButL";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                    }
                }

                else if (obj.URLIsExist("events/Default.aspx") || obj.URLIsExist("events/eventsDetails.aspx"))
                {
                    a_event.Attributes["class"] = "isActive";
                    img_event.Attributes["class"] = "menuButL";
                    img_main.Attributes["class"] = "menuButR";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_event.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                    }

                    a_main.Attributes["class"] = "";
                }

                else if (obj.URLIsExist("topics/topicsDetails.aspx") || obj.URLIsExist("topics/Default.aspx"))
                {
                    a_topic.Attributes["class"] = "isActive";
                    img_topic.Attributes["class"] = "menuButL";
                    img_event.Attributes["class"] = "menuButR";
                   
                    a_main.Attributes["class"] = ""; img_main.Attributes["class"] = "menuButN";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_topic.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                        img_event.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                    }
                }

                else if (obj.URLIsExist("sheikhs/Default.aspx") || obj.URLIsExist("sheikhs/characterdetails.aspx"))
                {

                    a_char.Attributes["class"] = "isActive";
                    img_topic.Attributes["class"] = "menuButR";
                    img_char.Attributes["class"] = "menuButL";
                    
                    a_main.Attributes["class"] = ""; img_main.Attributes["class"] = "menuButN";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_char.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                        img_topic.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                    }
                }

                else if (obj.URLIsExist("places/Default.aspx") || obj.URLIsExist("places/placesDetails.aspx") || obj.URLIsExist("places/placesMoreDetails.aspx"))
                {
                    a_place.Attributes["class"] = "isActive";
                    img_place.Attributes["class"] = "menuButL";
                    img_char.Attributes["class"] = "menuButR";
                    
                    a_main.Attributes["class"] = ""; img_main.Attributes["class"] = "menuButN";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_place.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                        img_char.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                    }

                }
                else if (obj.URLIsExist("Esdarat/list_document.aspx") || obj.URLIsExist("Esdarat/document_details.aspx") ||
                    obj.URLIsExist("Esdarat/listConferencePropceed.aspx") || obj.URLIsExist("Esdarat/ConferenceProceedDetails.aspx")||
                    obj.URLIsExist("Esdarat/list_characters_books.aspx") || obj.URLIsExist("Esdarat/books_details.aspx")||
                    obj.URLIsExist("Esdarat/list_articles.aspx") || obj.URLIsExist("Esdarat/article_details.aspx")||
                    obj.URLIsExist("Esdarat/listManuscript.aspx") || obj.URLIsExist("Esdarat/manuscriptDetails.aspx")||
                    obj.URLIsExist("Elzakera/List_theses.aspx") || obj.URLIsExist("Elzakera/thesesDetails.aspx") ||
                    obj.URLIsExist("Esdarat/listArtifacts.aspx") || obj.URLIsExist("Esdarat/artifactsDetails.aspx")||
                     obj.URLIsExist("Esdarat/listWebSites.aspx") || obj.URLIsExist("Esdarat/webSiteDetails.aspx"))
               
                { 
                    a_lib.Attributes["class"] = "isActive";
                    img_place.Attributes["class"] = "menuButR";
                    img_library.Attributes["class"] = "menuButL";
                    
                    a_main.Attributes["class"] = ""; img_main.Attributes["class"] = "menuButN";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_library.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                        img_place.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                    }
                }

                else if (obj.URLIsExist("timeline.aspx"))
                {
                    a_timeline.Attributes["class"] = "isActive";
                    img_library.Attributes["class"] = "menuButR";
                    img_timeline.Attributes["class"] = "menuButL";
                   
                    a_main.Attributes["class"] = ""; img_main.Attributes["class"] = "menuButN";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {
                        img_timeline.Style.Add("background-image", "url(../images/menuImages/side-L_fliped.jpg)");
                        img_library.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                    }
                }
                else if (obj.URLIsExist("media/listPhotos.aspx") || obj.URLIsExist("media/photoDetails.aspx") ||
                    obj.URLIsExist("media/audio_list.aspx") || obj.URLIsExist("AudioDetails.aspx") ||
                    obj.URLIsExist("media/tvAudioList.aspx") || obj.URLIsExist("media/tvaudioDetailss.aspx"))
                {
                    a_media.Attributes["class"] = "isActive";
                    img_timeline.Attributes["class"] = "menuButR";
                    a_main.Attributes["class"] = ""; img_main.Attributes["class"] = "menuButN";

                    a_main.Style.Add("class", "isActive"); img_main.Attributes["class"] = "menuButN";
                    if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                    {

                        img_timeline.Style.Add("background-image", "url(../images/menuImages/side-R_fliped.jpg)");
                        img_main.Style.Add("background-image", "url(../images/menuImages/side-N_fliped.jpg)");
                    }

                }
                else { 

                }
               

            }

        }
    }
    protected bool master_page_modified(Get_subpath obj)
    {
        string[] pages = { "general/Default.aspx", "general/search.aspx", "general/theCo_org.aspx", "general/FAQ.aspx", "glossary/Default.aspx" ,
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
    protected void main_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "main";
        Response.Redirect("~/general/Default.aspx");
    }
    protected void event_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "event";
        Response.Redirect("~/events/Default.aspx");
    }
    protected void topic_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "topic";
        Response.Redirect("~/topics/Default.aspx");
    }
    protected void char_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "char";
        Response.Redirect("~/sheikhs/Default.aspx");
    }
    protected void place_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "place";
        Response.Redirect("~/places/Default.aspx");
    }
    protected void lib_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/list_document.aspx");

    }
    protected void lib_click2(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/list_articles.aspx");

    }
    protected void lib_click3(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/list_characters_books.aspx");

    }
    protected void lib_click4(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/listManuscript.aspx");

    }
    protected void lib_click5(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/listConferencePropceed.aspx");

    }
    protected void lib_click6(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        
        Response.Redirect("~/Elzakera/List_theses.aspx");

    }
    protected void lib_click7(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/listArtifacts.aspx");

    }
     protected void lib_click8(object sender, EventArgs e)
    {
        Session["menu_item"] = "lib";
        Response.Redirect("~/Esdarat/listWebSites.aspx");

    }
    
    protected void timeline_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "timeline";
        //Response.Redirect("~/general/Timeline.swf");

    }
    protected void media_click(object sender, EventArgs e)
    {
        Session["menu_item"] = "media";
        Response.Redirect("~/media/listPhotos.aspx");

    }
    protected void media_click1(object sender, EventArgs e)
    {
        Session["menu_item"] = "media";
        Response.Redirect("~/media/audio_list.aspx");

    }
    protected void media_click2(object sender, EventArgs e)
    {
        Session["menu_item"] = "media";
        Response.Redirect("~/media/tvAudioList.aspx");

    }
}
