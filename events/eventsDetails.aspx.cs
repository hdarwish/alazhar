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

public partial class events_eventsDetails : BasePage
{
    
    public int count_fields = 0;
    public String[] arr_divs = new String[12];
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
        Session["content_id"] = id.ToString();
            Session["content_type"] = "2";
            //Session["referred"] = "true";
            
            HiddenID.Value = id.ToString();
            if (id > 0)
            { hits_count obj = new hits_count(); 
                obj.hit_count_save(id, 2);
            }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                trname.Attributes["class"] = "accordion_title_enfr";
                trstarteventdate.Attributes["class"] = "accordion_title_enfr";
                trendeventdate.Attributes["class"] = "accordion_title_enfr";
                trnabtha.Attributes["class"] = "accordion_title_enfr";
                trtafsil.Attributes["class"] = "accordion_title_enfr";
                trn.Attributes["class"] = "accordion_title_enfr";

                trdetails.Attributes["class"] = "accordion_body_enfr";
                trbdetails.Attributes["class"] = "accordion_body_enfr";
                trnotes.Attributes["class"] = "accordion_body_enfr";

                  
            }
                
            
           
            View();


            //-------------------------clored the Divs-------------------------------------
            for (int y = 0; y < count_fields-1; y = y + 2)
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


        //}


    }   
    public void View()
    {
        int j = 0;


        events_DT obj = new events_DT();
        events_details_DT obj_dt = new events_details_DT();
        obj = events_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        obj_dt = events_details_DB.SelectByevent_ID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());
        if (obj != null)
        {
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (obj.form_status != 12)
                    Response.Redirect("~/events/Default.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (obj.form_status_en != 12)
                    Response.Redirect("~/events/Default.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (obj.form_status_fr != 12)
                    Response.Redirect("~/events/Default.aspx");
            }
        }



        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (obj.large_image != "")
        {

            lcImage.ImageUrl = "../images/events/" + obj.large_image;
        }
        else
        {
           // lcImage.ImageUrl = "../img/event2.jpg";
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                lcImage.ImageUrl = "../img/event2.jpg";
            }
            else
                lcImage.ImageUrl = "../img/event2_en.jpg";
        }
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");

        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        { lclabel.Text = "الحدث"; }
        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
        { lclabel.Text = "Event"; }
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        { lclabel.Text = "événement"; }




        // lclabel.Text = "الحدث";
        HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
        // rlabel.InnerText = " محتوى متعلق بالحدث ";

        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
        { rlabel.InnerText = "محتوى متعلق بالحدث "; }
        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
        { rlabel.InnerText = "Content related to the event "; }
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        { rlabel.InnerText = "Contenu lié à l'événement "; }



        //if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        //{
        //    rlabel.InnerText = " content related to event ";
        //}
        txt_title.Text = obj_dt.title;

        if ((obj.start_date == null || obj.start_date == "") &&
       (obj.start_date_hergi == null || obj.start_date_hergi == ""))
        {
            trstarteventdate.Visible = false;
        }
        else
        {
            txt_start_date.Text = obj.start_date;
            txt_hstart_date.Text = obj.start_date_hergi;

            count_fields = count_fields + 1;
            arr_divs[j] = "trstarteventdate";
            j = j + 1;
        }

        if ((obj.end_date == null || obj.end_date == "") &&
         (obj.end_date_hergi == null || obj.end_date_hergi == ""))
        { trendeventdate.Visible = false; }
        else
        {
            txt_end_date.Text = obj.end_date;
            txt_hend_date.Text = obj.end_date_hergi;
            count_fields = count_fields + 1;
            arr_divs[j] = "trendeventdate";
            j = j + 1;
        }

        if (obj_dt.event_brief != null && obj_dt.event_brief != "")
        {
            txtDesc.Text = obj_dt.event_brief.ToString();
            count_fields = count_fields + 1;
            arr_divs[j] = "trnabtha";
            j = j + 1;
        }
        else
        {
            trdetails.Visible = trnabtha.Visible = false;
        }

        if (obj_dt.event_details != null && obj_dt.event_details != "")
        {
            txtDetailedDesc.Text = obj_dt.event_details.ToString();
            count_fields = count_fields + 1;
            arr_divs[j] = "trtafsil";
            j = j + 1;
        }
        else
        {
            trbdetails.Visible = trtafsil.Visible = false;
        }



        if (obj_dt.notes != null && obj_dt.notes != "")
        {
            txtNotes.Text = obj_dt.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "trn";
            j = j + 1;
        }
        else
        {
            trnotes.Visible = trn.Visible = false;
        }
       
    }
    public void changeDiv_cssClass(object sender, EventArgs e, String DivName, String ClassName)
    {
        // Find the div control as htmlgenericcontrol type, if found apply style
        System.Web.UI.HtmlControls.HtmlGenericControl div = (System.Web.UI.HtmlControls.HtmlGenericControl)Master.FindControl("ContentPlaceHolder2").FindControl(DivName);

        if (div != null)
        {
            // div.Attributes.Remove("class");
            div.Attributes.Add("class", ClassName);
        }

    }
     
  
}
