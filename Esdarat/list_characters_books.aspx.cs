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

public partial class Esdarat_list_characters_books : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "10";
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
                   
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_books_content");
                    }

                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                   // int counter = 0;

                    if (dt.Rows.Count > 0)
                    {
                        foreach (ListViewDataItem item in ListView1.Items)
                        {
                            LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                          
                            Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString().Trim();
                          
                            Labbooktitle.PostBackUrl = "~/Esdarat/books_details.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                          
                            Image img = (Image)item.FindControl("Img_book");
                           
                            if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                            //{

                            //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1])))
                            //{ Img_book.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1];
                            {
                                img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["small_image"].ToString();
                            }
                            else
                            { img.ImageUrl = "../img/Icon%202.png"; }


                            //}
                            //else Img_book.ImageUrl = "../img/Icon%202.png";

                            //HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                           // limg.HRef = "~/Esdarat/document_details.aspx?id=" + dt.Rows[counter]["id"].ToString();
                            Label Labwriter = (Label)item.FindControl("Labwriter");

                            Labwriter.Text = dt.Rows[item.DataItemIndex]["resource"].ToString();

                            Label Labres = (Label)item.FindControl("Labres");

                            Labres.Text = dt.Rows[item.DataItemIndex]["organization_save"].ToString();
                            
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
        
        
            dt = DatabaseFunctions.SelectData(sqlParams, "get_books_content");
        
          
        ListView1.DataSource = dt;
        ListView1.DataBind();
        //int counter = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {

                LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                //Labbooktitle.Text = dt.Rows[counter]["title"].ToString();
                string str = dt.Rows[item.DataItemIndex]["title"].ToString();
                if (str.Length > 100)
                {
                    Labbooktitle.Text = str.Substring(0, 100);
                }

                else
                {
                    Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString().Trim();
                }
                Labbooktitle.PostBackUrl = "~/Esdarat/books_details.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();

                Label Labwriter = (Label)item.FindControl("Labwriter");
                HtmlTableRow tr1 = (HtmlTableRow)item.FindControl("tr_res");
                HtmlTableRow tr2 = (HtmlTableRow)item.FindControl("tr_location");

                if (dt.Rows[item.DataItemIndex]["publish_location"].ToString() != "")
                {
                    Labwriter.Text = dt.Rows[item.DataItemIndex]["publish_location"].ToString();
                }
                else
                {
                    tr2.Visible = false;
                }
                Label Labres = (Label)item.FindControl("Labres");
                if (dt.Rows[item.DataItemIndex]["resource"].ToString() != "")
                {
                    Labres.Text = dt.Rows[item.DataItemIndex]["resource"].ToString();
                }
                else
                {
                    tr1.Visible = false;
                }
                ImageButton Img_book = (ImageButton)item.FindControl("Img_book");

                if (Convert.ToString(dt.Rows[item.DataItemIndex]["small_image"]) != "")
                //{

                    //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1])))
                    //{ Img_book.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["small_image"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["small_image"].ToString().Split('.')[1];
                    {
                        Img_book.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["small_image"].ToString();
                    }
                    else
                    { Img_book.ImageUrl = "../img/Icon%202.png"; }


                //}
                //else Img_book.ImageUrl = "../img/Icon%202.png";



                Img_book.PostBackUrl = "~/esdarat/books_details.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                //counter++;
            }

        }

    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_books_list();
        

    }
}
