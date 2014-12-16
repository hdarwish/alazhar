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

public partial class places_Default : BasePage
{
    public static DataTable dt_place_list;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Session["menu_item"] = "place";

            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                Session["lang_id"] = menus_update.get_current_lang();
                ViewPlacesList(GetDataTableFromCacheOrDatabase());
                viewImageList(GetDataTableFromCacheOrDatabase());


            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpUtility.HtmlEncode(Request.QueryString["type"].ToString())), 
                                                     
                    new SqlParameter("@content_id", HttpUtility.HtmlEncode(Request.QueryString["id"].ToString())), 
                                                             
                    new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable places_list = new DataTable();
                    places_list = DatabaseFunctions.SelectData(sqlParams, "get_places_content");
                    dt_place_list = places_list;
                    ViewPlacesList(places_list);
                    viewImageList(places_list);
                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    ViewPlacesList(GetDataTableFromCacheOrDatabase());
                    viewImageList(GetDataTableFromCacheOrDatabase());
                }

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
    protected DataTable GetDataTableFromDatabase()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

        DataTable places_list = new DataTable();
        places_list = DatabaseFunctions.SelectData(sqlParams, "get_places_content");
        dt_place_list = places_list;
        return places_list;
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
    public void ViewPlacesList(DataTable places_list)
    {

        tableList.Visible = true;
        tableBoth.Visible = false;
        ListView1.Visible = true;

        tr_error.Visible = false;


        if (places_list.Rows.Count > 0)
        {
            ListView1.Visible = true;
            DataPager1.Visible = true;
            ListView1.DataSource = places_list;
            ListView1.DataBind();

            foreach (ListViewDataItem Titem in ListView1.Items)
            {
                LinkButton Linklist = (LinkButton)Titem.FindControl("Linklist1");
                Linklist.Text = places_list.Rows[Titem.DataItemIndex]["name"].ToString();// +"  " + char_list.Rows[count]["other_names"].ToString();
                Linklist.PostBackUrl = "~/places/placesDetails.aspx?id=" + places_list.Rows[Titem.DataItemIndex]["id"].ToString();

                if (places_list.Rows[Titem.DataItemIndex]["id"].ToString() != "")
                {
                    hidden_id.Value = places_list.Rows[Titem.DataItemIndex]["id"].ToString();


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
    public void viewImageList(DataTable places_list)
    {

        tableList.Visible = false;
        tableBoth.Visible = true;
        ListView2.Visible = true;

        tr_error.Visible = false;


        if (places_list.Rows.Count > 0)
        {
            DataPager2.Visible = true;
            ListView2.Visible = true;
            ListView2.DataSource = places_list;
            ListView2.DataBind();


            foreach (ListViewDataItem Titem in ListView2.Items)
            {
                LinkButton Linklist = (LinkButton)Titem.FindControl("Linklist3");
                Linklist.Text = places_list.Rows[Titem.DataItemIndex]["name"].ToString();// +"  " + charimg_list.Rows[count]["other_names"].ToString();
                ImageButton Imagelist = (ImageButton)Titem.FindControl("Imagelist");
                //Imagelist.ImageUrl = "../images/sheikhs/" + char_list.Rows[Titem.DataItemIndex]["image_name"].ToString();
                Imagelist.ImageUrl = "../img/place.jpg";
                if (places_list.Rows[Titem.DataItemIndex]["image_name"].ToString() != "")
                {
                    Imagelist.PostBackUrl = "~/places/placesDetails.aspx?id=" + places_list.Rows[Titem.DataItemIndex]["id"].ToString();
                    Linklist.PostBackUrl = "~/places/placesDetails.aspx?id=" + places_list.Rows[Titem.DataItemIndex]["id"].ToString();
                    Imagelist.ImageUrl = "../upload/forms/" + places_list.Rows[Titem.DataItemIndex]["image_name"].ToString();
                }
                else
                {
                    Linklist.PostBackUrl = "~/places/placesDetails.aspx?id=" + places_list.Rows[Titem.DataItemIndex]["id"].ToString();
                    Imagelist.ImageUrl = "../img/place.jpg";
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


    protected void PlacesList_Click(object sender, ImageClickEventArgs e)
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
        DataTable places_list = GetDataTableFromCacheOrDatabase();
        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        {
            if (lnk.Text == "ا")
            {
                var result = from record in places_list.AsEnumerable()
                             where record.Field<string>("name").Trim().Substring(0, 1) == lnk.Text
                             select record;

                var result1 = from record in places_list.AsEnumerable()
                              where record.Field<string>("name").Trim().Substring(0, 1) == "أ"
                              select record;

                var result2 = result.Concat(result1);




                var result3 = from record in places_list.AsEnumerable()
                              where record.Field<string>("name").Trim().Substring(0, 1) == "إ"
                              select record;

                var result4 = result2.Concat(result3);




                var result5 = from record in places_list.AsEnumerable()
                              where record.Field<string>("name").Trim().Substring(0, 1) == "آ"
                              select record;

                var result6 = result4.Concat(result5);



                tableList.Visible = true;
                tableBoth.Visible = false;
                if (result6.Count() > 0)
                {
                    places_list = result6.CopyToDataTable();
                    dt_place_list = places_list;
                    ViewPlacesList(places_list);

                    viewImageList(places_list);
                }
                else
                {
                    places_list = new DataTable();

                    dt_place_list = places_list;
                    ViewPlacesList(places_list);

                    viewImageList(places_list);
                }
            }

            else
            {
                var result = from record in places_list.AsEnumerable()
                             where record.Field<string>("name").Trim().Substring(0, 1) == lnk.Text
                             select record;

                tableList.Visible = true;
                tableBoth.Visible = false;
                if (result.Count() > 0)
                {
                    places_list = result.CopyToDataTable();
                    dt_place_list = places_list;
                    ViewPlacesList((DataTable)dt_place_list);

                    viewImageList((DataTable)dt_place_list);
                }
                else
                {
                    places_list = new DataTable();

                    dt_place_list = places_list;
                    ViewPlacesList((DataTable)dt_place_list);

                    viewImageList((DataTable)dt_place_list);
                }
            }
        }
        else
        {

            char temp = char.Parse(lnk.Text);
            char temp1 = char.ToLower(temp);
            string temp2 = temp1.ToString();

            var result1 = from record in places_list.AsEnumerable()
                          where record.Field<string>("name").Trim().Substring(0, 1) == lnk.Text
                          select record;

            var result2 = from record in places_list.AsEnumerable()
                          where record.Field<string>("name").Trim().Substring(0, 1) == temp2
                          select record;
            var result3 = result1.Concat(result2);



            tableList.Visible = true;
            tableBoth.Visible = false;
            if (result3.Count() > 0)
            {
                places_list = result3.CopyToDataTable();
                dt_place_list = places_list;
                ViewPlacesList((DataTable)dt_place_list);

                viewImageList((DataTable)dt_place_list);
            }
            else
            {
                places_list = new DataTable();

                dt_place_list = places_list;
                ViewPlacesList((DataTable)dt_place_list);

                viewImageList((DataTable)dt_place_list);
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
        ViewPlacesList((DataTable)dt_place_list);
    }
    protected void ListPager2_PreRender(object sender, EventArgs e)
    {

        viewImageList((DataTable)dt_place_list);
    }

}
