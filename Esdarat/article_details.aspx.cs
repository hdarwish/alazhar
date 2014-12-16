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

public partial class Esdarat_document_details : BasePage
{
    public int count_fields = 0;
    public String[] arr_divs = new String[12];

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = Convert.ToInt16(HttpUtility.HtmlEncode(Request.QueryString["id"]));
            Session["content_id"] = id.ToString();
            Session["content_type"] = "9";
           
            HiddenID.Value = id.ToString();
            filllang();
            View();
            if (menus_update.get_current_lang() == 1)
            {

                gview_moalf.Columns[1].Visible = false;
                gview_moalf.Columns[2].Visible = false;

            }
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2" || Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                Div1.Attributes["class"] = "accordion_title_enfr";
                //Div2.Attributes["class"] = "accordion_body_enfr";
                tr1.Attributes["class"] = "accordion_title_enfr";
                trlang.Attributes["class"] = "accordion_body_enfr";
                tr_grid_name.Attributes["class"] = "accordion_title_enfr";
                tr_grid.Attributes["class"] = "accordion_body_enfr";
                trpages.Attributes["class"] = "accordion_title_enfr";
                trpages1.Attributes["class"] = "accordion_body_enfr";
                tr6.Attributes["class"] = "accordion_title_enfr";
                tr7.Attributes["class"] = "accordion_body_enfr";
                tr2.Attributes["class"] = "accordion_title_enfr";
                tr8.Attributes["class"] = "accordion_body_enfr";
                tr12.Attributes["class"] = "accordion_title_enfr";
                tr13.Attributes["class"] = "accordion_body_enfr";
                tr4.Attributes["class"] = "accordion_title_enfr";
                trnotes.Attributes["class"] = "accordion_body_enfr";
                
            }

            //-----------------------------------------------------for  color the Divs--------------------------------------------------------
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
    }
    private void filllang()
    {
        languages_DT obj = new languages_DT();
        DataTable lang_dt = languages_DB.SelectAll();

        drop_lang.DataSource = lang_dt;
        drop_lang.DataBind();
        ListItem litem = new ListItem("-- اختر اللغة  --", "0");
        drop_lang.Items.Insert(0, litem);
       
    }   
    private void fillcheck_periods()
    {
        periods_DT obj = new periods_DT();
        DataTable per_dt = periods_DB.SelectAll();
        //chk_periods.DataSource = per_dt;
        //chk_periods.DataBind();
        //chk_periods.DataValueField = "id";
        // chk_periods.DataTextField = "title";

    }
    public void View()
    {
        int j = 0;
        documents_DT obj = new documents_DT();
        documents_details_DT obj_dt = new documents_details_DT();
        obj = documents_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value));
        obj_dt = documents_details_DB.SelectByID(CDataConverter.ConvertToInt(HiddenID.Value), menus_update.get_current_lang());

        if (obj != null)
        {
            if (obj.form_status != 12)
                Response.Redirect("~/Esdarat/list_articles.aspx");
            else if ((Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2") && obj.form_status_en != 12)
            {
                Response.Redirect("~/Esdarat/list_articles.aspx");
            }
            else if ((Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3") && obj.form_status_fr != 12)
            {
                Response.Redirect("~/Esdarat/list_articles.aspx");
            }
        }

       
        
        Labtitle.Text = obj_dt.title;


        if (obj_dt.doc_lang != "")
        {
            if (obj_dt.doc_lang != null)
            {
                string id = obj_dt.doc_lang;
                drop_lang.Items.FindByText(id).Selected = true;
            }
            lbl_drop_lang.Text = drop_lang.SelectedItem.Text;
        }



        if (obj_dt.title != "")
        {
            Labtitle.Text = obj_dt.title;
        }

        if (obj_dt.doc_lang != "")
        {
            lbl_drop_lang.Text = obj_dt.doc_lang;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr1";
            j = j + 1;
        }
        else { 
            trlang.Visible = false; tr1.Visible = false; 
        }
       
        if (obj_dt.resource != "")
         { 
            Labpubtitle.Text = obj_dt.resource;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr6";
            j = j + 1;
        }
        else {
            tr6.Visible = false; tr7.Visible = false;
        }


        if (obj.folders_no != "")
        {
            labpubLocation.Text = obj.folders_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr2";
            j = j + 1;
        }
        else {
            tr8.Visible = false; tr2.Visible = false;
        }

        if (obj_dt.series_no != "")
        { 
            lbl_seriesno.Text = obj_dt.series_no;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr12";
            j = j + 1;
        }
        else {
            tr12.Visible = false; tr13.Visible = false;
        }
        //////////////////////////////////////////////////////////////////////////////
        if ((obj.pages_no == null || obj.pages_no.ToString() == "") && (obj.pages_from == null || obj.pages_from.ToString() == "") && (obj.pages_to == null || obj.pages_to.ToString() == ""))
        { 
            trpages.Visible = false; trpages1.Visible = false;
        }
        else
        {
            //txt_no.Text = obj.pages_no.ToString();
            txt_from.Text = obj.pages_from.ToString();
            txt_to.Text = obj.pages_to.ToString();
            count_fields = count_fields + 1;
            arr_divs[j] = "trpages";
            j = j + 1;
        }
        if (obj_dt.notes != "")
        {
            Label14.Text = obj_dt.notes;
            count_fields = count_fields + 1;
            arr_divs[j] = "tr4";
            j = j + 1;
        }
        else { 
            trnotes.Visible = false; tr4.Visible = false; 
        }
        tr_grid_name.Visible = false;
        tr_grid.Visible = false;
        
        ////labisbn.Text = dt.Rows[0]["isbn"].ToString();

        ////labdirsub.Text = dt.Rows[0]["notes"].ToString();
        
       //-----------------------------------------------------------------------------------------------------------------------------------------


        if (obj.large_image != "")
        {
            //link_pdf1.Visible = true;
            //link_pdf1.HRef = "~/images/esdarat/" + obj.large_image;
            HtmlAnchor link_pdf1 = (HtmlAnchor)Page.Master.FindControl("leftUC11").FindControl("link_pdf1");
            link_pdf1.HRef = "~/images/esdarat/" + obj.large_image;
            Label lbl_veiw = (Label)Page.Master.FindControl("leftUC11").FindControl("lbl_veiw");
            //lbl_veiw.Text = "عرض المقالة";
            if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
            {
                lbl_veiw.Text = "View the Articles";
            }
            else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
            {
                lbl_veiw.Text = "Voir Les Articles";
            }
            else
            {
                lbl_veiw.Text = "عرض المقالة";
            }
        }
        else
        {
            HtmlGenericControl pdf_continer = (HtmlGenericControl)Page.Master.FindControl("leftUC11").FindControl("pdf_continer");
            pdf_continer.Visible = false;
        }
        Image lcImage = (Image)Page.Master.FindControl("leftUC11").FindControl("Image1");
        if (obj.small_image != "")
        {
            
            lcImage.ImageUrl = "../images/esdarat/" + obj.small_image;
            //Image1.ImageUrl = "~/images/esdarat/" + obj.small_image;
        }
        else lcImage.ImageUrl = "../img/Icon-7.jpg";
        Label lclabel = (Label)Page.Master.FindControl("leftUC11").FindControl("content_txt");
       
        

        if (Session["Lang"].ToString() == "en" || Session["Lang"].ToString() == "2")
        {
            lclabel.Text = "Articles";
        }
        else if (Session["Lang"].ToString() == "fr" || Session["Lang"].ToString() == "3")
        {
            lclabel.Text = "Articles";
        }
        else
        {
            lclabel.Text = "المقالة";
        }

       
      
       
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
     

