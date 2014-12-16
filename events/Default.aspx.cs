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

public partial class events_Default : BasePage 
{
    public static DataTable dt_event_lists;
    protected void Page_Load(object sender, EventArgs e)
    {
        string fullPath = Request.Url.AbsolutePath;
        string fileName = System.IO.Path.GetFileName(fullPath);
        if (!IsPostBack)
        {
            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                Session["lang_id"] = menus_update.get_current_lang();
                ViewList(GetDataTableFromCacheOrDatabase());
                viewImageList(GetDataTableFromCacheOrDatabase());
                
            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpUtility.HtmlEncode(Request.QueryString["type"].ToString())), 
                                                     
                    new SqlParameter("@content_id", HttpUtility.HtmlEncode(Request.QueryString["id"].ToString())), 
                                                             
                    new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable events_list = new DataTable();
                    events_list = DatabaseFunctions.SelectData(sqlParams, "get_events_content");
                    dt_event_lists = events_list;
                    ViewList(events_list);
                    viewImageList(events_list);
                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    ViewList(GetDataTableFromCacheOrDatabase());
                    viewImageList(GetDataTableFromCacheOrDatabase());
                }
                if (menus_update.get_current_lang() != 1)
                {
                    tdlnk27.Visible = false;
                    tdlnk28.Visible = false;
                }
                else
                {
                    tdlnk27.Visible = true;
                    tdlnk28.Visible = true;
                }

            }
        }
        
    }
  
    protected DataTable GetDataTableFromDatabase()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

        DataTable events_list = new DataTable();
        events_list = DatabaseFunctions.SelectData(sqlParams, "get_events_content");
        dt_event_lists = events_list;
        return events_list;
    }
    public DataTable GetDataTableFromCacheOrDatabase()
    {
        // DataTable dataTable = HttpContext.Current.Cache["defaultDatatable"] as DataTable;
        // if (dataTable == null)
        // {
        DataTable dataTable = GetDataTableFromDatabase();
        //     HttpContext.Current.Cache.Insert("defaultDatatable", dataTable, null, DateTime.Now.AddHours(1), System.Web.Caching.Cache.NoSlidingExpiration);

        //  }
        return dataTable;
    }
    public void ViewList(DataTable events_list)
    {

        tableList.Visible = true;
        tableBoth.Visible = false;
        ListView1.Visible = true;
        DataPager1.Visible = true;
        tr_error.Visible = false;


        if (events_list.Rows.Count > 0)
        {
            ListView1.Visible = true;
            ListView1.Items.Clear();
            ListView1.DataSource = events_list;
            ListView1.DataBind();
            
            foreach (ListViewDataItem Titem in ListView1.Items)
            {
                LinkButton Linklist = (LinkButton)Titem.FindControl("Linklist1");
                Linklist.Text = events_list.Rows[Titem.DataItemIndex]["title"].ToString();// +"  " + char_list.Rows[count]["other_names"].ToString();
                Linklist.PostBackUrl = "~/events/eventsDetails.aspx?id=" + events_list.Rows[Titem.DataItemIndex]["id"].ToString();

                if (events_list.Rows[Titem.DataItemIndex]["id"].ToString() != "")
                {
                    hidden_id.Value = events_list.Rows[Titem.DataItemIndex]["id"].ToString();

                }
               
            }

        }
        else
        {
            tr_error.Visible = true;
            ListView1.Visible = false;

            DataPager1.Visible = false;
        }

    }
    public void viewImageList(DataTable events_list)
    {

        tableList.Visible = false;
        tableBoth.Visible = true;
        ListView2.Visible = true;
        DataPager2.Visible = true;
        tr_error.Visible = false;


        if (events_list.Rows.Count > 0)
        {
            ListView2.Visible = true;
            ListView2.DataSource = events_list;
            ListView2.DataBind();

            
            foreach (ListViewDataItem Titem in ListView2.Items)
            {
                LinkButton Linklist = (LinkButton)Titem.FindControl("Linklist3");
                Linklist.Text = events_list.Rows[Titem.DataItemIndex]["title"].ToString();// +"  " + charimg_list.Rows[count]["other_names"].ToString();
                ImageButton Imagelist = (ImageButton)Titem.FindControl("Imagelist");
                Imagelist.ImageUrl = "../images/events/" + events_list.Rows[Titem.DataItemIndex]["large_image"].ToString();
                if (events_list.Rows[Titem.DataItemIndex]["large_image"].ToString() != "")
                {
                    Imagelist.PostBackUrl = "~/events/eventsDetails.aspx?id=" + events_list.Rows[Titem.DataItemIndex]["id"].ToString();
                    Linklist.PostBackUrl = "~/events/eventsDetails.aspx?id=" + events_list.Rows[Titem.DataItemIndex]["id"].ToString();
                }
                else
                {
                    Linklist.PostBackUrl = "~/events/eventsDetails.aspx?id=" + events_list.Rows[Titem.DataItemIndex]["id"].ToString();
                    if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                    { 
                        Imagelist.ImageUrl = "../img/even.jpg";
                    }else
                        Imagelist.ImageUrl = "../img/even_en.jpg";
                    
                }
                
            }
        }
        else
        {
            tr_error.Visible = true;
            ListView2.Visible = false;
            DataPager2.Visible = false;
        }
    }
   

    protected void CharList_Click(object sender, ImageClickEventArgs e)
    {
        check_mode.Text = "tableList";
        //tableList.Visible = true;
        tableList.Visible = true;
        tableBoth.Visible = false;
        //tableImage.Visible = false;
        

    }

    protected void Link_Click(object sender, EventArgs e)
    {

        LinkButton lnk = (LinkButton)sender;

        DataTable events_list = GetDataTableFromCacheOrDatabase();
        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        {


            if (lnk.Text == "أ")
            {
                var result = from record in events_list.AsEnumerable()
                             where record.Field<string>("title").Trim().Substring(0, 1) == lnk.Text
                             select record;


                var result1 = from record in events_list.AsEnumerable()
                              where record.Field<string>("title").Trim().Substring(0, 1) == "ا"
                              select record;

                var result2 = result.Concat(result1);




                var result3 = from record in events_list.AsEnumerable()
                              where record.Field<string>("title").Trim().Substring(0, 1) == "إ"
                              select record;

                var result4 = result2.Concat(result3);




                var result5 = from record in events_list.AsEnumerable()
                              where record.Field<string>("title").Trim().Substring(0, 1) == "آ"
                              select record;

                var result6 = result4.Concat(result5);


                tableList.Visible = true;
                tableBoth.Visible = false;
                if (result6.Count() > 0)
                {
                    events_list = result6.CopyToDataTable();
                    dt_event_lists = events_list;
                    ViewList(events_list);

                    viewImageList(events_list);
                }
                else
                {
                    events_list = new DataTable();
                    dt_event_lists = events_list;
                    ViewList(events_list);

                    viewImageList(events_list);
                }
            }

            else
            {
                var result = from record in events_list.AsEnumerable()
                             where record.Field<string>("title").Trim().Substring(0, 1) == lnk.Text
                             select record;





                tableList.Visible = true;
                tableBoth.Visible = false;
                if (result.Count() > 0)
                {
                    events_list = result.CopyToDataTable();
                    dt_event_lists = events_list;
                    ViewList(events_list);

                    viewImageList((DataTable)dt_event_lists);
                }
                else
                {
                    events_list = new DataTable();
                    dt_event_lists = events_list;
                    ViewList((DataTable)dt_event_lists);

                    viewImageList(events_list);
                }

            }
        }
        else
        {
            //--------------------------to convert  lower case to upper case ------------------------------
            char temp = char.Parse(lnk.Text);
            char temp1 = char.ToLower(temp);
            string temp2 = temp1.ToString();

            var result1 = from record in events_list.AsEnumerable()
                          where record.Field<string>("title").Trim().Substring(0, 1) == lnk.Text
                          select record;

            var result2 = from record in events_list.AsEnumerable()
                          where record.Field<string>("title").Trim().Substring(0, 1) == temp2
                          select record;
            var result3 = result1.Concat(result2);

            tableList.Visible = true;
            tableBoth.Visible = false;
            if (result3.Count() > 0)
            {
                events_list = result3.CopyToDataTable();
                dt_event_lists = events_list;
                ViewList(events_list);

                viewImageList((DataTable)dt_event_lists);
            }
            else
            {
                events_list = new DataTable();
                dt_event_lists = events_list;
                ViewList((DataTable)dt_event_lists);

                viewImageList(events_list);
            }

        }
    }
  

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        check_mode.Text = "tableBoth";
        tableList.Visible = false;
        tableBoth.Visible = true;
        //tableImage.Visible = false;
        
       
    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        ViewList((DataTable)dt_event_lists);
    }
    protected void ListPager2_PreRender(object sender, EventArgs e)
    {

        viewImageList((DataTable)dt_event_lists);
    }
  
    
}

