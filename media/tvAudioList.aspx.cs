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

public partial class Esdarat_tvAudioList : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                view_books_list();
            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpUtility.HtmlEncode(Request.QueryString["type"].ToString())), 
                                                     
            new SqlParameter("@content_id", HttpUtility.HtmlEncode(Request.QueryString["id"].ToString())), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang())
                    
           // , new SqlParameter("@form_status",12)
            //, new SqlParameter("@form_status_en", DBNull.Value )
            //, new SqlParameter("@form_status_fr", DBNull.Value )
                    
                    
                    };

                    DataTable dt = new DataTable();
                    dt = DatabaseFunctions.SelectData(sqlParams, "get_video_content");
                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                   
                    if (dt.Rows.Count > 0)
                    {
                        foreach (ListViewDataItem item in ListView1.Items)
                        {
                            Image img = (Image)item.FindControl("Image1");
                            //if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                            //{

                               // if (System.IO.File.Exists(Server.MapPath("~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[1])))
                            if (System.IO.File.Exists(Server.MapPath("~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[1])))
                            {
                                if (dt.Rows[item.DataItemIndex]["small_image"].ToString() != "")

                                { img.ImageUrl = "~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString(); }
                                else

                                { img.ImageUrl = "~/img/Icon%203.png"; } 

                            }

                            
                            HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                            limg.HRef = "tvaudioDetailss.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            LinkButton VedioTitle = (LinkButton)item.FindControl("VedioTitle");
                            VedioTitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                            VedioTitle.PostBackUrl = "tvaudioDetailss.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            Label Labguest = (Label)item.FindControl("Labguest");
                            Labguest.Text = dt.Rows[item.DataItemIndex]["guest_details"].ToString();
                           
                        }

                    }
                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    view_books_list();
                }

            }


          
        }
    }
    public void view_books_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang())
       
        };

        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "get_video_content");
        ListView1.DataSource = dt;
        ListView1.DataBind();
        
        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {
                Image img = (Image)item.FindControl("Image1");
                //if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                //{

                    //if (System.IO.File.Exists(Server.MapPath("~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[1])))
                    //{ img.ImageUrl = "~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[1]; }
                    //else
                    //{ img.ImageUrl = "~/img/Icon%203.png"; }


                //}
                if (System.IO.File.Exists(Server.MapPath("~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString())))
                    //.Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["small_image"].ToString().Split('.')[1])))
                {
                    if (dt.Rows[item.DataItemIndex]["small_image"].ToString() != "")

                    { img.ImageUrl = "~/upload/Videos/" + dt.Rows[item.DataItemIndex]["small_image"].ToString(); }
                    else

                    { img.ImageUrl = "~/img/Icon%203.png"; }

                }
                else

                { img.ImageUrl = "~/img/Icon%203.png"; }
                HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                limg.HRef = "~/media/tvaudioDetailss.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                LinkButton VedioTitle = (LinkButton)item.FindControl("VedioTitle");
                VedioTitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                VedioTitle.PostBackUrl = "~/media/tvaudioDetailss.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                Label Labguest = (Label)item.FindControl("Labguest");
              
                Label Label2 = (Label)item.FindControl("Label2");
                if ((Convert.ToString(dt.Rows[item.DataItemIndex]["guest_details"]) != "") && (Convert.ToString(dt.Rows[item.DataItemIndex]["guest_details"]) != null))
                {
                    Label2.Visible = true;
                    Labguest.Visible = true;
                    Labguest.Text = dt.Rows[item.DataItemIndex]["guest_details"].ToString();
                }
                else
                {

                    Label2.Visible = false;

                    Labguest.Visible = false;
                }



             //   Labguest.Text = dt.Rows[item.DataItemIndex]["guest_details"].ToString();
                           
              
            }

        }

    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_books_list();
    }
}
