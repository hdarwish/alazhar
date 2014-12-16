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
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading;
using System.Globalization;


public partial class general_Default : BasePage
{
    #region Members
    int count = 0;
    int lastindex = 0;
    int myear = 0;
    int newcycle = 0;
    XmlDocument doc = new XmlDocument();
    DataTable Timelinedt = new DataTable();
    DataTable Detailsdt = new DataTable();
    #endregion

    #region Events
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {


            HttpContext.Current.Session["content_type"] = 0;
            HttpContext.Current.Session["content_id"] = 0;
            HttpContext.Current.Session["lang"] = menus_update.get_current_lang().ToString();

            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                css_gen.Attributes.Add("href", "../css/CSS.css");
                LinkButton3.Style.Add("font-weight", "bold");
                LinkButton3.Style.Add("color", "#f6f2e2");
                LinkButton3.Style.Add("font-size", "12px");
            }

            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                css_gen.Attributes.Add("href", "../css/CSS_en.css");
                LinkButton2.Style.Add("font-weight", "bold");
                LinkButton2.Style.Add("color", "#f6f2e2");
                LinkButton2.Style.Add("font-size", "12px");
                Page.Title = "Azhar Memory";
            }

            if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                css_gen.Attributes.Add("href", "../css/CSS_fr.css");
                LinkButton1.Style.Add("font-weight", "bold");
                LinkButton1.Style.Add("color", "#f6f2e2");
                LinkButton1.Style.Add("font-size", "12px");
                Page.Title = "mémoire de Azhar";
            }

            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                //if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                //{
                //    entd.Visible = arensep.Visible = frensep.Visible = false;
                //}
                //if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                //{
                //    frtd.Visible = arensep.Visible = frensep.Visible = false;
                //}
                divtop_menu_right.Style.Add("float", "left");
                //divtop_menu_right.Style.Add("margin-left", "10px");

                divtop_menu_left.Style.Add("float", "right");
                divtop_menu_left.Style.Add("margin-right", "25px");
                //palign.Attributes["style"] = "text-align:left;";
                dvfromlib.Style.Add("text-align", "left");
                dvfromlib.Style.Add("float", "left");
                dvfromlib.Style.Add("direction", "ltr");
                divtabs.Style.Add("float", "left");
                diva.Style.Add("float", "left");
                pictab.Style.Add("float", "left"); vidtab.Style.Add("float", "left"); audtab.Style.Add("float", "right");
                diva.Style.Add("direction", "ltr");
                Table0.Attributes["style"] = Table1.Attributes["style"] =
                Table2.Attributes["style"] = Table3.Attributes["style"] =
                Table4.Attributes["style"] = Table5.Attributes["style"] =
                Table6.Attributes["style"] = Table7.Attributes["style"] = "float: left;vertical-align: top; padding-top: 0";
                td_img.Attributes["style"] = Img4.Attributes["style"] = Img8.Attributes["style"] =
                Img2.Attributes["style"] = Img5.Attributes["style"] = Img6.Attributes["style"] =
                Img7.Attributes["style"] = Img3.Attributes["style"] = "width: 100px;padding-left:2px;padding-right:5px;float:left";
                //tdtxtalign.Attributes["align"] = tdtxt1align.Attributes["align"] =
                //tdtxt2align.Attributes["align"] = tdtxt3align.Attributes["align"] =
                //tdtxt4align.Attributes["align"] = tdtxt5align.Attributes["align"] =
                //tdtxt6align.Attributes["align"] = tdtxt7align.Attributes["align"] = "left";
                title2.Attributes["style"] = Label1.Attributes["style"] =
                event_link2.Attributes["style"] = Label2.Attributes["style"] =
                Label3.Attributes["style"] = Label4.Attributes["style"] =
                Label5.Attributes["style"] = Label6.Attributes["style"] = "width: 260px;text-align:left;vertical-align:top";
                td_brief.Attributes["style"] = PEventsBrief.Attributes["style"] =
                PTopicsBrief.Attributes["style"] = PplaceBrief.Attributes["style"] =
                mchar_brief.Attributes["style"] = Pplacesvisited.Attributes["style"] =
                pEventsvisited.Attributes["style"] = ptopvisited.Attributes["style"] = "text-align:left;padding-top:5px";
                hmore.Attributes["style"] = A1.Attributes["style"] = A8.Attributes["style"] =
                A3.Attributes["style"] = A4.Attributes["style"] = A5.Attributes["style"] =
                A6.Attributes["style"] = A7.Attributes["style"] = "width: 100px;float:right;text-align:right";
                div0.Style.Add("float", "left"); div1.Style.Add("float", "left");
                div2.Style.Add("float", "left"); div3.Style.Add("float", "left");
                div4.Style.Add("float", "left"); div5.Style.Add("float", "left");
                div6.Style.Add("float", "left"); div7.Style.Add("float", "left");
                divpad.Style.Add("float", "left"); divpad1.Style.Add("float", "left");
                divpad.Style.Add("direction", "ltr"); divpad1.Style.Add("direction", "ltr");
                dvpage.Style.Add("float", "left"); dvpage1.Style.Add("float", "left");
                dvpage.Style.Add("direction", "ltr"); dvpage1.Style.Add("direction", "ltr");
                dvpages.Style.Add("float", "left");
                dvpages.Style.Add("direction", "ltr");

                dvchar2.Style.Add("text-align", "left"); dvchar2.Style.Add("float", "left");
                dvplace2.Style.Add("text-align", "left"); dvplace2.Style.Add("float", "left");
                dvevent2.Style.Add("text-align", "left"); dvevent2.Style.Add("float", "left");
                dvtopics2.Style.Add("text-align", "left"); dvtopics2.Style.Add("float", "left");
                Div8.Style.Add("text-align", "left"); Div8.Style.Add("float", "left");
                Div9.Style.Add("text-align", "left"); Div9.Style.Add("float", "left");
                Div10.Style.Add("text-align", "left"); Div10.Style.Add("float", "left");
                divev.Style.Add("text-align", "left"); divev.Style.Add("float", "left");
                tit0.Attributes["style"] = tit1.Attributes["style"] = tit4.Attributes["style"] = tit5.Attributes["style"] = tit6.Attributes["style"] = tit7.Attributes["style"] =
                tit2.Attributes["style"] = tit3.Attributes["style"] = "float:left;text-align:left;background-image: url(../img/arrow1resizedflipped.png)";
                row1.Attributes["class"] = "divtabL"; row2.Attributes["class"] = "divtabL"; row3.Attributes["class"] = "divtabL";
                row5.Attributes["class"] = "divtabL"; row6.Attributes["class"] = "divtabL"; row7.Attributes["class"] = "divtabL";
                row0.Attributes["class"] = "divtabselL"; row4.Attributes["class"] = "divtabselL";
                div_page1.Style.Add("float", "right"); div_page2.Style.Add("float", "right");
            }
            //if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            //{
            //    artd.Visible = arensep.Visible = frensep.Visible = false;
            //}
            get_random();
            get_most_visited();
            get_book_Randmize();
            get_media();
            time_line();
            tbl_menu.Visible = true;
            tbl_en_menu.Visible = false;
            //string prefix = "";
            //if (HttpContext.Current.Session["Lang"].ToString() == "Ar")
            //    prefix = prefix + "ar";
            //Page.ClientScript.RegisterClientScriptInclude("selective", ResolveUrl(@"Script\" + Session["Lang"].ToString() + "transmenu.js"));
            //CSS.Attributes.Add("href", "css/" + Session["Lang"].ToString() + "cssverticalmenu.css");
            //CSS.Attributes.Add("href", "css/" + Session["Lang"].ToString() + "style.css");

            //else
            //{
            //    tbl_en_menu.Visible = true;
            //    tbl_menu.Visible = false;
            //}
        }
    }



    #endregion

    public string FullyQualifiedApplicationPath()
    {

        //Return variable declaration
        string appPath = null;

        //Getting the current context of HTTP request
        HttpContext context = HttpContext.Current;

        //Checking the current context content
        if (context != null)
        {
            //Formatting the fully qualified website url/name
            appPath = string.Format("{0}://{1}{2}{3}",
              context.Request.Url.Scheme,
              context.Request.Url.Host,
              context.Request.Url.Port == 80
                ? string.Empty : ":" + context.Request.Url.Port,
              context.Request.ApplicationPath);
        }
        if (!appPath.EndsWith("/"))
            appPath += "/";
        return appPath;

    }

    //// Left Tap/////
    public void get_random()
    {
        div0.Style.Add("display", "block");

        //////////characters
        //x:
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) };
        DataTable charDT = new DataTable();
        charDT = DatabaseFunctions.SelectData(sqlParams, "GetRandomRecord");
        int count = charDT.Rows.Count;
        if (charDT.Rows.Count > 0)
        {
                if (charDT.Rows[0]["image_name"] != null && charDT.Rows[0]["image_name"].ToString() != "")
            {
                td_img.Src = "../images/sheikhs/" + charDT.Rows[0]["image_name"].ToString();
            }
            else { td_img.Src = "../img/char.gif"; }
            string str = charDT.Rows[0]["name"].ToString();
            title2.Text = charDT.Rows[0]["name"].ToString();
            if (str.Length > 63)
            {
                title1.Text = str.Substring(0, 62);

            }
            else
            {
                title1.Text = charDT.Rows[0]["name"].ToString();
            }
            td_brief.Text = "";
            if (charDT.Rows[0]["char_details"].ToString() != "")
            {
                string brief = charDT.Rows[0]["char_details"].ToString();
                if (brief.Length > 300)
                {
                    td_brief.Text = brief.Substring(0, 300) + ".... ";
                }
                else { td_brief.Text = charDT.Rows[0]["char_details"].ToString(); }
            }
            hidden_id.Value = charDT.Rows[0]["char_id"].ToString();
            hmore.Visible = true;
            hmore.HRef = "../sheikhs/characterdetails.aspx?id=" + hidden_id.Value;
        }
        //else { goto x; }
        ////////Places
        SqlParameter[] sqlParamsplac = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) };
        DataTable placeDT = new DataTable();
        placeDT = DatabaseFunctions.SelectData(sqlParamsplac, "places_get_random_record");
        if (placeDT.Rows.Count > 0)
        {
            //div1.Style.Add("display", "block");
            string str = placeDT.Rows[0]["name"].ToString();

            Label1.Text = placeDT.Rows[0]["name"].ToString();
            if (str.Length > 60)
            { place_title.Text = str.Substring(0, 60); }
            else { place_title.Text = placeDT.Rows[0]["name"].ToString(); }
            
                if (placeDT.Rows[0]["image_name"] != null && placeDT.Rows[0]["image_name"].ToString() != "")
            {
                Img4.Src = "../upload/forms/" + placeDT.Rows[0]["image_name"].ToString();
            }
            else { Img4.Src = "../img/place.jpg"; }



            string brief = placeDT.Rows[0]["brief"].ToString();
            if (brief != null)
            {
                if (brief != "")
                {
                    Regex rx = new Regex("<[^>]*>");

                    brief = rx.Replace(brief, "");
                    if (brief.Length > 300)
                    {
                        PplaceBrief.Text = brief.Substring(0, 300) + ".... ";
                    }
                    else
                    {
                        PplaceBrief.Text = placeDT.Rows[0]["brief"].ToString();
                    }
                }
            }

            hidden_plac.Value = placeDT.Rows[0]["id"].ToString();
            A1.Visible = true;
            A1.HRef = "../places/placesDetails.aspx?id=" + hidden_plac.Value;
        }
        //////////EVENTS

        SqlParameter[] sqlParamse = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) };

        DataTable eventDT = new DataTable();
        eventDT = DatabaseFunctions.SelectData(sqlParamse, "events_get_random_record");
        if (eventDT.Rows.Count > 0)
        {
            string str = eventDT.Rows[0]["title"].ToString();
            event_link2.Text = eventDT.Rows[0]["title"].ToString();
            if (str.Length > 60)
            {
                event_link.Text = str.Substring(0, 60);
            }
            else
            {
                event_link.Text = eventDT.Rows[0]["title"].ToString();
            }
            
                if (eventDT.Rows.Count > 0 && eventDT.Rows[0]["large_image"] != null && eventDT.Rows[0]["large_image"].ToString() != "")
            {
                Img8.Src = "../images/events/" + eventDT.Rows[0]["large_image"].ToString();
            }
            else { Img8.Src = "../img/even.jpg"; }

            string brief = eventDT.Rows[0]["event_brief"].ToString();


            if (brief != null)
            {
                if (brief != "")
                {
                    Regex rx = new Regex("<[^>]*>");

                    brief = rx.Replace(brief, "");
                    if (brief.Length > 300)
                    {
                        PEventsBrief.Text = brief.Substring(0, 300) + ".... ";
                    }
                    else { PEventsBrief.Text = eventDT.Rows[0]["event_brief"].ToString(); }
                }
            }
            hidden_eve.Value = eventDT.Rows[0]["id"].ToString();
            A8.Visible = true;
            A8.HRef = "../events/eventsDetails.aspx?id=" + hidden_eve.Value;
        }
        ////////topics
        SqlParameter[] sqlParamsSub = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) };
        DataTable topicsDT = new DataTable();
        topicsDT = DatabaseFunctions.SelectData(sqlParamsSub, "topics_get_randomrecord");
        if (topicsDT.Rows.Count > 0)
        {
            string str = topicsDT.Rows[0]["title"].ToString();
            if (str.Length > 60)
            {
                topic_title.Text = str.Substring(0, 60);
            }
            else
            { topic_title.Text = topicsDT.Rows[0]["title"].ToString(); }
            Label2.Text = topicsDT.Rows[0]["title"].ToString();
            
                if (topicsDT.Rows[0]["large_image"] != null && topicsDT.Rows[0]["large_image"].ToString() != "")
            {
                Img3.Src = "../images/topics/" + topicsDT.Rows[0]["large_image"].ToString();
            }
            else { Img3.Src = "../img/sub.jpg"; }
            string brief = topicsDT.Rows[0]["topic_brief"].ToString();

            if (brief != null)
            {
                if (brief != "")
                {
                    Regex rx = new Regex("<[^>]*>");

                    brief = rx.Replace(brief, "");
                    if (brief.Length > 300)
                    {
                        PTopicsBrief.Text = brief.Substring(0, 300) + ".... ";
                    }
                    else
                    {
                        PTopicsBrief.Text = topicsDT.Rows[0]["topic_brief"].ToString();
                    }
                }
            }
            hidden_top.Value = topicsDT.Rows[0]["id"].ToString();
            A3.Visible = true;
            A3.HRef = "../topics/topicsDetails.aspx?id=" + hidden_top.Value;
        }
    }


    /////// Right Tap ////////
    public void get_media()
    {
        /// get 6 top images//
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) };

        DataTable img = DatabaseFunctions.SelectData(sqlParams, "content_images_SelectTop6");
        if (img.Rows.Count > 0)
        {
            if (img.Rows[0]["small_image"].ToString() != "")
            {
                img_1_1.ImageUrl = "../images/uploaded_images/" + img.Rows[0]["small_image"].ToString();
                a_1_1.HRef = "../media/listPhotos.aspx?imgid=" + img.Rows[0]["id"].ToString();

                if (img.Rows[0]["title"].ToString() != "")
                {
                    img_1_1.ToolTip = img.Rows[0]["title"].ToString();
                }
            }
            else
                a_1_1.Visible = img_1_1.Visible = false;
            if (img.Rows.Count > 1)
            {
                if (img.Rows[1]["small_image"].ToString() != "")
                {
                    img_1_2.ImageUrl = "../images/uploaded_images/" + img.Rows[1]["small_image"].ToString();
                    a_1_2.HRef = "../media/listPhotos.aspx?imgid=" + img.Rows[1]["id"].ToString();
                    if (img.Rows[1]["title"].ToString() != null)
                    {
                        img_1_2.ToolTip = img.Rows[1]["title"].ToString();

                    }
                }
                else
                    a_1_2.Visible = img_1_2.Visible = false;
            }
            if (img.Rows.Count > 2)
            {
                if (img.Rows[2]["small_image"].ToString() != "")
                {
                    a_1_3.HRef = "../media/listPhotos.aspx?imgid=" + img.Rows[2]["id"].ToString();
                    img_1_3.ImageUrl = "../images/uploaded_images/" + img.Rows[2]["small_image"].ToString();
                    img_1_3.ToolTip = img.Rows[2]["title"].ToString();
                }
                else
                    a_1_3.Visible = img_1_3.Visible = false;
            }
            if (img.Rows.Count > 3)
            {
                if (img.Rows[3]["small_image"].ToString() != "")
                {
                    img_1_4.ImageUrl = "../images/uploaded_images/" + img.Rows[3]["small_image"].ToString();
                    a_1_4.HRef = "../media/listPhotos.aspx?imgid=" + img.Rows[3]["id"].ToString();

                    if (img.Rows[3]["title"].ToString() != "")
                    {
                        img_1_4.ToolTip = img.Rows[3]["title"].ToString();
                    }
                }
                else
                    a_1_4.Visible = img_1_4.Visible = false;
            }
            if (img.Rows.Count > 4)
            {
                if (img.Rows[4]["small_image"].ToString() != "")
                {
                    img_1_5.ImageUrl = "../images/uploaded_images/" + img.Rows[4]["small_image"].ToString();
                    a_1_5.HRef = "../media/listPhotos.aspx?imgid=" + img.Rows[4]["id"].ToString();

                    if (img.Rows[4]["title"].ToString() != "")
                    {
                        img_1_5.ToolTip = img.Rows[4]["title"].ToString();
                    }
                }
                else
                    a_1_5.Visible = img_1_5.Visible = false;
            }
            if (img.Rows.Count > 5)
            {
                if (img.Rows[5]["small_image"].ToString() != "")
                {
                    a_1_6.HRef = "../media/listPhotos.aspx?imgid=" + img.Rows[5]["id"].ToString();
                    img_1_6.ImageUrl = "../images/uploaded_images/" + img.Rows[5]["small_image"].ToString();


                    if (img.Rows[5]["title"].ToString() != "")
                    {
                        img_1_6.ToolTip = img.Rows[5]["title"].ToString();
                    }
                }
                else
                    a_1_6.Visible = img_1_6.Visible = false;
            }
        }
        else
        {
            a_1_1.Visible = img_1_1.Visible =
            a_1_2.Visible = img_1_2.Visible =
            a_1_3.Visible = img_1_3.Visible =
            a_1_4.Visible = img_1_4.Visible =
            a_1_5.Visible = img_1_5.Visible =
            a_1_6.Visible = img_1_6.Visible =
        imgpics.Visible = false;
        }

        /// get 6 top video///

        SqlParameter[] sqlavideo = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) ,
        new SqlParameter("@type", CDataConverter.ConvertToInt(6))};

        DataTable video = DatabaseFunctions.SelectData(sqlavideo, "content_VideoAudio_SelectTop6");

        if (video.Rows.Count > 0)
        {
            if (video.Rows[0]["small_image"].ToString() != "")
            {
                img_2_1.ImageUrl = "../upload/Videos/" + video.Rows[0]["small_image"].ToString();

                a_2_1.HRef = "../media/tvaudioDetailss.aspx?id=" + video.Rows[0]["id"].ToString();
                if (video.Rows[0]["title"].ToString() != "")
                {
                    img_2_1.ToolTip = video.Rows[0]["title"].ToString();
                }
            }
            else
                a_2_1.Visible = false;
            if (video.Rows.Count > 1 && video.Rows[1]["small_image"].ToString() != "")
            {
                img_2_2.ImageUrl = "../upload/Videos/" + video.Rows[1]["small_image"].ToString();
                a_2_2.HRef = "../media/tvaudioDetailss.aspx?id=" + video.Rows[1]["id"].ToString();

                if (video.Rows[1]["title"].ToString() != "")
                {
                    img_2_2.ToolTip = video.Rows[1]["title"].ToString();
                }
            }
            else
                a_2_2.Visible = false;
            if (video.Rows.Count > 2 && video.Rows[2]["small_image"].ToString() != "")
            {
                img_2_3.ImageUrl = "../upload/Videos/" + video.Rows[2]["small_image"].ToString();
                a_2_3.HRef = "../media/tvaudioDetailss.aspx?id=" + video.Rows[2]["id"].ToString();

                if (video.Rows[2]["title"].ToString() != "")
                {
                    img_2_3.ToolTip = video.Rows[2]["title"].ToString();
                }
            }
            else
                a_2_3.Visible = false;
            if (video.Rows.Count > 3 && video.Rows[3]["small_image"].ToString() != "")
            {
                img_2_4.ImageUrl = "../upload/Videos/" + video.Rows[3]["small_image"].ToString();

                a_2_4.HRef = "../media/tvaudioDetailss.aspx?id=" + video.Rows[3]["id"].ToString();
                if (video.Rows[3]["title"].ToString() != "")
                {
                    img_2_4.ToolTip = video.Rows[3]["title"].ToString();
                }
            }
            else
                a_2_4.Visible = false;
            if (video.Rows.Count > 4 && video.Rows[4]["small_image"].ToString() != "")
            {
                img_2_5.ImageUrl = "../upload/Videos/" + video.Rows[4]["small_image"].ToString();

                a_2_5.HRef = "../media/tvaudioDetailss.aspx?id=" + video.Rows[4]["id"].ToString();
                if (video.Rows[4]["title"].ToString() != "")
                {
                    img_2_5.ToolTip = video.Rows[4]["title"].ToString();
                }
            }
            else
                a_2_5.Visible = false;
            if (video.Rows.Count > 5 && video.Rows[5]["small_image"].ToString() != "")
            {
                img_2_6.ImageUrl = "../upload/Videos/" + video.Rows[5]["small_image"].ToString();
                a_2_6.HRef = "../media/tvaudioDetailss.aspx?id=" + video.Rows[5]["id"].ToString();

                if (video.Rows[5]["title"].ToString() != "")
                {
                    img_2_6.ToolTip = video.Rows[5]["title"].ToString();
                }
            }
            else
                a_2_6.Visible = false;
        }
        else
        {
            a_2_1.Visible =
            a_2_2.Visible =
            a_2_3.Visible =
            a_2_4.Visible =
            a_2_5.Visible =
            a_2_6.Visible =
        imgvids.Visible = false;
        }
        //// get 6 top audio ////

        SqlParameter[] sqlaudio = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang()) ,
        new SqlParameter("@type", CDataConverter.ConvertToInt(7))};

        DataTable audio = DatabaseFunctions.SelectData(sqlaudio, "content_VideoAudio_SelectTop6");
        if (audio.Rows.Count > 0)
        {

            img_3_1.ImageUrl = "../img/Icon_audio.png";
            a_3_1.HRef = "../media/AudioDetails.aspx?id=" + audio.Rows[0]["id"].ToString();
            if (audio.Rows[0]["title"].ToString() != "")
            {
                img_3_1.ToolTip = audio.Rows[0]["title"].ToString();
            }

            if (audio.Rows.Count > 1)
            {
                img_3_2.ImageUrl = "../img/Icon_audio.png";
                a_3_2.HRef = "../media/AudioDetails.aspx?id=" + audio.Rows[1]["id"].ToString();
                if (audio.Rows[1]["title"].ToString() != "")
                {
                    img_3_2.ToolTip = audio.Rows[1]["title"].ToString();
                }
            }
            else
                a_3_2.Visible = false;
            if (audio.Rows.Count > 2)
            {
                img_3_3.ImageUrl = "../img/Icon_audio.png";
                a_3_3.HRef = "../media/AudioDetails.aspx?id=" + audio.Rows[2]["id"].ToString();
                if (audio.Rows[2]["title"].ToString() != "")
                {
                    img_3_3.ToolTip = audio.Rows[2]["title"].ToString();
                }
            }
            else
                a_3_3.Visible = false;
            if (audio.Rows.Count > 3)
            {
                img_3_4.ImageUrl = "../img/Icon_audio.png";
                a_3_4.HRef = "../media/AudioDetails.aspx?id=" + audio.Rows[3]["id"].ToString();
                if (audio.Rows[3]["title"].ToString() != "")
                {
                    img_3_4.ToolTip = audio.Rows[3]["title"].ToString();
                }
            }
            else
                a_3_4.Visible = false;
            if (audio.Rows.Count > 4)
            {
                img_3_5.ImageUrl = "../img/Icon_audio.png";
                a_3_5.HRef = "../media/AudioDetails.aspx?id=" + audio.Rows[4]["id"].ToString();
                if (audio.Rows[4]["title"].ToString() != "")
                {
                    img_3_5.ToolTip = audio.Rows[4]["title"].ToString();
                }
            }
            else
                a_3_5.Visible = false;
            if (audio.Rows.Count > 5)
            {
                img_3_6.ImageUrl = "../img/Icon_audio.png";
                a_3_6.HRef = "../media/AudioDetails.aspx?id=" + audio.Rows[5]["id"].ToString();
                if (audio.Rows[5]["title"].ToString() != "")
                {
                    img_3_6.ToolTip = audio.Rows[5]["title"].ToString();
                }
            }
            else
                a_3_6.Visible = false;
        }
        else
        {
            a_3_1.Visible =
            a_3_2.Visible =
            a_3_3.Visible =
            a_3_4.Visible =
            a_3_5.Visible =
            a_3_6.Visible =
        imgauds.Visible = false;
        }
    }

    //////// MOST VISITED ELEMNTS //////////

    protected void get_most_visited()
    {
        //div4.Style.Add("display", "block");
        hits_DT hdt = new hits_DT();
        int id = 0;
        SqlParameter[] refusedSqlParams = new SqlParameter[] { new SqlParameter("@cont_type", 1) };
        DataTable tsDT = DatabaseFunctions.SelectDataByParam(refusedSqlParams, "hits_Count_Select");
        if (tsDT.Rows.Count > 0)
        {
            id = Convert.ToInt32(tsDT.Rows[0]["cont_id"].ToString());
        }
        if (id != 0)
        {
            characters_details_DT chara_dt = characters_details_DB.SelectBychar_ID(id, menus_update.get_current_lang());
            characters_DT char_dt = characters_DB.SelectByID(id);
            string str = chara_dt.char_details;
            if (str != null)
            {
                if (str != "")
                {
                    Regex rx = new Regex("<[^>]*>");
                    str = rx.Replace(str, "");
                    if (str.Length > 300)
                    { mchar_brief.Text = str.Substring(0, 300) + ".... "; }
                    else { mchar_brief.Text = str; }

                }
            }
            Label3.Text = chara_dt.name;
            mchar_title.Text = chara_dt.name;
            if (char_dt.image_name != null && char_dt.image_name.ToString() != "")
            {
                Img2.Src = "../images/sheikhs/" + char_dt.image_name;
            }
            else
            {
                Img2.Src = "../img/char.gif";
            }
            A4.HRef = "../sheikhs/characterdetails.aspx?id=" + id;

        }
        else { mchar_title.Text = "...."; }

        ///////////////Places LINK ////////////// 4
        // div5.Style.Add("display", "block");
        int id4 = 0;
        SqlParameter[] paramplace = new SqlParameter[] { new SqlParameter("@cont_type", 4) };
        DataTable hit_place = DatabaseFunctions.SelectDataByParam(paramplace, "hits_Count_Select");

        if (hit_place.Rows.Count > 0)
        {
            id4 = CDataConverter.ConvertToInt(hit_place.Rows[0]["cont_id"].ToString());
        }
        if (id4 != 0)
        {
            places_DT place = places_DB.SelectByID(id4);
            places_details_DT place_details = places_details_DB.SelectByID(id4, menus_update.get_current_lang());
            if (place_details != null && place_details.name != null)
            {
                string str = place_details.name;
                if (str.Length > 60)
                {

                    mplac_title.Text = str.Substring(0, 60);
                }
                else
                {
                    mplac_title.Text = place_details.name;
                }
                Label4.Text = place_details.name;

                string str2 = place_details.description;
                if (str2 != null)
                {
                    if (str2 != "")
                    {
                        Regex rx = new Regex("<[^>]*>");


                        str2 = rx.Replace(str2, "");
                        if (str2.Length > 300)
                        {
                            Pplacesvisited.Text = str2.Substring(0, 300) + ".... ";
                        }
                        else
                        {
                            Pplacesvisited.Text = str2;
                        }

                    }
                }

                if (place.image_name != null  && place.image_name.ToString() != "")
                {
                    Img5.Src = "../upload/forms/" + place.image_name;
                }
                else
                {
                    Img5.Src = "../img/place.jpg";
                }
                hidden_plac.Value = hit_place.Rows[0]["id"].ToString();
                A5.HRef = "../places/placesDetails.aspx?id=" + id4;
            }
        }


        ////////////// EVENTS LINK  ////////////// 2
        int id2 = 0;
        SqlParameter[] paramevents = new SqlParameter[] { new SqlParameter("@cont_type", 2) };
        DataTable hit_event = DatabaseFunctions.SelectDataByParam(paramevents, "hits_Count_Select");

        if (hit_event.Rows.Count > 0)
        {
            id2 = CDataConverter.ConvertToInt(hit_event.Rows[0]["cont_id"].ToString());
        }
        if (id2 != 0)
        {
            events_details_DT evedet_dt = events_details_DB.SelectByevent_ID(id2, menus_update.get_current_lang());
            events_DT event_dt = events_DB.SelectByID(id2);
            if (evedet_dt.title != null)
            {
                string str = evedet_dt.title.TrimEnd();
                if (str.Length > 60)
                {
                    mevent_title.Text = str.Substring(0, 60);
                }
                else
                {
                    mevent_title.Text = evedet_dt.title.TrimEnd();
                }
            }

            Label5.Text = evedet_dt.title;

            string str3 = evedet_dt.event_brief;
            if (str3 != null)
            {
                if (str3 != "")
                {
                    Regex rx = new Regex("<[^>]*>");


                    str3 = rx.Replace(str3, "");
                    if (str3.Length > 300)
                    {
                        pEventsvisited.Text = str3.Substring(0, 300) + ".... ";
                    }

                    else { pEventsvisited.Text = evedet_dt.event_brief; }
                }
            }

            if (event_dt.large_image != null && event_dt.large_image.ToString() != "")
            {
                Img6.Src = "../images/events/" + event_dt.large_image;
            }
            else { Img6.Src = "../img/even.jpg"; }
            A6.HRef = "../events/eventsDetails.aspx?id=" + id2;
        }

        ///////////////Topics LINK ////////////// 3
        int id3 = 0;
        SqlParameter[] paramtopics = new SqlParameter[] { new SqlParameter("@cont_type", 3) };
        DataTable hit_topics = DatabaseFunctions.SelectDataByParam(paramtopics, "hits_Count_Select");

        if (hit_topics.Rows.Count > 0)
        {
            id3 = CDataConverter.ConvertToInt(hit_topics.Rows[0]["cont_id"].ToString());
        }
        if (id3 != 0)
        {

            topics_DT dt = topics_DB.SelectByID(id3);
            topics_details_DT top_dt = new topics_details_DT();
            top_dt = topics_details_DB.SelectByID(id3, menus_update.get_current_lang());
            string str = mtopic_title.Text = top_dt.title;
            if (str != null && str.Length > 60)
            { mtopic_title.Text = str.Substring(0, 60); }
            else
            {
                mtopic_title.Text = top_dt.title;
            }
            Label6.Text = top_dt.title;

            string str4 = top_dt.topic_brief;

            if (str4 != null)
            {
                if (str4 != "")
                {
                    Regex rx = new Regex("<[^>]*>");


                    str4 = rx.Replace(str4, "");
                    if (str4.Length > 300)
                    { ptopvisited.Text = str4.Substring(0, 300) + ".... "; }
                    else { ptopvisited.Text = str4; }
                }
            }


            if (top_dt.form_pic_state != 0 || top_dt.form_pic_state != null)
            {
                if (dt.small_image != null && dt.small_image.ToString() != "")
                {
                    Img7.Src = "../images/uploaded_images/" + dt.small_image;
                }
                else { Img7.Src = "../img/sub.jpg"; }
            }
            else { Img7.Src = "../img/sub.jpg"; }

            A7.HRef = "../topics/topicsDetails.aspx?id=" + id3;

        }
    }

    //////////////////////////////////////////////Bottom Time line ///////////////////////////////////////////////

    protected void time_line()
    {
        try
        {

            SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@ctype", CDataConverter.ConvertToInt(1)) };

            Timelinedt = DatabaseFunctions.SelectData(sqlParams, "timeline_select");

            // XML declaration
            XmlNode declaration = doc.CreateNode(XmlNodeType.XmlDeclaration, null, null);
            doc.AppendChild(declaration);

            // Root element: article
            XmlElement root = doc.CreateElement("models");
            doc.AppendChild(root);
            if (Timelinedt != null)
            {
                if (Timelinedt.Rows.Count != 0)
                {
                    for (int i = 0; i < Timelinedt.Rows.Count; i++)
                    {

                        // Sub-element: year
                        XmlElement year = doc.CreateElement("years_" + i);
                        root.AppendChild(year);
                        // Attribute: meladiyear
                        XmlAttribute meladiyear = doc.CreateAttribute("meladiyear");
                        if (Timelinedt.Rows[i]["meladiyear"] != null)
                        {
                            if (CDataConverter.ConvertToInt(Timelinedt.Rows[i]["meladiyear"].ToString()) != 0)
                                meladiyear.Value = Timelinedt.Rows[i]["meladiyear"].ToString();
                        }

                        year.Attributes.Append(meladiyear);

                        // Attribute: hejriyear
                        XmlAttribute hejriyear = doc.CreateAttribute("hejriyear");
                        if (Timelinedt.Rows[i]["hejriyear"] != null)
                        {
                            if (CDataConverter.ConvertToInt(Timelinedt.Rows[i]["hejriyear"].ToString()) != 0)
                                hejriyear.Value = Timelinedt.Rows[i]["hejriyear"].ToString();
                        }
                        year.Attributes.Append(hejriyear);
                        // Commented (So get dt foreach row instead)
                        // if (i != 0 && newcycle !=0) 
                        // {
                        //     i = lastindex;
                        // }
                        //myear = Convert.ToInt32(dt.Rows[i]["meladiyear"].ToString());

                        //if (myear == Convert.ToInt32(dt.Rows[i + 1]["meladiyear"].ToString()))
                        //{
                        //    count += 1;
                        //    newcycle = 0; 
                        //}
                        //else
                        //{
                        //    newcycle = 1;
                        //    count = 1;
                        //    lastindex = i;
                        //}
                        string tparam = "";
                        if (Timelinedt.Rows[i]["meladiyear"] != null)
                        {

                            tparam = Timelinedt.Rows[i]["meladiyear"].ToString();
                        }
                        SqlParameter[] sqlParams2 = new SqlParameter[] { new SqlParameter("@char_id",Convert.ToInt16 (1)) ,
                        new SqlParameter("@lang_id",Convert.ToInt16(1)), new SqlParameter("@myear",tparam)};
                        Detailsdt = DatabaseFunctions.SelectData(sqlParams2, "timeline_select_details");
                        if (Detailsdt != null)
                        {
                            if (Detailsdt.Rows.Count != 0)
                            {
                                for (int y = 0; y < Detailsdt.Rows.Count; y++)
                                {
                                    // Sub-element: title
                                    XmlElement item = doc.CreateElement("item_" + y);
                                    //title.InnerText = "Sample XML Document";
                                    year.AppendChild(item);

                                    // Attribute: id
                                    XmlAttribute id = doc.CreateAttribute("id");
                                    id.Value = Detailsdt.Rows[y]["id"].ToString();
                                    item.Attributes.Append(id);
                                    // Attribute: type
                                    XmlAttribute type = doc.CreateAttribute("type");
                                    type.Value = Detailsdt.Rows[y]["type"].ToString();
                                    item.Attributes.Append(type);
                                    // Attribute: title
                                    XmlAttribute title = doc.CreateAttribute("title");
                                    title.Value = Detailsdt.Rows[y]["title"].ToString();
                                    item.Attributes.Append(title);

                                    // Attribute: url
                                    XmlAttribute url = doc.CreateAttribute("url");
                                    url.Value = FullyQualifiedApplicationPath() + "sheikhs/characterdetails.aspx?id=" + Detailsdt.Rows[y]["chrID"].ToString().Trim();
                                    item.Attributes.Append(url);

                                    // Attribute: Dummy
                                    XmlAttribute jop = doc.CreateAttribute("jop");
                                    jop.Value = Detailsdt.Rows[y]["describ"].ToString();
                                    item.Attributes.Append(jop);

                                }
                            }
                        }
                    }
                }
            }

            doc.Save(Server.MapPath(@"~/general/timelinedata_2.xml"));


        }
        catch (InvalidCastException ex)
        {
            // Response.Write(ex.Message);
            throw (ex);
        }
    }

    //////////////////////////////////////////////Bottom Library ///////////////////////////////////////////////
    public void get_book_Randmize()
    {
        SqlParameter[] sqlParamsbook = new SqlParameter[] { new SqlParameter("@doc_type", 1),
        new SqlParameter("@lang_id", menus_update.get_current_lang())};
        DataTable docs_dt = new DataTable();
        docs_dt = DatabaseFunctions.SelectData(sqlParamsbook, "documents_details_Select_rand");
        if (docs_dt.Rows.Count > 0)
        {
            if (docs_dt.Rows[0]["title"].ToString() != "")
            {
                string booktitle = docs_dt.Rows[0]["title"].ToString();
                if (booktitle.Length > 25)
                { div_title.InnerText = booktitle.Substring(0, 25) + " ..."; }

                else
                {
                    div_title.InnerText = docs_dt.Rows[0]["title"].ToString();
                }
            }
            div_content.InnerText = docs_dt.Rows[0]["brief"].ToString();
            A2.HRef = "../Esdarat/books_details.aspx?id=" + docs_dt.Rows[0]["doc_id"].ToString();
        }

        //div_title.InnerText ="الحج إلى بيت الله الحرام";

        //div_content.InnerText = "تأليف:الدكتور عبد الحليم محمود، طبعة دار الكتاب المصري- القاهرة، ودار الكتاب اللبناني- بيروت.";

        SqlParameter[] sqlParamsdoc = new SqlParameter[] { new SqlParameter("@doc_type", 3),
        new SqlParameter("@lang_id", menus_update.get_current_lang())};
        DataTable doc_dt = new DataTable();
        docs_dt = DatabaseFunctions.SelectData(sqlParamsdoc, "documents_details_Select_rand");
        if (docs_dt.Rows.Count > 0)
        {
            string str = docs_dt.Rows[0]["title"].ToString();
            if (str.Length > 25)
            {
                div_title1.InnerText = docs_dt.Rows[0]["title"].ToString().Substring(0, 25) + " ...";
            }
            else { div_title1.InnerText = docs_dt.Rows[0]["title"].ToString(); }
            if (docs_dt.Rows[0]["resource"].ToString() != "")
            { div_content1.InnerHtml = "<b>منشئ الوثيقة" + ":</b>" + docs_dt.Rows[0]["resource"].ToString(); }
            link_more2.Visible = true;
            link_more2.HRef = "../Esdarat/document_details.aspx?id=" + docs_dt.Rows[0]["doc_id"].ToString();
            //ImageButton2.ImageUrl = "../images/esdarat/" + eventDT.Rows[0]["small_image"].ToString();
        }
        SqlParameter[] sqlParamsman = new SqlParameter[] { new SqlParameter("@lang_id", menus_update.get_current_lang())
         };
        DataTable mans_dt = new DataTable();
        mans_dt = DatabaseFunctions.SelectData(sqlParamsman, "manuscripts_details_Select_randm");
        if (mans_dt.Rows.Count > 0)
        {
            string str2 = mans_dt.Rows[0]["title"].ToString();
            if (str2.Length > 25)
            { div_title2.InnerHtml = mans_dt.Rows[0]["title"].ToString().Substring(0, 25) + " ..."; }
            else { div_title2.InnerText = mans_dt.Rows[0]["title"].ToString(); }
            if (mans_dt.Rows[0]["author_fromtitle"].ToString() != "")
            {
                string str3 = mans_dt.Rows[0]["author_fromtitle"].ToString();
                if (str3.Length > 45)
                    div_content2.InnerText = " مؤلف المخطوط من صفحة العنوان:" + mans_dt.Rows[0]["author_fromtitle"].ToString().Substring(0, 45);

            }
            link_more.HRef = "../Esdarat/manuscriptDetails.aspx?id=" + mans_dt.Rows[0]["id"].ToString();
            //ImageButton2.ImageUrl = "../images/esdarat/" + eventDT.Rows[0]["small_image"].ToString();
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
        tbl_menu.Visible = true;
        tbl_en_menu.Visible = false;
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
        tbl_en_menu.Visible = true;
        tbl_menu.Visible = false;
        Response.Redirect(Request.Url.ToString());

    }
    protected void FrLinkButton_Click(object sender, EventArgs e)
    {
        Session["Lang"] = "fr";
        tbl_en_menu.Visible = true;
        tbl_menu.Visible = false;
        Response.Redirect(Request.Url.ToString());

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["k"] = txt_sr2.Text.Trim();
        Response.Redirect("../general/search.aspx?k=?");
    }

}
