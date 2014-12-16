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

public partial class masterpage_rightUC1 : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            
           if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
            divheader.Style.Add("float", "left");
            trev1.Style.Add("float", "left");
            trev2.Style.Add("float", "right");
            trev2.Style.Add("background-image", "url('../img/Arrow__f.jpg')");
            events_page.Style.Add("margin-right", "1px");
            events_page.Style.Add("margin-left", "13px");
            trch1.Style.Add("float", "left");
            trch2.Style.Add("float", "right");
            trch2.Style.Add("background-image", "url('../img/Arrow__f.jpg')");
            characters_page.Style.Add("margin-right", "1px");
            characters_page.Style.Add("margin-left", "13px");
            trto1.Style.Add("float", "left");
            trto2.Style.Add("float", "right");
            trto2.Style.Add("background-image", "url('../img/Arrow__f.jpg')");
            subjects_page.Style.Add("margin-right", "1px");
            subjects_page.Style.Add("margin-left", "13px");
            trpl1.Style.Add("float", "left");
            trpl2.Style.Add("float", "right");
            trpl2.Style.Add("background-image", "url('../img/Arrow__f.jpg')");
            memoristic_page.Style.Add("margin-right", "1px");
            memoristic_page.Style.Add("margin-left", "13px");
           }
        }
       
       
        view_related_items();
        view_chars_list();
        view_events_list();
        view_topics_list();
        veiw_places_list();
    }

    public void view_related_items()
    {
       // view_events_list();
       // view_topics_list();
       // view_chars_list();
        string ireq_id;
        string page_name = Request.FilePath;
        if (Request.QueryString["id"] != null)
        {
            ireq_id = Request.QueryString["id"].ToString();
        }
        else
        { ireq_id = "0"; }
        string char_count_str = menus_update.get_char_count(page_name);
        if (char_count_str == "")
        {
            characters_page.HRef = "";
            characters_page.Attributes.Add("onclick", "javascript : void(0);");
        }
        else
        {
            char_count.Text = char_count_str;
            if (getpage_name() != "0" && ireq_id != "0")
            {
                characters_page.HRef = "~/sheikhs/Default.aspx?id=" + ireq_id  + "&type=" + getpage_name();
            }
        }
        string event_count_str = menus_update.get_events_count(page_name);
        if (event_count_str == "")
        {
            events_page.HRef = "";
            events_page.Attributes.Add("onclick", "javascript : void(0);");
        }
        else
        {
            events_count.Text = event_count_str;
            if (getpage_name() != "0" && ireq_id != "0")
            {
                events_page.HRef = "~/events/Default.aspx?id=" + ireq_id + "&type=" + getpage_name();
            }
        }
        string topics_count_str = menus_update.get_topics_count(page_name);
        if (topics_count_str == "")
        {
            subjects_page.HRef = "";
            subjects_page.Attributes.Add("onclick", "javascript : void(0);");
        }
        else
        {
            topics_count.Text = topics_count_str;
            if (getpage_name() != "0" && ireq_id != "0")
            {
                subjects_page.HRef = "~/topics/Default.aspx?id=" + ireq_id + "&type=" + getpage_name();
            }
        }
        string places_count_str = menus_update.get_places_count(page_name);
        if (places_count_str == "")
        {
            memoristic_page.HRef = "";
            memoristic_page.Attributes.Add("onclick", "javascript : void(0);");
        }
        else
        {
            places_count.Text = places_count_str;
            if (getpage_name() != "0" && ireq_id != "0")
            {
                memoristic_page.HRef = "~/places/Default.aspx?id=" + ireq_id + "&type=" + getpage_name();
            }
        }
        //places_count.Text += places_count_str;

        //switch (page_name)
        //{
        //    //chars_tr2
        //    case "/azhar/events/Default.aspx":
        //        events_tr2.Attributes.Remove("class");
        //        events_tr2.Attributes.Add("class", "right-menu-roll");
        //        break;
        //    case "/azhar/topics/Default.aspx":
        //        topic_tr2.Attributes.Remove("class");
        //        topic_tr2.Attributes.Add("class", "right-menu-roll");
        //        break;
        //    case "/azhar/sheikhs/Default.aspx":
        //        chars_tr2.Attributes.Remove("class");
        //        chars_tr2.Attributes.Add("class", "right-menu-roll");
        //        break;
        //}
    }

    public void view_events_list()
    {
        string ireq_id;
        if (Request.QueryString["id"] != null)
        {
            ireq_id = Request.QueryString["id"].ToString();
        }
        else
        { ireq_id = "0"; }
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", getpage_name()), 
                                                        new SqlParameter("@content_id", ireq_id), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) 
                                                        };
        DataTable events_list = new DataTable();
        events_list = DatabaseFunctions.SelectData(sqlParams, "get_events_content");
        

        if (events_list.Rows.Count > 1)
        {
            Random rnd = new Random();
            int skprn = rnd.Next(0, events_list.Rows.Count - 2);
            skprn = skprn < 0 ? 0 : skprn;
            var top2events = events_list.AsEnumerable().Skip(skprn).Take(2).ToList();
            DataList1.DataSource = top2events;
            DataList1.DataBind();
            int itemcount = 0;
            foreach (DataRow rw in top2events.AsEnumerable())
            {
                HtmlTable tblevent = (HtmlTable)DataList1.Items[itemcount].FindControl("tblevent");
                tblevent.Visible = true;
                LinkButton Lab_event_title = (LinkButton)DataList1.Items[itemcount].FindControl("Lab_event_title");
                Lab_event_title.Text = rw["title"].ToString();
                Lab_event_title.PostBackUrl = "~/events/eventsDetails.aspx?id=" + rw["id"].ToString();
                itemcount++;
             
            }
            

         //events_tr.Visible = true;
        }
        else if (events_list.Rows.Count == 1)
        {
            DataList1.DataSource = events_list;
            DataList1.DataBind();
            HtmlTable tblevent = (HtmlTable)DataList1.Items[0].FindControl("tblevent");
            tblevent.Visible = true;
            LinkButton Lab_event_title = (LinkButton)DataList1.Items[0].FindControl("Lab_event_title");
            Lab_event_title.Text = events_list.Rows[0]["title"].ToString();
            Lab_event_title.PostBackUrl = "~/events/eventsDetails.aspx?id=" + events_list.Rows[0]["id"].ToString();
        }


    }

    public void view_topics_list()
    {
        string ireq_id;
        if (Request.QueryString["id"] != null)
        {
            ireq_id = Request.QueryString["id"].ToString();
        }
        else
        { ireq_id = "0"; }
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type",getpage_name()), 
                                                        new SqlParameter("@content_id", ireq_id), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) 
                                                        };
        DataTable topics_list = new DataTable();
        topics_list = DatabaseFunctions.SelectData(sqlParams, "get_topics_content");
        

        if (topics_list.Rows.Count > 1)
        {
            Random rnd = new Random();
            int skprn = rnd.Next(0, topics_list.Rows.Count - 2);
            skprn = skprn < 0 ? 0 : skprn;
            var top2topics = topics_list.AsEnumerable().Skip(skprn).Take(2).ToList();
            DataList2.DataSource = top2topics;
            DataList2.DataBind();
            int itemcount = 0;
            foreach (DataRow rw in top2topics.AsEnumerable())
            {
                HtmlTable tbltopics = (HtmlTable)DataList2.Items[itemcount].FindControl("tbltopics");
                tbltopics.Visible = true;
                LinkButton Lab_topic_title = (LinkButton)DataList2.Items[itemcount].FindControl("Lab_topic_title");
                Lab_topic_title.Text = rw["title"].ToString();
                Lab_topic_title.PostBackUrl = "~/topics/topicsDetails.aspx?id=" + rw["id"].ToString();
                itemcount++;
               
            }
            //topic_tr.Visible = true;
        }
        else if (topics_list.Rows.Count == 1)
        {
            DataList2.DataSource = topics_list;
            DataList2.DataBind();
            HtmlTable tbltopics = (HtmlTable)DataList2.Items[0].FindControl("tbltopics");
            tbltopics.Visible = true;
            LinkButton Lab_topic_title = (LinkButton)DataList2.Items[0].FindControl("Lab_topic_title");
            Lab_topic_title.Text = topics_list.Rows[0]["title"].ToString();
            Lab_topic_title.PostBackUrl = "~/topics/topicsDetails.aspx?id=" + topics_list.Rows[0]["id"].ToString();
        }

    }

    public void view_chars_list()
    {
        string ireq_id;
        if (Request.QueryString["id"] != null)
        {
            ireq_id = Request.QueryString["id"].ToString();
        }
        else
        { ireq_id = "0"; }
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", getpage_name()), 
                                                        new SqlParameter("@content_id", ireq_id), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) 
                                                        };
        DataTable char_list = new DataTable();
        char_list = DatabaseFunctions.SelectData(sqlParams, "get_characters_content");
        
        if (char_list.Rows.Count > 1)
        {
            Random rnd = new Random();
            int skprn = rnd.Next(0, char_list.Rows.Count - 2);
            skprn = skprn < 0 ? 0 : skprn;
            var top2chars = char_list.AsEnumerable().Skip(skprn).Take(2).ToList();
            DataList3.DataSource = top2chars;
            DataList3.DataBind();
            int itemcount = 0;
            foreach (DataRow rw in top2chars.AsEnumerable())
            {

                HtmlTable tblchar = (HtmlTable)DataList3.Items[itemcount].FindControl("tblchar");
                tblchar.Visible = true;
                LinkButton Lab_char_title = (LinkButton)DataList3.Items[itemcount].FindControl("Lab_char_title");

                Lab_char_title.Text = rw["name"].ToString();
                Lab_char_title.PostBackUrl = "~/sheikhs/characterdetails.aspx?id=" + rw["id"].ToString();
                itemcount++;
            }
           // chars_tr.Visible = true;
        }
        else if (char_list.Rows.Count == 1)
        {
            DataList3.DataSource = char_list;
            DataList3.DataBind();
            HtmlTable tblchar = (HtmlTable)DataList3.Items[0].FindControl("tblchar");
            tblchar.Visible = true;
            LinkButton Lab_char_title = (LinkButton)DataList3.Items[0].FindControl("Lab_char_title");
            Lab_char_title.Text = char_list.Rows[0]["name"].ToString();
            Lab_char_title.PostBackUrl = "~/sheikhs/characterdetails.aspx?id=" + char_list.Rows[0]["id"].ToString();
        }


        //
       
    }
    public void veiw_places_list()
    {
        string ireq_id;
        if (Request.QueryString["id"] != null)
        {
            ireq_id = Request.QueryString["id"].ToString();
        }
        else
        { ireq_id = "0"; }
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", getpage_name()), 
                                                        new SqlParameter("@content_id", ireq_id), 
                                                        new SqlParameter("@lang", menus_update.get_current_lang()) 
                                                        };
        DataTable places_list = new DataTable();

        places_list = DatabaseFunctions.SelectData(sqlParams, "get_places_content");

        if (places_list.Rows.Count > 1)
        {
            Random rnd = new Random();
            int skprn = rnd.Next(0, places_list.Rows.Count - 2);
            skprn = skprn < 0 ? 0 : skprn;
            var top2places = places_list.AsEnumerable().Skip(skprn).Take(2).ToList();
            DataList4.DataSource = top2places;
            DataList4.DataBind();
            int itemcount = 0;
            foreach (DataRow rw in top2places.AsEnumerable())
            {

                HtmlTable tblplaces = (HtmlTable)DataList4.Items[itemcount].FindControl("tblplaces");
                tblplaces.Visible = true;
                LinkButton Lab_places_title = (LinkButton)DataList4.Items[itemcount].FindControl("Lab_arch_memory_title");

                Lab_places_title.Text = rw["name"].ToString();
                Lab_places_title.PostBackUrl = "~/places/placesDetails.aspx?id=" + rw["id"].ToString();
                itemcount++;
            }
            // chars_tr.Visible = true;
        }
        else if (places_list.Rows.Count == 1)
        {
            DataList4.DataSource = places_list;
            DataList4.DataBind();
            HtmlTable tblplaces = (HtmlTable)DataList4.Items[0].FindControl("tblplaces");
            tblplaces.Visible = true;
            LinkButton Lab_places_title = (LinkButton)DataList4.Items[0].FindControl("Lab_arch_memory_title");
            Lab_places_title.Text = places_list.Rows[0]["name"].ToString();
            Lab_places_title.PostBackUrl = "~/places/placesDetails.aspx?id=" + places_list.Rows[0]["id"].ToString();
        }


        //

    }


    public string getpage_name()
    {

        string contentType="";
        string fullPath = Request.Url.AbsolutePath;
        string pagename = System.IO.Path.GetFileName(fullPath).ToLower();
        switch (pagename)
        {
            case "characterdetails.aspx":
                {
                    contentType = "1";
                    break;
                }
            case "eventsdetails.aspx":
                {
                    contentType = "2";
                    break;
                }
            case "topicsdetails.aspx":
                {
                    contentType = "3";
                    break;
                }
            case "placesdetails.aspx":
                {
                    contentType = "4";
                    break;
                }
            case "artifactsdetails.aspx":
                {
                    contentType = "5";
                    break;
                }
            case "tvaudiodetailss.aspx":
                {
                    contentType = "6";
                    break;
                }
            case "audiodetails.aspx":
                {
                    contentType = "7";
                    break;
                     
                }
                case "document_details.aspx":
                {
                    contentType = "8";
                    break;
                    
                    
                }
                case "article_details.aspx":
                {
                    contentType = "9";
                    break;


                }
                case "books_details.aspx":
                {
                    contentType = "10";
                    break;


                }
                case "listphotos.asp":
                {
                    contentType = "11";
                    break;


                }
                case "manuscriptdetails.aspx":
                {
                    contentType = "12";
                    break;


                }
                case "thesesdetails.aspx":
                {
                    contentType = "13";
                    break;


                }
                case "conferenceproceeddetails.aspx":
                {
                    contentType = "14";
                    break;


                }
                case "websitedetails.aspx":
                {
                    contentType = "15";
                    break;


                }
                case "glossary_details.aspx":
                {
                    contentType = "16";
                    break;


                }
        }
        return contentType;
    }
}
