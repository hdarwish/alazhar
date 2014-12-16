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

public partial class topics_topicsDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[12];//as 12 div titles
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
        Session["content_id"] = id.ToString();
            Session["content_type"] = "3";
            //Session["referred"] = "true";
            
            HiddenID.Value = id.ToString();
            if (id > 0)
            { hits_count obj = new hits_count(); 
                obj.hit_count_save(id, 3); 
            }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                   trname.Attributes["class"] = "accordion_title_enfr";
                   trnabtha.Attributes["class"] = "accordion_title_enfr";
                   trdetails.Attributes["class"] = "accordion_body_enfr";
                   trtafsil.Attributes["class"] = "accordion_title_enfr";
                   trbdetails.Attributes["class"] = "accordion_body_enfr";
                   trn.Attributes["class"] = "accordion_title_enfr";
                   trnotes.Attributes["class"] = "accordion_body_enfr";
            }                           
            View();

            //----------------------------------------change div color-------------------------------------
            for (int y = 0; y < count_fields; y = y + 2)
            {
                if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title_enfr2");
                    changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title_enfr");
                }
                else
                {
                    changeDiv_cssClass(sender, e, arr_divs[y], "accordion_title2");
                    changeDiv_cssClass(sender, e, arr_divs[y + 1], "accordion_title");
                }
            }
    }   
    public void View()
    {

        int j = 0;


        topics_DT obj = new topics_DT();
        topics_details_DT obj_dt = new topics_details_DT();
        obj = topics_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        obj_dt = topics_details_DB.SelectBytopic_ID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());
        if (obj != null)
        {
            //if (obj.form_status != 12)
            //    Response.Redirect("~/topics/Default.aspx");
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (obj.form_status != 12)
                    Response.Redirect("~/topics/Default.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (obj.form_status_en != 12)
                    Response.Redirect("~/topics/Default.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (obj.form_status_fr != 12)
                    Response.Redirect("~/topics/Default.aspx");
            }
        }

        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (obj.large_image != "")
        {
            lcImage.ImageUrl = "../images/topics/" + obj.large_image;
        }
        else
        {
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                lcImage.ImageUrl = "../img/subject2.jpg";
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                lcImage.ImageUrl = "../img/sub_en-L.jpg";
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                lcImage.ImageUrl = "../img/sub_fr-L.jpg";
            }
        } 
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
        //lclabel.Text = "الموضوع";
        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            lclabel.Text = "الموضوع";
        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            lclabel.Text = "topic";
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            lclabel.Text = "sujet";
        HtmlGenericControl rlabel = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("relatspan");
        //rlabel.InnerText = " محتوى متعلق بالموضوع ";
        if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            rlabel.InnerText = " محتوى متعلق بالموضوع ";
        else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            rlabel.InnerText = " Content related to the topic";
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            rlabel.InnerText = "Contenu lié au sujet";
        txt_title.Text = obj_dt.title;
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (obj_dt.topic_brief != null && obj_dt.topic_brief != "")
        {
            txtDesc.Text = obj_dt.topic_brief.ToString();
            arr_divs[j] = "trnabtha";
            j++;
            count_fields = count_fields + 1;
        }
        else
        { trdetails.Visible = trnabtha.Visible = false; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (obj_dt.topic_details != null && obj_dt.topic_details != "")
        {
            txtDetailedDesc.Text = obj_dt.topic_details.ToString();
            arr_divs[j] = "trtafsil";
            count_fields = count_fields + 1;
            j++;
        }
        else
        { trbdetails.Visible = trtafsil.Visible = false; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        if (obj_dt.notes != null && obj_dt.notes != "")
        {
            txtNotes.Text = obj_dt.notes;
            arr_divs[j] = "trn";
            j++;
            count_fields = count_fields + 1;
        }
        else
        { trnotes.Visible = trn.Visible = false; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                         
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
