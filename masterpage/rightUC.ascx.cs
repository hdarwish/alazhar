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

public partial class masterpage_rightUC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            view_related_items();
        }
    }

    public void view_related_items()
    {
        view_events_list();
        view_topics_list();
        view_chars_list();
    }

    public void view_events_list() 
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) 
                                                        };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "related_events_select");
        DataList1.DataSource = dt;
        DataList1.DataBind();
        int counter = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (DataListItem item in DataList1.Items)
            {
                HtmlAnchor Lab_event_title = (HtmlAnchor)item.FindControl("Lab_event_title");
                Lab_event_title.InnerText = dt.Rows[counter]["title"].ToString();
                Lab_event_title.HRef = "~/events/event_details.aspx?id=" + dt.Rows[counter]["event_id"].ToString();
                counter++;
            }
            events_tr.Visible = true;
        }
        

    }

    public void view_topics_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) 
                                                        };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "related_topics_select");
        DataList2.DataSource = dt;
        DataList2.DataBind();
        int counter = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (DataListItem item in DataList2.Items)
            {
                HtmlAnchor Lab_topic_title = (HtmlAnchor)item.FindControl("Lab_topic_title");
                Lab_topic_title.InnerText = dt.Rows[counter]["title"].ToString();
                Lab_topic_title.HRef = "~/topics/topic_details.aspx?id=" + dt.Rows[counter]["topic_id"].ToString();
                counter++;
            }
            topic_tr.Visible = true;
        }

    }

    public void view_chars_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                        new SqlParameter("@lang", HttpContext.Current.Session["lang_id"].ToString()) 
                                                        };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "related_characters_select");
        DataList3.DataSource = dt;
        DataList3.DataBind();
        int counter = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (DataListItem item in DataList3.Items)
            {
                HtmlAnchor Lab_char_title = (HtmlAnchor)item.FindControl("Lab_char_title");
                Lab_char_title.InnerText = dt.Rows[counter]["name"].ToString();
                Lab_char_title.HRef = "~/sheikhs/characters_details.aspx?id=" + dt.Rows[counter]["char_id"].ToString();
                counter++;
            }
            chars_tr.Visible = true;
        }

    }
}
