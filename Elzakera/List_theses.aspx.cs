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

public partial class Elzakera_listManuscriptAtroha : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {



            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                view_theses_list();
            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", Request.QueryString["type"].ToString()), 
                                                     
            new SqlParameter("@content_id", Request.QueryString["id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };
                    int lang = menus_update.get_current_lang();
                    DataTable dt = new DataTable();
                    if (lang == 1)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_theses_content");
                    }
                    else if (lang == 2)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_theses_content_en");
 
                    }
                    else if (lang == 3)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_theses_content_fr");

                    }
                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                   // int counter = 0;

                    if (dt.Rows.Count > 0)
                    {
                        foreach (ListViewDataItem item in ListView1.Items)
                        {
                            Image img = (Image)item.FindControl("Image1");
                            if (Convert.ToString(dt.Rows[item.DataItemIndex]["image_name"]) != "")
                            //{

                            //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1])))

                            //{ img.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1]; }
                            {
                                img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString();

                            }
                            else
                            { img.ImageUrl = "~/img/Icon 7.png"; }


                            //}
                            //else img.ImageUrl = "~/img/Icon 7.png";
                            HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                            limg.HRef = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                            Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                            Labbooktitle.PostBackUrl = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            Label Labwriter = (Label)item.FindControl("Labwriter");
                            Labwriter.Text = dt.Rows[item.DataItemIndex]["author"].ToString();
                            ////Label Labres = (Label)item.FindControl("Labres");
                            ////Labres.Text = dt.Rows[counter]["resource"].ToString();
                            //ImageButton Img_book = (ImageButton)item.FindControl("Img_book");
                            //if (dt.Rows[counter]["small_image"].ToString() != "")
                            //{
                            //    //HtmlInputHidden hidden_id = (HtmlInputHidden)item.FindControl("hidden_id");
                            //    //hidden_id.Value = dt.Rows[counter]["doc_id"].ToString();
                            //    Img_book.ImageUrl = "~/images/Esdarat/" + dt.Rows[counter]["small_image"].ToString();
                            //}
                            //else Img_book.ImageUrl = "~/images/noImageAvailable.jpg";
                            //Img_book.PostBackUrl = "~/esdarat/books_details.aspx?id=" + dt.Rows[counter]["doc_id"].ToString();
                           
                        }

                    }
                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    view_theses_list();
                }

            }



        }
    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_theses_list();
    }
    public void view_theses_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

        int lang = menus_update.get_current_lang();
        DataTable dt = new DataTable();
        if (lang == 1)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_theses_content");
        }
        else if (lang == 2)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_theses_content_en");

        }
        else if (lang == 3)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_theses_content_fr");

        }
        ListView1.DataSource = dt;
        ListView1.DataBind();
       // int counter = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {
                Image img = (Image)item.FindControl("Image1");
                if (Convert.ToString(dt.Rows[item.DataItemIndex]["image_name"]) != "")
                //{

                //if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1])))

                //{ img.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1]; }
                {
                    img.ImageUrl = "~/images/esdarat/" + dt.Rows[item.DataItemIndex]["image_name"].ToString();
 
                }
                else
                { img.ImageUrl = "~/img/Icon 7.png"; }


                //}
                //else img.ImageUrl = "~/img/Icon 7.png";
                HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                limg.HRef = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                LinkButton Labbooktitle = (LinkButton)item.FindControl("Labbooktitle");
                Labbooktitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString();
                Labbooktitle.PostBackUrl = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();

                Label Labwriter = (Label)item.FindControl("Labwriter");
                if (dt.Rows[item.DataItemIndex]["author"].ToString() != "")
                {
                    Labwriter.Text = dt.Rows[item.DataItemIndex]["author"].ToString();
                }
                else 
                {
                    Label Labw = (Label)item.FindControl("Label2");
                    Labw.Visible = false;
                }
                ////Label Labres = (Label)item.FindControl("Labres");
                ////Labres.Text = dt.Rows[counter]["resource"].ToString();
                //ImageButton Img_book = (ImageButton)item.FindControl("Img_book");
                //if (dt.Rows[counter]["small_image"].ToString() != "")
                //{
                //    //HtmlInputHidden hidden_id = (HtmlInputHidden)item.FindControl("hidden_id");
                //    //hidden_id.Value = dt.Rows[counter]["doc_id"].ToString();
                //    Img_book.ImageUrl = "~/images/Esdarat/" + dt.Rows[counter]["small_image"].ToString();
                //}
                //else Img_book.ImageUrl = "~/images/noImageAvailable.jpg";
                //Img_book.PostBackUrl = "~/esdarat/books_details.aspx?id=" + dt.Rows[counter]["doc_id"].ToString();
               // counter++;
            }

        }

    }
  
}
