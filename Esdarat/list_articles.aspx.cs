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

public partial class Esdarat_Articles : BasePage 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                view_articles_list();
            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpUtility.HtmlEncode(Request.QueryString["type"].ToString())), 
                                                     
            new SqlParameter("@content_id", HttpUtility.HtmlEncode(Request.QueryString["id"].ToString())), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable dt = new DataTable();
                    dt = DatabaseFunctions.SelectData(sqlParams, "get_articles_content");
                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                   // int counter = 0;


                    if (dt.Rows.Count > 0)
                    {
                        foreach (ListViewDataItem item in ListView1.Items)
                        {
                            Image img = (Image)item.FindControl("Image1");
                            if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                            //{

                            //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1])))
                            //{ Img_book.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1];
                            {
                                img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["small_image"].ToString();
                            }
                            else
                            { img.ImageUrl = "../img/Icon%207.png"; }


                            //}
                            //else Img_book.ImageUrl = "../img/Icon%202.png";

                            LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                            Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                            Labbooktitle.PostBackUrl = "~/Esdarat/article_details.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            Label Labpubtitle = (Label)item.FindControl("Labpubtitle");
                            Labpubtitle.Text = dt.Rows[item.DataItemIndex]["resource"].ToString();

                           
                            //ImageButton Img_book = (ImageButton)item.FindControl("Img_book");
                            //HtmlInputHidden hidden_id = (HtmlInputHidden)item.FindControl("hidden_id");
                            //hidden_id.Value = dt.Rows[counter]["doc_id"].ToString();
                            //Img_book.ImageUrl = "~/images/Esdarat/" + dt.Rows[counter]["small_image"].ToString();
                            //Img_book.PostBackUrl = "~/esdarat/articles_details.aspx?id=" + dt.Rows[counter]["id"].ToString();
                           // counter++;
                        }

                    }
                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    view_articles_list();
                }
            }
          
            
        }
    }
    public void view_articles_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) 
        };

        DataTable dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "get_articles_content");
        ListView1.DataSource = dt;
        ListView1.DataBind();
       // int counter = 0;
        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {
                Image img = (Image)item.FindControl("Image1");
                if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                //{

                //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1])))
                //{ Img_book.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1];
                {
                    img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["small_image"].ToString();
                }
                else
                { img.ImageUrl = "../img/Icon%207.png"; }


                //}
                //else Img_book.ImageUrl = "../img/Icon%202.png";

                LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                Labbooktitle.PostBackUrl = "~/Esdarat/article_details.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                
                Label Labpubtitle = (Label)item.FindControl("Labpubtitle");
                Label source = (Label)item.FindControl("Label1");
                if (dt.Rows[item.DataItemIndex]["resource"].ToString().Equals(null) || dt.Rows[item.DataItemIndex]["resource"].ToString().Equals(""))
                {
                    source.Visible = false;
                    Labpubtitle.Visible = false;
                }
                else
                {
                    source.Visible = true;
                    Labpubtitle.Visible = true;
                    Labpubtitle.Text = dt.Rows[item.DataItemIndex]["resource"].ToString();
                }
                
                
                //ImageButton Img_book = (ImageButton)item.FindControl("Img_book");
                //HtmlInputHidden hidden_id = (HtmlInputHidden)item.FindControl("hidden_id");
                //hidden_id.Value = dt.Rows[counter]["doc_id"].ToString();
                //Img_book.ImageUrl = "~/images/Esdarat/" + dt.Rows[counter]["small_image"].ToString();
                //Img_book.PostBackUrl = "~/esdarat/articles_details.aspx?id=" + dt.Rows[counter]["id"].ToString();
                //counter++;
            }

        }

    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_articles_list();
    }
}
