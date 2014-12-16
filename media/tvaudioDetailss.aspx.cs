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

public partial class media_tvaudioDetailss : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[12];
    protected void Page_Load(object sender, EventArgs e)
    {
        HtmlGenericControl div_related = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related");
        div_related.Visible = false;
        if (!IsPostBack)
        {
            //HtmlGenericControl div_related = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("div_related");
            div_related.Visible = false;
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            HiddenID.Value = id.ToString();
            if (id != 0)
            {
                Session["content_id"] = id.ToString();
                Session["content_type"] = "6";
                //RblMediaType.DataSource = content_media_type_DB.SelectAll();
                //rblTimeLine.DataSource = periods_DB.SelectAll();
                //RblMediaType.DataBind();
                //rblTimeLine.DataBind();
                View();
                
            }
        }
        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            tr_title.Attributes["class"] = "accordion_title_enfr";
            //trworktitle.Attributes["class"] = "accordion_title_enfr";
            tr_title2.Attributes["class"] = "accordion_title_enfr";
            trworkType.Attributes["class"] = "accordion_body_enfr";
            Tr5.Attributes["class"] = "accordion_title_enfr";
            trworkDesc.Attributes["class"] = "accordion_body_enfr";
            Tr2.Attributes["class"] = "accordion_title_enfr";
            trname.Attributes["class"] = "accordion_body_enfr";
            tr6.Attributes["class"] = "accordion_title_enfr";
            trduration.Attributes["class"] = "accordion_body_enfr";
            tr_place.Attributes["class"] = "accordion_title_enfr";
            trguestName.Attributes["class"] = "accordion_body_enfr";
            tr_copier.Attributes["class"] = "accordion_title_enfr";
            trguestTitle.Attributes["class"] = "accordion_body_enfr";
            tr_date.Attributes["class"] = "accordion_title_enfr";
            trintroName.Attributes["class"] = "accordion_body_enfr";
            tr8.Attributes["class"] = "accordion_title_enfr";
            trDate.Attributes["class"] = "accordion_body_enfr";
            tr10.Attributes["class"] = "accordion_title_enfr";
            trsourcaName.Attributes["class"] = "accordion_body_enfr";
            trcountry2.Attributes["class"] = "accordion_title_enfr";
            trCountry.Attributes["class"] = "accordion_body_enfr";
            tr1.Attributes["class"] = "accordion_title_enfr";
            trCity.Attributes["class"] = "accordion_body_enfr";
            tr12.Attributes["class"] = "accordion_title_enfr";
            trsaveNo.Attributes["class"] = "accordion_body_enfr";
            tr13.Attributes["class"] = "accordion_title_enfr";
            trmeasure.Attributes["class"] = "accordion_body_enfr";
            tr14.Attributes["class"] = "accordion_title_enfr";
            trNotes.Attributes["class"] = "accordion_body_enfr";
            tr15.Attributes["class"] = "accordion_title_enfr";
            trelement.Attributes["class"] = "accordion_body_enfr";
            tr4.Attributes["class"] = "accordion_title_enfr";
            trgeneralNotes.Attributes["class"] = "accordion_body_enfr";

            


        }
        //-------------------------clored the Divs-------------------------------------
        for (int y = 0; y < count_fields; y = y + 2)
        {
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title_enfr2");
                if (arr_divs[y + 1] != null)
                {
                    changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title_enfr");
                }
            }
            else
            {
                changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title2");
                if (arr_divs[y + 1] != null)
                {
                    changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title");
                }
            }
        }
    }
    public string Get_Path()
    {
        string path = "";

        content_media_DT media_obj_to_veiw = new content_media_DT();
        media_obj_to_veiw = content_media_DB.SelectByID(Convert.ToInt16(HiddenID.Value));

        path += ResolveUrl("~/upload/Videos/" + media_obj_to_veiw.file_name.ToString() + media_obj_to_veiw.extension.ToString());
        // path += "&image=";
        //path += ResolveUrl("~/upload/Videos/" + videosDT.Rows[0]["thumbnail"].ToString());
        //videoDesc.Text = videosDT.Rows[0]["description"].ToString();
        return path;
    }
    public void View()
    {
        int j = 0;

        content_media_DT media_obj_to_veiw = new content_media_DT();
        content_media_details_DT media_details_obj_to_veiw = new content_media_details_DT();
        media_obj_to_veiw = content_media_DB.SelectByID(Convert.ToInt16(HiddenID.Value));
        media_details_obj_to_veiw = content_media_details_DB.SelectByID(Convert.ToInt16(HiddenID.Value), menus_update.get_current_lang());

        if (media_obj_to_veiw != null)
        {
           if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
               { if (media_obj_to_veiw.form_status != 12) 
                Response.Redirect("~/media/tvAudioList.aspx");
                }
               else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
              { if (media_obj_to_veiw.form_status_en != 12)
                 Response.Redirect("~/media/tvAudioList.aspx");
               } 
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
             { if (media_obj_to_veiw.form_status_fr != 12) 
               Response.Redirect("~/media/tvAudioList.aspx");
            }
        }

            else
            Response.Redirect("~/media/tvAudioList.aspx");

        //Labtitle.Text = media_details_obj_to_veiw.title;
//--------------------------------------------------------------------------------------------------------------------------------------------------
        if (media_details_obj_to_veiw.title != null && media_details_obj_to_veiw.title != "")
        {
            lblfromtitle.Text = media_details_obj_to_veiw.title;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_title";
            j = j + 1;
        }
        else
        {
            //trworktitle.Visible = false;
            tr_title.Visible = false;

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.content_url != null && media_details_obj_to_veiw.content_url != "")
        {
            string str = media_details_obj_to_veiw.content_url;
            int x = str.IndexOf("//www");
            str = str.Remove(0, x);
            str = str.Replace("watch?v=", "embed/");
            vidframe.Attributes["src"] = str;
           //this.frame_url.Attributes["src"] = media_details_obj_to_veiw.content_url;
            //frame_url.Attributes.Add("src", media_details_obj_to_veiw.content_url);
            //frame_url.Attributes.Add("value", media_details_obj_to_veiw.content_url);

           
        }
        else {frame_url.Visible = false; }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        
        if (media_details_obj_to_veiw.category != null && media_details_obj_to_veiw.category != "")
        {


             if (media_details_obj_to_veiw.lang_id == "1")
            {
                switch (media_details_obj_to_veiw.category)
                {

                    case "1":
                        lblworkType.Text = "برنامج فني";
                        break;

                    case "2":
                        lblworkType.Text = "برنامج وثائقي";
                        break;

                    case "3":
                        lblworkType.Text = "مسلسلات ودراما";
                        break;


                    case "4":
                        lblworkType.Text = "كلمة لمناسبة معينة";
                        break;

                    case "5":
                        lblworkType.Text = "برنامج حواري";
                        break;

                    case "6":
                        lblworkType.Text = "فيلم تسجيلي";
                        break;


                    case "7":
                        lblworkType.Text = "برنامج رياضي";
                        break;

                    case "8":
                        lblworkType.Text = "برامج دينية";
                        break;

                    case "9":
                        lblworkType.Text = "خطبة";
                        break;

                    case "10":
                        lblworkType.Text = "برنامج تثقيفي";
                        break;


                    case "11":
                        lblworkType.Text = "برنامج أطفال";
                        break;

                    case "12":
                        lblworkType.Text = "أخرى";
                        break;

                }
            }
             else if (media_details_obj_to_veiw.lang_id == "2")
             {
                 switch (media_details_obj_to_veiw.category)
                 {

                     case "1":
                         lblworkType.Text = "Art Program";
                         break;

                     case "2":
                         lblworkType.Text = "Documentary Program";
                         break;

                     case "3":
                         lblworkType.Text = "Series and Drama";
                         break;


                     case "4":
                         lblworkType.Text = "Word For Specific Occasion";
                         break;

                     case "5":
                         lblworkType.Text = "Talk show";
                         break;

                     case "6":
                         lblworkType.Text = "A documentary film";
                         break;


                     case "7":
                         lblworkType.Text = "Athletic program";
                         break;

                     case "8":
                         lblworkType.Text = "Religious programs";
                         break;

                     case "9":
                         lblworkType.Text = "Sermon";
                         break;

                     case "10":
                         lblworkType.Text = "Educational program";
                         break;


                     case "11":
                         lblworkType.Text = "Children program";
                         break;

                     case "12":
                         lblworkType.Text = "Other";
                         break;

                 }
             }


             count_fields = count_fields + 1;
             arr_divs[j] = "tr_title2";
             j = j + 1;

            //RblMediaType.SelectedValue = media_details_obj_to_veiw.category.ToString();
            //lblworkType.Text = RblMediaType.SelectedItem.ToString();
            //RblMediaType.Enabled = false;
        }
        else
        {
            trworkType.Visible = false;
            tr_title2.Visible = false;
        }
       
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.name != null && media_details_obj_to_veiw.name != "")
        {
            lblnameanddesc.Text = media_details_obj_to_veiw.name;
            count_fields = count_fields + 1;
            arr_divs[j] = "Tr2";
            j = j + 1;
        }
        else
        {
            trname.Visible = false;
            Tr2.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.period != null && media_details_obj_to_veiw.period != "")
        {
            lblMin.Text = media_details_obj_to_veiw.period.Split(':')[0];
            lblSec.Text = media_details_obj_to_veiw.period.Split(':')[1].Split(' ')[0];
            count_fields = count_fields + 1;
            arr_divs[j] = "tr6";
            j = j + 1;

        }
        else
        {
            trduration.Visible = false;
            tr6.Visible = false;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------
        if (media_details_obj_to_veiw.guest_details != null && media_details_obj_to_veiw.guest_details != "")
        {
            lblguestName.Text = media_details_obj_to_veiw.guest_details;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_place";
            j = j + 1;
        }
        else
        {
            trguestName.Visible = false;
            tr_place.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.guest_desc != null && media_details_obj_to_veiw.guest_desc != "")
        {
            lblguesttitle.Text = media_details_obj_to_veiw.guest_desc;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_copier";
            j = j + 1;
        }

        else
        {
            trguestTitle.Visible = false;
            tr_copier.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.presenter_details != null && media_details_obj_to_veiw.presenter_details != "")
        {
            lblCommenterName.Text = media_details_obj_to_veiw.presenter_details;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr_date";
            j = j + 1;
        }
        else
        {
            trintroName.Visible = false;
            tr_date.Visible = false;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_obj_to_veiw.record_date_georgian != null && media_obj_to_veiw.record_date_georgian != "")
            lblGorgDate.Text = media_obj_to_veiw.record_date_georgian;
        if (media_obj_to_veiw.record_date_hijri != null && media_obj_to_veiw.record_date_hijri != "")
            lblHijriDate.Text = media_obj_to_veiw.record_date_hijri;
        if ((media_obj_to_veiw.record_date_georgian == null || media_obj_to_veiw.record_date_georgian == "") && (media_obj_to_veiw.record_date_hijri == null || media_obj_to_veiw.record_date_hijri == ""))
        {
            trDate.Visible = false;
            tr8.Visible = false;
        }
        else
        {
            count_fields = count_fields + 1;
            arr_divs[j] = "tr8";
            j = j + 1;

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.resource_name != null && media_details_obj_to_veiw.resource_name != "")
        {
            lblsourceName.Text = media_details_obj_to_veiw.resource_name;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr10";
            j = j + 1;
        }
        else
        {
            trsourcaName.Visible = false;
            tr10.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.resource_country != null && media_details_obj_to_veiw.resource_country != "")
        {
            lblcountry.Text = media_details_obj_to_veiw.resource_country;
            count_fields = count_fields + 1;
            arr_divs[j] = "trcountry2";
            j = j + 1;
        }

        else
        {
            trCountry.Visible = false;
            trcountry2.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.resource_city != null && media_details_obj_to_veiw.resource_city != "")
        {
            lblCity.Text += media_details_obj_to_veiw.resource_city;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr1";
            j = j + 1;
        }
        else
        {
            trCity.Visible = false;
            tr1.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.resource_save_no != null && media_details_obj_to_veiw.resource_save_no != "")
        {
            lblsaveNo.Text = media_details_obj_to_veiw.resource_save_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr12";
            j = j + 1;
        }
        else
        {
            trsaveNo.Visible = false;
            tr12.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.desc != null && media_details_obj_to_veiw.desc != "")
        {
            lbldesc.Text = media_details_obj_to_veiw.desc;
            count_fields = count_fields + 1;
            arr_divs[j] = "Tr5";
            j = j + 1;
        }
        else
        {
            trworkDesc.Visible = false;
            Tr5.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.resource_note != null && media_details_obj_to_veiw.resource_note != "")
        {
            lblsNotes.Text = media_details_obj_to_veiw.resource_note;
            lblsaveNo.Text = media_details_obj_to_veiw.resource_save_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr13";
            j = j + 1;
        }
        else
        {
            trNotes.Visible = false;
            tr13.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_details_obj_to_veiw.notes != null && media_details_obj_to_veiw.notes != "")
        {
            lblNotes.Text = media_details_obj_to_veiw.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr14";
            j = j + 1;
        }
        else
        {
            trNotes.Visible = false;
            tr14.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_obj_to_veiw.period_id != 0 && media_obj_to_veiw.period_id.ToString() != "")
        {
           // rblTimeLine.SelectedValue = media_obj_to_veiw.period_id.ToString();
            //lblElemnt.Text = rblTimeLine.SelectedItem.ToString();

            count_fields = count_fields + 1;
            arr_divs[j] = "tr15";
            j = j + 1;
        }
        else
        {
            trelement.Visible = false;
            tr15.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------

        if (media_obj_to_veiw.period_desc != null && media_obj_to_veiw.period_desc != "")
        {
            lblTimelineNotes.Text = media_obj_to_veiw.period_desc;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr4";
            j = j + 1;
        }
        else
        {
            trgeneralNotes.Visible = false;
            tr4.Visible = false;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------

        //if (media_obj_to_veiw.file_name != "")
        //{

        //    HtmlAnchor link_pdf1 = (HtmlAnchor)Page.Master.FindControl("leftUC11").FindControl("link_pdf1");
        //    link_pdf1.HRef = "~/images/esdarat/" + media_obj_to_veiw.file_name;
        //    Label lbl_veiw = (Label)Page.Master.FindControl("leftUC11").FindControl("lbl_veiw");
        //    if (menus_update.get_current_lang() == 1)
        //    lbl_veiw.Text = "عرض التسجيل";
        //    else if (menus_update.get_current_lang() == 2)
        //        lbl_veiw.Text = "play recording";
        //    else if (menus_update.get_current_lang() == 3)
        //        lbl_veiw.Text = "TV Show Date"; 
        //}

       
        HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
        pdf_continer.Visible = false;
        
        
        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (media_obj_to_veiw.small_image != "")
        {

            lcImage.ImageUrl = "../upload/Videos/" + media_obj_to_veiw.small_image;
        }
        else lcImage.ImageUrl = "~/img/Icon-3.jpg"; ;


        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
        // lclabel.Text = "lclabel";
        if (menus_update.get_current_lang() == 1)
            lclabel.Text = "التسجيل التلفزيوني";
        else if (menus_update.get_current_lang() == 2)
            lclabel.Text = "Media TV";
        else if (menus_update.get_current_lang() == 3)
            lclabel.Text = "Media TV"; 



    }

    public void changeDiv_cssClass(object sender, EventArgs e, String DivName, String ClassName)
    {
        // Find the div control as htmlgenericcontrol type, if found apply style
        System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ContentPlaceHolder2").FindControl(DivName);

        if (div != null)
        {
            div.Attributes.Remove("class");
            div.Attributes.Add("class", ClassName);
        }

    }
   
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     