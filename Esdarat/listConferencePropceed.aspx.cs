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

public partial class Esdarat_listConferencePropceed : BasePage
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
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable dt = new DataTable();
                    dt = DatabaseFunctions.SelectData(sqlParams, "get_conference_proceedings_content");
                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                   
                    if (dt.Rows.Count > 0)
                    {
                        foreach (ListViewDataItem item in ListView1.Items)
                        {
                            Image img = (Image)item.FindControl("Image1");
                            if (Convert.ToString(dt.Rows[item.DataItemIndex]["image_name"]) != "")
                            //{

                            {
                                img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString();
                            }
                            //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[1])))
                            //{ img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[1]; }
                            //
                            else
                            { img.ImageUrl = "~/img/Icon 6.png"; }


                            //}
                            //else img.ImageUrl = "~/img/Icon 6.png";
                            HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                            limg.HRef = "~/Esdarat/ConferenceProceedDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                            Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                            Labbooktitle.PostBackUrl = "~/Esdarat/ConferenceProceedDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            if (dt.Rows[item.DataItemIndex]["author"].ToString() != "" && dt.Rows[item.DataItemIndex]["author"].ToString() != null)
                            {
                                Label Labwriter = (Label)item.FindControl("Labwriter");
                                Labwriter.Text = dt.Rows[item.DataItemIndex]["author_fromtitle"].ToString();
                                //Labwriter.Visible = true; 
                               
                            }
                            else
                            {
                                //Label Labwriter = (Label)item.FindControl("Labwriter");
                               // Labwriter.Visible = false; 
                               // new2.Visible = false;
                            }
                           
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
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "get_conference_proceedings_content");
        ListView1.DataSource = dt;
        ListView1.DataBind();
        
        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {
                Image img = (Image)item.FindControl("Image1");
                if (Convert.ToString(dt.Rows[item.DataItemIndex]["image_name"]) != "")
                //{
                {
                    img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString();
                }
                //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[1])))
                //{ img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[item.DataItemIndex]["image_name"].ToString().Split('.')[1]; }
                //
                else
                { img.ImageUrl = "~/img/Icon 6.png"; 
                }


                //}
                //else img.ImageUrl = "~/img/Icon 6.png";
                HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                limg.HRef = "~/Esdarat/ConferenceProceedDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                Labbooktitle.PostBackUrl = "~/Esdarat/ConferenceProceedDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                Label Labwriter = (Label)item.FindControl("Labwriter");
                Label Label2 = (Label)item.FindControl("Label2");
               
                  /*  if (dt.Rows[counter]["resource"].ToString().Equals(null) || dt.Rows[counter]["resource"].ToString().Equals(""))
                    {
                        Labwriter.Visible = false;
                    }
                    else
                    {
                        Labwriter.Visible = true;  
                    }*/
                if ((Convert.ToString(dt.Rows[item.DataItemIndex]["author"]) != "") && (Convert.ToString(dt.Rows[item.DataItemIndex]["author"]) != null))
                {
                    Label2.Visible = true;
                    Labwriter.Visible = true;
                    Labwriter.Text = dt.Rows[item.DataItemIndex]["author"].ToString();
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
        view_books_list();
    }
}
