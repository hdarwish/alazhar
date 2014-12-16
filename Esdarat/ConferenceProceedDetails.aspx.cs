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
using System.Collections.Generic;


public partial class Esdarat_ConferenceProceedDetails : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[20];
    //List<String> arr_divs = new List<String>();
    
    protected void Page_Load(object sender, EventArgs e)
    {
       // if (!IsPostBack)
       // {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            HiddenID.Value = id.ToString();
            if (id != 0)
            {
                Session["content_id"] = id.ToString();
                Session["content_type"] = "14";
                //Session["referred"] = "true";
               // fillcheck_periods();
                //View();
            }

            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                Div1.Attributes["class"] = "accordion_title_enfr";
               // tr_title.Attributes["class"] = "accordion_title_enfr";

                tr_title2.Attributes["class"] = "accordion_title_enfr";
                Tr5.Attributes["class"] = "accordion_title_enfr";
                Tr2.Attributes["class"] = "accordion_title_enfr";
                tr4.Attributes["class"] = "accordion_title_enfr";
                tr6.Attributes["class"] = "accordion_title_enfr";
                tr_place.Attributes["class"] = "accordion_title_enfr";
                tr_copier.Attributes["class"] = "accordion_title_enfr";               
                tr_notes.Attributes["class"] = "accordion_title_enfr";
                tr1.Attributes["class"] = "accordion_title_enfr";

                trgid1.Attributes["class"] = "accordion_body_enfr";
                trnotes.Attributes["class"] = "accordion_body_enfr";
                trcopier.Attributes["class"] = "accordion_body_enfr";
                trplace.Attributes["class"] = "accordion_body_empty";
                trlang.Attributes["class"] = "accordion_body_enfr";
                tr7.Attributes["class"] = "accordion_body_enfr";
                trauthfromintro.Attributes["class"] = "accordion_body_enfr";
                trauthfromtit.Attributes["class"] = "accordion_body_enfr";
                trtitfromintro.Attributes["class"] = "accordion_body_enfr";
               // trtitfromtit.Attributes["class"] = "accordion_body_enfr";
                Div2.Attributes["class"] = "accordion_body_empty";
                 
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
        
    }
    public void FillGrid()
    {
        DataTable dt = new DataTable();
        SqlParameter[] sqlParams = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt(Session["content_id"].ToString())),
           new SqlParameter("@lang_id",  menus_update.get_current_lang()) };
        dt = new DataTable();
        dt = DatabaseFunctions.SelectData(sqlParams, "authorstitle_conference_select");
        //==========================================================check to view the grid ===================================
        if (dt.Rows.Count != 0)
        {
            gview_moalf.Visible = true;
            Label1.Visible = true;
            trgid1.Visible = true;
            tr1.Visible = true;
           
        }
        else
        {
            gview_moalf.Visible = false;
            Label1.Visible = false;
            trgid1.Visible = false;
            tr1.Visible = false;
        }
        //--------------------------------------------------------------------------------------------------------------------
        
        gview_moalf.DataSource = dt;
        gview_moalf.DataBind();

        /////////////////////////////////////////////////////////////////////
        if (CDataConverter.ConvertToInt(menus_update.get_current_lang()) > 1)
        {
            SqlParameter[] sqlParams1 = new SqlParameter[] { new SqlParameter("@doc_id", CDataConverter.ConvertToInt( Session["content_id"].ToString())) ,
                new SqlParameter("@lang_id", menus_update.get_current_lang())};
            DataTable dt2 = new DataTable();
            dt2 = DatabaseFunctions.SelectData(sqlParams1, "authorstitle_conference_select");
            for (int f = 0; f < dt.Rows.Count; f++)
            {
                if (dt.Rows[f]["is_character"].ToString() == "1")
                {
                    dt.Rows[f].Delete();
                }
                else
                {
                    DataRow[] foundRows;

                    foundRows = dt2.Select("author_id = '" + dt.Rows[f]["author_id"].ToString() + "'");
                    if (foundRows.Length > 0)
                    {
                        dt.Rows[f]["name_ar"] = foundRows[0][1].ToString();
                    }
                }
            }
            //==========================================================check to view the grid ===================================
            if (dt2 != null)
            {
                gview_moalf.Visible = true;
                Label1.Visible = true;
                trgid1.Visible = true;
                tr1.Visible = true;
            }
            else
            {
                gview_moalf.Visible = false;
                Label1.Visible = false; 
                trgid1.Visible = false;
                tr1.Visible = false;
            }
            //--------------------------------------------------------------------------------------------------------------------
        
            gview_moalf.DataSource = dt;
            gview_moalf.DataBind();
        }
        if (menus_update.get_current_lang() == 1)
        {
            gview_moalf.Columns[2].Visible = false;
            gview_moalf.Columns[3].Visible = false;
            //gview_moalf.Columns[5].Visible = false;
            //gview_moalf.Columns[6].Visible = false;
        }
        else
        {
            gview_moalf.Columns[2].Visible = true;
            gview_moalf.Columns[3].Visible = true;
            //gview_moalf.Columns[5].Visible = false;
            //gview_moalf.Columns[6].Visible = false;
        }
    }
    public void View()
    {
        int j = 0;
 
        int lang = menus_update.get_current_lang();

        conference_proceedings_DT conferenceProceedingsObj = new conference_proceedings_DT();
        conference_proceedings_details_DT conferenceProceedDetailsObj = new conference_proceedings_details_DT();
             
        conferenceProceedingsObj = conference_proceedings_DB.SelectByID(Convert.ToInt16(HiddenID.Value));
        conferenceProceedDetailsObj = conference_proceedings_details_DB.SelectByConference_ID(Convert.ToInt16(HiddenID.Value), menus_update.get_current_lang());

        if (conferenceProceedingsObj != null)
        {
           // if (conferenceProceedingsObj.form_status != 12)
               // Response.Redirect("~/Esdarat/listConferencePropceed.aspx");
            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                if (conferenceProceedingsObj.form_status != 12)
                    Response.Redirect("~/Esdarat/listConferencePropceed.aspx");
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                if (conferenceProceedingsObj.form_status_en != 12)
                    Response.Redirect("~/Esdarat/listConferencePropceed.aspx");
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                if (conferenceProceedingsObj.form_status_fr != 12)
                    Response.Redirect("~/Esdarat/listConferencePropceed.aspx");
            }
        }
       
        Labtitle.Text = conferenceProceedDetailsObj.title;

        //--------------------------------------------------no 1------------------------------------------------------------------

        if (conferenceProceedDetailsObj.conference_from != 0)
        {
            if (conferenceProceedDetailsObj.conference_to != 0)
            {

                if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
                {
                    lbl_man_lang.Text = "من " + conferenceProceedDetailsObj.conference_from.ToString() + " الي" + conferenceProceedDetailsObj.conference_to.ToString();
                }
                else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
                {
                    lbl_man_lang.Text = "from " + conferenceProceedDetailsObj.conference_from.ToString() + " to" + conferenceProceedDetailsObj.conference_to.ToString();
                }
                else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
                {
                    lbl_man_lang.Text = "à partir de " + conferenceProceedDetailsObj.conference_from.ToString() + " à" + conferenceProceedDetailsObj.conference_to.ToString();
                }
                count_fields = count_fields + 1;

                arr_divs[j] = "tr_title2";
                j++;



            }
            else
                lbl_man_lang.Text = conferenceProceedDetailsObj.conference_from.ToString();

        }


        //--------------------------------------------------no 2------------------------------------------------------------------


        if (conferenceProceedDetailsObj.conference_lang != null && conferenceProceedDetailsObj.conference_lang != 0)
        {
            author.Text = conferenceProceedDetailsObj.conference_lang.ToString();
            count_fields = count_fields + 1;


            arr_divs[j] = "Tr5";
            j++;


        }
        else
            Tr5.Visible = trauthfromtit.Visible = false;

 
        //--------------------------------------------------no 3------------------------------------------------------------------
        if (conferenceProceedDetailsObj.conference_name != null && conferenceProceedDetailsObj.conference_name != "")
        {
            txt_author_mokdma.Text = conferenceProceedDetailsObj.conference_name;
            count_fields = count_fields + 1;
            arr_divs[j]= "Tr2";
            j++;
             
        }
        else
        {
            Tr2.Visible = trauthfromintro.Visible = false;
        }
        //--------------------------------------------------no 4------------------------------------------------------------------

        if (conferenceProceedDetailsObj.conference_no != null && conferenceProceedDetailsObj.conference_no != "")
        { 
            lbl_man_lang0.Text = conferenceProceedDetailsObj.conference_no;
            count_fields = count_fields + 1;
            
            arr_divs[j] = "tr4";
            j++;  
        }
        
        else 
        {
            tr4.Visible = tr7.Visible = false;
        }
        //       
        //--------------------------------------------------no 5------------------------------------------------------------------

        //=====================================check holding date============================
        if (conferenceProceedingsObj.conf_hdate != null && conferenceProceedingsObj.conf_hdate != "")
        {
            Labeldateh.Text = conferenceProceedingsObj.conf_hdate.ToString();
            tr6.Visible = trlang.Visible = true;
            count_fields = count_fields + 1;

            arr_divs[j] = "tr6";
            j++;

        }
        else { tr6.Visible = trlang.Visible = false; }

        //-----------------------------------------------------------------------------------
        //--------------------------------------------------no 6------------------------------------------------------------------

        if (conferenceProceedDetailsObj.conference_place != null && conferenceProceedDetailsObj.conference_place != "")
        {
            if (conferenceProceedDetailsObj.conference_city != null && conferenceProceedDetailsObj.conference_city != "")
            {
                if (conferenceProceedDetailsObj.conference_country != "" && conferenceProceedDetailsObj.conference_country != null)
                {
                    Label11.Text = conferenceProceedDetailsObj.conference_place + " - " + conferenceProceedDetailsObj.conference_city + " - " + conferenceProceedDetailsObj.conference_country;
                }
                else
                    Label11.Text = conferenceProceedDetailsObj.conference_place + " - " + conferenceProceedDetailsObj.conference_city;
            }
            else
            {
                Label11.Text = conferenceProceedDetailsObj.conference_place;
            }

            count_fields = count_fields + 1;

            arr_divs[j] = "tr_place";
            j++;

        }
        else
        {
            tr_place.Visible = trplace.Visible = false;
        }
        //--------------------------------------------------no 7------------------------------------------------------------------

        if (conferenceProceedDetailsObj.conference_org != null && conferenceProceedDetailsObj.conference_org != "")
        {
            copier.Text = conferenceProceedDetailsObj.conference_org;
            count_fields = count_fields + 1;

            arr_divs[j] = "tr_copier";
            j++;

        }
        else
            trcopier.Visible = tr_copier.Visible = false;

        //--------------------------------------------------no 8------------------------------------------------------------------

        if (conferenceProceedDetailsObj.notes != null && conferenceProceedDetailsObj.notes != "")
        {
            notes.Text = conferenceProceedDetailsObj.notes;
            count_fields = count_fields + 1;
           
            arr_divs[j] = "tr_notes";
            j++;
             
        }
        else
        {
            trnotes.Visible = tr_notes.Visible = false;
        }
        //        //--------------------------------------------------------------------------------------------------------------------

        if (conferenceProceedingsObj.file_name != "")
        {
         
            HtmlAnchor link_pdf1 = (HtmlAnchor)Page.Master.FindControl("leftUC11").FindControl("link_pdf1");
            link_pdf1.HRef = "~/images/esdarat/" + conferenceProceedingsObj.file_name;
            Label lbl_veiw = (Label)Page.Master.FindControl("leftUC11").FindControl("lbl_veiw");

            if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                lbl_veiw.Text = " عرض وثيقة المؤتمر"; 
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            { 
                lbl_veiw.Text = "Show Conference document "; 
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            { 
                lbl_veiw.Text = "Et conférence le document "; 
            }
            
            
           // lbl_veiw.Text = "عرض وثيقة المؤتمر";
        }

        else
        {
            HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
            pdf_continer.Visible = false;
        } 

        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (conferenceProceedingsObj.image_name != "")
        {

            lcImage.ImageUrl = "../images/esdarat/" + conferenceProceedingsObj.image_name;
        }
        else lcImage.ImageUrl = "~/img/Icon-6.jpg";

       
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
       // Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
       
         if (Session["Lang"].ToString() == "ar" || Session["Lang"].ToString() == "1")
            {
                lclabel.Text = " المؤتمر"; 
            }
            else if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                lclabel.Text = "The Conference "; 
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            { 
                 lclabel.Text = " le conférence "; 
            }
        
        
       // lclabel.Text = "المؤتمر";

        FillGrid();       
      
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