using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class glossary_Default : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                //view_glossary();
            }

            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                string page_name2 = Request.Url.AbsoluteUri;

                Get_subpath dd = new Get_subpath();
                if (dd.URLIsExist("glossary/glossary_details.aspx"))
                    Link1.Text = "zxzxzx";
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Request.QueryString["type"].ToString()), 
                                                     
            new SqlParameter("@content_id", Request.QueryString["id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable dt = new DataTable();
                    if (menus_update.get_current_lang() == 1)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_glossary_count");
                    }
                    if (menus_update.get_current_lang() == 2)
                    {
                        // dt = DatabaseFunctions.SelectData(sqlParams, "get_glossary_count");
                    }
                    if (menus_update.get_current_lang() == 3)
                    {
                        //dt = DatabaseFunctions.SelectData(sqlParams, "list_books_select");
                    }
                    //DataList1.DataSource = dt;
                    // DataList1.DataBind();
                    int counter = 0;

                }
            }

        }
    }

    protected void view_glossary()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
        new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                 
        new SqlParameter("@lang", menus_update.get_current_lang()) };

        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "get_glossary_count");
        // ListView1.DataSource = dt;
        // ListView1.DataBind();

    }

   
    protected void Link_Click(object sender, EventArgs e)
    {
        //int x = 0;
        //LinkButton lnk = (LinkButton)sender;
        //if (lnk.ID == "Link1")
        //    x = 1;
        //if (lnk.ID == "Link2")
        //    x = 2;
        //if (lnk.ID == "Link3")
        //    x = 3;
        //if (lnk.ID == "Link4")
        //    x = 4;
        //if (lnk.ID == "Link5")
        //    x = 5;
        //if (lnk.ID == "Link6")
        //    x = 6;
        //if (lnk.ID == "Link7")
        //    x = 7;
        //if (lnk.ID == "Link8")
        //    x = 8;
        //if (lnk.ID == "Link9")
        //    x = 9;
        //if (lnk.ID == "Link10")
        //    x = 10;
        //if (lnk.ID == "Link11")
        //    x = 11;
        //if (lnk.ID == "Link12")
        //    x = 12;
        //if (lnk.ID == "Link13")
        //    x = 13;
        //if (lnk.ID == "Link14")
        //    x = 14;
        //if (lnk.ID == "Link15")
        //    x = 15;
        //if (lnk.ID == "Link16")
        //    x = 16;
        //if (lnk.ID == "Link17")
        //    x = 17;
        //if (lnk.ID == "Link18")
        //    x = 18;
        //if (lnk.ID == "Link19")
        //    x = 19;
        //if (lnk.ID == "Link20")
        //    x = 20;
        //if (lnk.ID == "Link21")
        //    x = 21;
        //if (lnk.ID == "Link22")
        //    x = 22;
        //if (lnk.ID == "Link23")
        //    x = 23;
        //if (lnk.ID == "Link24")
        //    x = 24;
        //if (lnk.ID == "Link25")
        //    x = 25;
        //if (lnk.ID == "Link26")
        //    x = 26;
        //if (lnk.ID == "Link27")
        //    x = 27;
        //if (lnk.ID == "Link28")
        //    x = 28;
        //lnk.PostBackUrl = "~/glossary/glossary_details.aspx?gid=0&l=" + x ;

    }


}
