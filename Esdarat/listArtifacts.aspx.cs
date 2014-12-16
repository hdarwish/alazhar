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

public partial class Esdarat_listArtifacts : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["content_type"] == null || Session["content_id"] == null)
        {
            Session["content_type"] = "0";
            Session["content_id"] = "0";
            view_artifacts_list();
        }
        else if (Session["content_type"] != null && Session["content_id"] != null)
        {
            if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
            {
                SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpUtility.HtmlEncode(Request.QueryString["type"].ToString())), 
                                                     
            new SqlParameter("@content_id", HttpUtility.HtmlEncode(Request.QueryString["id"].ToString())), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };
                int lang = menus_update.get_current_lang();
                DataTable dt = new DataTable();
                dt = DatabaseFunctions.SelectData(sqlParams, "get_artifacts_content");
                ListView1.DataSource = dt;
                ListView1.DataBind();
               // int counter = 0;
                if (dt.Rows.Count > 0)
                {
                    foreach (ListViewDataItem item in ListView1.Items)
                    {
                        Image img = (Image)item.FindControl("Image1");
                        if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                        {
                            img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["small_image"].ToString();
                        }
                        else img.ImageUrl = "../img/Icon%208.jpg";

                        HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                        limg.HRef = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                        LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                        Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                        Labbooktitle.PostBackUrl = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                        Label Labwriter = (Label)item.FindControl("Labwriter");
                        Labwriter.Text = dt.Rows[item.DataItemIndex]["author"].ToString();
                        
                    }
                }
            }
            else
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                view_artifacts_list();
            }
        }
    }

    public void view_artifacts_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
            new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "get_artifacts_content");
        ListView1.DataSource = dt;
        ListView1.DataBind();
        //int counter = 0;
        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {
                LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                Image img = (Image)item.FindControl("Image1");
                if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                {
                    img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["small_image"].ToString();
                }
                else img.ImageUrl = "../img/Icon%208.jpg";

                HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                limg.HRef = "~/Esdarat/artifactsDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                Labbooktitle.PostBackUrl = "~/Esdarat/artifactsDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                Label Labwriter = (Label)item.FindControl("Labwriter");
                //Label Label2 = (Label)item.FindControl("Label2");
                //if (dt.Rows[counter]["maker_name"].ToString() != "")
                //{
                //    Labwriter.Text = dt.Rows[counter]["maker_name"].ToString();
                //}
                //else
                //{
                //    Labwriter.Visible = Label2.Visible = false;
                //}


                Label Label2 = (Label)item.FindControl("Label2");
                if ((Convert.ToString(dt.Rows[item.DataItemIndex]["maker_name"]) != "") && (Convert.ToString(dt.Rows[item.DataItemIndex]["maker_name"]) != null))
                {
                    Label2.Visible = true;
                    Labwriter.Visible = true;
                    Labwriter.Text = dt.Rows[item.DataItemIndex]["maker_name"].ToString();
                }
                else
                {

                    Label2.Visible = false;

                    Labwriter.Visible = false;
                }

            }
        }
    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_artifacts_list();
    }
}
