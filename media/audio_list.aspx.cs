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

public partial class Media_listAudio : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {



            if (Session["content_type"] == null || Session["content_id"] == null)
            {
                Session["content_type"] = "0";
                Session["content_id"] = "0";
                view_audio_list();
            }
            else if (Session["content_type"] != null && Session["content_id"] != null)
            {
                if (Request.QueryString["id"] != null && Request.QueryString["type"] != null)
                {
                    SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpUtility.HtmlEncode(Request.QueryString["type"].ToString())), 
                                                     
            new SqlParameter("@content_id", HttpUtility.HtmlEncode(Request.QueryString["id"].ToString())), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };

                    DataTable dt = new DataTable();
                    int lang = menus_update.get_current_lang();
                    if (lang == 1)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_audio_content");
                    }
                    else if (lang == 2)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_audio_content_en");
                    }
                    else if (lang == 3)
                    {
                        dt = DatabaseFunctions.SelectData(sqlParams, "get_audio_content_fr");
                    }
                    ListView1.DataSource = dt;

                    ListView1.DataBind();
                    //int counter = 0;

                    if (dt.Rows.Count > 0)
                    {
                        foreach (ListViewDataItem item in ListView1.Items)
                        {
                        //    Image img = (Image)item.FindControl("Image1");
                        //    if (Convert.ToString(dt.Rows[counter]["image_name"]) != "")
                        //    {

                        //        if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1])))
                        //        { img.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1]; }
                        //        else
                        //        { img.ImageUrl = "~/images/no img av.bmp"; }


                        //    }
                        //    else img.ImageUrl = "~/images/no img av.bmp";
                        //    HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                        //    limg.HRef = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[counter]["id"].ToString();
                            LinkButton Labaudiotitle = (LinkButton)item.FindControl("Labaudiotitle");
                            Labaudiotitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString().Trim();
                            Labaudiotitle.PostBackUrl = "~/media/AudioDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();
                            Label Labrecordplace = (Label)item.FindControl("LabelGuests");
                            Labrecordplace.Text = dt.Rows[item.DataItemIndex]["guest_details"].ToString();
                            Label Labelinterviewer = (Label)item.FindControl("Labelinterviewer");
                            Labelinterviewer.Text = dt.Rows[item.DataItemIndex]["presenter_details"].ToString();

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
                            //counter++;
                        }

                    }
                }
                else
                {
                    Session["content_type"] = "0";
                    Session["content_id"] = "0";
                    view_audio_list();
                }

            }



        }
    }
    public void view_audio_list()
    {
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@content_type", HttpContext.Current.Session["content_type"].ToString()), 
                                                     
            new SqlParameter("@content_id", HttpContext.Current.Session["content_id"].ToString()), 
                                                     
            new SqlParameter("@lang", menus_update.get_current_lang()) };
        DataTable dt = new DataTable();
        int lang = menus_update.get_current_lang();
        if (lang == 1)
        {

            dt = DatabaseFunctions.SelectData(sqlParams, "get_audio_content");
        }
        else if (lang == 2)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_audio_content_en");
        }
        else if (lang == 3)
        {
            dt = DatabaseFunctions.SelectData(sqlParams, "get_audio_content_fr");
        }


        ListView1.DataSource = dt;
        ListView1.DataBind();
        //int counter = 0;

        if (dt.Rows.Count > 0)
        {
            foreach (ListViewDataItem item in ListView1.Items)
            {
                //Image img = (Image)item.FindControl("Image1");
                //if (Convert.ToString(dt.Rows[counter]["image_name"]) != "")
                //{

                //    if (System.IO.File.Exists(Server.MapPath("~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1])))
                //    { img.ImageUrl = "~/images/esdarat/" + dt.Rows[counter]["image_name"].ToString().Split('.')[0] + "_small." + dt.Rows[counter]["image_name"].ToString().Split('.')[1]; }
                //    else
                //    { img.ImageUrl = "~/images/no img av.bmp"; }


                //}
                //else img.ImageUrl = "~/images/no img av.bmp";
                //HtmlAnchor limg = (HtmlAnchor)item.FindControl("link_Image");
                //limg.HRef = "~/Elzakera/thesesDetails.aspx?id=" + dt.Rows[counter]["id"].ToString();
                LinkButton Labaudiotitle = (LinkButton)item.FindControl("Labaudiotitle");
                Labaudiotitle.Text = dt.Rows[item.DataItemIndex]["title"].ToString().Trim();
                Labaudiotitle.PostBackUrl = "~/media/AudioDetails.aspx?id=" + dt.Rows[item.DataItemIndex]["id"].ToString();

                Label LabelGuests = (Label)item.FindControl("LabelGuests");
                if (dt.Rows[item.DataItemIndex]["guest_details"].ToString() != "")
                {
                    LabelGuests.Text = dt.Rows[item.DataItemIndex]["guest_details"].ToString().Trim();
                }
                else
                {
                    Label Labw = (Label)item.FindControl("Label2");
                    Labw.Visible = false;
                }
                Label Labelinterviewer = (Label)item.FindControl("Labelinterviewer");
                if (dt.Rows[item.DataItemIndex]["presenter_details"].ToString() != "")
                {
                    Labelinterviewer.Text = dt.Rows[item.DataItemIndex]["presenter_details"].ToString().Trim();
                }
                else
                {
                    Label Labww = (Label)item.FindControl("Label1");
                    Labww.Visible = false;
                }
                
               
            }

        }

    }
    protected void ListPager1_PreRender(object sender, EventArgs e)
    {
        view_audio_list();

    }
}
