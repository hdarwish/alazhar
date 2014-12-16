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

public partial class Esdarat_listWebSites : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["content_type"] = "0";
            Session["content_id"] = "0";
            view_webSites_list(); 
        }
    }
    public void view_webSites_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] {                                                      
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
             new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()),                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable dt = new DataTable();
        int lang = menus_update.get_current_lang();
        if (lang == 1)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_website_content");
        }
        else if (lang == 2)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_website_content_en");
        }
        else if (lang == 3)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_website_content_fr");
        }
        //dt = DatabaseFunctions.SelectData(sqlParams, "get_website_content");
        DataList1.DataSource = dt;
        DataList1.DataBind();      
        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in DataList1.Items)
            {
                LinkButton Labbooktitle = (LinkButton)item.FindControl("LabWebSitetitle");
                //Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                Labbooktitle.PostBackUrl = "~/Esdarat/webSiteDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                Label Labres = (Label)item.FindControl("Labres");
                Label Label1 = (Label)item.FindControl("Label1");
                if (dt.Rows[item.DataItemIndex]["responsible_name"].ToString() != "")
                {
                    Labres.Text = dt.Rows[item.DataItemIndex]["responsible_name"].ToString();
                }
                else
                {
                    Label1.Visible = false;
                    Labres.Visible = false;
                }
            }
        }
    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_webSites_list();
    }
}
