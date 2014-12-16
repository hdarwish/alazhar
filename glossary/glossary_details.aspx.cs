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

public partial class glossary_glossary_details : BasePage
{
    string char_code = "";

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {


            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                Session["lang_id"] = menus_update.get_current_lang();
                ViewGolassryList(GetDataTableFromCacheOrDatabase());
                // viewImageList(GetDataTableFromCacheOrDatabase());


            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Request.QueryString["type"].ToString()), 
                                                     
                    new SqlParameter("@content_id", Request.QueryString["id"].ToString()), 
                                                             
                    new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable gollasry_list = new DataTable();
                    gollasry_list = DatabaseFunctions.SelectData(sqlParams, "get_glossary_contents");
                    Session["gollasry_list"] = null;
                    Session["gollasry_list"] = gollasry_list;
                    ViewGolassryList(gollasry_list);

                }

                //{
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                if (Request.QueryString["l"].ToString() != "" && Request.QueryString["l"].ToString() != null)
                {
                    if (Request.QueryString["gid"] == "0")
                    {
                        link_character(Request.QueryString["l"].ToString());
                        char_filter(char_code);
                        char_filterlab.Text = char_code;
                    }

                }

                if (Request.QueryString["gid"] != "" && Request.QueryString["gid"] != null)
                {
                    if (Request.QueryString["l"].ToString() == "0")
                    {
                        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@id", Request.QueryString["gid"].ToString()),                                 
                            new SqlParameter("@lang_id", menus_update.get_current_lang()) };
                        DataTable gollasry_list = new DataTable();
                        gollasry_list = DatabaseFunctions.SelectData(sqlParams, "glossary_details_Select");
                        Session["gollasry_list"] = null;
                        Session["gollasry_list"] = gollasry_list;
                        ViewGolassryList(gollasry_list);
                        //char_filterlab.Text = gollasry_list.Rows["title"].Trim().Substring(0, 1);
                        char_filterlab.Text = (gollasry_list.Rows[0]["title"]).ToString().Trim().Substring(0, 1);

                    }
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

        DataTable gollasry_list = new DataTable();
        gollasry_list = DatabaseFunctions.SelectData(sqlParams, "get_glossary_contents");
        Session["gollasry_list"] = null;
        Session["gollasry_list"] = gollasry_list;
        return gollasry_list;
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
    public void ViewGolassryList(DataTable gollasry_list)
    {

        tableList.Visible = true;

        ListView1.Visible = true;

        tr_error.Visible = false;

        if (gollasry_list != null)
        {
            if (gollasry_list.Rows.Count > 0)
            {
                ListView1.Items.Clear();
                ListView1.Visible = true;
                DataPager1.Visible = true;
                ListView1.DataSource = gollasry_list;
                ListView1.DataBind();

                foreach (ListViewDataItem Titem in ListView1.Items)
                {
                    Label Linklist = (Label)Titem.FindControl("Linklist1");
                    Linklist.Text = gollasry_list.Rows[Titem.DataItemIndex]["title"].ToString();// +"  " + gollasry_list.Rows[count]["other_names"].ToString();
                    //Linklist.PostBackUrl = "~/sheikhs/characterdetails.aspx?id=" + gollasry_list.Rows[Titem.DataItemIndex]["id"].ToString();
                    Label defnation = (Label)Titem.FindControl("defination");
                    defnation.Text = gollasry_list.Rows[Titem.DataItemIndex]["glossary_definition"].ToString();

                    if (gollasry_list.Rows[Titem.DataItemIndex]["id"].ToString() != "")
                    {
                        HiddenID2.Value = gollasry_list.Rows[Titem.DataItemIndex]["id"].ToString();


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
    }



    protected void CharList_Click(object sender, ImageClickEventArgs e)
    {
        check_mode.Text = "tableList";
        //tableList.Visible = true;
        tableList.Visible = true;




    }

    protected void Link_Click(object sender, EventArgs e)
    {

        LinkButton lnk = (LinkButton)sender;

        link_character(Request.QueryString["l"].ToString());

        char_filter(lnk.Text);
        if (lnk.Text != "" && lnk.Text != null)
            char_filterlab.Text = lnk.Text;


    }

    protected void char_filter(string filter)
    {


        DataTable gollasry_list = new DataTable();


        gollasry_list = GetDataTableFromCacheOrDatabase();




        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        {
            if (filter == "ا")
            {
                var result = from record in gollasry_list.AsEnumerable()
                             where record.Field<string>("title").Trim().Substring(0, 1) == filter
                             select record;

                var result1 = from record in gollasry_list.AsEnumerable()
                              where record.Field<string>("title").Trim().Substring(0, 1) == "أ"
                              select record;

                var result2 = result.Concat(result1);




                var result3 = from record in gollasry_list.AsEnumerable()
                              where record.Field<string>("title").Trim().Substring(0, 1) == "إ"
                              select record;

                var result4 = result2.Concat(result3);




                var result5 = from record in gollasry_list.AsEnumerable()
                              where record.Field<string>("title").Trim().Substring(0, 1) == "آ"
                              select record;

                var result6 = result4.Concat(result5);


                tableList.Visible = true;
                if (result6.Count() > 0)
                {
                    gollasry_list = result6.CopyToDataTable();
                    Session["gollasry_list"] = null;
                    Session["gollasry_list"] = gollasry_list;
                    ViewGolassryList(gollasry_list);


                }
                else
                {
                    gollasry_list = new DataTable();
                    Session["gollasry_list"] = null;
                    Session["gollasry_list"] = gollasry_list;
                    ViewGolassryList(gollasry_list);


                }



            }



            else
            {
                var result = from record in gollasry_list.AsEnumerable()
                             where record.Field<string>("title").Trim().Substring(0, 1) == filter
                             select record;





                tableList.Visible = true;

                if (result.Count() > 0)
                {
                    gollasry_list = result.CopyToDataTable();
                    Session["gollasry_list"] = null;
                    Session["gollasry_list"] = gollasry_list;
                    ViewGolassryList(gollasry_list);


                }
                else
                {
                    gollasry_list = new DataTable();
                    Session["gollasry_list"] = null;
                    Session["gollasry_list"] = gollasry_list;
                    ViewGolassryList(gollasry_list);


                }

            }
        }
        else
        {

            //--------------------------to convert  lower case to upper case ------------------------------
            char temp = char.Parse(filter);
            char temp1 = char.ToLower(temp);
            string temp2 = temp1.ToString();

            var result1 = from record in gollasry_list.AsEnumerable()
                          where record.Field<string>("title").Trim().Substring(0, 1) == filter
                          select record;

            var result2 = from record in gollasry_list.AsEnumerable()
                          where record.Field<string>("title").Trim().Substring(0, 1) == temp2
                          select record;
            var result3 = result1.Concat(result2);

            tableList.Visible = true;

            if (result3.Count() > 0)
            {
                gollasry_list = result3.CopyToDataTable();
                Session["gollasry_list"] = null;
                Session["gollasry_list"] = gollasry_list;
                ViewGolassryList(gollasry_list);


            }
            else
            {
                gollasry_list = new DataTable();
                Session["gollasry_list"] = null;
                Session["gollasry_list"] = gollasry_list;
                ViewGolassryList(gollasry_list);


            }

        }



    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        check_mode.Text = "tableBoth";
        tableList.Visible = false;




    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {

        ViewGolassryList((DataTable)Session["gollasry_list"]);
    }
    protected void ListPager2_PreRender(object sender, EventArgs e)
    {


    }
    protected void link_character(string code)
    {
        switch (code)
        {
            case "1":
                Link1.Text = char_code = "ا";

                break;
            case "2":
                Link2.Text = char_code = "ب";
                break;
            case "3":
                Link3.Text = char_code = "ت";
                break;
            case "4":
                Link4.Text = char_code = "ث";
                break;
            case "5":
                Link5.Text = char_code = "ج";
                break;
            case "6":
                Link6.Text = char_code = "ح";
                break;
            case "7":
                Link7.Text = char_code = "خ";
                break;
            case "8":
                Link8.Text = char_code = "د";
                break;
            case "9":
                Link9.Text = char_code = "ذ";
                break;
            case "10":
                Link10.Text = char_code = "ر";
                break;
            case "11":
                Link1.Text = char_code = "ز";

                break;
            case "12":
                Link2.Text = char_code = "س";
                break;
            case "13":
                Link3.Text = char_code = "ش";
                break;
            case "14":
                Link4.Text = char_code = "ص";
                break;
            case "15":
                Link5.Text = char_code = "ض";
                break;
            case "16":
                Link6.Text = char_code = "ط";
                break;
            case "17":
                Link7.Text = char_code = "ظ";
                break;
            case "18":
                Link8.Text = char_code = "ع";
                break;
            case "19":
                Link9.Text = char_code = "غ";
                break;
            case "20":
                Link10.Text = char_code = "ف";
                break;
            case "21":
                Link1.Text = char_code = "ق";

                break;
            case "22":
                Link2.Text = char_code = "ك";
                break;
            case "23":
                Link3.Text = char_code = "ل";
                break;
            case "24":
                Link4.Text = char_code = "م";
                break;
            case "25":
                Link5.Text = char_code = "ن";
                break;
            case "26":
                Link6.Text = char_code = "ه";
                break;
            case "27":
                Link7.Text = char_code = "و";
                break;
            case "28":
                Link8.Text = char_code = "ى";
                break;






        }

    }

}

